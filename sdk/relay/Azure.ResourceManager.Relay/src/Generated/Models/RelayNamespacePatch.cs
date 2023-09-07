// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Relay;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> Description of a namespace resource. </summary>
    public partial class RelayNamespacePatch : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RelayNamespacePatch"/>. </summary>
        public RelayNamespacePatch()
        {
            PrivateEndpointConnections = new ChangeTrackingList<RelayPrivateEndpointConnectionData>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="RelayNamespacePatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> SKU of the namespace. </param>
        /// <param name="provisioningState"> Provisioning state of the Namespace. </param>
        /// <param name="status"> Status of the Namespace. </param>
        /// <param name="createdOn"> The time the namespace was created. </param>
        /// <param name="updatedOn"> The time the namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform Service Bus operations. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="publicNetworkAccess"> This determines if traffic is allowed over public network. By default it is enabled. DO NOT USE PublicNetworkAccess on Namespace API. Please use the NetworkRuleSet API to enable or disable PublicNetworkAccess. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RelayNamespacePatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RelaySku sku, string provisioningState, string status, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string serviceBusEndpoint, string metricId, IList<RelayPrivateEndpointConnectionData> privateEndpointConnections, RelayPublicNetworkAccess? publicNetworkAccess, IDictionary<string, string> tags, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            ProvisioningState = provisioningState;
            Status = status;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ServiceBusEndpoint = serviceBusEndpoint;
            MetricId = metricId;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> SKU of the namespace. </summary>
        public RelaySku Sku { get; set; }
        /// <summary> Provisioning state of the Namespace. </summary>
        public string ProvisioningState { get; }
        /// <summary> Status of the Namespace. </summary>
        public string Status { get; }
        /// <summary> The time the namespace was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time the namespace was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Endpoint you can use to perform Service Bus operations. </summary>
        public string ServiceBusEndpoint { get; }
        /// <summary> Identifier for Azure Insights metrics. </summary>
        public string MetricId { get; }
        /// <summary> List of private endpoint connections. </summary>
        public IList<RelayPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> This determines if traffic is allowed over public network. By default it is enabled. DO NOT USE PublicNetworkAccess on Namespace API. Please use the NetworkRuleSet API to enable or disable PublicNetworkAccess. </summary>
        public RelayPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
