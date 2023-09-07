// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Response of getting suggestions for search for time series instances. </summary>
    internal partial class InstancesSuggestResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InstancesSuggestResponse"/>. </summary>
        internal InstancesSuggestResponse()
        {
            Suggestions = new ChangeTrackingList<InstancesSearchStringSuggestion>();
        }

        /// <summary> Initializes a new instance of <see cref="InstancesSuggestResponse"/>. </summary>
        /// <param name="suggestions"> List of instance suggestions for searching time series models. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InstancesSuggestResponse(IReadOnlyList<InstancesSearchStringSuggestion> suggestions, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Suggestions = suggestions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of instance suggestions for searching time series models. </summary>
        public IReadOnlyList<InstancesSearchStringSuggestion> Suggestions { get; }
    }
}
