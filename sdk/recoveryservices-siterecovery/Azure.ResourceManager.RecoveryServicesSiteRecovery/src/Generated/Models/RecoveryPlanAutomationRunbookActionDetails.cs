// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan Automation runbook action details. </summary>
    public partial class RecoveryPlanAutomationRunbookActionDetails : RecoveryPlanActionDetails
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanAutomationRunbookActionDetails"/>. </summary>
        /// <param name="fabricLocation"> The fabric location. </param>
        public RecoveryPlanAutomationRunbookActionDetails(RecoveryPlanActionLocation fabricLocation)
        {
            FabricLocation = fabricLocation;
            InstanceType = "AutomationRunbookActionDetails";
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanAutomationRunbookActionDetails"/>. </summary>
        /// <param name="instanceType"> Gets the type of action details (see RecoveryPlanActionDetailsTypes enum for possible values). </param>
        /// <param name="runbookId"> The runbook ARM Id. </param>
        /// <param name="timeout"> The runbook timeout. </param>
        /// <param name="fabricLocation"> The fabric location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryPlanAutomationRunbookActionDetails(string instanceType, ResourceIdentifier runbookId, string timeout, RecoveryPlanActionLocation fabricLocation, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            RunbookId = runbookId;
            Timeout = timeout;
            FabricLocation = fabricLocation;
            InstanceType = instanceType ?? "AutomationRunbookActionDetails";
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanAutomationRunbookActionDetails"/> for deserialization. </summary>
        internal RecoveryPlanAutomationRunbookActionDetails()
        {
        }

        /// <summary> The runbook ARM Id. </summary>
        public ResourceIdentifier RunbookId { get; set; }
        /// <summary> The runbook timeout. </summary>
        public string Timeout { get; set; }
        /// <summary> The fabric location. </summary>
        public RecoveryPlanActionLocation FabricLocation { get; set; }
    }
}
