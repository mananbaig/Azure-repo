// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing the ServiceBusDisasterRecovery data model.
    /// Single item in List or Get Alias(Disaster Recovery configuration) operation
    /// </summary>
    public partial class ServiceBusDisasterRecoveryData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceBusDisasterRecoveryData"/>. </summary>
        public ServiceBusDisasterRecoveryData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBusDisasterRecoveryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the Alias(Disaster Recovery configuration) - possible values 'Accepted' or 'Succeeded' or 'Failed'. </param>
        /// <param name="pendingReplicationOperationsCount"> Number of entities pending to be replicated. </param>
        /// <param name="partnerNamespace"> ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </param>
        /// <param name="alternateName"> Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </param>
        /// <param name="role"> role of namespace in GEO DR - possible values 'Primary' or 'PrimaryNotReplicating' or 'Secondary'. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceBusDisasterRecoveryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ServiceBusDisasterRecoveryProvisioningState? provisioningState, long? pendingReplicationOperationsCount, string partnerNamespace, string alternateName, ServiceBusDisasterRecoveryRole? role, AzureLocation? location, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PendingReplicationOperationsCount = pendingReplicationOperationsCount;
            PartnerNamespace = partnerNamespace;
            AlternateName = alternateName;
            Role = role;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provisioning state of the Alias(Disaster Recovery configuration) - possible values 'Accepted' or 'Succeeded' or 'Failed'. </summary>
        public ServiceBusDisasterRecoveryProvisioningState? ProvisioningState { get; }
        /// <summary> Number of entities pending to be replicated. </summary>
        public long? PendingReplicationOperationsCount { get; }
        /// <summary> ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </summary>
        public string PartnerNamespace { get; set; }
        /// <summary> Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </summary>
        public string AlternateName { get; set; }
        /// <summary> role of namespace in GEO DR - possible values 'Primary' or 'PrimaryNotReplicating' or 'Secondary'. </summary>
        public ServiceBusDisasterRecoveryRole? Role { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
