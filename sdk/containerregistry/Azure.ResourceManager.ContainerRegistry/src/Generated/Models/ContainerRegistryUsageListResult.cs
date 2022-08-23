// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The result of a request to get container registry quota usages. </summary>
    internal partial class ContainerRegistryUsageListResult
    {
        /// <summary> Initializes a new instance of ContainerRegistryUsageListResult. </summary>
        internal ContainerRegistryUsageListResult()
        {
            Value = new ChangeTrackingList<ContainerRegistryUsage>();
        }

        /// <summary> Initializes a new instance of ContainerRegistryUsageListResult. </summary>
        /// <param name="value"> The list of container registry quota usages. </param>
        internal ContainerRegistryUsageListResult(IReadOnlyList<ContainerRegistryUsage> value)
        {
            Value = value;
        }

        /// <summary> The list of container registry quota usages. </summary>
        public IReadOnlyList<ContainerRegistryUsage> Value { get; }
    }
}
