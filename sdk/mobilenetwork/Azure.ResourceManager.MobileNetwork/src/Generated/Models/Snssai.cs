// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Single-network slice selection assistance information (S-NSSAI). </summary>
    public partial class Snssai
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Snssai"/>. </summary>
        /// <param name="sst"> Slice/service type (SST). </param>
        public Snssai(int sst)
        {
            Sst = sst;
        }

        /// <summary> Initializes a new instance of <see cref="Snssai"/>. </summary>
        /// <param name="sst"> Slice/service type (SST). </param>
        /// <param name="sd"> Slice differentiator (SD). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Snssai(int sst, string sd, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sst = sst;
            Sd = sd;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Snssai"/> for deserialization. </summary>
        internal Snssai()
        {
        }

        /// <summary> Slice/service type (SST). </summary>
        public int Sst { get; set; }
        /// <summary> Slice differentiator (SD). </summary>
        public string Sd { get; set; }
    }
}
