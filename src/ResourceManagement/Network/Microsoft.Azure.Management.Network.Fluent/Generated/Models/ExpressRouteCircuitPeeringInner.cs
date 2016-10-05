// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Peering in a ExpressRouteCircuit resource
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteCircuitPeeringInner : Microsoft.Rest.Azure.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitPeeringInner
        /// class.
        /// </summary>
        public ExpressRouteCircuitPeeringInner() { }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitPeeringInner
        /// class.
        /// </summary>
        /// <param name="peeringType">Gets or sets PeeringType. Possible
        /// values include: 'AzurePublicPeering', 'AzurePrivatePeering',
        /// 'MicrosoftPeering'</param>
        /// <param name="state">Gets or sets state of Peering. Possible values
        /// include: 'Disabled', 'Enabled'</param>
        /// <param name="azureASN">Gets or sets the azure ASN</param>
        /// <param name="peerASN">Gets or sets the peer ASN</param>
        /// <param name="primaryPeerAddressPrefix">Gets or sets the primary
        /// address prefix</param>
        /// <param name="secondaryPeerAddressPrefix">Gets or sets the
        /// secondary address prefix</param>
        /// <param name="primaryAzurePort">Gets or sets the primary
        /// port</param>
        /// <param name="secondaryAzurePort">Gets or sets the secondary
        /// port</param>
        /// <param name="sharedKey">Gets or sets the shared key</param>
        /// <param name="vlanId">Gets or sets the vlan id</param>
        /// <param name="microsoftPeeringConfig">Gets or sets the mircosoft
        /// peering config</param>
        /// <param name="stats">Gets or peering stats</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// PublicIP resource Updating/Deleting/Failed</param>
        /// <param name="gatewayManagerEtag">Gets or sets the GatewayManager
        /// Etag</param>
        /// <param name="lastModifiedBy">Gets whether the provider or the
        /// customer last modified the peering</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public ExpressRouteCircuitPeeringInner(string id = default(string), string peeringType = default(string), string state = default(string), int? azureASN = default(int?), int? peerASN = default(int?), string primaryPeerAddressPrefix = default(string), string secondaryPeerAddressPrefix = default(string), string primaryAzurePort = default(string), string secondaryAzurePort = default(string), string sharedKey = default(string), int? vlanId = default(int?), ExpressRouteCircuitPeeringConfig microsoftPeeringConfig = default(ExpressRouteCircuitPeeringConfig), ExpressRouteCircuitStatsInner stats = default(ExpressRouteCircuitStatsInner), string provisioningState = default(string), string gatewayManagerEtag = default(string), string lastModifiedBy = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            PeeringType = peeringType;
            State = state;
            AzureASN = azureASN;
            PeerASN = peerASN;
            PrimaryPeerAddressPrefix = primaryPeerAddressPrefix;
            SecondaryPeerAddressPrefix = secondaryPeerAddressPrefix;
            PrimaryAzurePort = primaryAzurePort;
            SecondaryAzurePort = secondaryAzurePort;
            SharedKey = sharedKey;
            VlanId = vlanId;
            MicrosoftPeeringConfig = microsoftPeeringConfig;
            Stats = stats;
            ProvisioningState = provisioningState;
            GatewayManagerEtag = gatewayManagerEtag;
            LastModifiedBy = lastModifiedBy;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets PeeringType. Possible values include:
        /// 'AzurePublicPeering', 'AzurePrivatePeering', 'MicrosoftPeering'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.peeringType")]
        public string PeeringType { get; set; }

        /// <summary>
        /// Gets or sets state of Peering. Possible values include:
        /// 'Disabled', 'Enabled'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the azure ASN
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.azureASN")]
        public int? AzureASN { get; set; }

        /// <summary>
        /// Gets or sets the peer ASN
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.peerASN")]
        public int? PeerASN { get; set; }

        /// <summary>
        /// Gets or sets the primary address prefix
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.primaryPeerAddressPrefix")]
        public string PrimaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the secondary address prefix
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.secondaryPeerAddressPrefix")]
        public string SecondaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the primary port
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.primaryAzurePort")]
        public string PrimaryAzurePort { get; set; }

        /// <summary>
        /// Gets or sets the secondary port
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.secondaryAzurePort")]
        public string SecondaryAzurePort { get; set; }

        /// <summary>
        /// Gets or sets the shared key
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// Gets or sets the vlan id
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.vlanId")]
        public int? VlanId { get; set; }

        /// <summary>
        /// Gets or sets the mircosoft peering config
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.microsoftPeeringConfig")]
        public ExpressRouteCircuitPeeringConfig MicrosoftPeeringConfig { get; set; }

        /// <summary>
        /// Gets or peering stats
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.stats")]
        public ExpressRouteCircuitStatsInner Stats { get; set; }

        /// <summary>
        /// Gets provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the GatewayManager Etag
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.gatewayManagerEtag")]
        public string GatewayManagerEtag { get; set; }

        /// <summary>
        /// Gets whether the provider or the customer last modified the peering
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
