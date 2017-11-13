// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The required set of inputs to validate a VNET
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VnetParameters : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the VnetParameters class.
        /// </summary>
        public VnetParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VnetParameters class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="vnetResourceGroup">The Resource Group of the VNET to
        /// be validated</param>
        /// <param name="vnetName">The name of the VNET to be validated</param>
        /// <param name="vnetSubnetName">The subnet name to be
        /// validated</param>
        public VnetParameters(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string vnetResourceGroup = default(string), string vnetName = default(string), string vnetSubnetName = default(string))
            : base(id, name, kind, type)
        {
            VnetResourceGroup = vnetResourceGroup;
            VnetName = vnetName;
            VnetSubnetName = vnetSubnetName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Resource Group of the VNET to be validated
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetResourceGroup")]
        public string VnetResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets the name of the VNET to be validated
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// Gets or sets the subnet name to be validated
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetSubnetName")]
        public string VnetSubnetName { get; set; }

    }
}
