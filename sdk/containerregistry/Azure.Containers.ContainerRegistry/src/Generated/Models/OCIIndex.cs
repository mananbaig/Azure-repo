// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Returns the requested OCI index file. </summary>
    internal partial class OCIIndex : Manifest
    {
        /// <summary> Initializes a new instance of OCIIndex. </summary>
        internal OCIIndex()
        {
            Manifests = new ChangeTrackingList<ManifestListAttributes>();
        }

        /// <summary> Initializes a new instance of OCIIndex. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="manifests"> List of OCI image layer information. </param>
        /// <param name="annotations"> Additional information provided through arbitrary metadata. </param>
        internal OCIIndex(int? schemaVersion, IReadOnlyList<ManifestListAttributes> manifests, Annotations annotations) : base(schemaVersion)
        {
            Manifests = manifests;
            Annotations = annotations;
        }

        /// <summary> List of OCI image layer information. </summary>
        public IReadOnlyList<ManifestListAttributes> Manifests { get; }
        /// <summary> Additional information provided through arbitrary metadata. </summary>
        public Annotations Annotations { get; }
    }
}
