// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> List of tag details. </summary>
    internal partial class TagList
    {
        /// <summary> Initializes a new instance of TagList. </summary>
        internal TagList()
        {
            Tags = new ChangeTrackingList<TagAttributesBase>();
        }

        /// <summary> Initializes a new instance of TagList. </summary>
        /// <param name="registry"> Registry name. </param>
        /// <param name="repository"> Repository name. </param>
        /// <param name="tags"> List of tag attribute details. </param>
        /// <param name="link"> . </param>
        internal TagList(string registry, string repository, IReadOnlyList<TagAttributesBase> tags, string link)
        {
            Registry = registry;
            Repository = repository;
            Tags = tags;
            Link = link;
        }

        /// <summary> Registry name. </summary>
        public string Registry { get; }
        /// <summary> Image name. </summary>
        public string Repository { get; }
        /// <summary> List of tag attribute details. </summary>
        public IReadOnlyList<TagAttributesBase> Tags { get; }
        public string Link { get; }
    }
}
