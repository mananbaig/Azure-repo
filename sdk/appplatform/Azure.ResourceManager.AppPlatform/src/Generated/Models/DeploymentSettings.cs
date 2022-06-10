// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Deployment settings payload. </summary>
    public partial class DeploymentSettings
    {
        /// <summary> Initializes a new instance of DeploymentSettings. </summary>
        public DeploymentSettings()
        {
            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
            AddonConfigs = new ChangeTrackingDictionary<string, IDictionary<string, BinaryData>>();
        }

        /// <summary> Initializes a new instance of DeploymentSettings. </summary>
        /// <param name="resourceRequests"> The requested resource quantity for required CPU and Memory. It is recommended that using this field to represent the required CPU and Memory, the old field cpu and memoryInGB will be deprecated later. </param>
        /// <param name="environmentVariables"> Collection of environment variables. </param>
        /// <param name="addonConfigs"> Collection of addons. </param>
        /// <param name="containerProbeSettings"> Container liveness and readiness probe settings. </param>
        internal DeploymentSettings(ResourceRequests resourceRequests, IDictionary<string, string> environmentVariables, IDictionary<string, IDictionary<string, BinaryData>> addonConfigs, ContainerProbeSettings containerProbeSettings)
        {
            ResourceRequests = resourceRequests;
            EnvironmentVariables = environmentVariables;
            AddonConfigs = addonConfigs;
            ContainerProbeSettings = containerProbeSettings;
        }

        /// <summary> The requested resource quantity for required CPU and Memory. It is recommended that using this field to represent the required CPU and Memory, the old field cpu and memoryInGB will be deprecated later. </summary>
        public ResourceRequests ResourceRequests { get; set; }
        /// <summary> Collection of environment variables. </summary>
        public IDictionary<string, string> EnvironmentVariables { get; }
        /// <summary> Collection of addons. </summary>
        public IDictionary<string, IDictionary<string, BinaryData>> AddonConfigs { get; }
        /// <summary> Container liveness and readiness probe settings. </summary>
        internal ContainerProbeSettings ContainerProbeSettings { get; set; }
        /// <summary> Indicates whether disable the liveness and readiness probe. </summary>
        public bool? DisableProbe
        {
            get => ContainerProbeSettings is null ? default : ContainerProbeSettings.DisableProbe;
            set
            {
                if (ContainerProbeSettings is null)
                    ContainerProbeSettings = new ContainerProbeSettings();
                ContainerProbeSettings.DisableProbe = value;
            }
        }
    }
}
