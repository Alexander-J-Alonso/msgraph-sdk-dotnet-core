// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum PrereleaseFeatures.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PrereleaseFeatures
    {
    
        /// <summary>
        /// user Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// settings Only
        /// </summary>
        SettingsOnly = 1,
	
        /// <summary>
        /// settings And Experimentations
        /// </summary>
        SettingsAndExperimentations = 2,
	
        /// <summary>
        /// not Allowed
        /// </summary>
        NotAllowed = 3,
	
    }
}
