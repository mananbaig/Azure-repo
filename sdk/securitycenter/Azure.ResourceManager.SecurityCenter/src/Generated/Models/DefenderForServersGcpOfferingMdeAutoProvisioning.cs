// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Microsoft Defender for Endpoint autoprovisioning configuration. </summary>
    public partial class DefenderForServersGcpOfferingMdeAutoProvisioning
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DefenderForServersGcpOfferingMdeAutoProvisioning"/>. </summary>
        public DefenderForServersGcpOfferingMdeAutoProvisioning()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefenderForServersGcpOfferingMdeAutoProvisioning"/>. </summary>
        /// <param name="isEnabled"> Is Microsoft Defender for Endpoint auto provisioning enabled. </param>
        /// <param name="configuration"> configuration for Microsoft Defender for Endpoint autoprovisioning. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DefenderForServersGcpOfferingMdeAutoProvisioning(bool? isEnabled, BinaryData configuration, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Configuration = configuration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Is Microsoft Defender for Endpoint auto provisioning enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// configuration for Microsoft Defender for Endpoint autoprovisioning
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Configuration { get; set; }
    }
}
