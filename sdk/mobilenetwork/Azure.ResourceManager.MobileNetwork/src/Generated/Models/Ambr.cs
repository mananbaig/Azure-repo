// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Aggregate maximum bit rate. </summary>
    public partial class Ambr
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="Ambr"/>. </summary>
        /// <param name="uplink"> Uplink bit rate. </param>
        /// <param name="downlink"> Downlink bit rate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uplink"/> or <paramref name="downlink"/> is null. </exception>
        public Ambr(string uplink, string downlink)
        {
            Argument.AssertNotNull(uplink, nameof(uplink));
            Argument.AssertNotNull(downlink, nameof(downlink));

            Uplink = uplink;
            Downlink = downlink;
        }

        /// <summary> Initializes a new instance of <see cref="Ambr"/>. </summary>
        /// <param name="uplink"> Uplink bit rate. </param>
        /// <param name="downlink"> Downlink bit rate. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal Ambr(string uplink, string downlink, Dictionary<string, BinaryData> rawData)
        {
            Uplink = uplink;
            Downlink = downlink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="Ambr"/> for deserialization. </summary>
        internal Ambr()
        {
        }

        /// <summary> Uplink bit rate. </summary>
        public string Uplink { get; set; }
        /// <summary> Downlink bit rate. </summary>
        public string Downlink { get; set; }
    }
}
