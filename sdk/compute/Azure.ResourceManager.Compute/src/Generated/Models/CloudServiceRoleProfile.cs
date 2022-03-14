// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the role profile for the cloud service. </summary>
    internal partial class CloudServiceRoleProfile
    {
        /// <summary> Initializes a new instance of CloudServiceRoleProfile. </summary>
        public CloudServiceRoleProfile()
        {
            Roles = new ChangeTrackingList<CloudServiceRoleProfileProperties>();
        }

        /// <summary> Initializes a new instance of CloudServiceRoleProfile. </summary>
        /// <param name="roles"> List of roles for the cloud service. </param>
        internal CloudServiceRoleProfile(IList<CloudServiceRoleProfileProperties> roles)
        {
            Roles = roles;
        }

        /// <summary> List of roles for the cloud service. </summary>
        public IList<CloudServiceRoleProfileProperties> Roles { get; }
    }
}
