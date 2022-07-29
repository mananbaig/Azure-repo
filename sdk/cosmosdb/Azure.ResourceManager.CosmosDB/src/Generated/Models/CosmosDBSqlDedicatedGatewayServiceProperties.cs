// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Properties for SqlDedicatedGatewayServiceResource. </summary>
    public partial class CosmosDBSqlDedicatedGatewayServiceProperties : CosmosDBServiceResourceProperties
    {
        /// <summary> Initializes a new instance of CosmosDBSqlDedicatedGatewayServiceProperties. </summary>
        public CosmosDBSqlDedicatedGatewayServiceProperties()
        {
            Locations = new ChangeTrackingList<CosmosDBSqlDedicatedGatewayRegionalServiceInfo>();
            ServiceType = ServiceType.SqlDedicatedGateway;
        }

        /// <summary> Initializes a new instance of CosmosDBSqlDedicatedGatewayServiceProperties. </summary>
        /// <param name="createdOn"> Time of the last state change (ISO-8601 format). </param>
        /// <param name="instanceSize"> Instance type for the service. </param>
        /// <param name="instanceCount"> Instance count for the service. </param>
        /// <param name="serviceType"> ServiceType for the service. </param>
        /// <param name="status"> Describes the status of a service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="sqlDedicatedGatewayEndpoint"> SqlDedicatedGateway endpoint for the service. </param>
        /// <param name="locations"> An array that contains all of the locations for the service. </param>
        internal CosmosDBSqlDedicatedGatewayServiceProperties(DateTimeOffset? createdOn, CosmosDBServiceSize? instanceSize, int? instanceCount, ServiceType serviceType, CosmosDBServiceStatus? status, IDictionary<string, BinaryData> additionalProperties, string sqlDedicatedGatewayEndpoint, IReadOnlyList<CosmosDBSqlDedicatedGatewayRegionalServiceInfo> locations) : base(createdOn, instanceSize, instanceCount, serviceType, status, additionalProperties)
        {
            SqlDedicatedGatewayEndpoint = sqlDedicatedGatewayEndpoint;
            Locations = locations;
            ServiceType = serviceType;
        }

        /// <summary> SqlDedicatedGateway endpoint for the service. </summary>
        public string SqlDedicatedGatewayEndpoint { get; set; }
        /// <summary> An array that contains all of the locations for the service. </summary>
        public IReadOnlyList<CosmosDBSqlDedicatedGatewayRegionalServiceInfo> Locations { get; }
    }
}
