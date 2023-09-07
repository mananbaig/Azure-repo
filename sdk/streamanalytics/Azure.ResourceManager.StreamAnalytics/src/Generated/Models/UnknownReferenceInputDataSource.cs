// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The UnknownReferenceInputDataSource. </summary>
    internal partial class UnknownReferenceInputDataSource : ReferenceInputDataSource
    {
        /// <summary> Initializes a new instance of <see cref="UnknownReferenceInputDataSource"/>. </summary>
        /// <param name="referenceInputDataSourceType"> Indicates the type of input data source containing reference data. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownReferenceInputDataSource(string referenceInputDataSourceType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(referenceInputDataSourceType, serializedAdditionalRawData)
        {
            ReferenceInputDataSourceType = referenceInputDataSourceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownReferenceInputDataSource"/> for deserialization. </summary>
        internal UnknownReferenceInputDataSource()
        {
        }
    }
}
