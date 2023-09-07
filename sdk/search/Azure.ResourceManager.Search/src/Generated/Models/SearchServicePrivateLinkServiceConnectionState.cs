// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes the current state of an existing Private Link Service connection to the Azure Private Endpoint. </summary>
    public partial class SearchServicePrivateLinkServiceConnectionState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SearchServicePrivateLinkServiceConnectionState"/>. </summary>
        public SearchServicePrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchServicePrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> Status of the the private link service connection. Can be Pending, Approved, Rejected, or Disconnected. </param>
        /// <param name="description"> The description for the private link service connection state. </param>
        /// <param name="actionsRequired"> A description of any extra actions that may be required. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchServicePrivateLinkServiceConnectionState(SearchServicePrivateLinkServiceConnectionStatus? status, string description, string actionsRequired, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Status of the the private link service connection. Can be Pending, Approved, Rejected, or Disconnected. </summary>
        public SearchServicePrivateLinkServiceConnectionStatus? Status { get; set; }
        /// <summary> The description for the private link service connection state. </summary>
        public string Description { get; set; }
        /// <summary> A description of any extra actions that may be required. </summary>
        public string ActionsRequired { get; set; }
    }
}
