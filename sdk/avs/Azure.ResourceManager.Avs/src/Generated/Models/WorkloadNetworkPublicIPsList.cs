// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A list of NSX Public IP Blocks. </summary>
    internal partial class WorkloadNetworkPublicIPsList
    {
        /// <summary> Initializes a new instance of WorkloadNetworkPublicIPsList. </summary>
        internal WorkloadNetworkPublicIPsList()
        {
            Value = new ChangeTrackingList<WorkloadNetworkPublicIPData>();
        }

        /// <summary> Initializes a new instance of WorkloadNetworkPublicIPsList. </summary>
        /// <param name="value"> The items on the page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        internal WorkloadNetworkPublicIPsList(IReadOnlyList<WorkloadNetworkPublicIPData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on the page. </summary>
        public IReadOnlyList<WorkloadNetworkPublicIPData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
