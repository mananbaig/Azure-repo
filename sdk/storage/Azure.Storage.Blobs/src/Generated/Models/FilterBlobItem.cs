// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Blob info from a Filter Blobs API call. </summary>
    internal partial class FilterBlobItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FilterBlobItem"/>. </summary>
        /// <param name="name"></param>
        /// <param name="containerName"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="containerName"/> is null. </exception>
        internal FilterBlobItem(string name, string containerName)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(containerName, nameof(containerName));

            Name = name;
            ContainerName = containerName;
        }

        /// <summary> Initializes a new instance of <see cref="FilterBlobItem"/>. </summary>
        /// <param name="name"></param>
        /// <param name="containerName"></param>
        /// <param name="tags"> Blob tags. </param>
        /// <param name="versionId"></param>
        /// <param name="isCurrentVersion"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FilterBlobItem(string name, string containerName, BlobTags tags, string versionId, bool? isCurrentVersion, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ContainerName = containerName;
            Tags = tags;
            VersionId = versionId;
            IsCurrentVersion = isCurrentVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FilterBlobItem"/> for deserialization. </summary>
        internal FilterBlobItem()
        {
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the container name. </summary>
        public string ContainerName { get; }
        /// <summary> Blob tags. </summary>
        public BlobTags Tags { get; }
        /// <summary> Gets the version id. </summary>
        public string VersionId { get; }
        /// <summary> Gets the is current version. </summary>
        public bool? IsCurrentVersion { get; }
    }
}
