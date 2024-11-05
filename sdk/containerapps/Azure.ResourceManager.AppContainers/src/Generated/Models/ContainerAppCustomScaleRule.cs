// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App container Custom scaling rule. </summary>
    public partial class ContainerAppCustomScaleRule
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomScaleRule"/>. </summary>
        public ContainerAppCustomScaleRule()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
            Auth = new ChangeTrackingList<ContainerAppScaleRuleAuth>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomScaleRule"/>. </summary>
        /// <param name="customScaleRuleType">
        /// Type of the custom scale rule
        /// eg: azure-servicebus, redis etc.
        /// </param>
        /// <param name="metadata"> Metadata properties to describe custom scale rule. </param>
        /// <param name="auth"> Authentication secrets for the custom scale rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppCustomScaleRule(string customScaleRuleType, IDictionary<string, string> metadata, IList<ContainerAppScaleRuleAuth> auth, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CustomScaleRuleType = customScaleRuleType;
            Metadata = metadata;
            Auth = auth;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Type of the custom scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        [WirePath("type")]
        public string CustomScaleRuleType { get; set; }
        /// <summary> Metadata properties to describe custom scale rule. </summary>
        [WirePath("metadata")]
        public IDictionary<string, string> Metadata { get; }
        /// <summary> Authentication secrets for the custom scale rule. </summary>
        [WirePath("auth")]
        public IList<ContainerAppScaleRuleAuth> Auth { get; }
    }
}
