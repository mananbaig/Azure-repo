// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The response from the List Fleets operation. </summary>
    internal partial class FleetListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FleetListResult"/>. </summary>
        internal FleetListResult()
        {
            Value = new ChangeTrackingList<ContainerServiceFleetData>();
        }

        /// <summary> Initializes a new instance of <see cref="FleetListResult"/>. </summary>
        /// <param name="value"> The list of Fleets. </param>
        /// <param name="nextLink"> The URL to get the next page of Fleets. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FleetListResult(IReadOnlyList<ContainerServiceFleetData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of Fleets. </summary>
        public IReadOnlyList<ContainerServiceFleetData> Value { get; }
        /// <summary> The URL to get the next page of Fleets. </summary>
        public string NextLink { get; }
    }
}
