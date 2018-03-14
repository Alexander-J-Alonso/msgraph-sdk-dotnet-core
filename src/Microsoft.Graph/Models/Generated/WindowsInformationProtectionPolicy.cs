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
    /// The type Windows Information Protection Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsInformationProtectionPolicy : WindowsInformationProtection
    {
    
        /// <summary>
        /// Gets or sets revoke on mdm handoff disabled.
        /// New property in RS2, pending documentation
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "revokeOnMdmHandoffDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? RevokeOnMdmHandoffDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets mdm enrollment url.
        /// Enrollment url for the MDM
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mdmEnrollmentUrl", Required = Newtonsoft.Json.Required.Default)]
        public string MdmEnrollmentUrl { get; set; }
    
        /// <summary>
        /// Gets or sets windows hello for business blocked.
        /// Boolean value that sets Windows Hello for Business as a method for signing into Windows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsHelloForBusinessBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? WindowsHelloForBusinessBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets pin minimum length.
        /// Integer value that sets the minimum number of characters required for the PIN. Default value is 4. The lowest number you can configure for this policy setting is 4. The largest number you can configure must be less than the number configured in the Maximum PIN length policy setting or the number 127, whichever is the lowest.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets pin uppercase letters.
        /// Integer value that configures the use of uppercase letters in the Windows Hello for Business PIN. Default is NotAllow. Possible values are: notAllow, requireAtLeastOne, allow.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinUppercaseLetters", Required = Newtonsoft.Json.Required.Default)]
        public WindowsInformationProtectionPinCharacterRequirements? PinUppercaseLetters { get; set; }
    
        /// <summary>
        /// Gets or sets pin lowercase letters.
        /// Integer value that configures the use of lowercase letters in the Windows Hello for Business PIN. Default is NotAllow. Possible values are: notAllow, requireAtLeastOne, allow.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinLowercaseLetters", Required = Newtonsoft.Json.Required.Default)]
        public WindowsInformationProtectionPinCharacterRequirements? PinLowercaseLetters { get; set; }
    
        /// <summary>
        /// Gets or sets pin special characters.
        /// Integer value that configures the use of special characters in the Windows Hello for Business PIN. Valid special characters for Windows Hello for Business PIN gestures include: ! " # $ % & ' ( )  + , - . / : ; < = > ? @ [ \ ] ^  ` {
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinSpecialCharacters", Required = Newtonsoft.Json.Required.Default)]
        public WindowsInformationProtectionPinCharacterRequirements? PinSpecialCharacters { get; set; }
    
        /// <summary>
        /// Gets or sets pin expiration days.
        /// Integer value specifies the period of time (in days) that a PIN can be used before the system requires the user to change it. The largest number you can configure for this policy setting is 730. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then the user's PIN will never expire. This node was added in Windows 10, version 1511. Default is 0.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets number of past pins remembered.
        /// Integer value that specifies the number of past PINs that can be associated to a user account that can't be reused. The largest number you can configure for this policy setting is 50. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then storage of previous PINs is not required. This node was added in Windows 10, version 1511. Default is 0.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "numberOfPastPinsRemembered", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NumberOfPastPinsRemembered { get; set; }
    
        /// <summary>
        /// Gets or sets password maximum attempt count.
        /// The number of authentication failures allowed before the device will be wiped. A value of 0 disables device wipe functionality. Range is an integer X where 4 <= X <= 16 for desktop and 0 <= X <= 999 for mobile devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMaximumAttemptCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMaximumAttemptCount { get; set; }
    
        /// <summary>
        /// Gets or sets minutes of inactivity before device lock.
        /// Specifies the maximum amount of time (in minutes) allowed after the device is idle that will cause the device to become PIN or password locked.   Range is an integer X where 0 <= X <= 999.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minutesOfInactivityBeforeDeviceLock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MinutesOfInactivityBeforeDeviceLock { get; set; }
    
        /// <summary>
        /// Gets or sets days without contact before unenroll.
        /// Offline interval before app data is wiped (days)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "daysWithoutContactBeforeUnenroll", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DaysWithoutContactBeforeUnenroll { get; set; }
    
    }
}

