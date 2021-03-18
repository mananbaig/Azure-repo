// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Manifest details. </summary>
    internal partial class ManifestAttributesBase
    {
        /// <summary> Initializes a new instance of ManifestAttributesBase. </summary>
        internal ManifestAttributesBase()
        {
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ManifestAttributesBase. </summary>
        /// <param name="digest"> Manifest. </param>
        /// <param name="imageSize"> Image size. </param>
        /// <param name="createdTime"> Created time. </param>
        /// <param name="lastUpdateTime"> Last update time. </param>
        /// <param name="architecture"> CPU architecture. </param>
        /// <param name="os"> Operating system. </param>
        /// <param name="mediaType"> Media type. </param>
        /// <param name="configMediaType"> Config blob media type. </param>
        /// <param name="tags"> List of tags. </param>
        /// <param name="changeableAttributes"> Changeable attributes. </param>
        internal ManifestAttributesBase(string digest, long? imageSize, string createdTime, string lastUpdateTime, string architecture, string os, string mediaType, string configMediaType, IReadOnlyList<string> tags, ContentProperties changeableAttributes)
        {
            Digest = digest;
            ImageSize = imageSize;
            CreatedTime = createdTime;
            LastUpdateTime = lastUpdateTime;
            Architecture = architecture;
            Os = os;
            MediaType = mediaType;
            ConfigMediaType = configMediaType;
            Tags = tags;
            ChangeableAttributes = changeableAttributes;
        }

        /// <summary> Manifest. </summary>
        public string Digest { get; }
        /// <summary> Image size. </summary>
        public long? ImageSize { get; }
        /// <summary> Created time. </summary>
        public string CreatedTime { get; }
        /// <summary> Last update time. </summary>
        public string LastUpdateTime { get; }
        /// <summary> CPU architecture. </summary>
        public string Architecture { get; }
        /// <summary> Operating system. </summary>
        public string Os { get; }
        /// <summary> Media type. </summary>
        public string MediaType { get; }
        /// <summary> Config blob media type. </summary>
        public string ConfigMediaType { get; }
        /// <summary> List of tags. </summary>
        public IReadOnlyList<string> Tags { get; }
        /// <summary> Changeable attributes. </summary>
        public ContentProperties ChangeableAttributes { get; }
    }
}
