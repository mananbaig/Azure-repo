// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Workflow model properties. </summary>
    public partial class DataReplicationWorkflowProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataReplicationWorkflowProperties"/>. </summary>
        /// <param name="customProperties">
        /// Workflow model custom properties.
        /// Please note <see cref="WorkflowModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FailoverWorkflowModelCustomProperties"/>, <see cref="TestFailoverCleanupWorkflowModelCustomProperties"/> and <see cref="TestFailoverWorkflowModelCustomProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customProperties"/> is null. </exception>
        internal DataReplicationWorkflowProperties(WorkflowModelCustomProperties customProperties)
        {
            Argument.AssertNotNull(customProperties, nameof(customProperties));

            AllowedActions = new ChangeTrackingList<string>();
            Tasks = new ChangeTrackingList<DataReplicationTask>();
            Errors = new ChangeTrackingList<DataReplicationErrorInfo>();
            CustomProperties = customProperties;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationWorkflowProperties"/>. </summary>
        /// <param name="displayName"> Gets or sets the friendly display name. </param>
        /// <param name="state"> Gets or sets the workflow state. </param>
        /// <param name="startOn"> Gets or sets the start time. </param>
        /// <param name="endOn"> Gets or sets the end time. </param>
        /// <param name="objectId"> Gets or sets the affected object Id. </param>
        /// <param name="objectName"> Gets or sets the affected object name. </param>
        /// <param name="objectInternalId"> Gets or sets the affected object internal Id. </param>
        /// <param name="objectInternalName"> Gets or sets the affected object internal name. </param>
        /// <param name="objectType"> Gets or sets the object type. </param>
        /// <param name="replicationProviderId"> Gets or sets the replication provider. </param>
        /// <param name="sourceFabricProviderId"> Gets or sets the source fabric provider. </param>
        /// <param name="targetFabricProviderId"> Gets or sets the target fabric provider. </param>
        /// <param name="allowedActions"> Gets or sets the list of allowed actions on the workflow. </param>
        /// <param name="activityId"> Gets or sets the workflow activity id. </param>
        /// <param name="tasks"> Gets or sets the list of tasks. </param>
        /// <param name="errors"> Gets or sets the list of errors. </param>
        /// <param name="customProperties">
        /// Workflow model custom properties.
        /// Please note <see cref="WorkflowModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FailoverWorkflowModelCustomProperties"/>, <see cref="TestFailoverCleanupWorkflowModelCustomProperties"/> and <see cref="TestFailoverWorkflowModelCustomProperties"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataReplicationWorkflowProperties(string displayName, DataReplicationWorkflowState? state, DateTimeOffset? startOn, DateTimeOffset? endOn, string objectId, string objectName, string objectInternalId, string objectInternalName, WorkflowObjectType? objectType, string replicationProviderId, string sourceFabricProviderId, string targetFabricProviderId, IReadOnlyList<string> allowedActions, string activityId, IReadOnlyList<DataReplicationTask> tasks, IReadOnlyList<DataReplicationErrorInfo> errors, WorkflowModelCustomProperties customProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            State = state;
            StartOn = startOn;
            EndOn = endOn;
            ObjectId = objectId;
            ObjectName = objectName;
            ObjectInternalId = objectInternalId;
            ObjectInternalName = objectInternalName;
            ObjectType = objectType;
            ReplicationProviderId = replicationProviderId;
            SourceFabricProviderId = sourceFabricProviderId;
            TargetFabricProviderId = targetFabricProviderId;
            AllowedActions = allowedActions;
            ActivityId = activityId;
            Tasks = tasks;
            Errors = errors;
            CustomProperties = customProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationWorkflowProperties"/> for deserialization. </summary>
        internal DataReplicationWorkflowProperties()
        {
        }

        /// <summary> Gets or sets the friendly display name. </summary>
        public string DisplayName { get; }
        /// <summary> Gets or sets the workflow state. </summary>
        public DataReplicationWorkflowState? State { get; }
        /// <summary> Gets or sets the start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Gets or sets the end time. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Gets or sets the affected object Id. </summary>
        public string ObjectId { get; }
        /// <summary> Gets or sets the affected object name. </summary>
        public string ObjectName { get; }
        /// <summary> Gets or sets the affected object internal Id. </summary>
        public string ObjectInternalId { get; }
        /// <summary> Gets or sets the affected object internal name. </summary>
        public string ObjectInternalName { get; }
        /// <summary> Gets or sets the object type. </summary>
        public WorkflowObjectType? ObjectType { get; }
        /// <summary> Gets or sets the replication provider. </summary>
        public string ReplicationProviderId { get; }
        /// <summary> Gets or sets the source fabric provider. </summary>
        public string SourceFabricProviderId { get; }
        /// <summary> Gets or sets the target fabric provider. </summary>
        public string TargetFabricProviderId { get; }
        /// <summary> Gets or sets the list of allowed actions on the workflow. </summary>
        public IReadOnlyList<string> AllowedActions { get; }
        /// <summary> Gets or sets the workflow activity id. </summary>
        public string ActivityId { get; }
        /// <summary> Gets or sets the list of tasks. </summary>
        public IReadOnlyList<DataReplicationTask> Tasks { get; }
        /// <summary> Gets or sets the list of errors. </summary>
        public IReadOnlyList<DataReplicationErrorInfo> Errors { get; }
        /// <summary>
        /// Workflow model custom properties.
        /// Please note <see cref="WorkflowModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FailoverWorkflowModelCustomProperties"/>, <see cref="TestFailoverCleanupWorkflowModelCustomProperties"/> and <see cref="TestFailoverWorkflowModelCustomProperties"/>.
        /// </summary>
        public WorkflowModelCustomProperties CustomProperties { get; }
    }
}
