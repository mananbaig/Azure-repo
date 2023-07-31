// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Temp.Batch.Models
{
    /// <summary> Information about the execution of a Task. </summary>
    public partial class TaskExecutionInformation
    {
        /// <summary> Initializes a new instance of TaskExecutionInformation. </summary>
        /// <param name="retryCount"> Task application failures (non-zero exit code) are retried, pre-processing errors (the Task could not be run) and file upload errors are not retried. The Batch service will retry the Task up to the limit specified by the constraints. </param>
        /// <param name="requeueCount"> When the user removes Compute Nodes from a Pool (by resizing/shrinking the pool) or when the Job is being disabled, the user can specify that running Tasks on the Compute Nodes be requeued for execution. This count tracks how many times the Task has been requeued for these reasons. </param>
        internal TaskExecutionInformation(int retryCount, int requeueCount)
        {
            RetryCount = retryCount;
            RequeueCount = requeueCount;
        }

        /// <summary> Initializes a new instance of TaskExecutionInformation. </summary>
        /// <param name="startTime"> 'Running' corresponds to the running state, so if the Task specifies resource files or Packages, then the start time reflects the time at which the Task started downloading or deploying these. If the Task has been restarted or retried, this is the most recent time at which the Task started running. This property is present only for Tasks that are in the running or completed state. </param>
        /// <param name="endTime"> This property is set only if the Task is in the Completed state. </param>
        /// <param name="exitCode"> This property is set only if the Task is in the completed state. In general, the exit code for a process reflects the specific convention implemented by the application developer for that process. If you use the exit code value to make decisions in your code, be sure that you know the exit code convention used by the application process. However, if the Batch service terminates the Task (due to timeout, or user termination via the API) you may see an operating system-defined exit code. </param>
        /// <param name="containerInfo"> This property is set only if the Task runs in a container context. </param>
        /// <param name="failureInfo"> This property is set only if the Task is in the completed state and encountered a failure. </param>
        /// <param name="retryCount"> Task application failures (non-zero exit code) are retried, pre-processing errors (the Task could not be run) and file upload errors are not retried. The Batch service will retry the Task up to the limit specified by the constraints. </param>
        /// <param name="lastRetryTime"> This element is present only if the Task was retried (i.e. retryCount is nonzero). If present, this is typically the same as startTime, but may be different if the Task has been restarted for reasons other than retry; for example, if the Compute Node was rebooted during a retry, then the startTime is updated but the lastRetryTime is not. </param>
        /// <param name="requeueCount"> When the user removes Compute Nodes from a Pool (by resizing/shrinking the pool) or when the Job is being disabled, the user can specify that running Tasks on the Compute Nodes be requeued for execution. This count tracks how many times the Task has been requeued for these reasons. </param>
        /// <param name="lastRequeueTime"> This property is set only if the requeueCount is nonzero. </param>
        /// <param name="result"> If the value is 'failed', then the details of the failure can be found in the failureInfo property. </param>
        internal TaskExecutionInformation(DateTimeOffset? startTime, DateTimeOffset? endTime, int? exitCode, TaskContainerExecutionInformation containerInfo, TaskFailureInformation failureInfo, int retryCount, DateTimeOffset? lastRetryTime, int requeueCount, DateTimeOffset? lastRequeueTime, TaskExecutionResult? result)
        {
            StartTime = startTime;
            EndTime = endTime;
            ExitCode = exitCode;
            ContainerInfo = containerInfo;
            FailureInfo = failureInfo;
            RetryCount = retryCount;
            LastRetryTime = lastRetryTime;
            RequeueCount = requeueCount;
            LastRequeueTime = lastRequeueTime;
            Result = result;
        }

        /// <summary> 'Running' corresponds to the running state, so if the Task specifies resource files or Packages, then the start time reflects the time at which the Task started downloading or deploying these. If the Task has been restarted or retried, this is the most recent time at which the Task started running. This property is present only for Tasks that are in the running or completed state. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> This property is set only if the Task is in the Completed state. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> This property is set only if the Task is in the completed state. In general, the exit code for a process reflects the specific convention implemented by the application developer for that process. If you use the exit code value to make decisions in your code, be sure that you know the exit code convention used by the application process. However, if the Batch service terminates the Task (due to timeout, or user termination via the API) you may see an operating system-defined exit code. </summary>
        public int? ExitCode { get; }
        /// <summary> This property is set only if the Task runs in a container context. </summary>
        public TaskContainerExecutionInformation ContainerInfo { get; }
        /// <summary> This property is set only if the Task is in the completed state and encountered a failure. </summary>
        public TaskFailureInformation FailureInfo { get; }
        /// <summary> Task application failures (non-zero exit code) are retried, pre-processing errors (the Task could not be run) and file upload errors are not retried. The Batch service will retry the Task up to the limit specified by the constraints. </summary>
        public int RetryCount { get; }
        /// <summary> This element is present only if the Task was retried (i.e. retryCount is nonzero). If present, this is typically the same as startTime, but may be different if the Task has been restarted for reasons other than retry; for example, if the Compute Node was rebooted during a retry, then the startTime is updated but the lastRetryTime is not. </summary>
        public DateTimeOffset? LastRetryTime { get; }
        /// <summary> When the user removes Compute Nodes from a Pool (by resizing/shrinking the pool) or when the Job is being disabled, the user can specify that running Tasks on the Compute Nodes be requeued for execution. This count tracks how many times the Task has been requeued for these reasons. </summary>
        public int RequeueCount { get; }
        /// <summary> This property is set only if the requeueCount is nonzero. </summary>
        public DateTimeOffset? LastRequeueTime { get; }
        /// <summary> If the value is 'failed', then the details of the failure can be found in the failureInfo property. </summary>
        public TaskExecutionResult? Result { get; }
    }
}
