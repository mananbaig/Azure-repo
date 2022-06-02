// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role assignment properties. </summary>
    public partial class RoleAssignmentProperties
    {
        /// <summary> Initializes a new instance of RoleAssignmentProperties. </summary>
        /// <param name="roleDefinitionId"> The role definition ID used in the role assignment. </param>
        /// <param name="principalId"> The principal ID assigned to the role. This maps to the ID inside the Active Directory. It can point to a user, service principal, or security group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> or <paramref name="principalId"/> is null. </exception>
        public RoleAssignmentProperties(string roleDefinitionId, string principalId)
        {
            if (roleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }
            if (principalId == null)
            {
                throw new ArgumentNullException(nameof(principalId));
            }

            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
        }

        /// <summary> The role definition ID used in the role assignment. </summary>
        public string RoleDefinitionId { get; }
        /// <summary> The principal ID assigned to the role. This maps to the ID inside the Active Directory. It can point to a user, service principal, or security group. </summary>
        public string PrincipalId { get; }
    }
}
