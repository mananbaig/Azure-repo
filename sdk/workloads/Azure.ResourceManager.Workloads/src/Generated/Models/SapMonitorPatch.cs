// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Tags field of the resource. </summary>
    public partial class SapMonitorPatch
    {
        /// <summary> Initializes a new instance of <see cref="SapMonitorPatch"/>. </summary>
        public SapMonitorPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Tags field of the resource. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
