// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> List of tag details. </summary>
    internal partial class TagList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TagList"/>. </summary>
        /// <param name="registryLoginServer"> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </param>
        /// <param name="repository"> Image name. </param>
        /// <param name="tagAttributeBases"> List of tag attribute details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registryLoginServer"/>, <paramref name="repository"/> or <paramref name="tagAttributeBases"/> is null. </exception>
        internal TagList(string registryLoginServer, string repository, IEnumerable<TagAttributesBase> tagAttributeBases)
        {
            Argument.AssertNotNull(registryLoginServer, nameof(registryLoginServer));
            Argument.AssertNotNull(repository, nameof(repository));
            Argument.AssertNotNull(tagAttributeBases, nameof(tagAttributeBases));

            RegistryLoginServer = registryLoginServer;
            Repository = repository;
            TagAttributeBases = tagAttributeBases.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="TagList"/>. </summary>
        /// <param name="registryLoginServer"> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </param>
        /// <param name="repository"> Image name. </param>
        /// <param name="tagAttributeBases"> List of tag attribute details. </param>
        /// <param name="link"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TagList(string registryLoginServer, string repository, IReadOnlyList<TagAttributesBase> tagAttributeBases, string link, Dictionary<string, BinaryData> rawData)
        {
            RegistryLoginServer = registryLoginServer;
            Repository = repository;
            TagAttributeBases = tagAttributeBases;
            Link = link;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TagList"/> for deserialization. </summary>
        internal TagList()
        {
        }

        /// <summary> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </summary>
        public string RegistryLoginServer { get; }
        /// <summary> Image name. </summary>
        public string Repository { get; }
        /// <summary> List of tag attribute details. </summary>
        public IReadOnlyList<TagAttributesBase> TagAttributeBases { get; }
        /// <summary> Gets the link. </summary>
        public string Link { get; }
    }
}
