// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> A listed Azure Storage share item. </summary>
    internal partial class ShareItemInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ShareItemInternal"/>. </summary>
        /// <param name="name"></param>
        /// <param name="properties"> Properties of a share. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        internal ShareItemInternal(string name, SharePropertiesInternal properties)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(properties, nameof(properties));

            Name = name;
            Properties = properties;
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ShareItemInternal"/>. </summary>
        /// <param name="name"></param>
        /// <param name="snapshot"></param>
        /// <param name="deleted"></param>
        /// <param name="version"></param>
        /// <param name="properties"> Properties of a share. </param>
        /// <param name="metadata"> Dictionary of &lt;string&gt;. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ShareItemInternal(string name, string snapshot, bool? deleted, string version, SharePropertiesInternal properties, IReadOnlyDictionary<string, string> metadata, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Snapshot = snapshot;
            Deleted = deleted;
            Version = version;
            Properties = properties;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ShareItemInternal"/> for deserialization. </summary>
        internal ShareItemInternal()
        {
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the snapshot. </summary>
        public string Snapshot { get; }
        /// <summary> Gets the deleted. </summary>
        public bool? Deleted { get; }
        /// <summary> Gets the version. </summary>
        public string Version { get; }
        /// <summary> Properties of a share. </summary>
        public SharePropertiesInternal Properties { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
