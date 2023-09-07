// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary> Transliterated text element. </summary>
    public partial class TransliteratedText
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of TransliteratedText. </summary>
        /// <param name="text"> A string which is the result of converting the input string to the output script. </param>
        /// <param name="script"> A string specifying the script used in the output. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="script"/> is null. </exception>
        internal TransliteratedText(string text, string script)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(script, nameof(script));

            Text = text;
            Script = script;
        }

        /// <summary> Initializes a new instance of TransliteratedText. </summary>
        /// <param name="text"> A string which is the result of converting the input string to the output script. </param>
        /// <param name="script"> A string specifying the script used in the output. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TransliteratedText(string text, string script, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Script = script;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TransliteratedText"/> for deserialization. </summary>
        internal TransliteratedText()
        {
        }

        /// <summary> A string which is the result of converting the input string to the output script. </summary>
        public string Text { get; }
        /// <summary> A string specifying the script used in the output. </summary>
        public string Script { get; }
    }
}
