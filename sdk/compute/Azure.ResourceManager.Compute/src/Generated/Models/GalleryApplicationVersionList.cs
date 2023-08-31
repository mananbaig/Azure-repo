// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Gallery Application version operation response. </summary>
    internal partial class GalleryApplicationVersionList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationVersionList"/>. </summary>
        /// <param name="value"> A list of gallery Application Versions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal GalleryApplicationVersionList(IEnumerable<GalleryApplicationVersionData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationVersionList"/>. </summary>
        /// <param name="value"> A list of gallery Application Versions. </param>
        /// <param name="nextLink"> The uri to fetch the next page of gallery Application Versions. Call ListNext() with this to fetch the next page of gallery Application Versions. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryApplicationVersionList(IReadOnlyList<GalleryApplicationVersionData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationVersionList"/> for deserialization. </summary>
        internal GalleryApplicationVersionList()
        {
        }

        /// <summary> A list of gallery Application Versions. </summary>
        public IReadOnlyList<GalleryApplicationVersionData> Value { get; }
        /// <summary> The uri to fetch the next page of gallery Application Versions. Call ListNext() with this to fetch the next page of gallery Application Versions. </summary>
        public string NextLink { get; }
    }
}
