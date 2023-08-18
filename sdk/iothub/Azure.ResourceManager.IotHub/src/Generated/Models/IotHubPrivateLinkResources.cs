// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The available private link resources for an IotHub. </summary>
    internal partial class IotHubPrivateLinkResources
    {
        /// <summary> Initializes a new instance of IotHubPrivateLinkResources. </summary>
        internal IotHubPrivateLinkResources()
        {
            Value = new Core.ChangeTrackingList<IotHubPrivateEndpointGroupInformationData>();
        }

        /// <summary> Initializes a new instance of IotHubPrivateLinkResources. </summary>
        /// <param name="value"> The list of available private link resources for an IotHub. </param>
        internal IotHubPrivateLinkResources(IReadOnlyList<IotHubPrivateEndpointGroupInformationData> value)
        {
            Value = value;
        }

        /// <summary> The list of available private link resources for an IotHub. </summary>
        public IReadOnlyList<IotHubPrivateEndpointGroupInformationData> Value { get; }
    }
}
