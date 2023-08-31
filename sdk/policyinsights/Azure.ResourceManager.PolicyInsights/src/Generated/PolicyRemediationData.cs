// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary>
    /// A class representing the PolicyRemediation data model.
    /// The remediation definition.
    /// </summary>
    public partial class PolicyRemediationData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PolicyRemediationData"/>. </summary>
        public PolicyRemediationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicyRemediationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="policyAssignmentId"> The resource ID of the policy assignment that should be remediated. </param>
        /// <param name="policyDefinitionReferenceId"> The policy definition reference ID of the individual definition that should be remediated. Required when the policy assignment being remediated assigns a policy set definition. </param>
        /// <param name="resourceDiscoveryMode"> The way resources to remediate are discovered. Defaults to ExistingNonCompliant if not specified. </param>
        /// <param name="provisioningState"> The status of the remediation. </param>
        /// <param name="createdOn"> The time at which the remediation was created. </param>
        /// <param name="lastUpdatedOn"> The time at which the remediation was last updated. </param>
        /// <param name="filter"> The filters that will be applied to determine which resources to remediate. </param>
        /// <param name="deploymentStatus"> The deployment status summary for all deployments created by the remediation. </param>
        /// <param name="statusMessage"> The remediation status message. Provides additional details regarding the state of the remediation. </param>
        /// <param name="correlationId"> The remediation correlation Id. Can be used to find events related to the remediation in the activity log. </param>
        /// <param name="resourceCount"> Determines the max number of resources that can be remediated by the remediation job. If not provided, the default resource count is used. </param>
        /// <param name="parallelDeployments"> Determines how many resources to remediate at any given time. Can be used to increase or reduce the pace of the remediation. If not provided, the default parallel deployments value is used. </param>
        /// <param name="failureThreshold"> The remediation failure threshold settings. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyRemediationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier policyAssignmentId, string policyDefinitionReferenceId, ResourceDiscoveryMode? resourceDiscoveryMode, string provisioningState, DateTimeOffset? createdOn, DateTimeOffset? lastUpdatedOn, RemediationFilters filter, RemediationDeploymentSummary deploymentStatus, string statusMessage, string correlationId, int? resourceCount, int? parallelDeployments, RemediationPropertiesFailureThreshold failureThreshold, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            PolicyAssignmentId = policyAssignmentId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            ResourceDiscoveryMode = resourceDiscoveryMode;
            ProvisioningState = provisioningState;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Filter = filter;
            DeploymentStatus = deploymentStatus;
            StatusMessage = statusMessage;
            CorrelationId = correlationId;
            ResourceCount = resourceCount;
            ParallelDeployments = parallelDeployments;
            FailureThreshold = failureThreshold;
            _rawData = rawData;
        }

        /// <summary> The resource ID of the policy assignment that should be remediated. </summary>
        public ResourceIdentifier PolicyAssignmentId { get; set; }
        /// <summary> The policy definition reference ID of the individual definition that should be remediated. Required when the policy assignment being remediated assigns a policy set definition. </summary>
        public string PolicyDefinitionReferenceId { get; set; }
        /// <summary> The way resources to remediate are discovered. Defaults to ExistingNonCompliant if not specified. </summary>
        public ResourceDiscoveryMode? ResourceDiscoveryMode { get; set; }
        /// <summary> The status of the remediation. </summary>
        public string ProvisioningState { get; }
        /// <summary> The time at which the remediation was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time at which the remediation was last updated. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> The filters that will be applied to determine which resources to remediate. </summary>
        internal RemediationFilters Filter { get; set; }
        /// <summary> The resource locations that will be remediated. </summary>
        public IList<AzureLocation> FilterLocations
        {
            get
            {
                if (Filter is null)
                    Filter = new RemediationFilters();
                return Filter.Locations;
            }
        }

        /// <summary> The deployment status summary for all deployments created by the remediation. </summary>
        public RemediationDeploymentSummary DeploymentStatus { get; }
        /// <summary> The remediation status message. Provides additional details regarding the state of the remediation. </summary>
        public string StatusMessage { get; }
        /// <summary> The remediation correlation Id. Can be used to find events related to the remediation in the activity log. </summary>
        public string CorrelationId { get; }
        /// <summary> Determines the max number of resources that can be remediated by the remediation job. If not provided, the default resource count is used. </summary>
        public int? ResourceCount { get; set; }
        /// <summary> Determines how many resources to remediate at any given time. Can be used to increase or reduce the pace of the remediation. If not provided, the default parallel deployments value is used. </summary>
        public int? ParallelDeployments { get; set; }
        /// <summary> The remediation failure threshold settings. </summary>
        internal RemediationPropertiesFailureThreshold FailureThreshold { get; set; }
        /// <summary> A number between 0.0 to 1.0 representing the percentage failure threshold. The remediation will fail if the percentage of failed remediation operations (i.e. failed deployments) exceeds this threshold. </summary>
        public float? FailureThresholdPercentage
        {
            get => FailureThreshold is null ? default : FailureThreshold.Percentage;
            set
            {
                if (FailureThreshold is null)
                    FailureThreshold = new RemediationPropertiesFailureThreshold();
                FailureThreshold.Percentage = value;
            }
        }
    }
}
