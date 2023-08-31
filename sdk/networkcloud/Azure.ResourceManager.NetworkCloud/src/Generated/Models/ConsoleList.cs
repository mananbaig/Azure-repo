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
    /// <summary> ConsoleList represents a list of virtual machine consoles. </summary>
    internal partial class ConsoleList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConsoleList"/>. </summary>
        internal ConsoleList()
        {
            Value = new ChangeTrackingList<NetworkCloudVirtualMachineConsoleData>();
        }

        /// <summary> Initializes a new instance of <see cref="ConsoleList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of virtual machine consoles. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConsoleList(string nextLink, IReadOnlyList<NetworkCloudVirtualMachineConsoleData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of virtual machine consoles. </summary>
        public IReadOnlyList<NetworkCloudVirtualMachineConsoleData> Value { get; }
    }
}
