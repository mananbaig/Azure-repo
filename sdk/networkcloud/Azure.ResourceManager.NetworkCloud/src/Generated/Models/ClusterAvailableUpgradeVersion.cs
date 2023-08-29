// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ClusterAvailableUpgradeVersion represents the various cluster upgrade parameters. </summary>
    public partial class ClusterAvailableUpgradeVersion
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ClusterAvailableUpgradeVersion"/>. </summary>
        internal ClusterAvailableUpgradeVersion()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClusterAvailableUpgradeVersion"/>. </summary>
        /// <param name="controlImpact"> The indicator of whether the control plane will be impacted during the upgrade. </param>
        /// <param name="expectedDuration"> The expected duration needed for this upgrade. </param>
        /// <param name="impactDescription"> The impact description including the specific details and release notes. </param>
        /// <param name="supportExpireOn"> The last date the version of the platform is supported. </param>
        /// <param name="targetClusterVersion"> The target version this cluster will be upgraded to. </param>
        /// <param name="workloadImpact"> The indicator of whether the workload will be impacted during the upgrade. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterAvailableUpgradeVersion(ControlImpact? controlImpact, string expectedDuration, string impactDescription, DateTimeOffset? supportExpireOn, string targetClusterVersion, WorkloadImpact? workloadImpact, Dictionary<string, BinaryData> rawData)
        {
            ControlImpact = controlImpact;
            ExpectedDuration = expectedDuration;
            ImpactDescription = impactDescription;
            SupportExpireOn = supportExpireOn;
            TargetClusterVersion = targetClusterVersion;
            WorkloadImpact = workloadImpact;
            _rawData = rawData;
        }

        /// <summary> The indicator of whether the control plane will be impacted during the upgrade. </summary>
        public ControlImpact? ControlImpact { get; }
        /// <summary> The expected duration needed for this upgrade. </summary>
        public string ExpectedDuration { get; }
        /// <summary> The impact description including the specific details and release notes. </summary>
        public string ImpactDescription { get; }
        /// <summary> The last date the version of the platform is supported. </summary>
        public DateTimeOffset? SupportExpireOn { get; }
        /// <summary> The target version this cluster will be upgraded to. </summary>
        public string TargetClusterVersion { get; }
        /// <summary> The indicator of whether the workload will be impacted during the upgrade. </summary>
        public WorkloadImpact? WorkloadImpact { get; }
    }
}
