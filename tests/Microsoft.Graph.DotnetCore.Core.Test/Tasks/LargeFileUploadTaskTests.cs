// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Core.Test.Tasks
{
    using Microsoft.Graph.Core.Models;
    using Microsoft.Graph.DotnetCore.Core.Test.Mocks;
    using Microsoft.Graph.DotnetCore.Core.Test.Requests;
    using Microsoft.Graph.DotnetCore.Core.Test.TestModels.ServiceModels;
    using Microsoft.Kiota.Abstractions.Authentication;
    using Microsoft.Kiota.Abstractions.Serialization;
    using Microsoft.Kiota.Serialization.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    public class LargeFileUploadTests : RequestTestBase
    {
        public LargeFileUploadTests()
        {
            // register the default serialization instance as the generator would.
            ParseNodeFactoryRegistry.DefaultInstance.ContentTypeAssociatedFactories.TryAdd(CoreConstants.MimeTypeNames.Application.Json, new JsonParseNodeFactory());
        }

        [Fact]
        public void ThrowsOnEmptyStream()
        {
            
            var uploadSession = new UploadSession
            {
                NextExpectedRanges = new List<string>() { "0-" },
                UploadUrl = "http://localhost",
                ExpirationDateTime = DateTimeOffset.Parse("2019-11-07T06:39:31.499Z")
            };

            int maxSliceSize = 200 * 1024;//slice size that is 200 KB

            // Act 
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                using Stream stream = new MemoryStream();
                return new LargeFileUploadTask<TestDriveItem>(uploadSession, stream, maxSliceSize);
            });
            Assert.NotNull(exception);
        }
        [Fact]
        public void AllowsVariableSliceSize()
        {
            byte[] mockData = new byte[1000000];
            using Stream stream = new MemoryStream(mockData);
            var uploadSession = new UploadSession
            {
            NextExpectedRanges = new List<string>() { "0-" },
            UploadUrl = "http://localhost",
            ExpirationDateTime = DateTimeOffset.Parse("2019-11-07T06:39:31.499Z")
            };

            int maxSliceSize = 200 * 1024;//slice size that is 200 KB

            // Act 
            var largeFileUploadTask = new LargeFileUploadTask<TestDriveItem>(uploadSession, stream, maxSliceSize);
            var uploadSlices = largeFileUploadTask.GetUploadSliceRequests();
            var onlyUploadSlice = uploadSlices.First();

            //Assert
            Assert.Equal(0, onlyUploadSlice.RangeBegin);
            Assert.Equal(204800, onlyUploadSlice.RangeLength);
            Assert.Equal(204799, onlyUploadSlice.RangeEnd);
        }

        [Fact]
        public void ShouldNotThrowArgumentExceptionOnConstructorWithoutSliceSize()
        {
            // Try to upload 1Mb stream without specifying the slice size(should default to 5Mb)
            byte[] mockData = new byte[1000000];
            using Stream stream = new MemoryStream(mockData);
            // Arrange
            var uploadSession = new UploadSession
            {
                NextExpectedRanges = new List<string>() { "0-" },
                UploadUrl = "http://localhost",
                ExpirationDateTime = DateTimeOffset.Parse("2019-11-07T06:39:31.499Z")
            };

            // Act with constructor without chunk length
            var fileUploadTask = new LargeFileUploadTask<TestDriveItem>(uploadSession, stream);
            var uploadSlices = fileUploadTask.GetUploadSliceRequests();

            // Assert
            //We have only 1 slices
            Assert.Single(uploadSlices);

            var onlyUploadSlice = uploadSlices.First();
            Assert.Equal(stream.Length, onlyUploadSlice.TotalSessionLength);
            Assert.Equal(0, onlyUploadSlice.RangeBegin);
            Assert.Equal(stream.Length - 1, onlyUploadSlice.RangeEnd);
            Assert.Equal(stream.Length, onlyUploadSlice.RangeLength); //verify the last slice is the right size
        }

        [Fact]
        public void BreaksDownStreamIntoRangesCorrectly()
        {
            byte[] mockData = new byte[1000000];//create a stream of about 1M so we can split it into a few 320K slices
            using Stream stream = new MemoryStream(mockData);
            // Arrange
            var uploadSession = new UploadSession
            {
                NextExpectedRanges = new List<string>() { "0-" },
                UploadUrl = "http://localhost",
                ExpirationDateTime = DateTimeOffset.Parse("2019-11-07T06:39:31.499Z")
            };

            int maxSliceSize = 320 * 1024;

            // Act 
            var fileUploadTask = new LargeFileUploadTask<TestDriveItem>(uploadSession, stream, maxSliceSize);
            var uploadSlices = fileUploadTask.GetUploadSliceRequests();

            // Assert
            //We have only 4 slices
            Assert.Equal(4, uploadSlices.Count());

            long currentRangeBegins = 0;
            foreach (var uploadSlice in uploadSlices)
            {
                Assert.Equal(stream.Length, uploadSlice.TotalSessionLength);
                Assert.Equal(currentRangeBegins, uploadSlice.RangeBegin);
                currentRangeBegins += maxSliceSize;
            }

            //The last slice is a a bit smaller than the rest
            var lastUploadSlice = uploadSlices.Last();
            Assert.Equal(stream.Length - 1, lastUploadSlice.RangeEnd);
            Assert.Equal(stream.Length % maxSliceSize, lastUploadSlice.RangeLength); //verify the last slice is the right size
        }

        [Fact]
        public async Task HandlesCancellationToken()
        {
            byte[] mockData = new byte[1000000];//create a stream of about 1M so we can split it into a few 320K slices
            var requestUrl = "https://localhost/";
            using Stream stream = new MemoryStream(mockData);

            // Arrange
            var uploadSession = new UploadSession
            {
                NextExpectedRanges = new List<string>() { "0-" },
                UploadUrl = requestUrl,
                ExpirationDateTime = DateTimeOffset.Parse("2019-11-07T06:39:31.499Z")
            };
            int maxSliceSize = 320 * 1024;
            // 1. create a mock response
            using var responseMessage = new HttpResponseMessage();
            var responseJSON = @"{
                  ""expirationDateTime"": ""2015 - 01 - 29T09: 21:55.523Z"",
                  ""nextExpectedRanges"": [
                  ""12345-55232"",
                  ""77829-99375""
                  ]
                }";
            HttpContent content = new StringContent(responseJSON, Encoding.UTF8, CoreConstants.MimeTypeNames.Application.Json);
            responseMessage.Content = content;

            // Create mock handler
            using var testHttpMessageHandler = new TestHttpMessageHandler();
            testHttpMessageHandler.AddResponseMapping(requestUrl, responseMessage);

            // Create cancelled token
            var cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;
            cancellationTokenSource.Cancel();

            // Create task
            IBaseClient baseClient = new BaseClient(new BaseGraphRequestAdapter(new AnonymousAuthenticationProvider(), httpClient: GraphClientFactory.Create(finalHandler: testHttpMessageHandler)));
            var fileUploadTask = new LargeFileUploadTask<TestDriveItem>(uploadSession, stream, maxSliceSize, baseClient.RequestAdapter);

            // Assert that the task is cancellable
            var cancellationException = await Assert.ThrowsAsync<TaskCanceledException>(() => fileUploadTask.UploadAsync(cancellationToken: cancellationToken));
            Assert.Contains("A task was canceled", cancellationException.Message);
        }
    }
}
