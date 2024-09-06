// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// GetInsights Query Errors.
    /// Serialized Name: GetInsightsErrorKind
    /// </summary>
    internal partial class GetInsightsErrorKind
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

        /// <summary> Initializes a new instance of <see cref="GetInsightsErrorKind"/>. </summary>
        /// <param name="kind">
        /// the query kind
        /// Serialized Name: GetInsightsErrorKind.kind
        /// </param>
        /// <param name="errorMessage">
        /// the error message
        /// Serialized Name: GetInsightsErrorKind.errorMessage
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errorMessage"/> is null. </exception>
        internal GetInsightsErrorKind(GetInsightsError kind, string errorMessage)
        {
            Argument.AssertNotNull(errorMessage, nameof(errorMessage));

            Kind = kind;
            ErrorMessage = errorMessage;
        }

        /// <summary> Initializes a new instance of <see cref="GetInsightsErrorKind"/>. </summary>
        /// <param name="kind">
        /// the query kind
        /// Serialized Name: GetInsightsErrorKind.kind
        /// </param>
        /// <param name="queryId">
        /// the query id
        /// Serialized Name: GetInsightsErrorKind.queryId
        /// </param>
        /// <param name="errorMessage">
        /// the error message
        /// Serialized Name: GetInsightsErrorKind.errorMessage
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetInsightsErrorKind(GetInsightsError kind, string queryId, string errorMessage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            QueryId = queryId;
            ErrorMessage = errorMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GetInsightsErrorKind"/> for deserialization. </summary>
        internal GetInsightsErrorKind()
        {
        }

        /// <summary>
        /// the query kind
        /// Serialized Name: GetInsightsErrorKind.kind
        /// </summary>
        public GetInsightsError Kind { get; }
        /// <summary>
        /// the query id
        /// Serialized Name: GetInsightsErrorKind.queryId
        /// </summary>
        public string QueryId { get; }
        /// <summary>
        /// the error message
        /// Serialized Name: GetInsightsErrorKind.errorMessage
        /// </summary>
        public string ErrorMessage { get; }
    }
}
