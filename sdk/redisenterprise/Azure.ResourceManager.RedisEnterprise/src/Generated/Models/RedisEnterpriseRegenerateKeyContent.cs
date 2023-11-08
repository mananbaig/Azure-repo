// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Specifies which access keys to reset to a new random value. </summary>
    public partial class RedisEnterpriseRegenerateKeyContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseRegenerateKeyContent"/>. </summary>
        /// <param name="keyType"> Which access key to regenerate. </param>
        public RedisEnterpriseRegenerateKeyContent(RedisEnterpriseAccessKeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseRegenerateKeyContent"/>. </summary>
        /// <param name="keyType"> Which access key to regenerate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisEnterpriseRegenerateKeyContent(RedisEnterpriseAccessKeyType keyType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyType = keyType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseRegenerateKeyContent"/> for deserialization. </summary>
        internal RedisEnterpriseRegenerateKeyContent()
        {
        }

        /// <summary> Which access key to regenerate. </summary>
        public RedisEnterpriseAccessKeyType KeyType { get; }
    }
}
