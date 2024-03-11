// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> A cluster migrate request. </summary>
    public partial class ClusterMigrateContent
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

        /// <summary> Initializes a new instance of <see cref="ClusterMigrateContent"/>. </summary>
        /// <param name="clusterResourceId"> Resource ID of the destination cluster or kusto pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterResourceId"/> is null. </exception>
        public ClusterMigrateContent(string clusterResourceId)
        {
            Argument.AssertNotNull(clusterResourceId, nameof(clusterResourceId));

            ClusterResourceId = clusterResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterMigrateContent"/>. </summary>
        /// <param name="clusterResourceId"> Resource ID of the destination cluster or kusto pool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterMigrateContent(string clusterResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClusterResourceId = clusterResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterMigrateContent"/> for deserialization. </summary>
        internal ClusterMigrateContent()
        {
        }

        /// <summary> Resource ID of the destination cluster or kusto pool. </summary>
        public string ClusterResourceId { get; }
    }
}
