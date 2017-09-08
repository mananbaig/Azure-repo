// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about the execution of a Job Release task on a
    /// compute node.
    /// </summary>
    public partial class JobReleaseTaskExecutionInformation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// JobReleaseTaskExecutionInformation class.
        /// </summary>
        public JobReleaseTaskExecutionInformation()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// JobReleaseTaskExecutionInformation class.
        /// </summary>
        /// <param name="startTime">The time at which the task started
        /// running.</param>
        /// <param name="state">The current state of the Job Release task on
        /// the compute node.</param>
        /// <param name="endTime">The time at which the Job Release task
        /// completed.</param>
        /// <param name="taskRootDirectory">The root directory of the Job
        /// Release task on the compute node. You can use this path to retrieve
        /// files created by the task, such as log files.</param>
        /// <param name="taskRootDirectoryUrl">The URL to the root directory of
        /// the Job Release task on the compute node.</param>
        /// <param name="exitCode">The exit code of the program specified on
        /// the task command line.</param>
        /// <param name="failureInfo">Information describing the task failure,
        /// if any.</param>
        /// <param name="result">The result of the task execution.</param>
        public JobReleaseTaskExecutionInformation(System.DateTime startTime, JobReleaseTaskState state, System.DateTime? endTime = default(System.DateTime?), string taskRootDirectory = default(string), string taskRootDirectoryUrl = default(string), int? exitCode = default(int?), TaskFailureInformation failureInfo = default(TaskFailureInformation), TaskExecutionResult? result = default(TaskExecutionResult?))
        {
            StartTime = startTime;
            EndTime = endTime;
            State = state;
            TaskRootDirectory = taskRootDirectory;
            TaskRootDirectoryUrl = taskRootDirectoryUrl;
            ExitCode = exitCode;
            FailureInfo = failureInfo;
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time at which the task started running.
        /// </summary>
        /// <remarks>
        /// If the task has been restarted or retried, this is the most recent
        /// time at which the task started running.
        /// </remarks>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the Job Release task completed.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task is in the Completed state.
        /// </remarks>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the current state of the Job Release task on the
        /// compute node.
        /// </summary>
        /// <remarks>
        /// Values are:
        ///
        /// running - the task is currently running (including retrying).
        /// completed - the task has exited, or the Batch service was unable to
        /// start the task due to task preparation errors (such as resource
        /// file download failures). Possible values include: 'running',
        /// 'completed'
        /// </remarks>
        [JsonProperty(PropertyName = "state")]
        public JobReleaseTaskState State { get; set; }

        /// <summary>
        /// Gets or sets the root directory of the Job Release task on the
        /// compute node. You can use this path to retrieve files created by
        /// the task, such as log files.
        /// </summary>
        [JsonProperty(PropertyName = "taskRootDirectory")]
        public string TaskRootDirectory { get; set; }

        /// <summary>
        /// Gets or sets the URL to the root directory of the Job Release task
        /// on the compute node.
        /// </summary>
        [JsonProperty(PropertyName = "taskRootDirectoryUrl")]
        public string TaskRootDirectoryUrl { get; set; }

        /// <summary>
        /// Gets or sets the exit code of the program specified on the task
        /// command line.
        /// </summary>
        /// <remarks>
        /// This parameter is returned only if the task is in the completed
        /// state. The exit code for a process reflects the specific convention
        /// implemented by the application developer for that process. If you
        /// use the exit code value to make decisions in your code, be sure
        /// that you know the exit code convention used by the application
        /// process. Note that the exit code may also be generated by the
        /// compute node operating system, such as when a process is forcibly
        /// terminated.
        /// </remarks>
        [JsonProperty(PropertyName = "exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Gets or sets information describing the task failure, if any.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task is in the completed state and
        /// encountered a failure.
        /// </remarks>
        [JsonProperty(PropertyName = "failureInfo")]
        public TaskFailureInformation FailureInfo { get; set; }

        /// <summary>
        /// Gets or sets the result of the task execution.
        /// </summary>
        /// <remarks>
        /// If the value is 'failed', then the details of the failure can be
        /// found in the failureInfo property. Possible values include:
        /// 'success', 'failure'
        /// </remarks>
        [JsonProperty(PropertyName = "result")]
        public TaskExecutionResult? Result { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FailureInfo != null)
            {
                FailureInfo.Validate();
            }
        }
    }
}
