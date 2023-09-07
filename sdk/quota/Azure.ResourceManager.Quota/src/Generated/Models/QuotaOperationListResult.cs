// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> The QuotaOperationListResult. </summary>
    internal partial class QuotaOperationListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QuotaOperationListResult"/>. </summary>
        internal QuotaOperationListResult()
        {
            Value = new ChangeTrackingList<QuotaOperationResult>();
        }

        /// <summary> Initializes a new instance of <see cref="QuotaOperationListResult"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next page of items. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaOperationListResult(IReadOnlyList<QuotaOperationResult> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<QuotaOperationResult> Value { get; }
        /// <summary> URL to get the next page of items. </summary>
        public string NextLink { get; }
    }
}
