// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IManagedAppProtectionRequestBuilder.
    /// </summary>
    public partial interface IManagedAppProtectionRequestBuilder : IManagedAppPolicyRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IManagedAppProtectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IManagedAppProtectionRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ManagedAppProtectionTargetApps.
        /// </summary>
        /// <returns>The <see cref="IManagedAppProtectionTargetAppsRequestBuilder"/>.</returns>
        IManagedAppProtectionTargetAppsRequestBuilder TargetApps(
            IEnumerable<ManagedMobileApp> apps = null);
    
    }
}
