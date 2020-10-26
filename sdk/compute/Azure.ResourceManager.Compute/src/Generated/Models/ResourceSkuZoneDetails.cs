// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes The zonal capabilities of a SKU. </summary>
    public partial class ResourceSkuZoneDetails
    {
        /// <summary> Initializes a new instance of ResourceSkuZoneDetails. </summary>
        internal ResourceSkuZoneDetails()
        {
            Name = new ChangeTrackingList<string>();
            Capabilities = new ChangeTrackingList<ResourceSkuCapabilities>();
        }

        /// <summary> Initializes a new instance of ResourceSkuZoneDetails. </summary>
        /// <param name="name"> The set of zones that the SKU is available in with the specified capabilities. </param>
        /// <param name="capabilities"> A list of capabilities that are available for the SKU in the specified list of zones. </param>
        internal ResourceSkuZoneDetails(IReadOnlyList<string> name, IReadOnlyList<ResourceSkuCapabilities> capabilities)
        {
            Name = name;
            Capabilities = capabilities;
        }

        /// <summary> The set of zones that the SKU is available in with the specified capabilities. </summary>
        public IReadOnlyList<string> Name { get; }
        /// <summary> A list of capabilities that are available for the SKU in the specified list of zones. </summary>
        public IReadOnlyList<ResourceSkuCapabilities> Capabilities { get; }
    }
}
