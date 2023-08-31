// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The ContainerRegistryKeyVaultProperties. </summary>
    public partial class ContainerRegistryKeyVaultProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryKeyVaultProperties"/>. </summary>
        public ContainerRegistryKeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryKeyVaultProperties"/>. </summary>
        /// <param name="keyIdentifier"> Key vault uri to access the encryption key. </param>
        /// <param name="versionedKeyIdentifier"> The fully qualified key identifier that includes the version of the key that is actually used for encryption. </param>
        /// <param name="identity"> The client id of the identity which will be used to access key vault. </param>
        /// <param name="isKeyRotationEnabled"> Auto key rotation status for a CMK enabled registry. </param>
        /// <param name="lastKeyRotationTimestamp"> Timestamp of the last successful key rotation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryKeyVaultProperties(string keyIdentifier, string versionedKeyIdentifier, string identity, bool? isKeyRotationEnabled, DateTimeOffset? lastKeyRotationTimestamp, Dictionary<string, BinaryData> rawData)
        {
            KeyIdentifier = keyIdentifier;
            VersionedKeyIdentifier = versionedKeyIdentifier;
            Identity = identity;
            IsKeyRotationEnabled = isKeyRotationEnabled;
            LastKeyRotationTimestamp = lastKeyRotationTimestamp;
            _rawData = rawData;
        }

        /// <summary> Key vault uri to access the encryption key. </summary>
        public string KeyIdentifier { get; set; }
        /// <summary> The fully qualified key identifier that includes the version of the key that is actually used for encryption. </summary>
        public string VersionedKeyIdentifier { get; }
        /// <summary> The client id of the identity which will be used to access key vault. </summary>
        public string Identity { get; set; }
        /// <summary> Auto key rotation status for a CMK enabled registry. </summary>
        public bool? IsKeyRotationEnabled { get; }
        /// <summary> Timestamp of the last successful key rotation. </summary>
        public DateTimeOffset? LastKeyRotationTimestamp { get; }
    }
}
