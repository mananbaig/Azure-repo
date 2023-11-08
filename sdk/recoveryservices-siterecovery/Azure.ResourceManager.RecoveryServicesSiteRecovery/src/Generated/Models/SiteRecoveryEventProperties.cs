// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The properties of a monitoring event. </summary>
    public partial class SiteRecoveryEventProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryEventProperties"/>. </summary>
        internal SiteRecoveryEventProperties()
        {
            HealthErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryEventProperties"/>. </summary>
        /// <param name="eventCode"> The Id of the monitoring event. </param>
        /// <param name="description"> The event name. </param>
        /// <param name="eventType"> The type of the event. for example: VM Health, Server Health, Job Failure etc. </param>
        /// <param name="affectedObjectFriendlyName"> The friendly name of the source of the event on which it is raised (for example, VM, VMM etc). </param>
        /// <param name="affectedObjectCorrelationId"> The affected object correlationId for the event. </param>
        /// <param name="severity"> The severity of the event. </param>
        /// <param name="occurredOn"> The time of occurrence of the event. </param>
        /// <param name="fabricId"> The ARM ID of the fabric. </param>
        /// <param name="providerSpecificDetails">
        /// The provider specific settings.
        /// Please note <see cref="SiteRecoveryEventProviderSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AEventDetails"/>, <see cref="HyperVReplica2012EventDetails"/>, <see cref="HyperVReplica2012R2EventDetails"/>, <see cref="HyperVReplicaAzureEventDetails"/>, <see cref="HyperVReplicaBaseEventDetails"/>, <see cref="InMageAzureV2EventDetails"/>, <see cref="InMageRcmEventDetails"/>, <see cref="InMageRcmFailbackEventDetails"/> and <see cref="VMwareCbtEventDetails"/>.
        /// </param>
        /// <param name="eventSpecificDetails">
        /// The event specific settings.
        /// Please note <see cref="SiteRecoveryEventSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SiteRecoveryJobStatusEventDetails"/>.
        /// </param>
        /// <param name="healthErrors"> The list of errors / warnings capturing details associated with the issue(s). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryEventProperties(string eventCode, string description, string eventType, string affectedObjectFriendlyName, string affectedObjectCorrelationId, string severity, DateTimeOffset? occurredOn, ResourceIdentifier fabricId, SiteRecoveryEventProviderSpecificDetails providerSpecificDetails, SiteRecoveryEventSpecificDetails eventSpecificDetails, IReadOnlyList<SiteRecoveryHealthError> healthErrors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EventCode = eventCode;
            Description = description;
            EventType = eventType;
            AffectedObjectFriendlyName = affectedObjectFriendlyName;
            AffectedObjectCorrelationId = affectedObjectCorrelationId;
            Severity = severity;
            OccurredOn = occurredOn;
            FabricId = fabricId;
            ProviderSpecificDetails = providerSpecificDetails;
            EventSpecificDetails = eventSpecificDetails;
            HealthErrors = healthErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Id of the monitoring event. </summary>
        public string EventCode { get; }
        /// <summary> The event name. </summary>
        public string Description { get; }
        /// <summary> The type of the event. for example: VM Health, Server Health, Job Failure etc. </summary>
        public string EventType { get; }
        /// <summary> The friendly name of the source of the event on which it is raised (for example, VM, VMM etc). </summary>
        public string AffectedObjectFriendlyName { get; }
        /// <summary> The affected object correlationId for the event. </summary>
        public string AffectedObjectCorrelationId { get; }
        /// <summary> The severity of the event. </summary>
        public string Severity { get; }
        /// <summary> The time of occurrence of the event. </summary>
        public DateTimeOffset? OccurredOn { get; }
        /// <summary> The ARM ID of the fabric. </summary>
        public ResourceIdentifier FabricId { get; }
        /// <summary>
        /// The provider specific settings.
        /// Please note <see cref="SiteRecoveryEventProviderSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AEventDetails"/>, <see cref="HyperVReplica2012EventDetails"/>, <see cref="HyperVReplica2012R2EventDetails"/>, <see cref="HyperVReplicaAzureEventDetails"/>, <see cref="HyperVReplicaBaseEventDetails"/>, <see cref="InMageAzureV2EventDetails"/>, <see cref="InMageRcmEventDetails"/>, <see cref="InMageRcmFailbackEventDetails"/> and <see cref="VMwareCbtEventDetails"/>.
        /// </summary>
        public SiteRecoveryEventProviderSpecificDetails ProviderSpecificDetails { get; }
        /// <summary>
        /// The event specific settings.
        /// Please note <see cref="SiteRecoveryEventSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SiteRecoveryJobStatusEventDetails"/>.
        /// </summary>
        public SiteRecoveryEventSpecificDetails EventSpecificDetails { get; }
        /// <summary> The list of errors / warnings capturing details associated with the issue(s). </summary>
        public IReadOnlyList<SiteRecoveryHealthError> HealthErrors { get; }
    }
}
