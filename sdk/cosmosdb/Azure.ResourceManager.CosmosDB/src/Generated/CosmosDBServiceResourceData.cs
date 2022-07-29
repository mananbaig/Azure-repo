// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing the CosmosDBServiceResource data model. </summary>
    public partial class CosmosDBServiceResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of CosmosDBServiceResourceData. </summary>
        public CosmosDBServiceResourceData()
        {
        }

        /// <summary> Initializes a new instance of CosmosDBServiceResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Services response resource.
        /// Please note <see cref="CosmosDBServiceResourceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CosmosDBDataTransferServiceProperties"/>, <see cref="CosmosDBGraphApiComputeServiceceProperties"/>, <see cref="CosmosDBMaterializedViewsBuilderServiceProperties"/> and <see cref="CosmosDBSqlDedicatedGatewayServiceProperties"/>.
        /// </param>
        internal CosmosDBServiceResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CosmosDBServiceResourceProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary>
        /// Services response resource.
        /// Please note <see cref="CosmosDBServiceResourceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CosmosDBDataTransferServiceProperties"/>, <see cref="CosmosDBGraphApiComputeServiceceProperties"/>, <see cref="CosmosDBMaterializedViewsBuilderServiceProperties"/> and <see cref="CosmosDBSqlDedicatedGatewayServiceProperties"/>.
        /// </summary>
        public CosmosDBServiceResourceProperties Properties { get; set; }
    }
}
