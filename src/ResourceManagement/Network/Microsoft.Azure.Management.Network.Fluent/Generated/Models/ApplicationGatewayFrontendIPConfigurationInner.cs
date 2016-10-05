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
    /// Frontend IP configuration of application gateway
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayFrontendIPConfigurationInner : Microsoft.Rest.Azure.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayFrontendIPConfigurationInner class.
        /// </summary>
        public ApplicationGatewayFrontendIPConfigurationInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayFrontendIPConfigurationInner class.
        /// </summary>
        /// <param name="privateIPAddress">PrivateIPAddress of the Network
        /// Interface IP Configuration</param>
        /// <param name="privateIPAllocationMethod">PrivateIP allocation
        /// method (Static/Dynamic). Possible values include: 'Static',
        /// 'Dynamic'</param>
        /// <param name="subnet">Reference of the subnet resource</param>
        /// <param name="publicIPAddress">Reference of the PublicIP
        /// resource</param>
        /// <param name="provisioningState">Provisioning state of the PublicIP
        /// resource Updating/Deleting/Failed</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public ApplicationGatewayFrontendIPConfigurationInner(string id = default(string), string privateIPAddress = default(string), string privateIPAllocationMethod = default(string), Microsoft.Rest.Azure.SubResource subnet = default(Microsoft.Rest.Azure.SubResource), Microsoft.Rest.Azure.SubResource publicIPAddress = default(Microsoft.Rest.Azure.SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets privateIPAddress of the Network Interface IP
        /// Configuration
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// Gets or sets privateIP allocation method (Static/Dynamic).
        /// Possible values include: 'Static', 'Dynamic'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets reference of the subnet resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.subnet")]
        public Microsoft.Rest.Azure.SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets reference of the PublicIP resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publicIPAddress")]
        public Microsoft.Rest.Azure.SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource
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
