// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class for NoEncryption scheme. </summary>
    internal partial class NoEncryption
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NoEncryption"/>. </summary>
        public NoEncryption()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NoEncryption"/>. </summary>
        /// <param name="enabledProtocols"> Representing supported protocols. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NoEncryption(MediaEnabledProtocols enabledProtocols, Dictionary<string, BinaryData> rawData)
        {
            EnabledProtocols = enabledProtocols;
            _rawData = rawData;
        }

        /// <summary> Representing supported protocols. </summary>
        public MediaEnabledProtocols EnabledProtocols { get; set; }
    }
}
