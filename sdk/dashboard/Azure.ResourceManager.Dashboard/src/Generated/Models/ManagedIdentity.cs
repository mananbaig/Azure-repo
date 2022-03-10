// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Dashboard.Models
{
    /// <summary> The managed identity of a resource. </summary>
    public partial class ManagedIdentity
    {
        /// <summary> Initializes a new instance of ManagedIdentity. </summary>
        public ManagedIdentity()
        {
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of ManagedIdentity. </summary>
        /// <param name="type"> The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the resource. </param>
        /// <param name="principalId"> The principal id of the system assigned identity. </param>
        /// <param name="tenantId"> The tenant id of the system assigned identity. </param>
        /// <param name="userAssignedIdentities"> Dictionary of user assigned identities. </param>
        internal ManagedIdentity(IdentityType? type, string principalId, string tenantId, IDictionary<string, UserAssignedIdentity> userAssignedIdentities)
        {
            Type = type;
            PrincipalId = principalId;
            TenantId = tenantId;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the resource. </summary>
        public IdentityType? Type { get; set; }
        /// <summary> The principal id of the system assigned identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The tenant id of the system assigned identity. </summary>
        public string TenantId { get; }
        /// <summary> Dictionary of user assigned identities. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
