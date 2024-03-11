// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List all the SecurityMLAnalyticsSettings. </summary>
    internal partial class SecurityMLAnalyticsSettingsList
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

        /// <summary> Initializes a new instance of <see cref="SecurityMLAnalyticsSettingsList"/>. </summary>
        /// <param name="value">
        /// Array of SecurityMLAnalyticsSettings
        /// Please note <see cref="SecurityMLAnalyticsSettingData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AnomalySecurityMLAnalyticsSettings"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SecurityMLAnalyticsSettingsList(IEnumerable<SecurityMLAnalyticsSettingData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityMLAnalyticsSettingsList"/>. </summary>
        /// <param name="nextLink"> URL to fetch the next set of SecurityMLAnalyticsSettings. </param>
        /// <param name="value">
        /// Array of SecurityMLAnalyticsSettings
        /// Please note <see cref="SecurityMLAnalyticsSettingData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AnomalySecurityMLAnalyticsSettings"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityMLAnalyticsSettingsList(string nextLink, IReadOnlyList<SecurityMLAnalyticsSettingData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityMLAnalyticsSettingsList"/> for deserialization. </summary>
        internal SecurityMLAnalyticsSettingsList()
        {
        }

        /// <summary> URL to fetch the next set of SecurityMLAnalyticsSettings. </summary>
        public string NextLink { get; }
        /// <summary>
        /// Array of SecurityMLAnalyticsSettings
        /// Please note <see cref="SecurityMLAnalyticsSettingData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AnomalySecurityMLAnalyticsSettings"/>.
        /// </summary>
        public IReadOnlyList<SecurityMLAnalyticsSettingData> Value { get; }
    }
}
