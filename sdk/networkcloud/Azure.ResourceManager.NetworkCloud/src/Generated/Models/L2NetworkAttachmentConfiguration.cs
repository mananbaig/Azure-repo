// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> L2NetworkAttachmentConfiguration represents the configuration of the attachment of a Layer 2 network. </summary>
    public partial class L2NetworkAttachmentConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="L2NetworkAttachmentConfiguration"/>. </summary>
        /// <param name="networkId"> The resource ID of the network that is being configured for attachment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkId"/> is null. </exception>
        public L2NetworkAttachmentConfiguration(ResourceIdentifier networkId)
        {
            Argument.AssertNotNull(networkId, nameof(networkId));

            NetworkId = networkId;
        }

        /// <summary> Initializes a new instance of <see cref="L2NetworkAttachmentConfiguration"/>. </summary>
        /// <param name="networkId"> The resource ID of the network that is being configured for attachment. </param>
        /// <param name="pluginType"> The indicator of how this network will be utilized by the Kubernetes cluster. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal L2NetworkAttachmentConfiguration(ResourceIdentifier networkId, KubernetesPluginType? pluginType, Dictionary<string, BinaryData> rawData)
        {
            NetworkId = networkId;
            PluginType = pluginType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="L2NetworkAttachmentConfiguration"/> for deserialization. </summary>
        internal L2NetworkAttachmentConfiguration()
        {
        }

        /// <summary> The resource ID of the network that is being configured for attachment. </summary>
        public ResourceIdentifier NetworkId { get; set; }
        /// <summary> The indicator of how this network will be utilized by the Kubernetes cluster. </summary>
        public KubernetesPluginType? PluginType { get; set; }
    }
}
