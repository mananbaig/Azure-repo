// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The key authorization type integration runtime. </summary>
    public partial class SynapseLinkedIntegrationRuntimeKeyAuthorization : SynapseLinkedIntegrationRuntimeType
    {
        /// <summary> Initializes a new instance of <see cref="SynapseLinkedIntegrationRuntimeKeyAuthorization"/>. </summary>
        /// <param name="key"> The key used for authorization. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public SynapseLinkedIntegrationRuntimeKeyAuthorization(SynapseSecureString key)
        {
            Argument.AssertNotNull(key, nameof(key));

            Key = key;
            AuthorizationType = "Key";
        }

        /// <summary> Initializes a new instance of <see cref="SynapseLinkedIntegrationRuntimeKeyAuthorization"/>. </summary>
        /// <param name="authorizationType"> The authorization type for integration runtime sharing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="key"> The key used for authorization. </param>
        internal SynapseLinkedIntegrationRuntimeKeyAuthorization(string authorizationType, IDictionary<string, BinaryData> serializedAdditionalRawData, SynapseSecureString key) : base(authorizationType, serializedAdditionalRawData)
        {
            Key = key;
            AuthorizationType = authorizationType ?? "Key";
        }

        /// <summary> Initializes a new instance of <see cref="SynapseLinkedIntegrationRuntimeKeyAuthorization"/> for deserialization. </summary>
        internal SynapseLinkedIntegrationRuntimeKeyAuthorization()
        {
        }

        /// <summary> The key used for authorization. </summary>
        public SynapseSecureString Key { get; set; }
    }
}
