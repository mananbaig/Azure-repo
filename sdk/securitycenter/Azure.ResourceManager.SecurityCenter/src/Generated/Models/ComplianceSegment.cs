// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> A segment of a compliance assessment. </summary>
    public partial class ComplianceSegment
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComplianceSegment"/>. </summary>
        internal ComplianceSegment()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComplianceSegment"/>. </summary>
        /// <param name="segmentType"> The segment type, e.g. compliant, non-compliance, insufficient coverage, N/A, etc. </param>
        /// <param name="percentage"> The size (%) of the segment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComplianceSegment(string segmentType, double? percentage, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SegmentType = segmentType;
            Percentage = percentage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The segment type, e.g. compliant, non-compliance, insufficient coverage, N/A, etc. </summary>
        public string SegmentType { get; }
        /// <summary> The size (%) of the segment. </summary>
        public double? Percentage { get; }
    }
}
