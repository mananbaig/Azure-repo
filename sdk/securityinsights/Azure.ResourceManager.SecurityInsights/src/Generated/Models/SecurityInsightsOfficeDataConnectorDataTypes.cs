// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The available data types for office data connector. </summary>
    public partial class SecurityInsightsOfficeDataConnectorDataTypes
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsOfficeDataConnectorDataTypes"/>. </summary>
        public SecurityInsightsOfficeDataConnectorDataTypes()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsOfficeDataConnectorDataTypes"/>. </summary>
        /// <param name="exchange"> Exchange data type connection. </param>
        /// <param name="sharePoint"> SharePoint data type connection. </param>
        /// <param name="teams"> Teams data type connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsOfficeDataConnectorDataTypes(OfficeDataConnectorDataTypesExchange exchange, OfficeDataConnectorDataTypesSharePoint sharePoint, OfficeDataConnectorDataTypesTeams teams, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Exchange = exchange;
            SharePoint = sharePoint;
            Teams = teams;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Exchange data type connection. </summary>
        internal OfficeDataConnectorDataTypesExchange Exchange { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        public SecurityInsightsDataTypeConnectionState? ExchangeState
        {
            get => Exchange is null ? default : Exchange.State;
            set
            {
                if (Exchange is null)
                    Exchange = new OfficeDataConnectorDataTypesExchange();
                Exchange.State = value;
            }
        }

        /// <summary> SharePoint data type connection. </summary>
        internal OfficeDataConnectorDataTypesSharePoint SharePoint { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        public SecurityInsightsDataTypeConnectionState? SharePointState
        {
            get => SharePoint is null ? default : SharePoint.State;
            set
            {
                if (SharePoint is null)
                    SharePoint = new OfficeDataConnectorDataTypesSharePoint();
                SharePoint.State = value;
            }
        }

        /// <summary> Teams data type connection. </summary>
        internal OfficeDataConnectorDataTypesTeams Teams { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        public SecurityInsightsDataTypeConnectionState? TeamsState
        {
            get => Teams is null ? default : Teams.State;
            set
            {
                if (Teams is null)
                    Teams = new OfficeDataConnectorDataTypesTeams();
                Teams.State = value;
            }
        }
    }
}
