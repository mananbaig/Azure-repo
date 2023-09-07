// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FluidRelay.Models
{
    /// <summary> The updatable properties of a Fluid Relay server. </summary>
    public partial class FluidRelayServerPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FluidRelayServerPatch"/>. </summary>
        public FluidRelayServerPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="FluidRelayServerPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> The type of identity used for the resource. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="encryption"> All encryption configuration for a resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FluidRelayServerPatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, AzureLocation? location, EncryptionProperties encryption, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Identity = identity;
            Location = location;
            Encryption = encryption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The type of identity used for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> All encryption configuration for a resource. </summary>
        internal EncryptionProperties Encryption { get; set; }
        /// <summary> All Customer-managed key encryption properties for the resource. </summary>
        public CmkEncryptionProperties CustomerManagedKeyEncryption
        {
            get => Encryption is null ? default : Encryption.CustomerManagedKeyEncryption;
            set
            {
                if (Encryption is null)
                    Encryption = new EncryptionProperties();
                Encryption.CustomerManagedKeyEncryption = value;
            }
        }
    }
}
