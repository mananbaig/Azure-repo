// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceFabric;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// NodeType details
    /// </summary>
    public partial class NodeTypeDescription
    {
        /// <summary>
        /// Initializes a new instance of the NodeTypeDescription class.
        /// </summary>
        public NodeTypeDescription() { }

        /// <summary>
        /// Initializes a new instance of the NodeTypeDescription class.
        /// </summary>
        /// <param name="name">Name of NodeType</param>
        /// <param name="placementProperties">Placement property key</param>
        /// <param name="capacities">Capacity property key</param>
        /// <param name="clientConnectionEndpointPort">TCP gateway endpoint
        /// port</param>
        /// <param name="httpGatewayEndpointPort">Http gateway endpoint
        /// port</param>
        /// <param name="durabilityLevel">Nodetype durability Level. Possible
        /// values include: 'Bronze', 'Silver', 'Gold', 'Platimun'</param>
        /// <param name="applicationPorts">Ports used by applications</param>
        /// <param name="ephemeralPorts">System assgined application
        /// ports</param>
        /// <param name="isPrimary">Mark this node as primay</param>
        /// <param name="vmInstanceCount">VMSS instance count</param>
        /// <param name="reverseProxyEndpointPort">Endpoint used by reverse
        /// proxy</param>
        public NodeTypeDescription(string name = default(string), IDictionary<string, string> placementProperties = default(IDictionary<string, string>), IDictionary<string, string> capacities = default(IDictionary<string, string>), int? clientConnectionEndpointPort = default(int?), int? httpGatewayEndpointPort = default(int?), string durabilityLevel = default(string), EndpointRangeDescription applicationPorts = default(EndpointRangeDescription), EndpointRangeDescription ephemeralPorts = default(EndpointRangeDescription), bool? isPrimary = default(bool?), int? vmInstanceCount = default(int?), int? reverseProxyEndpointPort = default(int?))
        {
            Name = name;
            PlacementProperties = placementProperties;
            Capacities = capacities;
            ClientConnectionEndpointPort = clientConnectionEndpointPort;
            HttpGatewayEndpointPort = httpGatewayEndpointPort;
            DurabilityLevel = durabilityLevel;
            ApplicationPorts = applicationPorts;
            EphemeralPorts = ephemeralPorts;
            IsPrimary = isPrimary;
            VmInstanceCount = vmInstanceCount;
            ReverseProxyEndpointPort = reverseProxyEndpointPort;
        }

        /// <summary>
        /// Gets or sets name of NodeType
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets placement property key
        /// </summary>
        [JsonProperty(PropertyName = "placementProperties")]
        public IDictionary<string, string> PlacementProperties { get; set; }

        /// <summary>
        /// Gets or sets capacity property key
        /// </summary>
        [JsonProperty(PropertyName = "capacities")]
        public IDictionary<string, string> Capacities { get; set; }

        /// <summary>
        /// Gets or sets TCP gateway endpoint port
        /// </summary>
        [JsonProperty(PropertyName = "clientConnectionEndpointPort")]
        public int? ClientConnectionEndpointPort { get; set; }

        /// <summary>
        /// Gets or sets http gateway endpoint port
        /// </summary>
        [JsonProperty(PropertyName = "httpGatewayEndpointPort")]
        public int? HttpGatewayEndpointPort { get; set; }

        /// <summary>
        /// Gets or sets nodetype durability Level. Possible values include:
        /// 'Bronze', 'Silver', 'Gold', 'Platimun'
        /// </summary>
        [JsonProperty(PropertyName = "durabilityLevel")]
        public string DurabilityLevel { get; set; }

        /// <summary>
        /// Gets or sets ports used by applications
        /// </summary>
        [JsonProperty(PropertyName = "applicationPorts")]
        public EndpointRangeDescription ApplicationPorts { get; set; }

        /// <summary>
        /// Gets or sets system assgined application ports
        /// </summary>
        [JsonProperty(PropertyName = "ephemeralPorts")]
        public EndpointRangeDescription EphemeralPorts { get; set; }

        /// <summary>
        /// Gets or sets mark this node as primay
        /// </summary>
        [JsonProperty(PropertyName = "isPrimary")]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Gets or sets VMSS instance count
        /// </summary>
        [JsonProperty(PropertyName = "vmInstanceCount")]
        public int? VmInstanceCount { get; set; }

        /// <summary>
        /// Gets or sets endpoint used by reverse proxy
        /// </summary>
        [JsonProperty(PropertyName = "reverseProxyEndpointPort")]
        public int? ReverseProxyEndpointPort { get; set; }

    }
}
