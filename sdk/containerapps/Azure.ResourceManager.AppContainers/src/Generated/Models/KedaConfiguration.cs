// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Configuration properties Keda component. </summary>
    internal partial class KedaConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KedaConfiguration"/>. </summary>
        public KedaConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KedaConfiguration"/>. </summary>
        /// <param name="version"> The version of Keda. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KedaConfiguration(string version, Dictionary<string, BinaryData> rawData)
        {
            Version = version;
            _rawData = rawData;
        }

        /// <summary> The version of Keda. </summary>
        public string Version { get; }
    }
}
