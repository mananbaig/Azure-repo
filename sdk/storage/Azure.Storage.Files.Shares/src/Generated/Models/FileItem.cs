// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> A listed file item. </summary>
    internal partial class FileItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FileItem"/>. </summary>
        /// <param name="name"></param>
        /// <param name="properties"> File properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        internal FileItem(StringEncoded name, FileProperty properties)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(properties, nameof(properties));

            Name = name;
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="FileItem"/>. </summary>
        /// <param name="name"></param>
        /// <param name="fileId"></param>
        /// <param name="properties"> File properties. </param>
        /// <param name="attributes"></param>
        /// <param name="permissionKey"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FileItem(StringEncoded name, string fileId, FileProperty properties, string attributes, string permissionKey, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            FileId = fileId;
            Properties = properties;
            Attributes = attributes;
            PermissionKey = permissionKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FileItem"/> for deserialization. </summary>
        internal FileItem()
        {
        }

        /// <summary> Gets the name. </summary>
        public StringEncoded Name { get; }
        /// <summary> Gets the file id. </summary>
        public string FileId { get; }
        /// <summary> File properties. </summary>
        public FileProperty Properties { get; }
        /// <summary> Gets the attributes. </summary>
        public string Attributes { get; }
        /// <summary> Gets the permission key. </summary>
        public string PermissionKey { get; }
    }
}
