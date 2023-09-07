// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Response of a single operation on a batch of instances. Only one of "get", "put", "update" or "delete" will be set based on the request. </summary>
    internal partial class InstancesBatchResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InstancesBatchResponse"/>. </summary>
        internal InstancesBatchResponse()
        {
            Get = new ChangeTrackingList<InstancesOperationResult>();
            Put = new ChangeTrackingList<InstancesOperationResult>();
            Update = new ChangeTrackingList<InstancesOperationResult>();
            Delete = new ChangeTrackingList<TimeSeriesOperationError>();
        }

        /// <summary> Initializes a new instance of <see cref="InstancesBatchResponse"/>. </summary>
        /// <param name="get"> List of instance or error objects corresponding by position to the "get" array in the request. Instance object is set when operation is successful and error object is set when operation is unsuccessful. </param>
        /// <param name="put"> List of error objects corresponding by position to the "put" array in the request. Error object is set when operation is unsuccessful. </param>
        /// <param name="update"> List of error objects corresponding by position to the "update" array in the request. Instance object is set when operation is successful and error object is set when operation is unsuccessful. </param>
        /// <param name="delete"> List of error objects corresponding by position to the "delete" array in the request. Null means the instance has been deleted, or did not exist. Error object is set when operation is unsuccessful (e.g. when there are events associated with this time series instance). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InstancesBatchResponse(IReadOnlyList<InstancesOperationResult> @get, IReadOnlyList<InstancesOperationResult> put, IReadOnlyList<InstancesOperationResult> update, IReadOnlyList<TimeSeriesOperationError> delete, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Get = @get;
            Put = put;
            Update = update;
            Delete = delete;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of instance or error objects corresponding by position to the "get" array in the request. Instance object is set when operation is successful and error object is set when operation is unsuccessful. </summary>
        public IReadOnlyList<InstancesOperationResult> Get { get; }
        /// <summary> List of error objects corresponding by position to the "put" array in the request. Error object is set when operation is unsuccessful. </summary>
        public IReadOnlyList<InstancesOperationResult> Put { get; }
        /// <summary> List of error objects corresponding by position to the "update" array in the request. Instance object is set when operation is successful and error object is set when operation is unsuccessful. </summary>
        public IReadOnlyList<InstancesOperationResult> Update { get; }
        /// <summary> List of error objects corresponding by position to the "delete" array in the request. Null means the instance has been deleted, or did not exist. Error object is set when operation is unsuccessful (e.g. when there are events associated with this time series instance). </summary>
        public IReadOnlyList<TimeSeriesOperationError> Delete { get; }
    }
}
