// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the HA software configuration. </summary>
    public partial class HighAvailabilitySoftwareConfiguration
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

        /// <summary> Initializes a new instance of <see cref="HighAvailabilitySoftwareConfiguration"/>. </summary>
        /// <param name="fencingClientId"> The fencing client id. </param>
        /// <param name="fencingClientPassword"> The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster VMs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fencingClientId"/> or <paramref name="fencingClientPassword"/> is null. </exception>
        public HighAvailabilitySoftwareConfiguration(string fencingClientId, string fencingClientPassword)
        {
            Argument.AssertNotNull(fencingClientId, nameof(fencingClientId));
            Argument.AssertNotNull(fencingClientPassword, nameof(fencingClientPassword));

            FencingClientId = fencingClientId;
            FencingClientPassword = fencingClientPassword;
        }

        /// <summary> Initializes a new instance of <see cref="HighAvailabilitySoftwareConfiguration"/>. </summary>
        /// <param name="fencingClientId"> The fencing client id. </param>
        /// <param name="fencingClientPassword"> The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster VMs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HighAvailabilitySoftwareConfiguration(string fencingClientId, string fencingClientPassword, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FencingClientId = fencingClientId;
            FencingClientPassword = fencingClientPassword;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HighAvailabilitySoftwareConfiguration"/> for deserialization. </summary>
        internal HighAvailabilitySoftwareConfiguration()
        {
        }

        /// <summary> The fencing client id. </summary>
        public string FencingClientId { get; set; }
        /// <summary> The fencing client id secret/password. The secret should never expire. This will be used pacemaker to start/stop the cluster VMs. </summary>
        public string FencingClientPassword { get; set; }
    }
}
