// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.Translation.Document;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary> Translation job submission batch request. </summary>
    internal partial class StartTranslationDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StartTranslationDetails"/>. </summary>
        /// <param name="inputs"> The input list of documents or folders containing documents. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> is null. </exception>
        public StartTranslationDetails(IEnumerable<DocumentTranslationInput> inputs)
        {
            Argument.AssertNotNull(inputs, nameof(inputs));

            Inputs = inputs.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="StartTranslationDetails"/>. </summary>
        /// <param name="inputs"> The input list of documents or folders containing documents. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StartTranslationDetails(IList<DocumentTranslationInput> inputs, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Inputs = inputs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StartTranslationDetails"/> for deserialization. </summary>
        internal StartTranslationDetails()
        {
        }

        /// <summary> The input list of documents or folders containing documents. </summary>
        public IList<DocumentTranslationInput> Inputs { get; }
    }
}
