// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Virtual Machine operation response. </summary>
    internal partial class VirtualMachineScaleSetListWithLinkResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetListWithLinkResult"/>. </summary>
        /// <param name="value"> The list of virtual machine scale sets. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VirtualMachineScaleSetListWithLinkResult(IEnumerable<VirtualMachineScaleSetData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetListWithLinkResult"/>. </summary>
        /// <param name="value"> The list of virtual machine scale sets. </param>
        /// <param name="nextLink"> The uri to fetch the next page of Virtual Machine Scale Sets. Call ListNext() with this to fetch the next page of Virtual Machine Scale Sets. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetListWithLinkResult(IReadOnlyList<VirtualMachineScaleSetData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetListWithLinkResult"/> for deserialization. </summary>
        internal VirtualMachineScaleSetListWithLinkResult()
        {
        }

        /// <summary> The list of virtual machine scale sets. </summary>
        public IReadOnlyList<VirtualMachineScaleSetData> Value { get; }
        /// <summary> The uri to fetch the next page of Virtual Machine Scale Sets. Call ListNext() with this to fetch the next page of Virtual Machine Scale Sets. </summary>
        public string NextLink { get; }
    }
}
