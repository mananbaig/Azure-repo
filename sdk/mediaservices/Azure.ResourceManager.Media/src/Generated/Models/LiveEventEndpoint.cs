// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The live event endpoint. </summary>
    public partial class LiveEventEndpoint
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LiveEventEndpoint"/>. </summary>
        public LiveEventEndpoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LiveEventEndpoint"/>. </summary>
        /// <param name="protocol"> The endpoint protocol. </param>
        /// <param name="uri"> The endpoint URL. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LiveEventEndpoint(string protocol, Uri uri, Dictionary<string, BinaryData> rawData)
        {
            Protocol = protocol;
            Uri = uri;
            _rawData = rawData;
        }

        /// <summary> The endpoint protocol. </summary>
        public string Protocol { get; set; }
        /// <summary> The endpoint URL. </summary>
        public Uri Uri { get; set; }
    }
}
