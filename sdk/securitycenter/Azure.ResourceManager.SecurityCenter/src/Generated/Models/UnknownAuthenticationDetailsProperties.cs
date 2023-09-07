// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The UnknownAuthenticationDetailsProperties. </summary>
    internal partial class UnknownAuthenticationDetailsProperties : AuthenticationDetailsProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAuthenticationDetailsProperties"/>. </summary>
        /// <param name="authenticationProvisioningState"> State of the multi-cloud connector. </param>
        /// <param name="grantedPermissions"> The permissions detected in the cloud account. </param>
        /// <param name="authenticationType"> Connect to your cloud account, for AWS use either account credentials or role-based authentication. For GCP use account organization credentials. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAuthenticationDetailsProperties(AuthenticationProvisioningState? authenticationProvisioningState, IReadOnlyList<SecurityCenterCloudPermission> grantedPermissions, AuthenticationType authenticationType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(authenticationProvisioningState, grantedPermissions, authenticationType, serializedAdditionalRawData)
        {
            AuthenticationType = authenticationType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAuthenticationDetailsProperties"/> for deserialization. </summary>
        internal UnknownAuthenticationDetailsProperties()
        {
        }
    }
}
