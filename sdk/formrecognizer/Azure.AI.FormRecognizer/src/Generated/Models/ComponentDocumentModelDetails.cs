// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> A component of a composed document model. </summary>
    internal partial class ComponentDocumentModelDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComponentDocumentModelDetails"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public ComponentDocumentModelDetails(string modelId)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));

            ModelId = modelId;
        }

        /// <summary> Initializes a new instance of <see cref="ComponentDocumentModelDetails"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentDocumentModelDetails(string modelId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ModelId = modelId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComponentDocumentModelDetails"/> for deserialization. </summary>
        internal ComponentDocumentModelDetails()
        {
        }

        /// <summary> Unique document model name. </summary>
        public string ModelId { get; }
    }
}
