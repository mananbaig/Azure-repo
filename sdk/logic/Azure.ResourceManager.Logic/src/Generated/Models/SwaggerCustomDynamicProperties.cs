// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The swagger custom dynamic properties. </summary>
    public partial class SwaggerCustomDynamicProperties
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

        /// <summary> Initializes a new instance of <see cref="SwaggerCustomDynamicProperties"/>. </summary>
        public SwaggerCustomDynamicProperties()
        {
            Parameters = new ChangeTrackingDictionary<string, SwaggerCustomDynamicProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="SwaggerCustomDynamicProperties"/>. </summary>
        /// <param name="operationId"> The operation id to fetch dynamic schema. </param>
        /// <param name="valuePath"> Json pointer to the dynamic schema on the response body. </param>
        /// <param name="parameters"> The operation parameters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SwaggerCustomDynamicProperties(string operationId, string valuePath, IDictionary<string, SwaggerCustomDynamicProperties> parameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OperationId = operationId;
            ValuePath = valuePath;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The operation id to fetch dynamic schema. </summary>
        public string OperationId { get; set; }
        /// <summary> Json pointer to the dynamic schema on the response body. </summary>
        public string ValuePath { get; set; }
        /// <summary> The operation parameters. </summary>
        public IDictionary<string, SwaggerCustomDynamicProperties> Parameters { get; }
    }
}
