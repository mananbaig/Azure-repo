// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A Synapse Workspace Sql Pool Table data set mapping. </summary>
    public partial class SynapseWorkspaceSqlPoolTableDataSetMapping : ShareDataSetMappingData
    {
        /// <summary> Initializes a new instance of <see cref="SynapseWorkspaceSqlPoolTableDataSetMapping"/>. </summary>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="synapseWorkspaceSqlPoolTableResourceId"> Resource id of the Synapse Workspace SQL Pool Table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="synapseWorkspaceSqlPoolTableResourceId"/> is null. </exception>
        public SynapseWorkspaceSqlPoolTableDataSetMapping(Guid dataSetId, ResourceIdentifier synapseWorkspaceSqlPoolTableResourceId)
        {
            Argument.AssertNotNull(synapseWorkspaceSqlPoolTableResourceId, nameof(synapseWorkspaceSqlPoolTableResourceId));

            DataSetId = dataSetId;
            SynapseWorkspaceSqlPoolTableResourceId = synapseWorkspaceSqlPoolTableResourceId;
            Kind = DataSetMappingKind.SynapseWorkspaceSqlPoolTable;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseWorkspaceSqlPoolTableDataSetMapping"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set mapping. </param>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="dataSetMappingStatus"> Gets the status of the data set mapping. </param>
        /// <param name="provisioningState"> Provisioning state of the data set mapping. </param>
        /// <param name="synapseWorkspaceSqlPoolTableResourceId"> Resource id of the Synapse Workspace SQL Pool Table. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseWorkspaceSqlPoolTableDataSetMapping(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetMappingKind kind, Guid dataSetId, DataSetMappingStatus? dataSetMappingStatus, DataShareProvisioningState? provisioningState, ResourceIdentifier synapseWorkspaceSqlPoolTableResourceId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            DataSetId = dataSetId;
            DataSetMappingStatus = dataSetMappingStatus;
            ProvisioningState = provisioningState;
            SynapseWorkspaceSqlPoolTableResourceId = synapseWorkspaceSqlPoolTableResourceId;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseWorkspaceSqlPoolTableDataSetMapping"/> for deserialization. </summary>
        internal SynapseWorkspaceSqlPoolTableDataSetMapping()
        {
        }

        /// <summary> The id of the source data set. </summary>
        public Guid DataSetId { get; set; }
        /// <summary> Gets the status of the data set mapping. </summary>
        public DataSetMappingStatus? DataSetMappingStatus { get; }
        /// <summary> Provisioning state of the data set mapping. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
        /// <summary> Resource id of the Synapse Workspace SQL Pool Table. </summary>
        public ResourceIdentifier SynapseWorkspaceSqlPoolTableResourceId { get; set; }
    }
}
