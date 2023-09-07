// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> An object representing the appearance of the text line. </summary>
    public partial class TextAppearance
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TextAppearance"/>. </summary>
        /// <param name="style"> An object representing the style of the text line. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="style"/> is null. </exception>
        internal TextAppearance(Style style)
        {
            Argument.AssertNotNull(style, nameof(style));

            Style = style;
        }

        /// <summary> Initializes a new instance of <see cref="TextAppearance"/>. </summary>
        /// <param name="style"> An object representing the style of the text line. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TextAppearance(Style style, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Style = style;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TextAppearance"/> for deserialization. </summary>
        internal TextAppearance()
        {
        }
    }
}
