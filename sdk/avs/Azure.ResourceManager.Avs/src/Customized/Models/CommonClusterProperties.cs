// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The common properties of a cluster. </summary>
    public partial class CommonClusterProperties
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
        [EditorBrowsable(EditorBrowsableState.Never)]
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CommonClusterProperties"/>. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CommonClusterProperties()
        {
            Hosts = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CommonClusterProperties"/>. </summary>
        /// <param name="clusterSize"> The cluster size. </param>
        /// <param name="provisioningState"> The state of the cluster provisioning. </param>
        /// <param name="clusterId"> The identity. </param>
        /// <param name="hosts"> The hosts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CommonClusterProperties(int? clusterSize, AvsPrivateCloudClusterProvisioningState? provisioningState, int? clusterId, IList<string> hosts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClusterSize = clusterSize;
            ProvisioningState = provisioningState;
            ClusterId = clusterId;
            Hosts = hosts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The cluster size. </summary>
        public int? ClusterSize { get; set; }
        /// <summary> The state of the cluster provisioning. </summary>
        public AvsPrivateCloudClusterProvisioningState? ProvisioningState { get; private protected set; }
        /// <summary> The identity. </summary>
        public int? ClusterId { get; private protected set; }
        /// <summary> The hosts. </summary>
        public IList<string> Hosts { get; private protected set; }
    }
}