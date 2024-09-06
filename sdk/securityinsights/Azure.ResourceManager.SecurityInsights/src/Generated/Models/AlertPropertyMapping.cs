// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// A single alert property mapping to override
    /// Serialized Name: AlertPropertyMapping
    /// </summary>
    public partial class AlertPropertyMapping
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

        /// <summary> Initializes a new instance of <see cref="AlertPropertyMapping"/>. </summary>
        public AlertPropertyMapping()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AlertPropertyMapping"/>. </summary>
        /// <param name="alertProperty">
        /// The V3 alert property
        /// Serialized Name: AlertPropertyMapping.alertProperty
        /// </param>
        /// <param name="value">
        /// the column name to use to override this property
        /// Serialized Name: AlertPropertyMapping.value
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AlertPropertyMapping(AlertProperty? alertProperty, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AlertProperty = alertProperty;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The V3 alert property
        /// Serialized Name: AlertPropertyMapping.alertProperty
        /// </summary>
        public AlertProperty? AlertProperty { get; set; }
        /// <summary>
        /// the column name to use to override this property
        /// Serialized Name: AlertPropertyMapping.value
        /// </summary>
        public string Value { get; set; }
    }
}
