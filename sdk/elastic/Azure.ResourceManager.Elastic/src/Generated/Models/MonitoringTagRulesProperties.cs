// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> Definition of the properties for a TagRules resource. </summary>
    public partial class MonitoringTagRulesProperties
    {
        /// <summary> Initializes a new instance of MonitoringTagRulesProperties. </summary>
        public MonitoringTagRulesProperties()
        {
        }

        /// <summary> Initializes a new instance of MonitoringTagRulesProperties. </summary>
        /// <param name="provisioningState"> Provisioning state of the monitoring tag rules. </param>
        /// <param name="logRules"> Rules for sending logs. </param>
        internal MonitoringTagRulesProperties(ProvisioningState? provisioningState, LogRules logRules)
        {
            ProvisioningState = provisioningState;
            LogRules = logRules;
        }

        /// <summary> Provisioning state of the monitoring tag rules. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
        /// <summary> Rules for sending logs. </summary>
        public LogRules LogRules { get; set; }
    }
}
