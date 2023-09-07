// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Exchange operation result. </summary>
    public partial class ExchangeResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExchangeResult"/>. </summary>
        internal ExchangeResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExchangeResult"/>. </summary>
        /// <param name="id"> It should match what is used to GET the operation result. </param>
        /// <param name="name"> It must match the last segment of the id field, and will typically be a GUID / system generated value. </param>
        /// <param name="status"> Status of the operation. </param>
        /// <param name="properties"> Exchange response properties. </param>
        /// <param name="error"> Required if status == failed or status == canceled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExchangeResult(ResourceIdentifier id, string name, ExchangeOperationResultStatus? status, ExchangeResultProperties properties, OperationResultError error, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            Status = status;
            Properties = properties;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> It should match what is used to GET the operation result. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> It must match the last segment of the id field, and will typically be a GUID / system generated value. </summary>
        public string Name { get; }
        /// <summary> Status of the operation. </summary>
        public ExchangeOperationResultStatus? Status { get; }
        /// <summary> Exchange response properties. </summary>
        public ExchangeResultProperties Properties { get; }
        /// <summary> Required if status == failed or status == canceled. </summary>
        public OperationResultError Error { get; }
    }
}
