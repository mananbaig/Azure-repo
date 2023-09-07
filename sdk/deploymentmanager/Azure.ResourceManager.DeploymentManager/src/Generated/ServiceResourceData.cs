// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeploymentManager
{
    /// <summary>
    /// A class representing the ServiceResource data model.
    /// The resource representation of a service in a service topology.
    /// </summary>
    public partial class ServiceResourceData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceResourceData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="targetLocation"> The Azure location to which the resources in the service belong to or should be deployed to. </param>
        /// <param name="targetSubscriptionId"> The subscription to which the resources in the service belong to or should be deployed to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetLocation"/> or <paramref name="targetSubscriptionId"/> is null. </exception>
        public ServiceResourceData(AzureLocation location, string targetLocation, string targetSubscriptionId) : base(location)
        {
            Argument.AssertNotNull(targetLocation, nameof(targetLocation));
            Argument.AssertNotNull(targetSubscriptionId, nameof(targetSubscriptionId));

            TargetLocation = targetLocation;
            TargetSubscriptionId = targetSubscriptionId;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="targetLocation"> The Azure location to which the resources in the service belong to or should be deployed to. </param>
        /// <param name="targetSubscriptionId"> The subscription to which the resources in the service belong to or should be deployed to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string targetLocation, string targetSubscriptionId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            TargetLocation = targetLocation;
            TargetSubscriptionId = targetSubscriptionId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceResourceData"/> for deserialization. </summary>
        internal ServiceResourceData()
        {
        }

        /// <summary> The Azure location to which the resources in the service belong to or should be deployed to. </summary>
        public string TargetLocation { get; set; }
        /// <summary> The subscription to which the resources in the service belong to or should be deployed to. </summary>
        public string TargetSubscriptionId { get; set; }
    }
}
