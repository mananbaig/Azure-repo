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
    /// <summary> A list of wait statistics. </summary>
    internal partial class MySqlWaitStatisticsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlWaitStatisticsListResult"/>. </summary>
        internal MySqlWaitStatisticsListResult()
        {
            Value = new ChangeTrackingList<MySqlWaitStatisticData>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlWaitStatisticsListResult"/>. </summary>
        /// <param name="value"> The list of wait statistics. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlWaitStatisticsListResult(IReadOnlyList<MySqlWaitStatisticData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of wait statistics. </summary>
        public IReadOnlyList<MySqlWaitStatisticData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
