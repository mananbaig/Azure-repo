// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary>
    /// Operation info.
    /// Please note <see cref="OperationDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DocumentClassifierBuildOperationDetails"/>, <see cref="DocumentModelBuildOperationDetails"/>, <see cref="DocumentModelComposeOperationDetails"/> and <see cref="DocumentModelCopyToOperationDetails"/>.
    /// </summary>
    public abstract partial class OperationDetails
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

        /// <summary> Initializes a new instance of <see cref="OperationDetails"/>. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedDateTime"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> or <paramref name="resourceLocation"/> is null. </exception>
        protected OperationDetails(string operationId, OperationStatus status, DateTimeOffset createdDateTime, DateTimeOffset lastUpdatedDateTime, Uri resourceLocation)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));
            Argument.AssertNotNull(resourceLocation, nameof(resourceLocation));

            OperationId = operationId;
            Status = status;
            CreatedDateTime = createdDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
            ResourceLocation = resourceLocation;
            Tags = new ChangeTrackingDictionary<string, string>();
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationDetails"/>. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentCompleted"> Operation progress (0-100). </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedDateTime"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="kind"> Type of operation. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <param name="apiVersion"> API version used to create this operation. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="error"> Encountered error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationDetails(string operationId, OperationStatus status, int? percentCompleted, DateTimeOffset createdDateTime, DateTimeOffset lastUpdatedDateTime, OperationKind kind, Uri resourceLocation, string apiVersion, IReadOnlyDictionary<string, string> tags, DocumentIntelligenceError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OperationId = operationId;
            Status = status;
            PercentCompleted = percentCompleted;
            CreatedDateTime = createdDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
            Kind = kind;
            ResourceLocation = resourceLocation;
            ApiVersion = apiVersion;
            Tags = tags;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OperationDetails"/> for deserialization. </summary>
        internal OperationDetails()
        {
        }
        /// <summary> Operation status. </summary>
        public OperationStatus Status { get; }
        /// <summary> Operation progress (0-100). </summary>
        public int? PercentCompleted { get; }
        /// <summary> Date and time (UTC) when the operation was created. </summary>
        public DateTimeOffset CreatedDateTime { get; }
        /// <summary> Date and time (UTC) when the status was last updated. </summary>
        public DateTimeOffset LastUpdatedDateTime { get; }
        /// <summary> Type of operation. </summary>
        internal OperationKind Kind { get; set; }
        /// <summary> URL of the resource targeted by this operation. </summary>
        public Uri ResourceLocation { get; }
        /// <summary> API version used to create this operation. </summary>
        public string ApiVersion { get; }
        /// <summary> List of key-value tag attributes associated with the document model. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Encountered error. </summary>
        public DocumentIntelligenceError Error { get; }
    }
}
