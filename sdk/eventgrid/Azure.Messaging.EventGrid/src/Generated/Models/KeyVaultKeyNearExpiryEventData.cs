// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.KeyVault.KeyNearExpiry event. </summary>
    public partial class KeyVaultKeyNearExpiryEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultKeyNearExpiryEventData"/>. </summary>
        internal KeyVaultKeyNearExpiryEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultKeyNearExpiryEventData"/>. </summary>
        /// <param name="id"> The id of the object that triggered this event. </param>
        /// <param name="vaultName"> Key vault name of the object that triggered this event. </param>
        /// <param name="objectType"> The type of the object that triggered this event. </param>
        /// <param name="objectName"> The name of the object that triggered this event. </param>
        /// <param name="version"> The version of the object that triggered this event. </param>
        /// <param name="nbf"> Not before date of the object that triggered this event. </param>
        /// <param name="exp"> The expiration date of the object that triggered this event. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultKeyNearExpiryEventData(string id, string vaultName, string objectType, string objectName, string version, float? nbf, float? exp, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            VaultName = vaultName;
            ObjectType = objectType;
            ObjectName = objectName;
            Version = version;
            Nbf = nbf;
            Exp = exp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The id of the object that triggered this event. </summary>
        public string Id { get; }
        /// <summary> Key vault name of the object that triggered this event. </summary>
        public string VaultName { get; }
        /// <summary> The type of the object that triggered this event. </summary>
        public string ObjectType { get; }
        /// <summary> The name of the object that triggered this event. </summary>
        public string ObjectName { get; }
        /// <summary> The version of the object that triggered this event. </summary>
        public string Version { get; }
        /// <summary> Not before date of the object that triggered this event. </summary>
        public float? Nbf { get; }
        /// <summary> The expiration date of the object that triggered this event. </summary>
        public float? Exp { get; }
    }
}
