// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Job.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Job : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        public Job()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        /// <param name="status">Current status of the job. Possible values
        /// include: 'Invalid', 'Running', 'Succeeded', 'Failed', 'Canceled',
        /// 'Paused', 'Scheduled'</param>
        /// <param name="percentComplete">The percentage of the job that is
        /// already complete</param>
        /// <param name="jobType">Type of the job. Possible values include:
        /// 'Backup', 'Clone', 'Failover', 'DownloadUpdates',
        /// 'InstallUpdates'</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="startTime">The UTC time at which the job was
        /// started</param>
        /// <param name="endTime">The UTC time at which the job
        /// completed</param>
        /// <param name="error">The Error details.</param>
        /// <param name="targetId">Id of the object that is created by the
        /// job</param>
        /// <param name="entityId">The entity identifier for which the job
        /// ran.</param>
        /// <param name="entityType">The entity type for which the job
        /// ran.</param>
        /// <param name="jobStages">The job stages.</param>
        /// <param name="deviceId">The device id in which the job is currently
        /// running</param>
        /// <param name="isCancellable">Represents whether the job is
        /// cancellable or not</param>
        /// <param name="stats">stats properties for the job</param>
        /// <param name="targetType">The target type of the backup. Possible
        /// values include: 'FileServer', 'DiskServer'</param>
        /// <param name="sourceDeviceId">The source device identifier of the
        /// failover job.</param>
        /// <param name="backupPointInTime">The time of the backup used for the
        /// failover.</param>
        /// <param name="downloadProgress">The download progress.</param>
        /// <param name="installProgress">The install progress.</param>
        public Job(JobStatus status, int percentComplete, JobType jobType, string id = default(string), string name = default(string), string type = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), JobErrorDetails error = default(JobErrorDetails), string targetId = default(string), string entityId = default(string), string entityType = default(string), IList<JobStage> jobStages = default(IList<JobStage>), string deviceId = default(string), bool? isCancellable = default(bool?), JobStats stats = default(JobStats), TargetType? targetType = default(TargetType?), string sourceDeviceId = default(string), System.DateTime? backupPointInTime = default(System.DateTime?), UpdateDownloadProgress downloadProgress = default(UpdateDownloadProgress), UpdateInstallProgress installProgress = default(UpdateInstallProgress))
            : base(id, name, type)
        {
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            PercentComplete = percentComplete;
            Error = error;
            JobType = jobType;
            TargetId = targetId;
            EntityId = entityId;
            EntityType = entityType;
            JobStages = jobStages;
            DeviceId = deviceId;
            IsCancellable = isCancellable;
            Stats = stats;
            TargetType = targetType;
            SourceDeviceId = sourceDeviceId;
            BackupPointInTime = backupPointInTime;
            DownloadProgress = downloadProgress;
            InstallProgress = installProgress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets current status of the job. Possible values include:
        /// 'Invalid', 'Running', 'Succeeded', 'Failed', 'Canceled', 'Paused',
        /// 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public JobStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the UTC time at which the job was started
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the UTC time at which the job completed
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the percentage of the job that is already complete
        /// </summary>
        [JsonProperty(PropertyName = "percentComplete")]
        public int PercentComplete { get; set; }

        /// <summary>
        /// Gets or sets the Error details.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public JobErrorDetails Error { get; set; }

        /// <summary>
        /// Gets or sets type of the job. Possible values include: 'Backup',
        /// 'Clone', 'Failover', 'DownloadUpdates', 'InstallUpdates'
        /// </summary>
        [JsonProperty(PropertyName = "properties.jobType")]
        public JobType JobType { get; set; }

        /// <summary>
        /// Gets or sets id of the object that is created by the job
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetId")]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or sets the entity identifier for which the job ran.
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityId")]
        public string EntityId { get; set; }

        /// <summary>
        /// Gets or sets the entity type for which the job ran.
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityType")]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or sets the job stages.
        /// </summary>
        [JsonProperty(PropertyName = "properties.jobStages")]
        public IList<JobStage> JobStages { get; set; }

        /// <summary>
        /// Gets or sets the device id in which the job is currently running
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets represents whether the job is cancellable or not
        /// </summary>
        [JsonProperty(PropertyName = "properties.isCancellable")]
        public bool? IsCancellable { get; set; }

        /// <summary>
        /// Gets or sets stats properties for the job
        /// </summary>
        [JsonProperty(PropertyName = "properties.stats")]
        public JobStats Stats { get; set; }

        /// <summary>
        /// Gets or sets the target type of the backup. Possible values
        /// include: 'FileServer', 'DiskServer'
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetType")]
        public TargetType? TargetType { get; set; }

        /// <summary>
        /// Gets or sets the source device identifier of the failover job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceDeviceId")]
        public string SourceDeviceId { get; set; }

        /// <summary>
        /// Gets or sets the time of the backup used for the failover.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupPointInTime")]
        public System.DateTime? BackupPointInTime { get; set; }

        /// <summary>
        /// Gets or sets the download progress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.downloadProgress")]
        public UpdateDownloadProgress DownloadProgress { get; set; }

        /// <summary>
        /// Gets or sets the install progress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.installProgress")]
        public UpdateInstallProgress InstallProgress { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Error != null)
            {
                Error.Validate();
            }
            if (JobStages != null)
            {
                foreach (var element in JobStages)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
