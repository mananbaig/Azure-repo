// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ExpressRouteGateway data model. </summary>
    public partial class ExpressRouteGatewayData : Resource
    {
        /// <summary> Initializes a new instance of ExpressRouteGatewayData. </summary>
        public ExpressRouteGatewayData()
        {
            ExpressRouteConnections = new ChangeTrackingList<ExpressRouteConnectionData>();
        }

        /// <summary> Initializes a new instance of ExpressRouteGatewayData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="autoScaleConfiguration"> Configuration for auto scaling. </param>
        /// <param name="expressRouteConnections"> List of ExpressRoute connections to the ExpressRoute gateway. </param>
        /// <param name="provisioningState"> The provisioning state of the express route gateway resource. </param>
        /// <param name="virtualHub"> The Virtual Hub where the ExpressRoute gateway is or will be deployed. </param>
        internal ExpressRouteGatewayData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, ExpressRouteGatewayPropertiesAutoScaleConfiguration autoScaleConfiguration, IReadOnlyList<ExpressRouteConnectionData> expressRouteConnections, ProvisioningState? provisioningState, WritableSubResource virtualHub) : base(id, name, type, location, tags)
        {
            Etag = etag;
            AutoScaleConfiguration = autoScaleConfiguration;
            ExpressRouteConnections = expressRouteConnections;
            ProvisioningState = provisioningState;
            VirtualHub = virtualHub;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Configuration for auto scaling. </summary>
        internal ExpressRouteGatewayPropertiesAutoScaleConfiguration AutoScaleConfiguration { get; set; }
        /// <summary> Minimum and maximum number of scale units to deploy. </summary>
        public ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds AutoScaleBounds
        {
            get => AutoScaleConfiguration is null ? default : AutoScaleConfiguration.Bounds;
            set
            {
                if (AutoScaleConfiguration is null)
                    AutoScaleConfiguration = new ExpressRouteGatewayPropertiesAutoScaleConfiguration();
                AutoScaleConfiguration.Bounds = value;
            }
        }

        /// <summary> List of ExpressRoute connections to the ExpressRoute gateway. </summary>
        public IReadOnlyList<ExpressRouteConnectionData> ExpressRouteConnections { get; }
        /// <summary> The provisioning state of the express route gateway resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The Virtual Hub where the ExpressRoute gateway is or will be deployed. </summary>
        internal WritableSubResource VirtualHub { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualHubId
        {
            get => VirtualHub is null ? default : VirtualHub.Id;
            set
            {
                if (VirtualHub is null)
                    VirtualHub = new WritableSubResource();
                VirtualHub.Id = value;
            }
        }
    }
}
