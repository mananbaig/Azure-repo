// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Public land mobile network (PLMN) ID. </summary>
    public partial class MobileNetworkPlmnId
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkPlmnId"/>. </summary>
        /// <param name="mcc"> Mobile country code (MCC). </param>
        /// <param name="mnc"> Mobile network code (MNC). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mcc"/> or <paramref name="mnc"/> is null. </exception>
        public MobileNetworkPlmnId(string mcc, string mnc)
        {
            Argument.AssertNotNull(mcc, nameof(mcc));
            Argument.AssertNotNull(mnc, nameof(mnc));

            Mcc = mcc;
            Mnc = mnc;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkPlmnId"/>. </summary>
        /// <param name="mcc"> Mobile country code (MCC). </param>
        /// <param name="mnc"> Mobile network code (MNC). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkPlmnId(string mcc, string mnc, Dictionary<string, BinaryData> rawData)
        {
            Mcc = mcc;
            Mnc = mnc;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkPlmnId"/> for deserialization. </summary>
        internal MobileNetworkPlmnId()
        {
        }

        /// <summary> Mobile country code (MCC). </summary>
        public string Mcc { get; set; }
        /// <summary> Mobile network code (MNC). </summary>
        public string Mnc { get; set; }
    }
}
