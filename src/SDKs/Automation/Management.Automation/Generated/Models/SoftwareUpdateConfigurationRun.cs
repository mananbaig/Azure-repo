// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Software update configuration Run properties.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SoftwareUpdateConfigurationRun
    {
        /// <summary>
        /// Initializes a new instance of the SoftwareUpdateConfigurationRun
        /// class.
        /// </summary>
        public SoftwareUpdateConfigurationRun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SoftwareUpdateConfigurationRun
        /// class.
        /// </summary>
        /// <param name="name">Name of the software update configuration
        /// run.</param>
        /// <param name="id">Resource Id of the software update configuration
        /// run</param>
        /// <param name="softwareUpdateConfiguration">software update
        /// configuration triggered this run</param>
        /// <param name="status">Status of the software update configuration
        /// run.</param>
        /// <param name="configuredDuration">Configured duration for the
        /// software update configuration run.</param>
        /// <param name="osType">Operating system target of the software update
        /// configuration triggered this run</param>
        /// <param name="startTime">Start time of the software update
        /// configuration run.</param>
        /// <param name="endTime">End time of the software update configuration
        /// run.</param>
        /// <param name="computerCount">Number of computers in the software
        /// update configuration run.</param>
        /// <param name="failedCount">Number of computers with failed
        /// status.</param>
        /// <param name="creationTime">Creation time of theresource, which only
        /// appears in the response.</param>
        /// <param name="createdBy">CreatedBy property, which only appears in
        /// the response.</param>
        /// <param name="lastModifiedTime">Last time resource was modified,
        /// which only appears in the response.</param>
        /// <param name="lastModifiedBy">LastModifiedBy property, which only
        /// appears in the response.</param>
        /// <param name="tasks">Software update configuration tasks triggered
        /// in this run</param>
        public SoftwareUpdateConfigurationRun(string name = default(string), string id = default(string), UpdateConfigurationNavigation softwareUpdateConfiguration = default(UpdateConfigurationNavigation), string status = default(string), string configuredDuration = default(string), string osType = default(string), System.DateTimeOffset startTime = default(System.DateTimeOffset), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), int? computerCount = default(int?), int? failedCount = default(int?), System.DateTimeOffset creationTime = default(System.DateTimeOffset), string createdBy = default(string), System.DateTimeOffset lastModifiedTime = default(System.DateTimeOffset), string lastModifiedBy = default(string), SoftareUpdateConfigurationRunTasks tasks = default(SoftareUpdateConfigurationRunTasks))
        {
            Name = name;
            Id = id;
            SoftwareUpdateConfiguration = softwareUpdateConfiguration;
            Status = status;
            ConfiguredDuration = configuredDuration;
            OsType = osType;
            StartTime = startTime;
            EndTime = endTime;
            ComputerCount = computerCount;
            FailedCount = failedCount;
            CreationTime = creationTime;
            CreatedBy = createdBy;
            LastModifiedTime = lastModifiedTime;
            LastModifiedBy = lastModifiedBy;
            Tasks = tasks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the software update configuration run.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource Id of the software update configuration run
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets software update configuration triggered this run
        /// </summary>
        [JsonProperty(PropertyName = "properties.softwareUpdateConfiguration")]
        public UpdateConfigurationNavigation SoftwareUpdateConfiguration { get; set; }

        /// <summary>
        /// Gets status of the software update configuration run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets configured duration for the software update configuration run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.configuredDuration")]
        public string ConfiguredDuration { get; private set; }

        /// <summary>
        /// Gets operating system target of the software update configuration
        /// triggered this run
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public string OsType { get; private set; }

        /// <summary>
        /// Gets start time of the software update configuration run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTimeOffset StartTime { get; private set; }

        /// <summary>
        /// Gets end time of the software update configuration run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTimeOffset? EndTime { get; private set; }

        /// <summary>
        /// Gets number of computers in the software update configuration run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.computerCount")]
        public int? ComputerCount { get; private set; }

        /// <summary>
        /// Gets number of computers with failed status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failedCount")]
        public int? FailedCount { get; private set; }

        /// <summary>
        /// Gets creation time of theresource, which only appears in the
        /// response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTimeOffset CreationTime { get; private set; }

        /// <summary>
        /// Gets createdBy property, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdBy")]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Gets last time resource was modified, which only appears in the
        /// response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTimeOffset LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets lastModifiedBy property, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedBy")]
        public string LastModifiedBy { get; private set; }

        /// <summary>
        /// Gets or sets software update configuration tasks triggered in this
        /// run
        /// </summary>
        [JsonProperty(PropertyName = "properties.tasks")]
        public SoftareUpdateConfigurationRunTasks Tasks { get; set; }

    }
}
