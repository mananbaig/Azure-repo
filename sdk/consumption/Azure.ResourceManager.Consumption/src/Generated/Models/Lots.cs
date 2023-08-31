// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Result of listing lot summary. </summary>
    internal partial class Lots
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="Lots"/>. </summary>
        internal Lots()
        {
            Value = new ChangeTrackingList<ConsumptionLotSummary>();
        }

        /// <summary> Initializes a new instance of <see cref="Lots"/>. </summary>
        /// <param name="value"> The list of lot summary. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal Lots(IReadOnlyList<ConsumptionLotSummary> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of lot summary. </summary>
        public IReadOnlyList<ConsumptionLotSummary> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
