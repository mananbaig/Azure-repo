// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The JIT authorization policies. </summary>
    public partial class JitAuthorizationPolicies
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="JitAuthorizationPolicies"/>. </summary>
        /// <param name="principalId"> The the principal id that will be granted JIT access. </param>
        /// <param name="roleDefinitionId"> The role definition id that will be granted to the Principal. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public JitAuthorizationPolicies(Guid principalId, string roleDefinitionId)
        {
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));

            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
        }

        /// <summary> Initializes a new instance of <see cref="JitAuthorizationPolicies"/>. </summary>
        /// <param name="principalId"> The the principal id that will be granted JIT access. </param>
        /// <param name="roleDefinitionId"> The role definition id that will be granted to the Principal. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JitAuthorizationPolicies(Guid principalId, string roleDefinitionId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JitAuthorizationPolicies"/> for deserialization. </summary>
        internal JitAuthorizationPolicies()
        {
        }

        /// <summary> The the principal id that will be granted JIT access. </summary>
        public Guid PrincipalId { get; set; }
        /// <summary> The role definition id that will be granted to the Principal. </summary>
        public string RoleDefinitionId { get; set; }
    }
}
