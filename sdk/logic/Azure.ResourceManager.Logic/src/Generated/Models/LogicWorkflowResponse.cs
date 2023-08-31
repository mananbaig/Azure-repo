// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> A response. </summary>
    public partial class LogicWorkflowResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowResponse"/>. </summary>
        public LogicWorkflowResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowResponse"/>. </summary>
        /// <param name="headers"> A list of all the headers attached to the response. </param>
        /// <param name="statusCode"> The status code of the response. </param>
        /// <param name="bodyLink"> Details on the location of the body content. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowResponse(BinaryData headers, int? statusCode, LogicContentLink bodyLink, Dictionary<string, BinaryData> rawData)
        {
            Headers = headers;
            StatusCode = statusCode;
            BodyLink = bodyLink;
            _rawData = rawData;
        }

        /// <summary>
        /// A list of all the headers attached to the response.
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
        public BinaryData Headers { get; set; }
        /// <summary> The status code of the response. </summary>
        public int? StatusCode { get; set; }
        /// <summary> Details on the location of the body content. </summary>
        public LogicContentLink BodyLink { get; set; }
    }
}
