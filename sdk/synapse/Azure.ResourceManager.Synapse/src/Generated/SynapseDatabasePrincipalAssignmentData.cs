// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseDatabasePrincipalAssignment data model.
    /// Class representing a database principal assignment.
    /// </summary>
    public partial class SynapseDatabasePrincipalAssignmentData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseDatabasePrincipalAssignmentData"/>. </summary>
        public SynapseDatabasePrincipalAssignmentData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseDatabasePrincipalAssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="principalId"> The principal ID assigned to the database principal. It can be a user email, application ID, or security group name. </param>
        /// <param name="role"> Database principal role. </param>
        /// <param name="tenantId"> The tenant id of the principal. </param>
        /// <param name="principalType"> Principal type. </param>
        /// <param name="tenantName"> The tenant name of the principal. </param>
        /// <param name="principalName"> The principal name. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="aadObjectId"> The service principal object id in AAD (Azure active directory). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseDatabasePrincipalAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string principalId, SynapseDatabasePrincipalRole? role, Guid? tenantId, SynapsePrincipalType? principalType, string tenantName, string principalName, ResourceProvisioningState? provisioningState, Guid? aadObjectId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            PrincipalId = principalId;
            Role = role;
            TenantId = tenantId;
            PrincipalType = principalType;
            TenantName = tenantName;
            PrincipalName = principalName;
            ProvisioningState = provisioningState;
            AadObjectId = aadObjectId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The principal ID assigned to the database principal. It can be a user email, application ID, or security group name. </summary>
        public string PrincipalId { get; set; }
        /// <summary> Database principal role. </summary>
        public SynapseDatabasePrincipalRole? Role { get; set; }
        /// <summary> The tenant id of the principal. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Principal type. </summary>
        public SynapsePrincipalType? PrincipalType { get; set; }
        /// <summary> The tenant name of the principal. </summary>
        public string TenantName { get; }
        /// <summary> The principal name. </summary>
        public string PrincipalName { get; }
        /// <summary> The provisioned state of the resource. </summary>
        public ResourceProvisioningState? ProvisioningState { get; }
        /// <summary> The service principal object id in AAD (Azure active directory). </summary>
        public Guid? AadObjectId { get; }
    }
}
