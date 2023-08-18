// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ElasticSan;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> List of Volumes. </summary>
    internal partial class ElasticSanVolumeList
    {
        /// <summary> Initializes a new instance of ElasticSanVolumeList. </summary>
        internal ElasticSanVolumeList()
        {
            Value = new Core.ChangeTrackingList<ElasticSanVolumeData>();
        }

        /// <summary> Initializes a new instance of ElasticSanVolumeList. </summary>
        /// <param name="value"> An array of Volume objects. </param>
        /// <param name="nextLink"> URI to fetch the next section of the paginated response. </param>
        internal ElasticSanVolumeList(IReadOnlyList<ElasticSanVolumeData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of Volume objects. </summary>
        public IReadOnlyList<ElasticSanVolumeData> Value { get; }
        /// <summary> URI to fetch the next section of the paginated response. </summary>
        public string NextLink { get; }
    }
}
