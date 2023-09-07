// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> An Azure Storage container. </summary>
    internal partial class ContainerItemInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerItemInternal"/>. </summary>
        /// <param name="name"></param>
        /// <param name="properties"> Properties of a container. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        internal ContainerItemInternal(string name, ContainerPropertiesInternal properties)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(properties, nameof(properties));

            Name = name;
            Properties = properties;
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerItemInternal"/>. </summary>
        /// <param name="name"></param>
        /// <param name="deleted"></param>
        /// <param name="version"></param>
        /// <param name="properties"> Properties of a container. </param>
        /// <param name="metadata"> Dictionary of &lt;string&gt;. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerItemInternal(string name, bool? deleted, string version, ContainerPropertiesInternal properties, IReadOnlyDictionary<string, string> metadata, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Deleted = deleted;
            Version = version;
            Properties = properties;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerItemInternal"/> for deserialization. </summary>
        internal ContainerItemInternal()
        {
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the deleted. </summary>
        public bool? Deleted { get; }
        /// <summary> Gets the version. </summary>
        public string Version { get; }
        /// <summary> Properties of a container. </summary>
        public ContainerPropertiesInternal Properties { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
