// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> Parameters describes the request to regenerate access keys. </summary>
    public partial class RegenerateCommunicationServiceKeyContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RegenerateCommunicationServiceKeyContent"/>. </summary>
        public RegenerateCommunicationServiceKeyContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RegenerateCommunicationServiceKeyContent"/>. </summary>
        /// <param name="keyType"> The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RegenerateCommunicationServiceKeyContent(CommunicationServiceKeyType? keyType, Dictionary<string, BinaryData> rawData)
        {
            KeyType = keyType;
            _rawData = rawData;
        }

        /// <summary> The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive). </summary>
        public CommunicationServiceKeyType? KeyType { get; set; }
    }
}
