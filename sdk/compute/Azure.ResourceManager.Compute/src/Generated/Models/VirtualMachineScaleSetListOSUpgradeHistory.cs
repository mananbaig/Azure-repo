// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> List of Virtual Machine Scale Set OS Upgrade History operation response. </summary>
    internal partial class VirtualMachineScaleSetListOSUpgradeHistory
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetListOSUpgradeHistory"/>. </summary>
        /// <param name="value"> The list of OS upgrades performed on the virtual machine scale set. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VirtualMachineScaleSetListOSUpgradeHistory(IEnumerable<UpgradeOperationHistoricalStatusInfo> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetListOSUpgradeHistory"/>. </summary>
        /// <param name="value"> The list of OS upgrades performed on the virtual machine scale set. </param>
        /// <param name="nextLink"> The uri to fetch the next page of OS Upgrade History. Call ListNext() with this to fetch the next page of history of upgrades. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetListOSUpgradeHistory(IReadOnlyList<UpgradeOperationHistoricalStatusInfo> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetListOSUpgradeHistory"/> for deserialization. </summary>
        internal VirtualMachineScaleSetListOSUpgradeHistory()
        {
        }

        /// <summary> The list of OS upgrades performed on the virtual machine scale set. </summary>
        public IReadOnlyList<UpgradeOperationHistoricalStatusInfo> Value { get; }
        /// <summary> The uri to fetch the next page of OS Upgrade History. Call ListNext() with this to fetch the next page of history of upgrades. </summary>
        public string NextLink { get; }
    }
}
