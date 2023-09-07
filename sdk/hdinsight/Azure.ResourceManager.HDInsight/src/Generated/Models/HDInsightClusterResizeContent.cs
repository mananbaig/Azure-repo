// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The Resize Cluster request parameters. </summary>
    public partial class HDInsightClusterResizeContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterResizeContent"/>. </summary>
        public HDInsightClusterResizeContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterResizeContent"/>. </summary>
        /// <param name="targetInstanceCount"> The target instance count for the operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterResizeContent(int? targetInstanceCount, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetInstanceCount = targetInstanceCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The target instance count for the operation. </summary>
        public int? TargetInstanceCount { get; set; }
    }
}
