// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment properties with additional details. </summary>
    public partial class DeploymentPropertiesExtended
    {
        /// <summary> Initializes a new instance of DeploymentPropertiesExtended. </summary>
        internal DeploymentPropertiesExtended()
        {
            Providers = new ChangeTrackingList<ProviderData>();
            Dependencies = new ChangeTrackingList<Dependency>();
            OutputResources = new ChangeTrackingList<SubResource>();
            ValidatedResources = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of DeploymentPropertiesExtended. </summary>
        /// <param name="provisioningState"> Denotes the state of provisioning. </param>
        /// <param name="correlationId"> The correlation ID of the deployment. </param>
        /// <param name="timestamp"> The timestamp of the template deployment. </param>
        /// <param name="duration"> The duration of the template deployment. </param>
        /// <param name="outputs"> Key/value pairs that represent deployment output. </param>
        /// <param name="providers"> The list of resource providers needed for the deployment. </param>
        /// <param name="dependencies"> The list of deployment dependencies. </param>
        /// <param name="templateLink"> The URI referencing the template. </param>
        /// <param name="parameters"> Deployment parameters. </param>
        /// <param name="parametersLink"> The URI referencing the parameters. </param>
        /// <param name="mode"> The deployment mode. Possible values are Incremental and Complete. </param>
        /// <param name="debugSetting"> The debug setting of the deployment. </param>
        /// <param name="onErrorDeployment"> The deployment on error behavior. </param>
        /// <param name="templateHash"> The hash produced for the template. </param>
        /// <param name="outputResources"> Array of provisioned resources. </param>
        /// <param name="validatedResources"> Array of validated resources. </param>
        /// <param name="error"> The deployment error. </param>
        internal DeploymentPropertiesExtended(ProvisioningState? provisioningState, string correlationId, DateTimeOffset? timestamp, string duration, object outputs, IReadOnlyList<ProviderData> providers, IReadOnlyList<Dependency> dependencies, TemplateLink templateLink, object parameters, ParametersLink parametersLink, DeploymentMode? mode, DebugSetting debugSetting, OnErrorDeploymentExtended onErrorDeployment, string templateHash, IReadOnlyList<SubResource> outputResources, IReadOnlyList<SubResource> validatedResources, ErrorDetail error)
        {
            ProvisioningState = provisioningState;
            CorrelationId = correlationId;
            Timestamp = timestamp;
            Duration = duration;
            Outputs = outputs;
            Providers = providers;
            Dependencies = dependencies;
            TemplateLink = templateLink;
            Parameters = parameters;
            ParametersLink = parametersLink;
            Mode = mode;
            DebugSetting = debugSetting;
            OnErrorDeployment = onErrorDeployment;
            TemplateHash = templateHash;
            OutputResources = outputResources;
            ValidatedResources = validatedResources;
            Error = error;
        }

        /// <summary> Denotes the state of provisioning. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The correlation ID of the deployment. </summary>
        public string CorrelationId { get; }
        /// <summary> The timestamp of the template deployment. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The duration of the template deployment. </summary>
        public string Duration { get; }
        /// <summary> Key/value pairs that represent deployment output. </summary>
        public object Outputs { get; }
        /// <summary> The list of resource providers needed for the deployment. </summary>
        public IReadOnlyList<ProviderData> Providers { get; }
        /// <summary> The list of deployment dependencies. </summary>
        public IReadOnlyList<Dependency> Dependencies { get; }
        /// <summary> The URI referencing the template. </summary>
        public TemplateLink TemplateLink { get; }
        /// <summary> Deployment parameters. </summary>
        public object Parameters { get; }
        /// <summary> The URI referencing the parameters. </summary>
        public ParametersLink ParametersLink { get; }
        /// <summary> The deployment mode. Possible values are Incremental and Complete. </summary>
        public DeploymentMode? Mode { get; }
        /// <summary> The debug setting of the deployment. </summary>
        internal DebugSetting DebugSetting { get; }
        /// <summary> Specifies the type of information to log for debugging. The permitted values are none, requestContent, responseContent, or both requestContent and responseContent separated by a comma. The default is none. When setting this value, carefully consider the type of information you are passing in during deployment. By logging information about the request or response, you could potentially expose sensitive data that is retrieved through the deployment operations. </summary>
        public string DebugSettingDetailLevel
        {
            get => DebugSetting.DetailLevel;
            set => DebugSetting.DetailLevel = value;
        }

        /// <summary> The deployment on error behavior. </summary>
        public OnErrorDeploymentExtended OnErrorDeployment { get; }
        /// <summary> The hash produced for the template. </summary>
        public string TemplateHash { get; }
        /// <summary> Array of provisioned resources. </summary>
        public IReadOnlyList<SubResource> OutputResources { get; }
        /// <summary> Array of validated resources. </summary>
        public IReadOnlyList<SubResource> ValidatedResources { get; }
        /// <summary> The deployment error. </summary>
        public ErrorDetail Error { get; }
    }
}
