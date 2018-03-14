// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceConfigurationUserStatusRequest.
    /// </summary>
    public partial interface IDeviceConfigurationUserStatusRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceConfigurationUserStatus using PUT.
        /// </summary>
        /// <param name="deviceConfigurationUserStatusToCreate">The DeviceConfigurationUserStatus to create.</param>
        /// <returns>The created DeviceConfigurationUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationUserStatus> CreateAsync(DeviceConfigurationUserStatus deviceConfigurationUserStatusToCreate);        /// <summary>
        /// Creates the specified DeviceConfigurationUserStatus using PUT.
        /// </summary>
        /// <param name="deviceConfigurationUserStatusToCreate">The DeviceConfigurationUserStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationUserStatus> CreateAsync(DeviceConfigurationUserStatus deviceConfigurationUserStatusToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceConfigurationUserStatus.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceConfigurationUserStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceConfigurationUserStatus.
        /// </summary>
        /// <returns>The DeviceConfigurationUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationUserStatus> GetAsync();

        /// <summary>
        /// Gets the specified DeviceConfigurationUserStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationUserStatus> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceConfigurationUserStatus using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationUserStatusToUpdate">The DeviceConfigurationUserStatus to update.</param>
        /// <returns>The updated DeviceConfigurationUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationUserStatus> UpdateAsync(DeviceConfigurationUserStatus deviceConfigurationUserStatusToUpdate);

        /// <summary>
        /// Updates the specified DeviceConfigurationUserStatus using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationUserStatusToUpdate">The DeviceConfigurationUserStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceConfigurationUserStatus.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationUserStatus> UpdateAsync(DeviceConfigurationUserStatus deviceConfigurationUserStatusToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationUserStatusRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationUserStatusRequest Expand(Expression<Func<DeviceConfigurationUserStatus, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationUserStatusRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationUserStatusRequest Select(Expression<Func<DeviceConfigurationUserStatus, object>> selectExpression);

    }
}
