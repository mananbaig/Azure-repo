// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.FormRecognizer.DocumentAnalysis;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> The UnknownOperationDetails. </summary>
    internal partial class UnknownOperationDetails : OperationDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownOperationDetails"/>. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentCompleted"> Operation progress (0-100). </param>
        /// <param name="createdOn"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="kind"> Type of operation. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <param name="serviceVersion"> API version used to create this operation. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="jsonError"> Encountered error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownOperationDetails(string operationId, DocumentOperationStatus status, int? percentCompleted, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, DocumentOperationKind kind, Uri resourceLocation, string serviceVersion, IReadOnlyDictionary<string, string> tags, JsonElement jsonError, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(operationId, status, percentCompleted, createdOn, lastUpdatedOn, kind, resourceLocation, serviceVersion, tags, jsonError, serializedAdditionalRawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownOperationDetails"/> for deserialization. </summary>
        internal UnknownOperationDetails()
        {
        }
    }
}
