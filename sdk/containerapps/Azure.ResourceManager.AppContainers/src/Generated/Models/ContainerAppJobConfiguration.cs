// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Non versioned Container Apps Job configuration properties. </summary>
    public partial class ContainerAppJobConfiguration
    {
        /// <summary> Initializes a new instance of ContainerAppJobConfiguration. </summary>
        /// <param name="triggerType"> Trigger type of the job. </param>
        /// <param name="replicaTimeout"> Maximum number of seconds a replica is allowed to run. </param>
        public ContainerAppJobConfiguration(ContainerAppJobTriggerType triggerType, int replicaTimeout)
        {
            Secrets = new ChangeTrackingList<ContainerAppWritableSecret>();
            TriggerType = triggerType;
            ReplicaTimeout = replicaTimeout;
            Registries = new ChangeTrackingList<ContainerAppRegistryCredentials>();
        }

        /// <summary> Initializes a new instance of ContainerAppJobConfiguration. </summary>
        /// <param name="secrets"> Collection of secrets used by a Container Apps Job. </param>
        /// <param name="triggerType"> Trigger type of the job. </param>
        /// <param name="replicaTimeout"> Maximum number of seconds a replica is allowed to run. </param>
        /// <param name="replicaRetryLimit"> Maximum number of retries before failing the job. </param>
        /// <param name="manualTriggerConfig"> Manual trigger configuration for a single execution job. Properties replicaCompletionCount and parallelism would be set to 1 by default. </param>
        /// <param name="scheduleTriggerConfig"> Cron formatted repeating trigger schedule ("* * * * *") for cronjobs. Properties completions and parallelism would be set to 1 by default. </param>
        /// <param name="eventTriggerConfig"> Trigger configuration of an event driven job. </param>
        /// <param name="registries"> Collection of private container registry credentials used by a Container apps job. </param>
        internal ContainerAppJobConfiguration(IList<ContainerAppWritableSecret> secrets, ContainerAppJobTriggerType triggerType, int replicaTimeout, int? replicaRetryLimit, JobConfigurationManualTriggerConfig manualTriggerConfig, JobConfigurationScheduleTriggerConfig scheduleTriggerConfig, EventTriggerConfiguration eventTriggerConfig, IList<ContainerAppRegistryCredentials> registries)
        {
            Secrets = secrets;
            TriggerType = triggerType;
            ReplicaTimeout = replicaTimeout;
            ReplicaRetryLimit = replicaRetryLimit;
            ManualTriggerConfig = manualTriggerConfig;
            ScheduleTriggerConfig = scheduleTriggerConfig;
            EventTriggerConfig = eventTriggerConfig;
            Registries = registries;
        }

        /// <summary> Collection of secrets used by a Container Apps Job. </summary>
        public IList<ContainerAppWritableSecret> Secrets { get; }
        /// <summary> Trigger type of the job. </summary>
        public ContainerAppJobTriggerType TriggerType { get; set; }
        /// <summary> Maximum number of seconds a replica is allowed to run. </summary>
        public int ReplicaTimeout { get; set; }
        /// <summary> Maximum number of retries before failing the job. </summary>
        public int? ReplicaRetryLimit { get; set; }
        /// <summary> Manual trigger configuration for a single execution job. Properties replicaCompletionCount and parallelism would be set to 1 by default. </summary>
        public JobConfigurationManualTriggerConfig ManualTriggerConfig { get; set; }
        /// <summary> Cron formatted repeating trigger schedule ("* * * * *") for cronjobs. Properties completions and parallelism would be set to 1 by default. </summary>
        public JobConfigurationScheduleTriggerConfig ScheduleTriggerConfig { get; set; }
        /// <summary> Trigger configuration of an event driven job. </summary>
        public EventTriggerConfiguration EventTriggerConfig { get; set; }
        /// <summary> Collection of private container registry credentials used by a Container apps job. </summary>
        public IList<ContainerAppRegistryCredentials> Registries { get; }
    }
}
