// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagementGroups.Models
{
    /// <summary> Describes the result of the request to check management group name availability. </summary>
    public partial class ManagementGroupNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of ManagementGroupNameAvailabilityResult. </summary>
        internal ManagementGroupNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of ManagementGroupNameAvailabilityResult. </summary>
        /// <param name="nameAvailable"> Required. True indicates name is valid and available. False indicates the name is invalid, unavailable, or both. </param>
        /// <param name="reason"> Required if nameAvailable == false. Invalid indicates the name provided does not match the resource provider&apos;s naming requirements (incorrect length, unsupported characters, etc.) AlreadyExists indicates that the name is already in use and is therefore unavailable. </param>
        /// <param name="message"> Required if nameAvailable == false. Localized. If reason == invalid, provide the user with the reason why the given name is invalid, and provide the resource naming requirements so that the user can select a valid name. If reason == AlreadyExists, explain that is already in use, and direct them to select a different name. </param>
        internal ManagementGroupNameAvailabilityResult(bool? nameAvailable, ManagementGroupNameUnavailableReason? reason, string message)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> Required. True indicates name is valid and available. False indicates the name is invalid, unavailable, or both. </summary>
        public bool? NameAvailable { get; }
        /// <summary> Required if nameAvailable == false. Invalid indicates the name provided does not match the resource provider&apos;s naming requirements (incorrect length, unsupported characters, etc.) AlreadyExists indicates that the name is already in use and is therefore unavailable. </summary>
        public ManagementGroupNameUnavailableReason? Reason { get; }
        /// <summary> Required if nameAvailable == false. Localized. If reason == invalid, provide the user with the reason why the given name is invalid, and provide the resource naming requirements so that the user can select a valid name. If reason == AlreadyExists, explain that is already in use, and direct them to select a different name. </summary>
        public string Message { get; }
    }
}
