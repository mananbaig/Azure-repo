// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the frontend configurations for the node type.
    /// </summary>
    public partial class FrontendConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the FrontendConfiguration class.
        /// </summary>
        public FrontendConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FrontendConfiguration class.
        /// </summary>
        /// <param name="ipAddressType">The IP address type of this frontend
        /// configuration. If omitted the default value is IPv4. Possible
        /// values include: 'IPv4', 'IPv6'</param>
        /// <param name="loadBalancerBackendAddressPoolId">The resource Id of
        /// the Load Balancer backend address pool that the VM instances of the
        /// node type are associated with. The format of the resource Id is
        /// '/subscriptions/&lt;subscriptionId&gt;/resourceGroups/&lt;resourceGroupName&gt;/providers/Microsoft.Network/loadBalancers/&lt;loadBalancerName&gt;/backendAddressPools/&lt;backendAddressPoolName&gt;'.</param>
        /// <param name="loadBalancerInboundNatPoolId">The resource Id of the
        /// Load Balancer inbound NAT pool that the VM instances of the node
        /// type are associated with. The format of the resource Id is
        /// '/subscriptions/&lt;subscriptionId&gt;/resourceGroups/&lt;resourceGroupName&gt;/providers/Microsoft.Network/loadBalancers/&lt;loadBalancerName&gt;/inboundNatPools/&lt;inboundNatPoolName&gt;'.</param>
        public FrontendConfiguration(string ipAddressType = default(string), string loadBalancerBackendAddressPoolId = default(string), string loadBalancerInboundNatPoolId = default(string))
        {
            IpAddressType = ipAddressType;
            LoadBalancerBackendAddressPoolId = loadBalancerBackendAddressPoolId;
            LoadBalancerInboundNatPoolId = loadBalancerInboundNatPoolId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IP address type of this frontend configuration. If
        /// omitted the default value is IPv4. Possible values include: 'IPv4',
        /// 'IPv6'
        /// </summary>
        [JsonProperty(PropertyName = "ipAddressType")]
        public string IpAddressType { get; set; }

        /// <summary>
        /// Gets or sets the resource Id of the Load Balancer backend address
        /// pool that the VM instances of the node type are associated with.
        /// The format of the resource Id is
        /// '/subscriptions/&amp;lt;subscriptionId&amp;gt;/resourceGroups/&amp;lt;resourceGroupName&amp;gt;/providers/Microsoft.Network/loadBalancers/&amp;lt;loadBalancerName&amp;gt;/backendAddressPools/&amp;lt;backendAddressPoolName&amp;gt;'.
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancerBackendAddressPoolId")]
        public string LoadBalancerBackendAddressPoolId { get; set; }

        /// <summary>
        /// Gets or sets the resource Id of the Load Balancer inbound NAT pool
        /// that the VM instances of the node type are associated with. The
        /// format of the resource Id is
        /// '/subscriptions/&amp;lt;subscriptionId&amp;gt;/resourceGroups/&amp;lt;resourceGroupName&amp;gt;/providers/Microsoft.Network/loadBalancers/&amp;lt;loadBalancerName&amp;gt;/inboundNatPools/&amp;lt;inboundNatPoolName&amp;gt;'.
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancerInboundNatPoolId")]
        public string LoadBalancerInboundNatPoolId { get; set; }

    }
}
