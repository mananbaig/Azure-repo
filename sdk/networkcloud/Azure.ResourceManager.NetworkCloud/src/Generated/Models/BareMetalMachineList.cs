// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineList represents a list of bare metal machines. </summary>
    internal partial class BareMetalMachineList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineList"/>. </summary>
        internal BareMetalMachineList()
        {
            Value = new ChangeTrackingList<NetworkCloudBareMetalMachineData>();
        }

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of bare metal machines. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BareMetalMachineList(string nextLink, IReadOnlyList<NetworkCloudBareMetalMachineData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of bare metal machines. </summary>
        public IReadOnlyList<NetworkCloudBareMetalMachineData> Value { get; }
    }
}
