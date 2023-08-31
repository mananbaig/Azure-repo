// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the proximity placement group. </summary>
    public partial class ProximityPlacementGroupPatch : ComputeResourcePatch
    {
        /// <summary> Initializes a new instance of <see cref="ProximityPlacementGroupPatch"/>. </summary>
        public ProximityPlacementGroupPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProximityPlacementGroupPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProximityPlacementGroupPatch(IDictionary<string, string> tags, Dictionary<string, BinaryData> rawData) : base(tags, rawData)
        {
        }
    }
}
