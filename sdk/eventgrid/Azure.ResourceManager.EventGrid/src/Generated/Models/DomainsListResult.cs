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
    /// <summary> Result of the List Domains operation. </summary>
    internal partial class DomainsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DomainsListResult"/>. </summary>
        internal DomainsListResult()
        {
            Value = new ChangeTrackingList<EventGridDomainData>();
        }

        /// <summary> Initializes a new instance of <see cref="DomainsListResult"/>. </summary>
        /// <param name="value"> A collection of Domains. </param>
        /// <param name="nextLink"> A link for the next page of domains. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DomainsListResult(IReadOnlyList<EventGridDomainData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A collection of Domains. </summary>
        public IReadOnlyList<EventGridDomainData> Value { get; }
        /// <summary> A link for the next page of domains. </summary>
        public string NextLink { get; }
    }
}
