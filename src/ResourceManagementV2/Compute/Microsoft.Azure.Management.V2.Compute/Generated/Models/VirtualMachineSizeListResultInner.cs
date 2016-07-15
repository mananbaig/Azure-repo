// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The List Virtual Machine operation response.
    /// </summary>
    public partial class VirtualMachineSizeListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineSizeListResultInner class.
        /// </summary>
        public VirtualMachineSizeListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineSizeListResultInner class.
        /// </summary>
        /// <param name="value">the list of virtual machine sizes.</param>
        public VirtualMachineSizeListResultInner(IList<VirtualMachineSize> value = default(IList<VirtualMachineSize>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the list of virtual machine sizes.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<VirtualMachineSize> Value { get; set; }

    }
}
