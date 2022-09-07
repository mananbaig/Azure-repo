// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Resource for a regional service location. </summary>
    public partial class MaterializedViewsBuilderRegionalServiceResource : RegionalServiceResource
    {
        /// <summary> Initializes a new instance of MaterializedViewsBuilderRegionalServiceResource. </summary>
        internal MaterializedViewsBuilderRegionalServiceResource()
        {
        }

        /// <summary> Initializes a new instance of MaterializedViewsBuilderRegionalServiceResource. </summary>
        /// <param name="name"> The regional service name. </param>
        /// <param name="location"> The location name. </param>
        /// <param name="status"> Describes the status of a service. </param>
        internal MaterializedViewsBuilderRegionalServiceResource(string name, AzureLocation? location, ServiceStatus? status) : base(name, location, status)
        {
        }
    }
}
