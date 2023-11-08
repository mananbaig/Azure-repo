// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Parameters describes the request to regenerate access keys. </summary>
    public partial class SignalRRegenerateKeyContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SignalRRegenerateKeyContent"/>. </summary>
        public SignalRRegenerateKeyContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignalRRegenerateKeyContent"/>. </summary>
        /// <param name="keyType"> The type of access key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRRegenerateKeyContent(SignalRKeyType? keyType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyType = keyType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of access key. </summary>
        public SignalRKeyType? KeyType { get; set; }
    }
}
