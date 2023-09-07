// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A provider specific settings. </summary>
    public partial class A2AProtectionContainerMappingDetails : ProtectionContainerMappingProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="A2AProtectionContainerMappingDetails"/>. </summary>
        internal A2AProtectionContainerMappingDetails()
        {
            InstanceType = "A2A";
        }

        /// <summary> Initializes a new instance of <see cref="A2AProtectionContainerMappingDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="agentAutoUpdateStatus"> A value indicating whether the auto update is enabled. </param>
        /// <param name="automationAccountArmId"> The automation account arm id. </param>
        /// <param name="automationAccountAuthenticationType"> A value indicating the type authentication to use for automation Account. </param>
        /// <param name="scheduleName"> The schedule arm name. </param>
        /// <param name="jobScheduleName"> The job schedule arm name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal A2AProtectionContainerMappingDetails(string instanceType, SiteRecoveryAgentAutoUpdateStatus? agentAutoUpdateStatus, ResourceIdentifier automationAccountArmId, AutomationAccountAuthenticationType? automationAccountAuthenticationType, string scheduleName, string jobScheduleName, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            AgentAutoUpdateStatus = agentAutoUpdateStatus;
            AutomationAccountArmId = automationAccountArmId;
            AutomationAccountAuthenticationType = automationAccountAuthenticationType;
            ScheduleName = scheduleName;
            JobScheduleName = jobScheduleName;
            InstanceType = instanceType ?? "A2A";
        }

        /// <summary> A value indicating whether the auto update is enabled. </summary>
        public SiteRecoveryAgentAutoUpdateStatus? AgentAutoUpdateStatus { get; }
        /// <summary> The automation account arm id. </summary>
        public ResourceIdentifier AutomationAccountArmId { get; }
        /// <summary> A value indicating the type authentication to use for automation Account. </summary>
        public AutomationAccountAuthenticationType? AutomationAccountAuthenticationType { get; }
        /// <summary> The schedule arm name. </summary>
        public string ScheduleName { get; }
        /// <summary> The job schedule arm name. </summary>
        public string JobScheduleName { get; }
    }
}
