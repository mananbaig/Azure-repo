// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> An IP Configuration of the private endpoint. </summary>
    public partial class PrivateEndpointIPConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointIPConfiguration"/>. </summary>
        public PrivateEndpointIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointIPConfiguration"/>. </summary>
        /// <param name="name"> The name of the resource that is unique within a resource group. </param>
        /// <param name="privateEndpointIPConfigurationType"> The resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="groupId"> The ID of a group obtained from the remote resource that this private endpoint should connect to. </param>
        /// <param name="memberName"> The member name of a group obtained from the remote resource that this private endpoint should connect to. </param>
        /// <param name="privateIPAddress"> A private ip address obtained from the private endpoint's subnet. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateEndpointIPConfiguration(string name, string privateEndpointIPConfigurationType, ETag? etag, string groupId, string memberName, IPAddress privateIPAddress, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            PrivateEndpointIPConfigurationType = privateEndpointIPConfigurationType;
            ETag = etag;
            GroupId = groupId;
            MemberName = memberName;
            PrivateIPAddress = privateIPAddress;
            _rawData = rawData;
        }

        /// <summary> The name of the resource that is unique within a resource group. </summary>
        public string Name { get; set; }
        /// <summary> The resource type. </summary>
        public string PrivateEndpointIPConfigurationType { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The ID of a group obtained from the remote resource that this private endpoint should connect to. </summary>
        public string GroupId { get; set; }
        /// <summary> The member name of a group obtained from the remote resource that this private endpoint should connect to. </summary>
        public string MemberName { get; set; }
        /// <summary> A private ip address obtained from the private endpoint's subnet. </summary>
        public IPAddress PrivateIPAddress { get; set; }
    }
}
