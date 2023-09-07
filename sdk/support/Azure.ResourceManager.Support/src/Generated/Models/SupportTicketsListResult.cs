// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Support;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Object that represents a collection of SupportTicket resources. </summary>
    internal partial class SupportTicketsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SupportTicketsListResult"/>. </summary>
        internal SupportTicketsListResult()
        {
            Value = new ChangeTrackingList<SupportTicketData>();
        }

        /// <summary> Initializes a new instance of <see cref="SupportTicketsListResult"/>. </summary>
        /// <param name="value"> List of SupportTicket resources. </param>
        /// <param name="nextLink"> The URI to fetch the next page of SupportTicket resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SupportTicketsListResult(IReadOnlyList<SupportTicketData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of SupportTicket resources. </summary>
        public IReadOnlyList<SupportTicketData> Value { get; }
        /// <summary> The URI to fetch the next page of SupportTicket resources. </summary>
        public string NextLink { get; }
    }
}
