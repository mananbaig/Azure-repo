// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> The QuotaOperationDisplay. </summary>
    public partial class QuotaOperationDisplay
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QuotaOperationDisplay"/>. </summary>
        internal QuotaOperationDisplay()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuotaOperationDisplay"/>. </summary>
        /// <param name="provider"> Provider name. </param>
        /// <param name="resource"> Resource name. </param>
        /// <param name="operation"> Operation name. </param>
        /// <param name="description"> Operation description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaOperationDisplay(string provider, string resource, string operation, string description, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provider name. </summary>
        public string Provider { get; }
        /// <summary> Resource name. </summary>
        public string Resource { get; }
        /// <summary> Operation name. </summary>
        public string Operation { get; }
        /// <summary> Operation description. </summary>
        public string Description { get; }
    }
}
