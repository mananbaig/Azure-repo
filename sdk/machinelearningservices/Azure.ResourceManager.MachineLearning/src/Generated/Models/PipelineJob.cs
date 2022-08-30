// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Pipeline Job definition: defines generic to MFE attributes. </summary>
    public partial class PipelineJob : MachineLearningJobProperties
    {
        /// <summary> Initializes a new instance of PipelineJob. </summary>
        public PipelineJob()
        {
            Inputs = new ChangeTrackingDictionary<string, JobInput>();
            Jobs = new ChangeTrackingDictionary<string, BinaryData>();
            Outputs = new ChangeTrackingDictionary<string, JobOutput>();
            JobType = JobType.Pipeline;
        }

        /// <summary> Initializes a new instance of PipelineJob. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="computeId"> ARM resource ID of the compute resource. </param>
        /// <param name="displayName"> Display name of job. </param>
        /// <param name="experimentName"> The name of the experiment the job belongs to. If not set, the job is placed in the &quot;Default&quot; experiment. </param>
        /// <param name="identity">
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// Please note <see cref="IdentityConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlToken"/>, <see cref="ManagedIdentity"/> and <see cref="UserIdentity"/>.
        /// </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="jobType"> [Required] Specifies the type of job. </param>
        /// <param name="schedule">
        /// Schedule definition of job.
        /// If no schedule is provided, the job is run once and immediately after submission.
        /// Please note <see cref="ScheduleBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CronSchedule"/> and <see cref="RecurrenceSchedule"/>.
        /// </param>
        /// <param name="services">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="status"> Status of the job. </param>
        /// <param name="inputs">
        /// Inputs for the pipeline job.
        /// Please note <see cref="JobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CustomModelJobInput"/>, <see cref="LiteralJobInput"/>, <see cref="MLFlowModelJobInput"/>, <see cref="MLTableJobInput"/>, <see cref="TritonModelJobInput"/>, <see cref="UriFileJobInput"/> and <see cref="UriFolderJobInput"/>.
        /// </param>
        /// <param name="jobs"> Jobs construct the Pipeline Job. </param>
        /// <param name="outputs">
        /// Outputs for the pipeline job
        /// Please note <see cref="JobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CustomModelJobOutput"/>, <see cref="MLFlowModelJobOutput"/>, <see cref="MLTableJobOutput"/>, <see cref="TritonModelJobOutput"/>, <see cref="UriFileJobOutput"/> and <see cref="UriFolderJobOutput"/>.
        /// </param>
        /// <param name="settings"> Pipeline settings, for things like ContinueRunOnStepFailure etc. </param>
        internal PipelineJob(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, string computeId, string displayName, string experimentName, IdentityConfiguration identity, bool? isArchived, JobType jobType, ScheduleBase schedule, IDictionary<string, JobService> services, JobStatus? status, IDictionary<string, JobInput> inputs, IDictionary<string, BinaryData> jobs, IDictionary<string, JobOutput> outputs, BinaryData settings) : base(description, properties, tags, computeId, displayName, experimentName, identity, isArchived, jobType, schedule, services, status)
        {
            Inputs = inputs;
            Jobs = jobs;
            Outputs = outputs;
            Settings = settings;
            JobType = jobType;
        }

        /// <summary>
        /// Inputs for the pipeline job.
        /// Please note <see cref="JobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CustomModelJobInput"/>, <see cref="LiteralJobInput"/>, <see cref="MLFlowModelJobInput"/>, <see cref="MLTableJobInput"/>, <see cref="TritonModelJobInput"/>, <see cref="UriFileJobInput"/> and <see cref="UriFolderJobInput"/>.
        /// </summary>
        public IDictionary<string, JobInput> Inputs { get; set; }
        /// <summary> Jobs construct the Pipeline Job. </summary>
        public IDictionary<string, BinaryData> Jobs { get; set; }
        /// <summary>
        /// Outputs for the pipeline job
        /// Please note <see cref="JobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CustomModelJobOutput"/>, <see cref="MLFlowModelJobOutput"/>, <see cref="MLTableJobOutput"/>, <see cref="TritonModelJobOutput"/>, <see cref="UriFileJobOutput"/> and <see cref="UriFolderJobOutput"/>.
        /// </summary>
        public IDictionary<string, JobOutput> Outputs { get; set; }
        /// <summary>
        /// Pipeline settings, for things like ContinueRunOnStepFailure etc.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Settings { get; set; }
    }
}
