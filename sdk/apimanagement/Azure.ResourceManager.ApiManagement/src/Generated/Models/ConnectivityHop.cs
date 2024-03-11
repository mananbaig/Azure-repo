// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Information about a hop between the source and the destination. </summary>
    public partial class ConnectivityHop
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConnectivityHop"/>. </summary>
        internal ConnectivityHop()
        {
            NextHopIds = new ChangeTrackingList<string>();
            Issues = new ChangeTrackingList<ConnectivityIssue>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityHop"/>. </summary>
        /// <param name="connectivityHopType"> The type of the hop. </param>
        /// <param name="id"> The ID of the hop. </param>
        /// <param name="address"> The IP address of the hop. </param>
        /// <param name="resourceId"> The ID of the resource corresponding to this hop. </param>
        /// <param name="nextHopIds"> List of next hop identifiers. </param>
        /// <param name="issues"> List of issues. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityHop(string connectivityHopType, string id, IPAddress address, ResourceIdentifier resourceId, IReadOnlyList<string> nextHopIds, IReadOnlyList<ConnectivityIssue> issues, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConnectivityHopType = connectivityHopType;
            Id = id;
            Address = address;
            ResourceId = resourceId;
            NextHopIds = nextHopIds;
            Issues = issues;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of the hop. </summary>
        public string ConnectivityHopType { get; }
        /// <summary> The ID of the hop. </summary>
        public string Id { get; }
        /// <summary> The IP address of the hop. </summary>
        public IPAddress Address { get; }
        /// <summary> The ID of the resource corresponding to this hop. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> List of next hop identifiers. </summary>
        public IReadOnlyList<string> NextHopIds { get; }
        /// <summary> List of issues. </summary>
        public IReadOnlyList<ConnectivityIssue> Issues { get; }
    }
}
