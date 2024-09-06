// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsDataConnector data model.
    /// Data connector
    /// Serialized Name: DataConnector
    /// Please note <see cref="SecurityInsightsDataConnectorData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SecurityInsightsAwsCloudTrailDataConnector"/>, <see cref="AwsS3DataConnector"/>, <see cref="CodelessApiPollingDataConnector"/>, <see cref="SecurityInsightsAadDataConnector"/>, <see cref="SecurityInsightsAatpDataConnector"/>, <see cref="SecurityInsightsAscDataConnector"/>, <see cref="Dynamics365DataConnector"/>, <see cref="GCPDataConnector"/>, <see cref="CodelessUiDataConnector"/>, <see cref="IotDataConnector"/>, <see cref="McasDataConnector"/>, <see cref="MdatpDataConnector"/>, <see cref="MicrosoftPurviewInformationProtectionDataConnector"/>, <see cref="MstiDataConnector"/>, <see cref="MTPDataConnector"/>, <see cref="SecurityInsightsOfficeDataConnector"/>, <see cref="Office365ProjectDataConnector"/>, <see cref="OfficeATPDataConnector"/>, <see cref="OfficeIRMDataConnector"/>, <see cref="OfficePowerBIDataConnector"/>, <see cref="RestApiPollerDataConnector"/>, <see cref="SecurityInsightsTIDataConnector"/> and <see cref="TiTaxiiDataConnector"/>.
    /// </summary>
    public partial class SecurityInsightsDataConnectorData : ResourceData
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsDataConnectorData"/>. </summary>
        public SecurityInsightsDataConnectorData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsDataConnectorData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind">
        /// The data connector kind
        /// Serialized Name: DataConnector.kind
        /// </param>
        /// <param name="etag">
        /// Etag of the azure resource
        /// Serialized Name: ResourceWithEtag.etag
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsDataConnectorData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataConnectorKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The data connector kind
        /// Serialized Name: DataConnector.kind
        /// </summary>
        internal DataConnectorKind Kind { get; set; }
        /// <summary>
        /// Etag of the azure resource
        /// Serialized Name: ResourceWithEtag.etag
        /// </summary>
        public ETag? ETag { get; set; }
    }
}
