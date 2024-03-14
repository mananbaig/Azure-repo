// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Properties of managed integration runtime operation result. </summary>
    public partial class ManagedIntegrationRuntimeOperationResult
    {
        /// <summary> Initializes a new instance of <see cref="ManagedIntegrationRuntimeOperationResult"/>. </summary>
        internal ManagedIntegrationRuntimeOperationResult()
        {
            Parameters = new ChangeTrackingList<string>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedIntegrationRuntimeOperationResult"/>. </summary>
        /// <param name="managedIntegrationRuntimeOperationResultType"> The operation type. Could be start or stop. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="result"> The operation result. </param>
        /// <param name="errorCode"> The error code. </param>
        /// <param name="parameters"> Managed integration runtime error parameters. </param>
        /// <param name="activityId"> The activity id for the operation request. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ManagedIntegrationRuntimeOperationResult(string managedIntegrationRuntimeOperationResultType, DateTimeOffset? startOn, string result, string errorCode, IReadOnlyList<string> parameters, string activityId, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            ManagedIntegrationRuntimeOperationResultType = managedIntegrationRuntimeOperationResultType;
            StartOn = startOn;
            Result = result;
            ErrorCode = errorCode;
            Parameters = parameters;
            ActivityId = activityId;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The operation type. Could be start or stop. </summary>
        public string ManagedIntegrationRuntimeOperationResultType { get; }
        /// <summary> The start time of the operation. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The operation result. </summary>
        public string Result { get; }
        /// <summary> The error code. </summary>
        public string ErrorCode { get; }
        /// <summary> Managed integration runtime error parameters. </summary>
        public IReadOnlyList<string> Parameters { get; }
        /// <summary> The activity id for the operation request. </summary>
        public string ActivityId { get; }
        /// <summary>
        /// Additional Properties
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
