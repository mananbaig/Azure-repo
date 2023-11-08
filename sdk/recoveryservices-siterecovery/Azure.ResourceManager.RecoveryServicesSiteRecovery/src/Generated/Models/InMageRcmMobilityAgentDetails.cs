// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm mobility agent details. </summary>
    public partial class InMageRcmMobilityAgentDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InMageRcmMobilityAgentDetails"/>. </summary>
        internal InMageRcmMobilityAgentDetails()
        {
            ReasonsBlockingUpgrade = new ChangeTrackingList<AgentUpgradeBlockedReason>();
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmMobilityAgentDetails"/>. </summary>
        /// <param name="version"> The agent version. </param>
        /// <param name="latestVersion"> The latest agent version available. </param>
        /// <param name="latestAgentReleaseDate"> The latest agent version release date. </param>
        /// <param name="driverVersion"> The driver version. </param>
        /// <param name="latestUpgradableVersionWithoutReboot"> The latest upgradeable version available without reboot. </param>
        /// <param name="agentVersionExpireOn"> The agent version expiry date. </param>
        /// <param name="driverVersionExpireOn"> The driver version expiry date. </param>
        /// <param name="lastHeartbeatReceivedOn"> The time of the last heartbeat received from the agent. </param>
        /// <param name="reasonsBlockingUpgrade"> The whether update is possible or not. </param>
        /// <param name="isUpgradeable"> A value indicating whether agent is upgradeable or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmMobilityAgentDetails(string version, string latestVersion, string latestAgentReleaseDate, string driverVersion, string latestUpgradableVersionWithoutReboot, DateTimeOffset? agentVersionExpireOn, DateTimeOffset? driverVersionExpireOn, DateTimeOffset? lastHeartbeatReceivedOn, IReadOnlyList<AgentUpgradeBlockedReason> reasonsBlockingUpgrade, string isUpgradeable, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Version = version;
            LatestVersion = latestVersion;
            LatestAgentReleaseDate = latestAgentReleaseDate;
            DriverVersion = driverVersion;
            LatestUpgradableVersionWithoutReboot = latestUpgradableVersionWithoutReboot;
            AgentVersionExpireOn = agentVersionExpireOn;
            DriverVersionExpireOn = driverVersionExpireOn;
            LastHeartbeatReceivedOn = lastHeartbeatReceivedOn;
            ReasonsBlockingUpgrade = reasonsBlockingUpgrade;
            IsUpgradeable = isUpgradeable;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The agent version. </summary>
        public string Version { get; }
        /// <summary> The latest agent version available. </summary>
        public string LatestVersion { get; }
        /// <summary> The latest agent version release date. </summary>
        public string LatestAgentReleaseDate { get; }
        /// <summary> The driver version. </summary>
        public string DriverVersion { get; }
        /// <summary> The latest upgradeable version available without reboot. </summary>
        public string LatestUpgradableVersionWithoutReboot { get; }
        /// <summary> The agent version expiry date. </summary>
        public DateTimeOffset? AgentVersionExpireOn { get; }
        /// <summary> The driver version expiry date. </summary>
        public DateTimeOffset? DriverVersionExpireOn { get; }
        /// <summary> The time of the last heartbeat received from the agent. </summary>
        public DateTimeOffset? LastHeartbeatReceivedOn { get; }
        /// <summary> The whether update is possible or not. </summary>
        public IReadOnlyList<AgentUpgradeBlockedReason> ReasonsBlockingUpgrade { get; }
        /// <summary> A value indicating whether agent is upgradeable or not. </summary>
        public string IsUpgradeable { get; }
    }
}
