// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The JobRequest. </summary>
    public partial class JobRequest
    {
        /// <summary> Initializes a new instance of JobRequest. </summary>
        public JobRequest()
        {
        }

        /// <summary> The unique identifier of the job. </summary>
        public string JobId { get; set; }
        /// <summary> The job type. </summary>
        public JobRequestType? Type { get; set; }
        /// <summary> The method type and parameters. This is required if the job type is cloudToDeviceMethod. </summary>
        public CloudToDeviceMethodRequest CloudToDeviceMethod { get; set; }
        /// <summary> The state information for a device or module. This is implicitly created and deleted when the corresponding device/ module identity is created or deleted in the IoT Hub. </summary>
        public TwinData UpdateTwin { get; set; }
        /// <summary> The condition for devices to execute the job. This is required if the job type is updateTwin or cloudToDeviceMethod. </summary>
        public string QueryCondition { get; set; }
        /// <summary> The start date and time of the job in ISO 8601 standard. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> The maximum execution time in secounds. </summary>
        public long? MaxExecutionTimeInSeconds { get; set; }
    }
}
