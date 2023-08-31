// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Crypto key properties. </summary>
    public partial class FirmwareCryptoKey
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoKey"/>. </summary>
        internal FirmwareCryptoKey()
        {
            Usage = new ChangeTrackingList<string>();
            FilePaths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoKey"/>. </summary>
        /// <param name="firmwareCryptoKeyId"> ID for the key. </param>
        /// <param name="keyType"> Type of the key (public or private). </param>
        /// <param name="keySize"> Size of the key in bits. </param>
        /// <param name="keyAlgorithm"> Key algorithm name. </param>
        /// <param name="usage"> Functions the key can fulfill. </param>
        /// <param name="filePaths"> List of files paths for this key. </param>
        /// <param name="pairedKey"> A matching paired key or certificate. </param>
        /// <param name="isShortKeySize"> Indicates the key size is considered too small to be secure for the algorithm. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FirmwareCryptoKey(string firmwareCryptoKeyId, string keyType, long? keySize, string keyAlgorithm, IReadOnlyList<string> usage, IReadOnlyList<string> filePaths, PairedKey pairedKey, IsShortKeySize? isShortKeySize, Dictionary<string, BinaryData> rawData)
        {
            FirmwareCryptoKeyId = firmwareCryptoKeyId;
            KeyType = keyType;
            KeySize = keySize;
            KeyAlgorithm = keyAlgorithm;
            Usage = usage;
            FilePaths = filePaths;
            PairedKey = pairedKey;
            IsShortKeySize = isShortKeySize;
            _rawData = rawData;
        }

        /// <summary> ID for the key. </summary>
        public string FirmwareCryptoKeyId { get; }
        /// <summary> Type of the key (public or private). </summary>
        public string KeyType { get; }
        /// <summary> Size of the key in bits. </summary>
        public long? KeySize { get; }
        /// <summary> Key algorithm name. </summary>
        public string KeyAlgorithm { get; }
        /// <summary> Functions the key can fulfill. </summary>
        public IReadOnlyList<string> Usage { get; }
        /// <summary> List of files paths for this key. </summary>
        public IReadOnlyList<string> FilePaths { get; }
        /// <summary> A matching paired key or certificate. </summary>
        public PairedKey PairedKey { get; }
        /// <summary> Indicates the key size is considered too small to be secure for the algorithm. </summary>
        public IsShortKeySize? IsShortKeySize { get; }
    }
}
