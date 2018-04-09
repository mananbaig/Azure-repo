// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details of the Process Server.
    /// </summary>
    public partial class ProcessServer
    {
        /// <summary>
        /// Initializes a new instance of the ProcessServer class.
        /// </summary>
        public ProcessServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProcessServer class.
        /// </summary>
        /// <param name="friendlyName">The Process Server's friendly
        /// name.</param>
        /// <param name="id">The Process Server Id.</param>
        /// <param name="ipAddress">The IP address of the server.</param>
        /// <param name="osType">The OS type of the server.</param>
        /// <param name="agentVersion">The version of the scout component on
        /// the server.</param>
        /// <param name="lastHeartbeat">The last heartbeat received from the
        /// server.</param>
        /// <param name="versionStatus">Version status</param>
        /// <param name="mobilityServiceUpdates">The list of the mobility
        /// service updates available on the Process Server.</param>
        /// <param name="hostId">The agent generated Id.</param>
        /// <param name="machineCount">The servers configured with this
        /// PS.</param>
        /// <param name="replicationPairCount">The number of replication pairs
        /// configured in this PS.</param>
        /// <param name="systemLoad">The percentage of the system load.</param>
        /// <param name="systemLoadStatus">The system load status.</param>
        /// <param name="cpuLoad">The percentage of the CPU load.</param>
        /// <param name="cpuLoadStatus">The CPU load status.</param>
        /// <param name="totalMemoryInBytes">The total memory.</param>
        /// <param name="availableMemoryInBytes">The available memory.</param>
        /// <param name="memoryUsageStatus">The memory usage status.</param>
        /// <param name="totalSpaceInBytes">The total space.</param>
        /// <param name="availableSpaceInBytes">The available space.</param>
        /// <param name="spaceUsageStatus">The space usage status.</param>
        /// <param name="psServiceStatus">The PS service status.</param>
        /// <param name="sslCertExpiryDate">The PS SSL cert expiry
        /// date.</param>
        /// <param name="sslCertExpiryRemainingDays">CS SSL cert expiry
        /// date.</param>
        /// <param name="osVersion">OS Version of the process server. Note:
        /// This will get populated if user has CS version greater than
        /// 9.12.0.0.</param>
        /// <param name="healthErrors">Health errors.</param>
        /// <param name="agentExpiryDate">Agent expiry date.</param>
        /// <param name="agentVersionDetails">The agent version
        /// details.</param>
        public ProcessServer(string friendlyName = default(string), string id = default(string), string ipAddress = default(string), string osType = default(string), string agentVersion = default(string), System.DateTime? lastHeartbeat = default(System.DateTime?), string versionStatus = default(string), IList<MobilityServiceUpdate> mobilityServiceUpdates = default(IList<MobilityServiceUpdate>), string hostId = default(string), string machineCount = default(string), string replicationPairCount = default(string), string systemLoad = default(string), string systemLoadStatus = default(string), string cpuLoad = default(string), string cpuLoadStatus = default(string), long? totalMemoryInBytes = default(long?), long? availableMemoryInBytes = default(long?), string memoryUsageStatus = default(string), long? totalSpaceInBytes = default(long?), long? availableSpaceInBytes = default(long?), string spaceUsageStatus = default(string), string psServiceStatus = default(string), System.DateTime? sslCertExpiryDate = default(System.DateTime?), int? sslCertExpiryRemainingDays = default(int?), string osVersion = default(string), IList<HealthError> healthErrors = default(IList<HealthError>), System.DateTime? agentExpiryDate = default(System.DateTime?), VersionDetails agentVersionDetails = default(VersionDetails))
        {
            FriendlyName = friendlyName;
            Id = id;
            IpAddress = ipAddress;
            OsType = osType;
            AgentVersion = agentVersion;
            LastHeartbeat = lastHeartbeat;
            VersionStatus = versionStatus;
            MobilityServiceUpdates = mobilityServiceUpdates;
            HostId = hostId;
            MachineCount = machineCount;
            ReplicationPairCount = replicationPairCount;
            SystemLoad = systemLoad;
            SystemLoadStatus = systemLoadStatus;
            CpuLoad = cpuLoad;
            CpuLoadStatus = cpuLoadStatus;
            TotalMemoryInBytes = totalMemoryInBytes;
            AvailableMemoryInBytes = availableMemoryInBytes;
            MemoryUsageStatus = memoryUsageStatus;
            TotalSpaceInBytes = totalSpaceInBytes;
            AvailableSpaceInBytes = availableSpaceInBytes;
            SpaceUsageStatus = spaceUsageStatus;
            PsServiceStatus = psServiceStatus;
            SslCertExpiryDate = sslCertExpiryDate;
            SslCertExpiryRemainingDays = sslCertExpiryRemainingDays;
            OsVersion = osVersion;
            HealthErrors = healthErrors;
            AgentExpiryDate = agentExpiryDate;
            AgentVersionDetails = agentVersionDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Process Server's friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the Process Server Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the server.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the OS type of the server.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the version of the scout component on the server.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets the last heartbeat received from the server.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeat")]
        public System.DateTime? LastHeartbeat { get; set; }

        /// <summary>
        /// Gets or sets version status
        /// </summary>
        [JsonProperty(PropertyName = "versionStatus")]
        public string VersionStatus { get; set; }

        /// <summary>
        /// Gets or sets the list of the mobility service updates available on
        /// the Process Server.
        /// </summary>
        [JsonProperty(PropertyName = "mobilityServiceUpdates")]
        public IList<MobilityServiceUpdate> MobilityServiceUpdates { get; set; }

        /// <summary>
        /// Gets or sets the agent generated Id.
        /// </summary>
        [JsonProperty(PropertyName = "hostId")]
        public string HostId { get; set; }

        /// <summary>
        /// Gets or sets the servers configured with this PS.
        /// </summary>
        [JsonProperty(PropertyName = "machineCount")]
        public string MachineCount { get; set; }

        /// <summary>
        /// Gets or sets the number of replication pairs configured in this PS.
        /// </summary>
        [JsonProperty(PropertyName = "replicationPairCount")]
        public string ReplicationPairCount { get; set; }

        /// <summary>
        /// Gets or sets the percentage of the system load.
        /// </summary>
        [JsonProperty(PropertyName = "systemLoad")]
        public string SystemLoad { get; set; }

        /// <summary>
        /// Gets or sets the system load status.
        /// </summary>
        [JsonProperty(PropertyName = "systemLoadStatus")]
        public string SystemLoadStatus { get; set; }

        /// <summary>
        /// Gets or sets the percentage of the CPU load.
        /// </summary>
        [JsonProperty(PropertyName = "cpuLoad")]
        public string CpuLoad { get; set; }

        /// <summary>
        /// Gets or sets the CPU load status.
        /// </summary>
        [JsonProperty(PropertyName = "cpuLoadStatus")]
        public string CpuLoadStatus { get; set; }

        /// <summary>
        /// Gets or sets the total memory.
        /// </summary>
        [JsonProperty(PropertyName = "totalMemoryInBytes")]
        public long? TotalMemoryInBytes { get; set; }

        /// <summary>
        /// Gets or sets the available memory.
        /// </summary>
        [JsonProperty(PropertyName = "availableMemoryInBytes")]
        public long? AvailableMemoryInBytes { get; set; }

        /// <summary>
        /// Gets or sets the memory usage status.
        /// </summary>
        [JsonProperty(PropertyName = "memoryUsageStatus")]
        public string MemoryUsageStatus { get; set; }

        /// <summary>
        /// Gets or sets the total space.
        /// </summary>
        [JsonProperty(PropertyName = "totalSpaceInBytes")]
        public long? TotalSpaceInBytes { get; set; }

        /// <summary>
        /// Gets or sets the available space.
        /// </summary>
        [JsonProperty(PropertyName = "availableSpaceInBytes")]
        public long? AvailableSpaceInBytes { get; set; }

        /// <summary>
        /// Gets or sets the space usage status.
        /// </summary>
        [JsonProperty(PropertyName = "spaceUsageStatus")]
        public string SpaceUsageStatus { get; set; }

        /// <summary>
        /// Gets or sets the PS service status.
        /// </summary>
        [JsonProperty(PropertyName = "psServiceStatus")]
        public string PsServiceStatus { get; set; }

        /// <summary>
        /// Gets or sets the PS SSL cert expiry date.
        /// </summary>
        [JsonProperty(PropertyName = "sslCertExpiryDate")]
        public System.DateTime? SslCertExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets CS SSL cert expiry date.
        /// </summary>
        [JsonProperty(PropertyName = "sslCertExpiryRemainingDays")]
        public int? SslCertExpiryRemainingDays { get; set; }

        /// <summary>
        /// Gets or sets OS Version of the process server. Note: This will get
        /// populated if user has CS version greater than 9.12.0.0.
        /// </summary>
        [JsonProperty(PropertyName = "osVersion")]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or sets health errors.
        /// </summary>
        [JsonProperty(PropertyName = "healthErrors")]
        public IList<HealthError> HealthErrors { get; set; }

        /// <summary>
        /// Gets or sets agent expiry date.
        /// </summary>
        [JsonProperty(PropertyName = "agentExpiryDate")]
        public System.DateTime? AgentExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets the agent version details.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersionDetails")]
        public VersionDetails AgentVersionDetails { get; set; }

    }
}
