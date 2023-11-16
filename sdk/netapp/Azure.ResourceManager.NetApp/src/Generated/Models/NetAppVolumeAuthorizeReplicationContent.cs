// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Authorize request. </summary>
    public partial class NetAppVolumeAuthorizeReplicationContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeAuthorizeReplicationContent"/>. </summary>
        public NetAppVolumeAuthorizeReplicationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeAuthorizeReplicationContent"/>. </summary>
        /// <param name="remoteVolumeResourceId"> Resource id of the remote volume. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeAuthorizeReplicationContent(ResourceIdentifier remoteVolumeResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RemoteVolumeResourceId = remoteVolumeResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource id of the remote volume. </summary>
        public ResourceIdentifier RemoteVolumeResourceId { get; set; }
    }
}
