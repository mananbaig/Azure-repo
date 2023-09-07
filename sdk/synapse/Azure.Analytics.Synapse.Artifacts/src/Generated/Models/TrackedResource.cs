// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The resource model definition for an Azure Resource Manager tracked top level resource which has 'tags' and a 'location'. </summary>
    public partial class TrackedResource : Resource
    {
        /// <summary> Initializes a new instance of <see cref="TrackedResource"/>. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public TrackedResource(string location)
        {
            Argument.AssertNotNull(location, nameof(location));

            Tags = new ChangeTrackingDictionary<string, string>();
            Location = location;
        }

        /// <summary> Initializes a new instance of <see cref="TrackedResource"/>. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrackedResource(string id, string name, string type, IDictionary<string, string> tags, string location, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, type, serializedAdditionalRawData)
        {
            Tags = tags;
            Location = location;
        }

        /// <summary> Initializes a new instance of <see cref="TrackedResource"/> for deserialization. </summary>
        internal TrackedResource()
        {
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public string Location { get; set; }
    }
}
