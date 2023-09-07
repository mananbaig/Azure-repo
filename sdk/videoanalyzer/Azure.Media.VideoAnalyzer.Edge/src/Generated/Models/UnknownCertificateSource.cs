// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The UnknownCertificateSource. </summary>
    internal partial class UnknownCertificateSource : CertificateSource
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCertificateSource"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownCertificateSource(string type, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
            Type = type ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownCertificateSource"/> for deserialization. </summary>
        internal UnknownCertificateSource()
        {
        }
    }
}
