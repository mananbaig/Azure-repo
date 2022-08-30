// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Represents a RegistrationInfo definition. </summary>
    public partial class HostPoolRegistrationInfoPatch
    {
        /// <summary> Initializes a new instance of HostPoolRegistrationInfoPatch. </summary>
        public HostPoolRegistrationInfoPatch()
        {
        }

        /// <summary> Initializes a new instance of HostPoolRegistrationInfoPatch. </summary>
        /// <param name="expireOn"> Expiration time of registration token. </param>
        /// <param name="registrationTokenOperation"> The type of resetting the token. </param>
        internal HostPoolRegistrationInfoPatch(DateTimeOffset? expireOn, HostPoolRegistrationTokenOperation? registrationTokenOperation)
        {
            ExpireOn = expireOn;
            RegistrationTokenOperation = registrationTokenOperation;
        }

        /// <summary> Expiration time of registration token. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The type of resetting the token. </summary>
        public HostPoolRegistrationTokenOperation? RegistrationTokenOperation { get; set; }
    }
}
