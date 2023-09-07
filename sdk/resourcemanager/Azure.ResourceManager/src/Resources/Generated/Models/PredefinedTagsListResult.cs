// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of subscription tags. </summary>
    internal partial class PredefinedTagsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PredefinedTagsListResult"/>. </summary>
        internal PredefinedTagsListResult()
        {
            Value = new ChangeTrackingList<PredefinedTag>();
        }

        /// <summary> Initializes a new instance of <see cref="PredefinedTagsListResult"/>. </summary>
        /// <param name="value"> An array of tags. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PredefinedTagsListResult(IReadOnlyList<PredefinedTag> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An array of tags. </summary>
        public IReadOnlyList<PredefinedTag> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
