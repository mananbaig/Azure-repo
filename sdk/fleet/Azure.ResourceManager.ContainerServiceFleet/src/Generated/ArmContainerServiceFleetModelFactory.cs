// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ContainerServiceFleet;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmContainerServiceFleetModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ContainerServiceFleet.ContainerServiceFleetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="eTag"> If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="identity"> Managed identity. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <returns> A new <see cref="ContainerServiceFleet.ContainerServiceFleetData"/> instance for mocking. </returns>
        public static ContainerServiceFleetData ContainerServiceFleetData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ETag? eTag = null, ManagedServiceIdentity identity = null, FleetProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ContainerServiceFleetData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                eTag,
                identity,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.FleetCredentialResults"/>. </summary>
        /// <param name="kubeconfigs"> Array of base64-encoded Kubernetes configuration files. </param>
        /// <returns> A new <see cref="Models.FleetCredentialResults"/> instance for mocking. </returns>
        public static FleetCredentialResults FleetCredentialResults(IEnumerable<FleetCredentialResult> kubeconfigs = null)
        {
            kubeconfigs ??= new List<FleetCredentialResult>();

            return new FleetCredentialResults(kubeconfigs?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.FleetCredentialResult"/>. </summary>
        /// <param name="name"> The name of the credential. </param>
        /// <param name="value"> Base64-encoded Kubernetes configuration file. </param>
        /// <returns> A new <see cref="Models.FleetCredentialResult"/> instance for mocking. </returns>
        public static FleetCredentialResult FleetCredentialResult(string name = null, byte[] value = null)
        {
            return new FleetCredentialResult(name, value, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceFleet.ContainerServiceFleetMemberData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="eTag"> If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="clusterResourceId"> The ARM resource id of the cluster that joins the Fleet. Must be a valid Azure resource id. e.g.: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{clusterName}'. </param>
        /// <param name="group"> The group this member belongs to for multi-cluster update management. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <returns> A new <see cref="ContainerServiceFleet.ContainerServiceFleetMemberData"/> instance for mocking. </returns>
        public static ContainerServiceFleetMemberData ContainerServiceFleetMemberData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ETag? eTag = null, ResourceIdentifier clusterResourceId = null, string group = null, FleetMemberProvisioningState? provisioningState = null)
        {
            return new ContainerServiceFleetMemberData(
                id,
                name,
                resourceType,
                systemData,
                eTag,
                clusterResourceId,
                group,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceFleet.ContainerServiceFleetUpdateRunData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="eTag"> If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="provisioningState"> The provisioning state of the UpdateRun resource. </param>
        /// <param name="updateStrategyId">
        /// The resource id of the FleetUpdateStrategy resource to reference.
        ///
        /// When creating a new run, there are three ways to define a strategy for the run:
        /// 1. Define a new strategy in place: Set the "strategy" field.
        /// 2. Use an existing strategy: Set the "updateStrategyId" field. (since 2023-08-15-preview)
        /// 3. Use the default strategy to update all the members one by one: Leave both "updateStrategyId" and "strategy" unset. (since 2023-08-15-preview)
        ///
        /// Setting both "updateStrategyId" and "strategy" is invalid.
        ///
        /// UpdateRuns created by "updateStrategyId" snapshot the referenced UpdateStrategy at the time of creation and store it in the "strategy" field.
        /// Subsequent changes to the referenced FleetUpdateStrategy resource do not propagate.
        /// UpdateRunStrategy changes can be made directly on the "strategy" field before launching the UpdateRun.
        /// </param>
        /// <param name="strategyStages">
        /// The strategy defines the order in which the clusters will be updated.
        /// If not set, all members will be updated sequentially. The UpdateRun status will show a single UpdateStage and a single UpdateGroup targeting all members.
        /// The strategy of the UpdateRun can be modified until the run is started.
        /// </param>
        /// <param name="managedClusterUpdate"> The update to be applied to all clusters in the UpdateRun. The managedClusterUpdate can be modified until the run is started. </param>
        /// <param name="status"> The status of the UpdateRun. </param>
        /// <returns> A new <see cref="ContainerServiceFleet.ContainerServiceFleetUpdateRunData"/> instance for mocking. </returns>
        public static ContainerServiceFleetUpdateRunData ContainerServiceFleetUpdateRunData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ETag? eTag = null, ContainerServiceFleetUpdateRunProvisioningState? provisioningState = null, ResourceIdentifier updateStrategyId = null, IEnumerable<ContainerServiceFleetUpdateStage> strategyStages = null, ContainerServiceFleetManagedClusterUpdate managedClusterUpdate = null, ContainerServiceFleetUpdateRunStatus status = null)
        {
            strategyStages ??= new List<ContainerServiceFleetUpdateStage>();

            return new ContainerServiceFleetUpdateRunData(
                id,
                name,
                resourceType,
                systemData,
                eTag,
                provisioningState,
                updateStrategyId,
                strategyStages != null ? new ContainerServiceFleetUpdateRunStrategy(strategyStages?.ToList(), serializedAdditionalRawData: null) : null,
                managedClusterUpdate,
                status,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ContainerServiceFleetUpdateRunStatus"/>. </summary>
        /// <param name="status"> The status of the UpdateRun. </param>
        /// <param name="stages"> The stages composing an update run. Stages are run sequentially withing an UpdateRun. </param>
        /// <param name="selectedNodeImageVersions"> The node image upgrade specs for the update run. It is only set in update run when `NodeImageSelection.type` is `Consistent`. </param>
        /// <returns> A new <see cref="Models.ContainerServiceFleetUpdateRunStatus"/> instance for mocking. </returns>
        public static ContainerServiceFleetUpdateRunStatus ContainerServiceFleetUpdateRunStatus(ContainerServiceFleetUpdateStatus status = null, IEnumerable<ContainerServiceFleetUpdateStageStatus> stages = null, IEnumerable<NodeImageVersion> selectedNodeImageVersions = null)
        {
            stages ??= new List<ContainerServiceFleetUpdateStageStatus>();
            selectedNodeImageVersions ??= new List<NodeImageVersion>();

            return new ContainerServiceFleetUpdateRunStatus(status, stages?.ToList(), selectedNodeImageVersions != null ? new NodeImageSelectionStatus(selectedNodeImageVersions?.ToList(), serializedAdditionalRawData: null) : null, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ContainerServiceFleetUpdateStatus"/>. </summary>
        /// <param name="startOn"> The time the operation or group was started. </param>
        /// <param name="completedOn"> The time the operation or group was completed. </param>
        /// <param name="state"> The State of the operation or group. </param>
        /// <param name="error"> The error details when a failure is encountered. </param>
        /// <returns> A new <see cref="Models.ContainerServiceFleetUpdateStatus"/> instance for mocking. </returns>
        public static ContainerServiceFleetUpdateStatus ContainerServiceFleetUpdateStatus(DateTimeOffset? startOn = null, DateTimeOffset? completedOn = null, ContainerServiceFleetUpdateState? state = null, ResponseError error = null)
        {
            return new ContainerServiceFleetUpdateStatus(startOn, completedOn, state, error, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ContainerServiceFleetUpdateStageStatus"/>. </summary>
        /// <param name="status"> The status of the UpdateStage. </param>
        /// <param name="name"> The name of the UpdateStage. </param>
        /// <param name="groups"> The list of groups to be updated as part of this UpdateStage. </param>
        /// <param name="afterStageWaitStatus"> The status of the wait period configured on the UpdateStage. </param>
        /// <returns> A new <see cref="Models.ContainerServiceFleetUpdateStageStatus"/> instance for mocking. </returns>
        public static ContainerServiceFleetUpdateStageStatus ContainerServiceFleetUpdateStageStatus(ContainerServiceFleetUpdateStatus status = null, string name = null, IEnumerable<ContainerServiceFleetUpdateGroupStatus> groups = null, ContainerServiceFleetWaitStatus afterStageWaitStatus = null)
        {
            groups ??= new List<ContainerServiceFleetUpdateGroupStatus>();

            return new ContainerServiceFleetUpdateStageStatus(status, name, groups?.ToList(), afterStageWaitStatus, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ContainerServiceFleetUpdateGroupStatus"/>. </summary>
        /// <param name="status"> The status of the UpdateGroup. </param>
        /// <param name="name"> The name of the UpdateGroup. </param>
        /// <param name="members"> The list of member this UpdateGroup updates. </param>
        /// <returns> A new <see cref="Models.ContainerServiceFleetUpdateGroupStatus"/> instance for mocking. </returns>
        public static ContainerServiceFleetUpdateGroupStatus ContainerServiceFleetUpdateGroupStatus(ContainerServiceFleetUpdateStatus status = null, string name = null, IEnumerable<MemberUpdateStatus> members = null)
        {
            members ??= new List<MemberUpdateStatus>();

            return new ContainerServiceFleetUpdateGroupStatus(status, name, members?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MemberUpdateStatus"/>. </summary>
        /// <param name="status"> The status of the MemberUpdate operation. </param>
        /// <param name="name"> The name of the FleetMember. </param>
        /// <param name="clusterResourceId"> The Azure resource id of the target Kubernetes cluster. </param>
        /// <param name="operationId"> The operation resource id of the latest attempt to perform the operation. </param>
        /// <param name="message"> The status message after processing the member update operation. </param>
        /// <returns> A new <see cref="Models.MemberUpdateStatus"/> instance for mocking. </returns>
        public static MemberUpdateStatus MemberUpdateStatus(ContainerServiceFleetUpdateStatus status = null, string name = null, ResourceIdentifier clusterResourceId = null, string operationId = null, string message = null)
        {
            return new MemberUpdateStatus(
                status,
                name,
                clusterResourceId,
                operationId,
                message,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ContainerServiceFleetWaitStatus"/>. </summary>
        /// <param name="status"> The status of the wait duration. </param>
        /// <param name="waitDurationInSeconds"> The wait duration configured in seconds. </param>
        /// <returns> A new <see cref="Models.ContainerServiceFleetWaitStatus"/> instance for mocking. </returns>
        public static ContainerServiceFleetWaitStatus ContainerServiceFleetWaitStatus(ContainerServiceFleetUpdateStatus status = null, int? waitDurationInSeconds = null)
        {
            return new ContainerServiceFleetWaitStatus(status, waitDurationInSeconds, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NodeImageVersion"/>. </summary>
        /// <param name="version"> The image version to upgrade the nodes to (e.g., 'AKSUbuntu-1804gen2containerd-2022.12.13'). </param>
        /// <returns> A new <see cref="Models.NodeImageVersion"/> instance for mocking. </returns>
        public static NodeImageVersion NodeImageVersion(string version = null)
        {
            return new NodeImageVersion(version, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceFleet.FleetUpdateStrategyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="eTag"> If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="provisioningState"> The provisioning state of the UpdateStrategy resource. </param>
        /// <param name="strategyStages"> Defines the update sequence of the clusters. </param>
        /// <returns> A new <see cref="ContainerServiceFleet.FleetUpdateStrategyData"/> instance for mocking. </returns>
        public static FleetUpdateStrategyData FleetUpdateStrategyData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ETag? eTag = null, FleetUpdateStrategyProvisioningState? provisioningState = null, IEnumerable<ContainerServiceFleetUpdateStage> strategyStages = null)
        {
            strategyStages ??= new List<ContainerServiceFleetUpdateStage>();

            return new FleetUpdateStrategyData(
                id,
                name,
                resourceType,
                systemData,
                eTag,
                provisioningState,
                strategyStages != null ? new ContainerServiceFleetUpdateRunStrategy(strategyStages?.ToList(), serializedAdditionalRawData: null) : null,
                serializedAdditionalRawData: null);
        }
    }
}
