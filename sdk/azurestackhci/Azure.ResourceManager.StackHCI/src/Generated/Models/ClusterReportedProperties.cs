// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StackHCI.Models
{
    /// <summary> Properties reported by cluster agent. </summary>
    public partial class ClusterReportedProperties
    {
        /// <summary> Initializes a new instance of ClusterReportedProperties. </summary>
        internal ClusterReportedProperties()
        {
            Nodes = new ChangeTrackingList<ClusterNode>();
        }

        /// <summary> Initializes a new instance of ClusterReportedProperties. </summary>
        /// <param name="clusterName"> Name of the on-prem cluster connected to this resource. </param>
        /// <param name="clusterId"> Unique id generated by the on-prem cluster. </param>
        /// <param name="clusterVersion"> Version of the cluster software. </param>
        /// <param name="nodes"> List of nodes reported by the cluster. </param>
        /// <param name="lastUpdated"> Last time the cluster reported the data. </param>
        /// <param name="imdsAttestation"> IMDS attestation status of the cluster. </param>
        /// <param name="diagnosticLevel"> Level of diagnostic data emitted by the cluster. </param>
        internal ClusterReportedProperties(string clusterName, string clusterId, string clusterVersion, IReadOnlyList<ClusterNode> nodes, DateTimeOffset? lastUpdated, ImdsAttestation? imdsAttestation, DiagnosticLevel? diagnosticLevel)
        {
            ClusterName = clusterName;
            ClusterId = clusterId;
            ClusterVersion = clusterVersion;
            Nodes = nodes;
            LastUpdated = lastUpdated;
            ImdsAttestation = imdsAttestation;
            DiagnosticLevel = diagnosticLevel;
        }

        /// <summary> Name of the on-prem cluster connected to this resource. </summary>
        public string ClusterName { get; }
        /// <summary> Unique id generated by the on-prem cluster. </summary>
        public string ClusterId { get; }
        /// <summary> Version of the cluster software. </summary>
        public string ClusterVersion { get; }
        /// <summary> List of nodes reported by the cluster. </summary>
        public IReadOnlyList<ClusterNode> Nodes { get; }
        /// <summary> Last time the cluster reported the data. </summary>
        public DateTimeOffset? LastUpdated { get; }
        /// <summary> IMDS attestation status of the cluster. </summary>
        public ImdsAttestation? ImdsAttestation { get; }
        /// <summary> Level of diagnostic data emitted by the cluster. </summary>
        public DiagnosticLevel? DiagnosticLevel { get; }
    }
}
