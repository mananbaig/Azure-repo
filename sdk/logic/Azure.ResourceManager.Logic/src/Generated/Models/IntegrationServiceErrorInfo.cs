// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The extended error info. </summary>
    public partial class IntegrationServiceErrorInfo
    {
        /// <summary> Initializes a new instance of IntegrationServiceErrorInfo. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal IntegrationServiceErrorInfo(IntegrationServiceErrorCode code, string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
            Details = new Core.ChangeTrackingList<IntegrationServiceErrorInfo>();
        }

        /// <summary> Initializes a new instance of IntegrationServiceErrorInfo. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="details"> The error message details. </param>
        /// <param name="innerError"> The inner error. </param>
        internal IntegrationServiceErrorInfo(IntegrationServiceErrorCode code, string message, IReadOnlyList<IntegrationServiceErrorInfo> details, BinaryData innerError)
        {
            Code = code;
            Message = message;
            Details = details;
            InnerError = innerError;
        }

        /// <summary> The error code. </summary>
        public IntegrationServiceErrorCode Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The error message details. </summary>
        public IReadOnlyList<IntegrationServiceErrorInfo> Details { get; }
        /// <summary>
        /// The inner error.
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
        public BinaryData InnerError { get; }
    }
}
