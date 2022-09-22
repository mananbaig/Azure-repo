// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the DataCollectionRuleAssociation data model. </summary>
    public partial class DataCollectionRuleAssociationData : ResourceData
    {
        /// <summary> Initializes a new instance of DataCollectionRuleAssociationData. </summary>
        public DataCollectionRuleAssociationData()
        {
        }

        /// <summary> Initializes a new instance of DataCollectionRuleAssociationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Resource entity tag (ETag). </param>
        /// <param name="description"> Description of the association. </param>
        /// <param name="dataCollectionRuleId"> The resource ID of the data collection rule that is to be associated. </param>
        /// <param name="dataCollectionEndpointId"> The resource ID of the data collection endpoint that is to be associated. </param>
        /// <param name="provisioningState"> The resource provisioning state. </param>
        /// <param name="metadata"> Metadata about the resource. </param>
        internal DataCollectionRuleAssociationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, string description, ResourceIdentifier dataCollectionRuleId, ResourceIdentifier dataCollectionEndpointId, DataCollectionRuleAssociationProvisioningState? provisioningState, DataCollectionRuleAssociationMetadata metadata) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            Description = description;
            DataCollectionRuleId = dataCollectionRuleId;
            DataCollectionEndpointId = dataCollectionEndpointId;
            ProvisioningState = provisioningState;
            Metadata = metadata;
        }

        /// <summary> Resource entity tag (ETag). </summary>
        public ETag? ETag { get; }
        /// <summary> Description of the association. </summary>
        public string Description { get; set; }
        /// <summary> The resource ID of the data collection rule that is to be associated. </summary>
        public ResourceIdentifier DataCollectionRuleId { get; set; }
        /// <summary> The resource ID of the data collection endpoint that is to be associated. </summary>
        public ResourceIdentifier DataCollectionEndpointId { get; set; }
        /// <summary> The resource provisioning state. </summary>
        public DataCollectionRuleAssociationProvisioningState? ProvisioningState { get; }
        /// <summary> Metadata about the resource. </summary>
        internal DataCollectionRuleAssociationMetadata Metadata { get; }
        /// <summary> Azure offering managing this resource on-behalf-of customer. </summary>
        public string MetadataProvisionedBy
        {
            get => Metadata?.ProvisionedBy;
        }
    }
}
