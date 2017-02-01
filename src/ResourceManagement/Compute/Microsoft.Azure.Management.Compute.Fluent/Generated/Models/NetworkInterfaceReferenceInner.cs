// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Azure;
    using Management;
    using Compute;
    using Fluent;
    using Rest;
    using Rest.Azure;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a network interface reference.
    /// </summary>
    [JsonTransformation]
    public partial class NetworkInterfaceReferenceInner : Microsoft.Azure.Management.Resource.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceReferenceInner
        /// class.
        /// </summary>
        public NetworkInterfaceReferenceInner() { }

        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceReferenceInner
        /// class.
        /// </summary>
        /// <param name="primary">Specifies the primary network interface in
        /// case the virtual machine has more than 1 network interface.</param>
        public NetworkInterfaceReferenceInner(string id = default(string), bool? primary = default(bool?))
            : base(id)
        {
            Primary = primary;
        }

        /// <summary>
        /// Gets or sets specifies the primary network interface in case the
        /// virtual machine has more than 1 network interface.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primary")]
        public bool? Primary { get; set; }

    }
}

