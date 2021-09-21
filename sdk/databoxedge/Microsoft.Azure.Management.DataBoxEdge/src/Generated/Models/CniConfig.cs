// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cni configuration
    /// </summary>
    public partial class CniConfig
    {
        /// <summary>
        /// Initializes a new instance of the CniConfig class.
        /// </summary>
        public CniConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CniConfig class.
        /// </summary>
        /// <param name="type">Cni type</param>
        /// <param name="version">Cni version</param>
        /// <param name="podSubnet">Pod Subnet</param>
        /// <param name="serviceSubnet">Service subnet</param>
        public CniConfig(string type = default(string), string version = default(string), string podSubnet = default(string), string serviceSubnet = default(string))
        {
            Type = type;
            Version = version;
            PodSubnet = podSubnet;
            ServiceSubnet = serviceSubnet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets cni type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets cni version
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets pod Subnet
        /// </summary>
        [JsonProperty(PropertyName = "podSubnet")]
        public string PodSubnet { get; private set; }

        /// <summary>
        /// Gets service subnet
        /// </summary>
        [JsonProperty(PropertyName = "serviceSubnet")]
        public string ServiceSubnet { get; private set; }

    }
}
