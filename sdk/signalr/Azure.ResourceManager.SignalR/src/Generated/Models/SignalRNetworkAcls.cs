// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Network ACLs for the resource. </summary>
    public partial class SignalRNetworkAcls
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SignalRNetworkAcls"/>. </summary>
        public SignalRNetworkAcls()
        {
            PrivateEndpoints = new ChangeTrackingList<SignalRPrivateEndpointAcl>();
        }

        /// <summary> Initializes a new instance of <see cref="SignalRNetworkAcls"/>. </summary>
        /// <param name="defaultAction"> Azure Networking ACL Action. </param>
        /// <param name="publicNetwork"> Network ACL. </param>
        /// <param name="privateEndpoints"> ACLs for requests from private endpoints. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRNetworkAcls(SignalRNetworkAclAction? defaultAction, SignalRNetworkAcl publicNetwork, IList<SignalRPrivateEndpointAcl> privateEndpoints, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DefaultAction = defaultAction;
            PublicNetwork = publicNetwork;
            PrivateEndpoints = privateEndpoints;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Azure Networking ACL Action. </summary>
        public SignalRNetworkAclAction? DefaultAction { get; set; }
        /// <summary> Network ACL. </summary>
        public SignalRNetworkAcl PublicNetwork { get; set; }
        /// <summary> ACLs for requests from private endpoints. </summary>
        public IList<SignalRPrivateEndpointAcl> PrivateEndpoints { get; }
    }
}
