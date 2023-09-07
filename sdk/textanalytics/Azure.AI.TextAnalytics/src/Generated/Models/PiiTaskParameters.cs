// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Supported parameters for a PII Entities Recognition task. </summary>
    internal partial class PiiTaskParameters : PreBuiltTaskParameters
    {
        /// <summary> Initializes a new instance of <see cref="PiiTaskParameters"/>. </summary>
        public PiiTaskParameters()
        {
            PiiCategories = new ChangeTrackingList<PiiEntityCategory>();
        }

        /// <summary> Initializes a new instance of <see cref="PiiTaskParameters"/>. </summary>
        /// <param name="loggingOptOut"></param>
        /// <param name="modelVersion"></param>
        /// <param name="domain"> The PII domain used for PII Entity Recognition. </param>
        /// <param name="piiCategories"> (Optional) describes the PII categories to return. </param>
        /// <param name="stringIndexType"> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PiiTaskParameters(bool? loggingOptOut, string modelVersion, PiiDomain? domain, IList<PiiEntityCategory> piiCategories, StringIndexType? stringIndexType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(loggingOptOut, modelVersion, serializedAdditionalRawData)
        {
            Domain = domain;
            PiiCategories = piiCategories;
            StringIndexType = stringIndexType;
        }

        /// <summary> The PII domain used for PII Entity Recognition. </summary>
        public PiiDomain? Domain { get; set; }
        /// <summary> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </summary>
        public StringIndexType? StringIndexType { get; set; }
    }
}
