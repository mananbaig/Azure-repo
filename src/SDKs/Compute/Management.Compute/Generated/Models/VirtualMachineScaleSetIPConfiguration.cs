// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set network profile's IP
    /// configuration.
    /// </summary>
    [JsonTransformation]
    public partial class VirtualMachineScaleSetIPConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetIPConfiguration class.
        /// </summary>
        public VirtualMachineScaleSetIPConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetIPConfiguration class.
        /// </summary>
        /// <param name="name">The IP configuration name.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="subnet">The subnet.</param>
        /// <param name="primary">Specifies the primary IP Configuration in
        /// case the network interface has more than one IP
        /// Configuration.</param>
        /// <param name="publicIPAddressConfiguration">The
        /// publicIPAddressConfiguration.</param>
        /// <param name="privateIPAddressVersion">Available from Api-Version
        /// 2017-03-30 onwards, it represents whether the specific
        /// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.
        /// Possible values are: 'IPv4' and 'IPv6'. Possible values include:
        /// 'IPv4', 'IPv6'</param>
        /// <param name="applicationGatewayBackendAddressPools">The application
        /// gateway backend address pools.</param>
        /// <param name="loadBalancerBackendAddressPools">The load balancer
        /// backend address pools.</param>
        /// <param name="loadBalancerInboundNatPools">The load balancer inbound
        /// nat pools.</param>
        public VirtualMachineScaleSetIPConfiguration(string name, string id = default(string), ApiEntityReference subnet = default(ApiEntityReference), bool? primary = default(bool?), VirtualMachineScaleSetPublicIPAddressConfiguration publicIPAddressConfiguration = default(VirtualMachineScaleSetPublicIPAddressConfiguration), string privateIPAddressVersion = default(string), IList<SubResource> applicationGatewayBackendAddressPools = default(IList<SubResource>), IList<SubResource> loadBalancerBackendAddressPools = default(IList<SubResource>), IList<SubResource> loadBalancerInboundNatPools = default(IList<SubResource>))
            : base(id)
        {
            Name = name;
            Subnet = subnet;
            Primary = primary;
            PublicIPAddressConfiguration = publicIPAddressConfiguration;
            PrivateIPAddressVersion = privateIPAddressVersion;
            ApplicationGatewayBackendAddressPools = applicationGatewayBackendAddressPools;
            LoadBalancerBackendAddressPools = loadBalancerBackendAddressPools;
            LoadBalancerInboundNatPools = loadBalancerInboundNatPools;
        }

        /// <summary>
        /// Gets or sets the IP configuration name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public ApiEntityReference Subnet { get; set; }

        /// <summary>
        /// Gets or sets specifies the primary IP Configuration in case the
        /// network interface has more than one IP Configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primary")]
        public bool? Primary { get; set; }

        /// <summary>
        /// Gets or sets the publicIPAddressConfiguration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddressConfiguration")]
        public VirtualMachineScaleSetPublicIPAddressConfiguration PublicIPAddressConfiguration { get; set; }

        /// <summary>
        /// Gets or sets available from Api-Version 2017-03-30 onwards, it
        /// represents whether the specific ipconfiguration is IPv4 or IPv6.
        /// Default is taken as IPv4.  Possible values are: 'IPv4' and 'IPv6'.
        /// Possible values include: 'IPv4', 'IPv6'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddressVersion")]
        public string PrivateIPAddressVersion { get; set; }

        /// <summary>
        /// Gets or sets the application gateway backend address pools.
        /// </summary>
        [JsonProperty(PropertyName = "properties.applicationGatewayBackendAddressPools")]
        public IList<SubResource> ApplicationGatewayBackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets the load balancer backend address pools.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerBackendAddressPools")]
        public IList<SubResource> LoadBalancerBackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets the load balancer inbound nat pools.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerInboundNatPools")]
        public IList<SubResource> LoadBalancerInboundNatPools { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (PublicIPAddressConfiguration != null)
            {
                PublicIPAddressConfiguration.Validate();
            }
        }
    }
}

