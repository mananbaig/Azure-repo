// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The agent that initiated the event. For most situations, this could be from the authorization context of the request. </summary>
    internal partial class ContainerRegistryWebhookEventActor
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookEventActor"/>. </summary>
        internal ContainerRegistryWebhookEventActor()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookEventActor"/>. </summary>
        /// <param name="name"> The subject or username associated with the request context that generated the event. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryWebhookEventActor(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> The subject or username associated with the request context that generated the event. </summary>
        public string Name { get; }
    }
}
