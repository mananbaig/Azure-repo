// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary> The Path. </summary>
    internal partial class Path
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Path"/>. </summary>
        internal Path()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Path"/>. </summary>
        /// <param name="name"></param>
        /// <param name="lastModified"></param>
        /// <param name="owner"></param>
        /// <param name="group"></param>
        /// <param name="permissions"></param>
        /// <param name="encryptionScope"> The name of the encryption scope under which the blob is encrypted. </param>
        /// <param name="creationTime"></param>
        /// <param name="expiryTime"></param>
        /// <param name="encryptionContext"></param>
        /// <param name="contentLength"></param>
        /// <param name="isDirectory"></param>
        /// <param name="etag"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Path(string name, DateTimeOffset? lastModified, string owner, string group, string permissions, string encryptionScope, string creationTime, string expiryTime, string encryptionContext, string contentLength, string isDirectory, string etag, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            LastModified = lastModified;
            Owner = owner;
            Group = group;
            Permissions = permissions;
            EncryptionScope = encryptionScope;
            CreationTime = creationTime;
            ExpiryTime = expiryTime;
            EncryptionContext = encryptionContext;
            ContentLength = contentLength;
            IsDirectory = isDirectory;
            Etag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the last modified. </summary>
        public DateTimeOffset? LastModified { get; }
        /// <summary> Gets the owner. </summary>
        public string Owner { get; }
        /// <summary> Gets the group. </summary>
        public string Group { get; }
        /// <summary> Gets the permissions. </summary>
        public string Permissions { get; }
        /// <summary> The name of the encryption scope under which the blob is encrypted. </summary>
        public string EncryptionScope { get; }
        /// <summary> Gets the creation time. </summary>
        public string CreationTime { get; }
        /// <summary> Gets the expiry time. </summary>
        public string ExpiryTime { get; }
        /// <summary> Gets the encryption context. </summary>
        public string EncryptionContext { get; }
        /// <summary> Gets the content length. </summary>
        public string ContentLength { get; }
        /// <summary> Gets the is directory. </summary>
        public string IsDirectory { get; }
        /// <summary> Gets the etag. </summary>
        public string Etag { get; }
    }
}
