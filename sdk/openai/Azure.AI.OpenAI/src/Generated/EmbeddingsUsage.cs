// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> Measurement of the amount of tokens used in this request and response. </summary>
    public partial class EmbeddingsUsage
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of EmbeddingsUsage. </summary>
        /// <param name="promptTokens"> Number of tokens sent in the original request. </param>
        /// <param name="totalTokens"> Total number of tokens transacted in this request/response. </param>
        internal EmbeddingsUsage(int promptTokens, int totalTokens)
        {
            PromptTokens = promptTokens;
            TotalTokens = totalTokens;
        }

        /// <summary> Initializes a new instance of EmbeddingsUsage. </summary>
        /// <param name="promptTokens"> Number of tokens sent in the original request. </param>
        /// <param name="totalTokens"> Total number of tokens transacted in this request/response. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EmbeddingsUsage(int promptTokens, int totalTokens, Dictionary<string, BinaryData> rawData)
        {
            PromptTokens = promptTokens;
            TotalTokens = totalTokens;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EmbeddingsUsage"/> for deserialization. </summary>
        internal EmbeddingsUsage()
        {
        }

        /// <summary> Number of tokens sent in the original request. </summary>
        public int PromptTokens { get; }
        /// <summary> Total number of tokens transacted in this request/response. </summary>
        public int TotalTokens { get; }
    }
}
