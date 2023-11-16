// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The virtual network connection reset shared key. </summary>
    public partial class ConnectionResetSharedKey
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConnectionResetSharedKey"/>. </summary>
        /// <param name="keyLength"> The virtual network connection reset shared key length, should between 1 and 128. </param>
        public ConnectionResetSharedKey(int keyLength)
        {
            KeyLength = keyLength;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionResetSharedKey"/>. </summary>
        /// <param name="keyLength"> The virtual network connection reset shared key length, should between 1 and 128. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectionResetSharedKey(int keyLength, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyLength = keyLength;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionResetSharedKey"/> for deserialization. </summary>
        internal ConnectionResetSharedKey()
        {
        }

        /// <summary> The virtual network connection reset shared key length, should between 1 and 128. </summary>
        public int KeyLength { get; set; }
    }
}
