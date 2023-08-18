// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Represents an update resource. </summary>
    public partial class DevTestLabResourcePatch
    {
        /// <summary> Initializes a new instance of DevTestLabResourcePatch. </summary>
        public DevTestLabResourcePatch()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The tags of the resource. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
