// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class IoTHubServiceModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ConfigurationQueriesTestResponse"/>. </summary>
        /// <param name="targetConditionError"> The errors from running the target condition query. </param>
        /// <param name="customMetricQueryErrors"> The errors from running the custom metric query. </param>
        /// <returns> A new <see cref="Models.ConfigurationQueriesTestResponse"/> instance for mocking. </returns>
        public static ConfigurationQueriesTestResponse ConfigurationQueriesTestResponse(string targetConditionError = null, IReadOnlyDictionary<string, string> customMetricQueryErrors = null)
        {
            customMetricQueryErrors ??= new Dictionary<string, string>();

            return new ConfigurationQueriesTestResponse(targetConditionError, customMetricQueryErrors, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevicesStatistics"/>. </summary>
        /// <param name="totalDeviceCount"> The total number of devices registered for the IoT Hub. </param>
        /// <param name="enabledDeviceCount"> The number of currently enabled devices. </param>
        /// <param name="disabledDeviceCount"> The number of currently disabled devices. </param>
        /// <returns> A new <see cref="Models.DevicesStatistics"/> instance for mocking. </returns>
        public static DevicesStatistics DevicesStatistics(long? totalDeviceCount = null, long? enabledDeviceCount = null, long? disabledDeviceCount = null)
        {
            return new DevicesStatistics(totalDeviceCount, enabledDeviceCount, disabledDeviceCount, default);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceStatistics"/>. </summary>
        /// <param name="connectedDeviceCount"> The number of currently connected devices. </param>
        /// <returns> A new <see cref="Models.ServiceStatistics"/> instance for mocking. </returns>
        public static ServiceStatistics ServiceStatistics(long? connectedDeviceCount = null)
        {
            return new ServiceStatistics(connectedDeviceCount, default);
        }

        /// <summary> Initializes a new instance of <see cref="BulkRegistryOperationResponse"/>. </summary>
        /// <param name="isSuccessful"> The operation result. </param>
        /// <param name="errors"> The device registry operation errors. </param>
        /// <param name="warnings"> The device registry operation warnings. </param>
        /// <returns> A new <see cref="Models.BulkRegistryOperationResponse"/> instance for mocking. </returns>
        public static BulkRegistryOperationResponse BulkRegistryOperationResponse(bool? isSuccessful = null, IEnumerable<DeviceRegistryOperationError> errors = null, IEnumerable<DeviceRegistryOperationWarning> warnings = null)
        {
            errors ??= new List<DeviceRegistryOperationError>();
            warnings ??= new List<DeviceRegistryOperationWarning>();

            return new BulkRegistryOperationResponse(isSuccessful, errors?.ToList(), warnings?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryOperationError"/>. </summary>
        /// <param name="deviceId"> The unique identifier of the device. </param>
        /// <param name="errorCode"> The error code. </param>
        /// <param name="errorStatus"> The details of the error. </param>
        /// <param name="moduleId"> The unique identifier of the module, if applicable. </param>
        /// <param name="operation"> The type of the operation that failed. </param>
        /// <returns> A new <see cref="Models.DeviceRegistryOperationError"/> instance for mocking. </returns>
        public static DeviceRegistryOperationError DeviceRegistryOperationError(string deviceId = null, DeviceRegistryOperationErrorCode? errorCode = null, string errorStatus = null, string moduleId = null, string operation = null)
        {
            return new DeviceRegistryOperationError(deviceId, errorCode, errorStatus, moduleId, operation, default);
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryOperationWarning"/>. </summary>
        /// <param name="deviceId"> The unique identifier of the device. </param>
        /// <param name="warningCode"> The warning code. </param>
        /// <param name="warningStatus"> The details of the warning. </param>
        /// <returns> A new <see cref="Models.DeviceRegistryOperationWarning"/> instance for mocking. </returns>
        public static DeviceRegistryOperationWarning DeviceRegistryOperationWarning(string deviceId = null, DeviceRegistryOperationWarningCode? warningCode = null, string warningStatus = null)
        {
            return new DeviceRegistryOperationWarning(deviceId, warningCode, warningStatus, default);
        }

        /// <summary> Initializes a new instance of <see cref="PurgeMessageQueueResult"/>. </summary>
        /// <param name="totalMessagesPurged"> The total number of messages purged. </param>
        /// <param name="deviceId"> The unique identifier of the device. </param>
        /// <param name="moduleId"> The unique identifier of the module. </param>
        /// <returns> A new <see cref="Models.PurgeMessageQueueResult"/> instance for mocking. </returns>
        public static PurgeMessageQueueResult PurgeMessageQueueResult(int? totalMessagesPurged = null, string deviceId = null, string moduleId = null)
        {
            return new PurgeMessageQueueResult(totalMessagesPurged, deviceId, moduleId, default);
        }

        /// <summary> Initializes a new instance of <see cref="JobResponse"/>. </summary>
        /// <param name="jobId"> System generated.  Ignored at creation. The unique identifier of the job. </param>
        /// <param name="queryCondition"> The device query condition. </param>
        /// <param name="createdTime"> System generated.  Ignored at creation. The creation date and time of the job. </param>
        /// <param name="startTime"> The start date and time of the scheduled job in UTC. </param>
        /// <param name="endTime"> System generated.  Ignored at creation. The end date and time of the job in UTC. </param>
        /// <param name="maxExecutionTimeInSeconds"> The maximum execution time in secounds. </param>
        /// <param name="type"> The job type. </param>
        /// <param name="cloudToDeviceMethod"> The method type and parameters. This is required if job type is cloudToDeviceMethod. </param>
        /// <param name="updateTwin"> The state information for a device or module. This is implicitly created and deleted when the corresponding device/ module identity is created or deleted in the IoT Hub. </param>
        /// <param name="status"> System generated.  Ignored at creation. The status of the job. </param>
        /// <param name="failureReason"> The reason for the failure, if a failure occurred. </param>
        /// <param name="statusMessage"> The status message of the job. </param>
        /// <param name="deviceJobStatistics"> The details regarding job execution status. </param>
        /// <returns> A new <see cref="Models.JobResponse"/> instance for mocking. </returns>
        public static JobResponse JobResponse(string jobId = null, string queryCondition = null, DateTimeOffset? createdTime = null, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, long? maxExecutionTimeInSeconds = null, JobResponseType? type = null, CloudToDeviceMethodRequest cloudToDeviceMethod = null, TwinData updateTwin = null, JobResponseStatus? status = null, string failureReason = null, string statusMessage = null, DeviceJobStatistics deviceJobStatistics = null)
        {
            return new JobResponse(jobId, queryCondition, createdTime, startTime, endTime, maxExecutionTimeInSeconds, type, cloudToDeviceMethod, updateTwin, status, failureReason, statusMessage, deviceJobStatistics, default);
        }

        /// <summary> Initializes a new instance of <see cref="DeviceJobStatistics"/>. </summary>
        /// <param name="deviceCount"> The number of devices targeted by the job. </param>
        /// <param name="failedCount"> The number of failed jobs. </param>
        /// <param name="succeededCount"> The number of succeeded jobs. </param>
        /// <param name="runningCount"> The number of running jobs. </param>
        /// <param name="pendingCount"> The number of pending (scheduled) jobs. </param>
        /// <returns> A new <see cref="Models.DeviceJobStatistics"/> instance for mocking. </returns>
        public static DeviceJobStatistics DeviceJobStatistics(int? deviceCount = null, int? failedCount = null, int? succeededCount = null, int? runningCount = null, int? pendingCount = null)
        {
            return new DeviceJobStatistics(deviceCount, failedCount, succeededCount, runningCount, pendingCount, default);
        }

        /// <summary> Initializes a new instance of <see cref="QueryResult"/>. </summary>
        /// <param name="type"> The query result type. </param>
        /// <param name="items"> The query result items, as a collection. </param>
        /// <param name="continuationToken"> The continuation token. </param>
        /// <returns> A new <see cref="Models.QueryResult"/> instance for mocking. </returns>
        public static QueryResult QueryResult(QueryResultType? type = null, IEnumerable<object> items = null, string continuationToken = null)
        {
            items ??= new List<object>();

            return new QueryResult(type, items?.ToList(), continuationToken, default);
        }

        /// <summary> Initializes a new instance of <see cref="CloudToDeviceMethodResponse"/>. </summary>
        /// <param name="status"> Method invocation result status. </param>
        /// <param name="payload"> Method invocation result payload. </param>
        /// <returns> A new <see cref="Models.CloudToDeviceMethodResponse"/> instance for mocking. </returns>
        public static CloudToDeviceMethodResponse CloudToDeviceMethodResponse(int? status = null, object payload = null)
        {
            return new CloudToDeviceMethodResponse(status, payload, default);
        }
    }
}
