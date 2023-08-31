// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the SharedGallery data model.
    /// Specifies information about the Shared Gallery that you want to create or update.
    /// </summary>
    public partial class SharedGalleryData : PirSharedGalleryResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SharedGalleryData"/>. </summary>
        internal SharedGalleryData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SharedGalleryData"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="uniqueId"> The unique id of this shared gallery. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedGalleryData(string name, AzureLocation? location, string uniqueId, Dictionary<string, BinaryData> rawData) : base(name, location, uniqueId, rawData)
        {
        }

        /// <summary> The resource identifier. </summary>
        public ResourceIdentifier Id { get; internal set; }
    }
}
