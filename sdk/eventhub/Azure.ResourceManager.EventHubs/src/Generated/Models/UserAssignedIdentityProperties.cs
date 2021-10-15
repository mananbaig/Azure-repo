// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The UserAssignedIdentityProperties. </summary>
    public partial class UserAssignedIdentityProperties
    {
        /// <summary> Initializes a new instance of UserAssignedIdentityProperties. </summary>
        public UserAssignedIdentityProperties()
        {
        }

        /// <summary> Initializes a new instance of UserAssignedIdentityProperties. </summary>
        /// <param name="userAssignedIdentity"> ARM ID of user Identity selected for encryption. </param>
        internal UserAssignedIdentityProperties(string userAssignedIdentity)
        {
            UserAssignedIdentity = userAssignedIdentity;
        }

        /// <summary> ARM ID of user Identity selected for encryption. </summary>
        public string UserAssignedIdentity { get; set; }
    }
}
