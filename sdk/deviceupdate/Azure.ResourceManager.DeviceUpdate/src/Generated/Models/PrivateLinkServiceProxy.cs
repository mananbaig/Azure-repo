// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Private link service proxy details. </summary>
    public partial class PrivateLinkServiceProxy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkServiceProxy"/>. </summary>
        public PrivateLinkServiceProxy()
        {
            GroupConnectivityInformation = new ChangeTrackingList<GroupConnectivityInformation>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkServiceProxy"/>. </summary>
        /// <param name="id"> NRP resource ID. </param>
        /// <param name="remotePrivateLinkServiceConnectionState"> Remote private link service connection state. </param>
        /// <param name="remotePrivateEndpointConnection"> Remote private endpoint connection details. </param>
        /// <param name="groupConnectivityInformation"> Group connectivity information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkServiceProxy(string id, DeviceUpdatePrivateLinkServiceConnectionState remotePrivateLinkServiceConnectionState, SubResource remotePrivateEndpointConnection, IList<GroupConnectivityInformation> groupConnectivityInformation, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            RemotePrivateLinkServiceConnectionState = remotePrivateLinkServiceConnectionState;
            RemotePrivateEndpointConnection = remotePrivateEndpointConnection;
            GroupConnectivityInformation = groupConnectivityInformation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> NRP resource ID. </summary>
        public string Id { get; set; }
        /// <summary> Remote private link service connection state. </summary>
        public DeviceUpdatePrivateLinkServiceConnectionState RemotePrivateLinkServiceConnectionState { get; set; }
        /// <summary> Remote private endpoint connection details. </summary>
        internal SubResource RemotePrivateEndpointConnection { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier RemotePrivateEndpointConnectionId
        {
            get => RemotePrivateEndpointConnection is null ? default : RemotePrivateEndpointConnection.Id;
        }

        /// <summary> Group connectivity information. </summary>
        public IList<GroupConnectivityInformation> GroupConnectivityInformation { get; }
    }
}
