// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Manifest attributes. </summary>
    internal partial class AcrManifests
    {
        /// <summary> Initializes a new instance of AcrManifests. </summary>
        internal AcrManifests()
        {
            Manifests = new ChangeTrackingList<ManifestAttributesBase>();
        }

        /// <summary> Initializes a new instance of AcrManifests. </summary>
        /// <param name="registryLoginServer"> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </param>
        /// <param name="repository"> Image name. </param>
        /// <param name="manifests"> List of manifests. </param>
        /// <param name="link"> . </param>
        internal AcrManifests(string registryLoginServer, string repository, IReadOnlyList<ManifestAttributesBase> manifests, string link)
        {
            RegistryLoginServer = registryLoginServer;
            Repository = repository;
            Manifests = manifests;
            Link = link;
        }

        /// <summary> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </summary>
        public string RegistryLoginServer { get; }
        /// <summary> Image name. </summary>
        public string Repository { get; }
        /// <summary> List of manifests. </summary>
        public IReadOnlyList<ManifestAttributesBase> Manifests { get; }
        public string Link { get; }
    }
}
