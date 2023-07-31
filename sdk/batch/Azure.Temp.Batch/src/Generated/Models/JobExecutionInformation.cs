// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Temp.Batch.Models
{
    /// <summary> Contains information about the execution of a Job in the Azure Batch service. </summary>
    public partial class JobExecutionInformation
    {
        /// <summary> Initializes a new instance of JobExecutionInformation. </summary>
        /// <param name="startTime"> This is the time at which the Job was created. </param>
        internal JobExecutionInformation(DateTimeOffset startTime)
        {
            StartTime = startTime;
        }

        /// <summary> Initializes a new instance of JobExecutionInformation. </summary>
        /// <param name="startTime"> This is the time at which the Job was created. </param>
        /// <param name="endTime"> This property is set only if the Job is in the completed state. </param>
        /// <param name="poolId"> This element contains the actual Pool where the Job is assigned. When you get Job details from the service, they also contain a poolInfo element, which contains the Pool configuration data from when the Job was added or updated. That poolInfo element may also contain a poolId element. If it does, the two IDs are the same. If it does not, it means the Job ran on an auto Pool, and this property contains the ID of that auto Pool. </param>
        /// <param name="schedulingError"> This property is not set if there was no error starting the Job. </param>
        /// <param name="terminateReason"> This property is set only if the Job is in the completed state. If the Batch service terminates the Job, it sets the reason as follows: JMComplete - the Job Manager Task completed, and killJobOnCompletion was set to true. MaxWallClockTimeExpiry - the Job reached its maxWallClockTime constraint. TerminateJobSchedule - the Job ran as part of a schedule, and the schedule terminated. AllTasksComplete - the Job's onAllTasksComplete attribute is set to terminatejob, and all Tasks in the Job are complete. TaskFailed - the Job's onTaskFailure attribute is set to performExitOptionsJobAction, and a Task in the Job failed with an exit condition that specified a jobAction of terminatejob. Any other string is a user-defined reason specified in a call to the 'Terminate a Job' operation. </param>
        internal JobExecutionInformation(DateTimeOffset startTime, DateTimeOffset? endTime, string poolId, JobSchedulingError schedulingError, string terminateReason)
        {
            StartTime = startTime;
            EndTime = endTime;
            PoolId = poolId;
            SchedulingError = schedulingError;
            TerminateReason = terminateReason;
        }

        /// <summary> This is the time at which the Job was created. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> This property is set only if the Job is in the completed state. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> This element contains the actual Pool where the Job is assigned. When you get Job details from the service, they also contain a poolInfo element, which contains the Pool configuration data from when the Job was added or updated. That poolInfo element may also contain a poolId element. If it does, the two IDs are the same. If it does not, it means the Job ran on an auto Pool, and this property contains the ID of that auto Pool. </summary>
        public string PoolId { get; }
        /// <summary> This property is not set if there was no error starting the Job. </summary>
        public JobSchedulingError SchedulingError { get; }
        /// <summary> This property is set only if the Job is in the completed state. If the Batch service terminates the Job, it sets the reason as follows: JMComplete - the Job Manager Task completed, and killJobOnCompletion was set to true. MaxWallClockTimeExpiry - the Job reached its maxWallClockTime constraint. TerminateJobSchedule - the Job ran as part of a schedule, and the schedule terminated. AllTasksComplete - the Job's onAllTasksComplete attribute is set to terminatejob, and all Tasks in the Job are complete. TaskFailed - the Job's onTaskFailure attribute is set to performExitOptionsJobAction, and a Task in the Job failed with an exit condition that specified a jobAction of terminatejob. Any other string is a user-defined reason specified in a call to the 'Terminate a Job' operation. </summary>
        public string TerminateReason { get; }
    }
}
