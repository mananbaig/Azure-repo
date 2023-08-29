// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A list of recommendation actions. </summary>
    internal partial class MySqlRecommendationActionListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MySqlRecommendationActionListResult"/>. </summary>
        internal MySqlRecommendationActionListResult()
        {
            Value = new ChangeTrackingList<MySqlRecommendationActionData>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlRecommendationActionListResult"/>. </summary>
        /// <param name="value"> The list of recommendation action advisors. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlRecommendationActionListResult(IReadOnlyList<MySqlRecommendationActionData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of recommendation action advisors. </summary>
        public IReadOnlyList<MySqlRecommendationActionData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
