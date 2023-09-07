// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Sets the CORS rules. You can include up to five CorsRule elements in the request. </summary>
    internal partial class StorageCorsRules
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageCorsRules"/>. </summary>
        public StorageCorsRules()
        {
            CorsRules = new ChangeTrackingList<StorageCorsRule>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageCorsRules"/>. </summary>
        /// <param name="corsRules"> The List of CORS rules. You can include up to five CorsRule elements in the request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCorsRules(IList<StorageCorsRule> corsRules, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CorsRules = corsRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The List of CORS rules. You can include up to five CorsRule elements in the request. </summary>
        public IList<StorageCorsRule> CorsRules { get; }
    }
}
