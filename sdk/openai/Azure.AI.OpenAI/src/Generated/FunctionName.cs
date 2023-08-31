// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// A structure that specifies the exact name of a specific, request-provided function to use when processing a chat
    /// completions operation.
    /// </summary>
    internal partial class FunctionName
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of FunctionName. </summary>
        /// <param name="name"> The name of the function to call. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public FunctionName(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of FunctionName. </summary>
        /// <param name="name"> The name of the function to call. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FunctionName(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="FunctionName"/> for deserialization. </summary>
        internal FunctionName()
        {
        }

        /// <summary> The name of the function to call. </summary>
        public string Name { get; }
    }
}
