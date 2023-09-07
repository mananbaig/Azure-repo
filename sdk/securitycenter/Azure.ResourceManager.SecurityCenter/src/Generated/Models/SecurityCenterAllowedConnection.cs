// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The resource whose properties describes the allowed traffic between Azure resources. </summary>
    public partial class SecurityCenterAllowedConnection : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityCenterAllowedConnection"/>. </summary>
        public SecurityCenterAllowedConnection()
        {
            ConnectableResources = new ChangeTrackingList<ConnectableResourceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityCenterAllowedConnection"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="calculatedOn"> The UTC time on which the allowed connections resource was calculated. </param>
        /// <param name="connectableResources"> List of connectable resources. </param>
        /// <param name="location"> Location where the resource is stored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityCenterAllowedConnection(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? calculatedOn, IReadOnlyList<ConnectableResourceInfo> connectableResources, AzureLocation? location, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            CalculatedOn = calculatedOn;
            ConnectableResources = connectableResources;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The UTC time on which the allowed connections resource was calculated. </summary>
        public DateTimeOffset? CalculatedOn { get; }
        /// <summary> List of connectable resources. </summary>
        public IReadOnlyList<ConnectableResourceInfo> ConnectableResources { get; }
        /// <summary> Location where the resource is stored. </summary>
        public AzureLocation? Location { get; }
    }
}
