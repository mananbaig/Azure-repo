// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Resource.Fluent;
    using System.Linq;

    /// <summary>
    /// Subnet in a VirtualNework resource
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SubnetInner : Microsoft.Azure.Management.Resource.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the SubnetInner class.
        /// </summary>
        public SubnetInner() { }

        /// <summary>
        /// Initializes a new instance of the SubnetInner class.
        /// </summary>
        /// <param name="addressPrefix">Gets or sets Address prefix for the
        /// subnet.</param>
        /// <param name="networkSecurityGroup">Gets or sets the reference of
        /// the NetworkSecurityGroup resource</param>
        /// <param name="routeTable">Gets or sets the reference of the
        /// RouteTable resource</param>
        /// <param name="ipConfigurations">Gets array of references to the
        /// network interface IP configurations using subnet</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// resource</param>
        /// <param name="name">Gets or sets the name of the resource that is
        /// unique within a resource group. This name can be used to access
        /// the resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public SubnetInner(string id = default(string), string addressPrefix = default(string), NetworkSecurityGroupInner networkSecurityGroup = default(NetworkSecurityGroupInner), RouteTableInner routeTable = default(RouteTableInner), System.Collections.Generic.IList<IPConfigurationInner> ipConfigurations = default(System.Collections.Generic.IList<IPConfigurationInner>), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            AddressPrefix = addressPrefix;
            NetworkSecurityGroup = new SubResource
            {
                Id = networkSecurityGroup.Id
            };
            RouteTable = new SubResource
            {
                Id = routeTable.Id
            };
            IpConfigurations = ipConfigurations;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets Address prefix for the subnet.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the reference of the NetworkSecurityGroup resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.networkSecurityGroup")]
        public SubResource NetworkSecurityGroup { get; set; }

        /// <summary>
        /// Gets or sets the reference of the RouteTable resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.routeTable")]
        public SubResource RouteTable { get; set; }

        /// <summary>
        /// Gets array of references to the network interface IP
        /// configurations using subnet
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.ipConfigurations")]
        public System.Collections.Generic.IList<IPConfigurationInner> IpConfigurations { get; private set; }

        /// <summary>
        /// Gets provisioning state of the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource
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
