// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The quota properties for the cluster. </summary>
    internal partial class QuotaInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QuotaInfo"/>. </summary>
        public QuotaInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuotaInfo"/>. </summary>
        /// <param name="coresUsed"> The cores used by the cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaInfo(int? coresUsed, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CoresUsed = coresUsed;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The cores used by the cluster. </summary>
        public int? CoresUsed { get; set; }
    }
}
