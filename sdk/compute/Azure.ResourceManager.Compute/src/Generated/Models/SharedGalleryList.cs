// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Shared Galleries operation response. </summary>
    internal partial class SharedGalleryList
    {
        /// <summary> Initializes a new instance of SharedGalleryList. </summary>
        /// <param name="value"> A list of shared galleries. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SharedGalleryList(IEnumerable<SharedGallery> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SharedGalleryList. </summary>
        /// <param name="value"> A list of shared galleries. </param>
        /// <param name="nextLink"> The uri to fetch the next page of shared galleries. Call ListNext() with this to fetch the next page of shared galleries. </param>
        internal SharedGalleryList(IReadOnlyList<SharedGallery> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of shared galleries. </summary>
        public IReadOnlyList<SharedGallery> Value { get; }
        /// <summary> The uri to fetch the next page of shared galleries. Call ListNext() with this to fetch the next page of shared galleries. </summary>
        public string NextLink { get; }
    }
}
