// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Defines contents of a web application firewall global configuration. </summary>
    public partial class PolicySettings
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

        /// <summary> Initializes a new instance of <see cref="PolicySettings"/>. </summary>
        public PolicySettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicySettings"/>. </summary>
        /// <param name="state"> The state of the policy. </param>
        /// <param name="mode"> The mode of the policy. </param>
        /// <param name="requestBodyCheck"> Whether to allow WAF to check request Body. </param>
        /// <param name="requestBodyInspectLimitInKB"> Max inspection limit in KB for request body inspection for WAF. </param>
        /// <param name="requestBodyEnforcement"> Whether allow WAF to enforce request body limits. </param>
        /// <param name="maxRequestBodySizeInKb"> Maximum request body size in Kb for WAF. </param>
        /// <param name="fileUploadEnforcement"> Whether allow WAF to enforce file upload limits. </param>
        /// <param name="fileUploadLimitInMb"> Maximum file upload size in Mb for WAF. </param>
        /// <param name="customBlockResponseStatusCode"> If the action type is block, customer can override the response status code. </param>
        /// <param name="customBlockResponseBody"> If the action type is block, customer can override the response body. The body must be specified in base64 encoding. </param>
        /// <param name="logScrubbing"> To scrub sensitive log fields. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicySettings(WebApplicationFirewallEnabledState? state, WebApplicationFirewallMode? mode, bool? requestBodyCheck, int? requestBodyInspectLimitInKB, bool? requestBodyEnforcement, int? maxRequestBodySizeInKb, bool? fileUploadEnforcement, int? fileUploadLimitInMb, int? customBlockResponseStatusCode, string customBlockResponseBody, PolicySettingsLogScrubbing logScrubbing, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            State = state;
            Mode = mode;
            RequestBodyCheck = requestBodyCheck;
            RequestBodyInspectLimitInKB = requestBodyInspectLimitInKB;
            RequestBodyEnforcement = requestBodyEnforcement;
            MaxRequestBodySizeInKb = maxRequestBodySizeInKb;
            FileUploadEnforcement = fileUploadEnforcement;
            FileUploadLimitInMb = fileUploadLimitInMb;
            CustomBlockResponseStatusCode = customBlockResponseStatusCode;
            CustomBlockResponseBody = customBlockResponseBody;
            LogScrubbing = logScrubbing;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The state of the policy. </summary>
        public WebApplicationFirewallEnabledState? State { get; set; }
        /// <summary> The mode of the policy. </summary>
        public WebApplicationFirewallMode? Mode { get; set; }
        /// <summary> Whether to allow WAF to check request Body. </summary>
        public bool? RequestBodyCheck { get; set; }
        /// <summary> Max inspection limit in KB for request body inspection for WAF. </summary>
        public int? RequestBodyInspectLimitInKB { get; set; }
        /// <summary> Whether allow WAF to enforce request body limits. </summary>
        public bool? RequestBodyEnforcement { get; set; }
        /// <summary> Maximum request body size in Kb for WAF. </summary>
        public int? MaxRequestBodySizeInKb { get; set; }
        /// <summary> Whether allow WAF to enforce file upload limits. </summary>
        public bool? FileUploadEnforcement { get; set; }
        /// <summary> Maximum file upload size in Mb for WAF. </summary>
        public int? FileUploadLimitInMb { get; set; }
        /// <summary> If the action type is block, customer can override the response status code. </summary>
        public int? CustomBlockResponseStatusCode { get; set; }
        /// <summary> If the action type is block, customer can override the response body. The body must be specified in base64 encoding. </summary>
        public string CustomBlockResponseBody { get; set; }
        /// <summary> To scrub sensitive log fields. </summary>
        public PolicySettingsLogScrubbing LogScrubbing { get; set; }
    }
}
