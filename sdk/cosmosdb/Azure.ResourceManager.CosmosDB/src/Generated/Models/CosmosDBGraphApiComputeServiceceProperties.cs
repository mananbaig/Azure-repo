// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Properties for GraphAPIComputeServiceResource. </summary>
    public partial class CosmosDBGraphApiComputeServiceceProperties : CosmosDBServiceResourceProperties
    {
        /// <summary> Initializes a new instance of CosmosDBGraphApiComputeServiceceProperties. </summary>
        public CosmosDBGraphApiComputeServiceceProperties()
        {
            Locations = new ChangeTrackingList<CosmosDBGraphApiComputeRegionalServiceInfo>();
            ServiceType = ServiceType.GraphApiCompute;
        }

        /// <summary> Initializes a new instance of CosmosDBGraphApiComputeServiceceProperties. </summary>
        /// <param name="createdOn"> Time of the last state change (ISO-8601 format). </param>
        /// <param name="instanceSize"> Instance type for the service. </param>
        /// <param name="instanceCount"> Instance count for the service. </param>
        /// <param name="serviceType"> ServiceType for the service. </param>
        /// <param name="status"> Describes the status of a service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="graphApiComputeEndpoint"> GraphAPICompute endpoint for the service. </param>
        /// <param name="locations"> An array that contains all of the locations for the service. </param>
        internal CosmosDBGraphApiComputeServiceceProperties(DateTimeOffset? createdOn, CosmosDBServiceSize? instanceSize, int? instanceCount, ServiceType serviceType, CosmosDBServiceStatus? status, IDictionary<string, BinaryData> additionalProperties, string graphApiComputeEndpoint, IReadOnlyList<CosmosDBGraphApiComputeRegionalServiceInfo> locations) : base(createdOn, instanceSize, instanceCount, serviceType, status, additionalProperties)
        {
            GraphApiComputeEndpoint = graphApiComputeEndpoint;
            Locations = locations;
            ServiceType = serviceType;
        }

        /// <summary> GraphAPICompute endpoint for the service. </summary>
        public string GraphApiComputeEndpoint { get; set; }
        /// <summary> An array that contains all of the locations for the service. </summary>
        public IReadOnlyList<CosmosDBGraphApiComputeRegionalServiceInfo> Locations { get; }
    }
}
