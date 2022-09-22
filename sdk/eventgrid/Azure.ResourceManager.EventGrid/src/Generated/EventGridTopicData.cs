// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary> A class representing the EventGridTopic data model. </summary>
    public partial class EventGridTopicData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of EventGridTopicData. </summary>
        /// <param name="location"> The location. </param>
        public EventGridTopicData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<EventGridPrivateEndpointConnectionData>();
            InboundIPRules = new ChangeTrackingList<EventGridInboundIPRule>();
        }

        /// <summary> Initializes a new instance of EventGridTopicData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity information for the resource. </param>
        /// <param name="privateEndpointConnections"></param>
        /// <param name="provisioningState"> Provisioning state of the topic. </param>
        /// <param name="endpoint"> Endpoint for the topic. </param>
        /// <param name="inputSchema"> This determines the format that Event Grid should expect for incoming events published to the topic. </param>
        /// <param name="inputSchemaMapping">
        /// This enables publishing using custom event schemas. An InputSchemaMapping can be specified to map various properties of a source schema to various required properties of the EventGridEvent schema.
        /// Please note <see cref="EventGridInputSchemaMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EventGridJsonInputSchemaMapping"/>.
        /// </param>
        /// <param name="metricResourceId"> Metric resource id for the topic. </param>
        /// <param name="publicNetworkAccess">
        /// This determines if traffic is allowed over public network. By default it is enabled. 
        /// You can further restrict to specific IPs by configuring &lt;seealso cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.TopicProperties.InboundIpRules&quot; /&gt;
        /// </param>
        /// <param name="inboundIPRules"> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </param>
        /// <param name="isLocalAuthDisabled"> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the topic. </param>
        /// <param name="dataResidencyBoundary"> Data Residency Boundary of the resource. </param>
        internal EventGridTopicData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, IReadOnlyList<EventGridPrivateEndpointConnectionData> privateEndpointConnections, EventGridTopicProvisioningState? provisioningState, Uri endpoint, EventGridInputSchema? inputSchema, EventGridInputSchemaMapping inputSchemaMapping, string metricResourceId, EventGridPublicNetworkAccess? publicNetworkAccess, IList<EventGridInboundIPRule> inboundIPRules, bool? isLocalAuthDisabled, DataResidencyBoundary? dataResidencyBoundary) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            Endpoint = endpoint;
            InputSchema = inputSchema;
            InputSchemaMapping = inputSchemaMapping;
            MetricResourceId = metricResourceId;
            PublicNetworkAccess = publicNetworkAccess;
            InboundIPRules = inboundIPRules;
            IsLocalAuthDisabled = isLocalAuthDisabled;
            DataResidencyBoundary = dataResidencyBoundary;
        }

        /// <summary> Identity information for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Gets the private endpoint connections. </summary>
        public IReadOnlyList<EventGridPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Provisioning state of the topic. </summary>
        public EventGridTopicProvisioningState? ProvisioningState { get; }
        /// <summary> Endpoint for the topic. </summary>
        public Uri Endpoint { get; }
        /// <summary> This determines the format that Event Grid should expect for incoming events published to the topic. </summary>
        public EventGridInputSchema? InputSchema { get; set; }
        /// <summary>
        /// This enables publishing using custom event schemas. An InputSchemaMapping can be specified to map various properties of a source schema to various required properties of the EventGridEvent schema.
        /// Please note <see cref="EventGridInputSchemaMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EventGridJsonInputSchemaMapping"/>.
        /// </summary>
        public EventGridInputSchemaMapping InputSchemaMapping { get; set; }
        /// <summary> Metric resource id for the topic. </summary>
        public string MetricResourceId { get; }
        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled. 
        /// You can further restrict to specific IPs by configuring &lt;seealso cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.TopicProperties.InboundIpRules&quot; /&gt;
        /// </summary>
        public EventGridPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </summary>
        public IList<EventGridInboundIPRule> InboundIPRules { get; }
        /// <summary> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the topic. </summary>
        public bool? IsLocalAuthDisabled { get; set; }
        /// <summary> Data Residency Boundary of the resource. </summary>
        public DataResidencyBoundary? DataResidencyBoundary { get; set; }
    }
}
