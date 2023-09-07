// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SignalR;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Custom domains list. </summary>
    internal partial class SignalRCustomDomainListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SignalRCustomDomainListResult"/>. </summary>
        internal SignalRCustomDomainListResult()
        {
            Value = new ChangeTrackingList<SignalRCustomDomainData>();
        }

        /// <summary> Initializes a new instance of <see cref="SignalRCustomDomainListResult"/>. </summary>
        /// <param name="value"> List of custom domains that bind to this resource. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRCustomDomainListResult(IReadOnlyList<SignalRCustomDomainData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of custom domains that bind to this resource. </summary>
        public IReadOnlyList<SignalRCustomDomainData> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
