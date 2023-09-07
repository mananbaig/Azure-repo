// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Usage for vault. </summary>
    internal partial class VaultUsageListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VaultUsageListResult"/>. </summary>
        internal VaultUsageListResult()
        {
            Value = new ChangeTrackingList<VaultUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="VaultUsageListResult"/>. </summary>
        /// <param name="value"> The list of usages for the given vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VaultUsageListResult(IReadOnlyList<VaultUsage> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of usages for the given vault. </summary>
        public IReadOnlyList<VaultUsage> Value { get; }
    }
}
