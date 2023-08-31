// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.MediaComposition.Models;

namespace Azure.Communication.MediaComposition
{
    /// <summary> The UnknownMediaInput. </summary>
    internal partial class UnknownMediaInput : MediaInput
    {
        /// <summary> Initializes a new instance of <see cref="UnknownMediaInput"/>. </summary>
        /// <param name="kind"> Kind of media input. </param>
        /// <param name="placeholderImageUri"> Image url to be used if participant has no video stream. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownMediaInput(MediaInputType kind, string placeholderImageUri, Dictionary<string, BinaryData> rawData) : base(kind, placeholderImageUri, rawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownMediaInput"/> for deserialization. </summary>
        internal UnknownMediaInput()
        {
        }
    }
}
