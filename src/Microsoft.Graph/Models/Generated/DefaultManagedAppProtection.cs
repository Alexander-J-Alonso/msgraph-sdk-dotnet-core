// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Default Managed App Protection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DefaultManagedAppProtection : ManagedAppProtection
    {
    
        /// <summary>
        /// Gets or sets app data encryption type.
        /// Type of encryption which should be used for data in a managed app. (iOS Only) Possible values are: useDeviceSettings, afterDeviceRestart, whenDeviceLockedExceptOpenFiles, whenDeviceLocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDataEncryptionType", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppDataEncryptionType? AppDataEncryptionType { get; set; }
    
        /// <summary>
        /// Gets or sets screen capture blocked.
        /// Indicates whether screen capture is blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "screenCaptureBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? ScreenCaptureBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets encrypt app data.
        /// Indicates whether managed-app data should be encrypted. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptAppData", Required = Newtonsoft.Json.Required.Default)]
        public bool? EncryptAppData { get; set; }
    
        /// <summary>
        /// Gets or sets disable app encryption if device encryption is enabled.
        /// When this setting is enabled, app level encryption is disabled if device level encryption is enabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disableAppEncryptionIfDeviceEncryptionIsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required sdk version.
        /// Versions less than the specified version will block the managed app from accessing company data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumRequiredSdkVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumRequiredSdkVersion { get; set; }
    
        /// <summary>
        /// Gets or sets custom settings.
        /// A set of string key and string value pairs to be sent to the affected users, unalterned by this service
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customSettings", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> CustomSettings { get; set; }
    
        /// <summary>
        /// Gets or sets deployed app count.
        /// Count of apps to which the current policy is deployed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deployedAppCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeployedAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required patch version.
        /// Define the oldest required Android security patch level a user can have to gain secure access to the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumRequiredPatchVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumRequiredPatchVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum warning patch version.
        /// Define the oldest recommended Android security patch level a user can have for secure access to the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWarningPatchVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWarningPatchVersion { get; set; }
    
        /// <summary>
        /// Gets or sets face id blocked.
        /// Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "faceIdBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? FaceIdBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets apps.
        /// List of apps to which the policy is deployed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apps", Required = Newtonsoft.Json.Required.Default)]
        public IDefaultManagedAppProtectionAppsCollectionPage Apps { get; set; }
    
        /// <summary>
        /// Gets or sets deployment summary.
        /// Navigation property to deployment summary of the configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentSummary", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
    
    }
}

