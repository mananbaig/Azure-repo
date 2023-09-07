// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Bounding polygon on a specific page of the input. </summary>
    public readonly partial struct BoundingRegion
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private readonly Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BoundingRegion"/>. </summary>
        /// <param name="pageNumber"> 1-based page number of page containing the bounding region. </param>
        /// <param name="polygon"> Bounding polygon on the page, or the entire page if not specified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BoundingRegion(int pageNumber, IReadOnlyList<float> polygon, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PageNumber = pageNumber;
            Polygon = polygon;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
