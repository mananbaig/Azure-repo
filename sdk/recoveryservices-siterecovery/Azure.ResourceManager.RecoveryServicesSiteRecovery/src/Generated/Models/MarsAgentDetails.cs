// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Mars agent details. </summary>
    public partial class MarsAgentDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MarsAgentDetails"/>. </summary>
        internal MarsAgentDetails()
        {
            HealthErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
        }

        /// <summary> Initializes a new instance of <see cref="MarsAgentDetails"/>. </summary>
        /// <param name="id"> The Mars agent Id. </param>
        /// <param name="name"> The Mars agent name. </param>
        /// <param name="biosId"> The Mars agent Bios Id. </param>
        /// <param name="fabricObjectId"> The fabric object Id. </param>
        /// <param name="fqdn"> The Mars agent Fqdn. </param>
        /// <param name="version"> The version. </param>
        /// <param name="lastHeartbeatReceivedOn"> The last heartbeat received from the Mars agent. </param>
        /// <param name="health"> The health of the Mars agent. </param>
        /// <param name="healthErrors"> The health errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MarsAgentDetails(string id, string name, string biosId, ResourceIdentifier fabricObjectId, string fqdn, string version, DateTimeOffset? lastHeartbeatReceivedOn, SiteRecoveryProtectionHealth? health, IReadOnlyList<SiteRecoveryHealthError> healthErrors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            BiosId = biosId;
            FabricObjectId = fabricObjectId;
            Fqdn = fqdn;
            Version = version;
            LastHeartbeatReceivedOn = lastHeartbeatReceivedOn;
            Health = health;
            HealthErrors = healthErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Mars agent Id. </summary>
        public string Id { get; }
        /// <summary> The Mars agent name. </summary>
        public string Name { get; }
        /// <summary> The Mars agent Bios Id. </summary>
        public string BiosId { get; }
        /// <summary> The fabric object Id. </summary>
        public ResourceIdentifier FabricObjectId { get; }
        /// <summary> The Mars agent Fqdn. </summary>
        public string Fqdn { get; }
        /// <summary> The version. </summary>
        public string Version { get; }
        /// <summary> The last heartbeat received from the Mars agent. </summary>
        public DateTimeOffset? LastHeartbeatReceivedOn { get; }
        /// <summary> The health of the Mars agent. </summary>
        public SiteRecoveryProtectionHealth? Health { get; }
        /// <summary> The health errors. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> HealthErrors { get; }
    }
}
