// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Subscription.Models;

namespace Azure.ResourceManager.Subscription
{
    /// <summary>
    /// A class representing the SubscriptionAlias data model.
    /// Subscription Information with the alias.
    /// </summary>
    public partial class SubscriptionAliasData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SubscriptionAliasData"/>. </summary>
        internal SubscriptionAliasData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionAliasData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Subscription Alias response properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubscriptionAliasData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SubscriptionAliasProperties properties, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Subscription Alias response properties. </summary>
        public SubscriptionAliasProperties Properties { get; }
    }
}
