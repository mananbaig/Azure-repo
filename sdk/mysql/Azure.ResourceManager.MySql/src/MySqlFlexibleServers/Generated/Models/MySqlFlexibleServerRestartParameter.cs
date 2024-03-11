// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Server restart parameters. </summary>
    public partial class MySqlFlexibleServerRestartParameter
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

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerRestartParameter"/>. </summary>
        public MySqlFlexibleServerRestartParameter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerRestartParameter"/>. </summary>
        /// <param name="restartWithFailover"> Whether or not failover to standby server when restarting a server with high availability enabled. </param>
        /// <param name="maxFailoverSeconds"> The maximum allowed failover time in seconds. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerRestartParameter(MySqlFlexibleServerEnableStatusEnum? restartWithFailover, int? maxFailoverSeconds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RestartWithFailover = restartWithFailover;
            MaxFailoverSeconds = maxFailoverSeconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Whether or not failover to standby server when restarting a server with high availability enabled. </summary>
        public MySqlFlexibleServerEnableStatusEnum? RestartWithFailover { get; set; }
        /// <summary> The maximum allowed failover time in seconds. </summary>
        public int? MaxFailoverSeconds { get; set; }
    }
}
