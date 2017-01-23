// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Describes an available virtual machine scale set sku.
    /// </summary>
    public partial class VirtualMachineScaleSetSku
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetSku class.
        /// </summary>
        public VirtualMachineScaleSetSku() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetSku class.
        /// </summary>
        /// <param name="resourceType">The type of resource the sku applies
        /// to.</param>
        /// <param name="sku">The Sku.</param>
        /// <param name="capacity">Available scaling information.</param>
        public VirtualMachineScaleSetSku(string resourceType = default(string), Sku sku = default(Sku), VirtualMachineScaleSetSkuCapacity capacity = default(VirtualMachineScaleSetSkuCapacity))
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
        }

        /// <summary>
        /// Gets the type of resource the sku applies to.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Gets the Sku.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; private set; }

        /// <summary>
        /// Gets available scaling information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capacity")]
        public VirtualMachineScaleSetSkuCapacity Capacity { get; private set; }

    }
}
