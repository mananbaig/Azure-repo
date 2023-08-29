// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.PowerBIDedicated;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> An array of auto scale v-core resources. </summary>
    internal partial class AutoScaleVCoreListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutoScaleVCoreListResult"/>. </summary>
        /// <param name="value"> An array of auto scale v-core resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AutoScaleVCoreListResult(IEnumerable<AutoScaleVCoreData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AutoScaleVCoreListResult"/>. </summary>
        /// <param name="value"> An array of auto scale v-core resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutoScaleVCoreListResult(IReadOnlyList<AutoScaleVCoreData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutoScaleVCoreListResult"/> for deserialization. </summary>
        internal AutoScaleVCoreListResult()
        {
        }

        /// <summary> An array of auto scale v-core resources. </summary>
        public IReadOnlyList<AutoScaleVCoreData> Value { get; }
    }
}
