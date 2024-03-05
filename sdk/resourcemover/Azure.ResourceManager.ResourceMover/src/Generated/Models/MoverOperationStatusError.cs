// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Class for operation status errors. </summary>
    public partial class MoverOperationStatusError
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

        /// <summary> Initializes a new instance of <see cref="MoverOperationStatusError"/>. </summary>
        internal MoverOperationStatusError()
        {
            Details = new ChangeTrackingList<MoverOperationStatusError>();
            AdditionalInfo = new ChangeTrackingList<MoverOperationErrorAdditionalInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="MoverOperationStatusError"/>. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="details"> The error details. </param>
        /// <param name="additionalInfo"> The additional info. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverOperationStatusError(string code, string message, IReadOnlyList<MoverOperationStatusError> details, IReadOnlyList<MoverOperationErrorAdditionalInfo> additionalInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Details = details;
            AdditionalInfo = additionalInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The error details. </summary>
        public IReadOnlyList<MoverOperationStatusError> Details { get; }
        /// <summary> The additional info. </summary>
        public IReadOnlyList<MoverOperationErrorAdditionalInfo> AdditionalInfo { get; }
    }
}
