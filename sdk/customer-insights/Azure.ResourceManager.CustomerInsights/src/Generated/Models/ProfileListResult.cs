// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list profile operation. </summary>
    internal partial class ProfileListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProfileListResult"/>. </summary>
        internal ProfileListResult()
        {
            Value = new ChangeTrackingList<ProfileResourceFormatData>();
        }

        /// <summary> Initializes a new instance of <see cref="ProfileListResult"/>. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProfileListResult(IReadOnlyList<ProfileResourceFormatData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<ProfileResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
