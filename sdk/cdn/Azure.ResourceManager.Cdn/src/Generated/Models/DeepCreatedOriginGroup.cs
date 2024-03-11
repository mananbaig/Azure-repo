// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Cdn;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The origin group for CDN content which is added when creating a CDN endpoint. Traffic is sent to the origins within the origin group based on origin health. </summary>
    public partial class DeepCreatedOriginGroup
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

        /// <summary> Initializes a new instance of <see cref="DeepCreatedOriginGroup"/>. </summary>
        /// <param name="name"> Origin group name which must be unique within the endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DeepCreatedOriginGroup(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Origins = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="DeepCreatedOriginGroup"/>. </summary>
        /// <param name="name"> Origin group name which must be unique within the endpoint. </param>
        /// <param name="healthProbeSettings"> Health probe settings to the origin that is used to determine the health of the origin. </param>
        /// <param name="origins"> The source of the content being delivered via CDN within given origin group. </param>
        /// <param name="trafficRestorationTimeToHealedOrNewEndpointsInMinutes"> Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported. </param>
        /// <param name="responseBasedOriginErrorDetectionSettings"> The JSON object that contains the properties to determine origin health using real requests/responses.This property is currently not supported. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeepCreatedOriginGroup(string name, HealthProbeSettings healthProbeSettings, IList<WritableSubResource> origins, int? trafficRestorationTimeToHealedOrNewEndpointsInMinutes, ResponseBasedOriginErrorDetectionSettings responseBasedOriginErrorDetectionSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            HealthProbeSettings = healthProbeSettings;
            Origins = origins;
            TrafficRestorationTimeToHealedOrNewEndpointsInMinutes = trafficRestorationTimeToHealedOrNewEndpointsInMinutes;
            ResponseBasedOriginErrorDetectionSettings = responseBasedOriginErrorDetectionSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeepCreatedOriginGroup"/> for deserialization. </summary>
        internal DeepCreatedOriginGroup()
        {
        }

        /// <summary> Origin group name which must be unique within the endpoint. </summary>
        public string Name { get; set; }
        /// <summary> Health probe settings to the origin that is used to determine the health of the origin. </summary>
        public HealthProbeSettings HealthProbeSettings { get; set; }
        /// <summary> The source of the content being delivered via CDN within given origin group. </summary>
        public IList<WritableSubResource> Origins { get; }
        /// <summary> Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported. </summary>
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }
        /// <summary> The JSON object that contains the properties to determine origin health using real requests/responses.This property is currently not supported. </summary>
        public ResponseBasedOriginErrorDetectionSettings ResponseBasedOriginErrorDetectionSettings { get; set; }
    }
}
