// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> The name of the sku supported by Azure Cognitive Search. </summary>
    public partial class QuotaUsageResultName
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QuotaUsageResultName"/>. </summary>
        internal QuotaUsageResultName()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuotaUsageResultName"/>. </summary>
        /// <param name="value"> The sku name supported by Azure Cognitive Search. </param>
        /// <param name="localizedValue"> The localized string value for the sku supported by Azure Cognitive Search. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaUsageResultName(string value, string localizedValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            LocalizedValue = localizedValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The sku name supported by Azure Cognitive Search. </summary>
        public string Value { get; }
        /// <summary> The localized string value for the sku supported by Azure Cognitive Search. </summary>
        public string LocalizedValue { get; }
    }
}
