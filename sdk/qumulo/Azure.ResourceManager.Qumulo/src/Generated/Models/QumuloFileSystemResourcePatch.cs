// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Qumulo.Models
{
    /// <summary> The type used for update operations of the FileSystemResource. </summary>
    public partial class QumuloFileSystemResourcePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QumuloFileSystemResourcePatch"/>. </summary>
        public QumuloFileSystemResourcePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="QumuloFileSystemResourcePatch"/>. </summary>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="properties"> The updatable properties of the FileSystemResource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QumuloFileSystemResourcePatch(ManagedServiceIdentity identity, IDictionary<string, string> tags, FileSystemResourceUpdateProperties properties, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            Tags = tags;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The updatable properties of the FileSystemResource. </summary>
        public FileSystemResourceUpdateProperties Properties { get; set; }
    }
}
