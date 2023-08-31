// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The Network Fabric Controller Patch payload definition. </summary>
    public partial class NetworkFabricControllerPatch : NetworkRackPatch
    {
        /// <summary> Initializes a new instance of <see cref="NetworkFabricControllerPatch"/>. </summary>
        public NetworkFabricControllerPatch()
        {
            InfrastructureExpressRouteConnections = new ChangeTrackingList<ExpressRouteConnectionInformation>();
            WorkloadExpressRouteConnections = new ChangeTrackingList<ExpressRouteConnectionInformation>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricControllerPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="infrastructureExpressRouteConnections"> As part of an update, the Infrastructure ExpressRoute CircuitID should be provided to create and Provision a NFC. This Express route is dedicated for Infrastructure services. (This is a Mandatory attribute). </param>
        /// <param name="workloadExpressRouteConnections"> As part of an update, the workload ExpressRoute CircuitID should be provided to create and Provision a NFC. This Express route is dedicated for Workload services. (This is a Mandatory attribute). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricControllerPatch(IDictionary<string, string> tags, IList<ExpressRouteConnectionInformation> infrastructureExpressRouteConnections, IList<ExpressRouteConnectionInformation> workloadExpressRouteConnections, Dictionary<string, BinaryData> rawData) : base(tags, rawData)
        {
            InfrastructureExpressRouteConnections = infrastructureExpressRouteConnections;
            WorkloadExpressRouteConnections = workloadExpressRouteConnections;
        }

        /// <summary> As part of an update, the Infrastructure ExpressRoute CircuitID should be provided to create and Provision a NFC. This Express route is dedicated for Infrastructure services. (This is a Mandatory attribute). </summary>
        public IList<ExpressRouteConnectionInformation> InfrastructureExpressRouteConnections { get; }
        /// <summary> As part of an update, the workload ExpressRoute CircuitID should be provided to create and Provision a NFC. This Express route is dedicated for Workload services. (This is a Mandatory attribute). </summary>
        public IList<ExpressRouteConnectionInformation> WorkloadExpressRouteConnections { get; }
    }
}
