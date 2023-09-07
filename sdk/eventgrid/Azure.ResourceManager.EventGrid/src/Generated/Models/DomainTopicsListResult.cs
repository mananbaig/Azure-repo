// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List Domain Topics operation. </summary>
    internal partial class DomainTopicsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DomainTopicsListResult"/>. </summary>
        internal DomainTopicsListResult()
        {
            Value = new ChangeTrackingList<DomainTopicData>();
        }

        /// <summary> Initializes a new instance of <see cref="DomainTopicsListResult"/>. </summary>
        /// <param name="value"> A collection of Domain Topics. </param>
        /// <param name="nextLink"> A link for the next page of domain topics. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DomainTopicsListResult(IReadOnlyList<DomainTopicData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A collection of Domain Topics. </summary>
        public IReadOnlyList<DomainTopicData> Value { get; }
        /// <summary> A link for the next page of domain topics. </summary>
        public string NextLink { get; }
    }
}
