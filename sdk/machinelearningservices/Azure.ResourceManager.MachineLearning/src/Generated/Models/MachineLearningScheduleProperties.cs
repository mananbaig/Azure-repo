// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Base definition of a schedule. </summary>
    public partial class MachineLearningScheduleProperties : MachineLearningResourceBase
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningScheduleProperties"/>. </summary>
        /// <param name="trigger">
        /// [Required] Specifies the trigger details
        /// Please note <see cref="MachineLearningTriggerBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CronTrigger"/> and <see cref="MachineLearningRecurrenceTrigger"/>.
        /// </param>
        /// <param name="action">
        /// [Required] Specifies the action of the schedule
        /// Please note <see cref="MachineLearningScheduleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningJobScheduleAction"/>, <see cref="CreateMonitorAction"/> and <see cref="MachineLearningEndpointScheduleAction"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trigger"/> or <paramref name="action"/> is null. </exception>
        public MachineLearningScheduleProperties(MachineLearningTriggerBase trigger, MachineLearningScheduleAction action)
        {
            Argument.AssertNotNull(trigger, nameof(trigger));
            Argument.AssertNotNull(action, nameof(action));

            Trigger = trigger;
            Action = action;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningScheduleProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="displayName"> Display name of schedule. </param>
        /// <param name="isEnabled"> Is the schedule enabled?. </param>
        /// <param name="trigger">
        /// [Required] Specifies the trigger details
        /// Please note <see cref="MachineLearningTriggerBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CronTrigger"/> and <see cref="MachineLearningRecurrenceTrigger"/>.
        /// </param>
        /// <param name="action">
        /// [Required] Specifies the action of the schedule
        /// Please note <see cref="MachineLearningScheduleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningJobScheduleAction"/>, <see cref="CreateMonitorAction"/> and <see cref="MachineLearningEndpointScheduleAction"/>.
        /// </param>
        /// <param name="provisioningState"> Provisioning state for the schedule. </param>
        internal MachineLearningScheduleProperties(string description, IDictionary<string, string> tags, IDictionary<string, string> properties, IDictionary<string, BinaryData> serializedAdditionalRawData, string displayName, bool? isEnabled, MachineLearningTriggerBase trigger, MachineLearningScheduleAction action, MachineLearningScheduleProvisioningStatus? provisioningState) : base(description, tags, properties, serializedAdditionalRawData)
        {
            DisplayName = displayName;
            IsEnabled = isEnabled;
            Trigger = trigger;
            Action = action;
            ProvisioningState = provisioningState;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningScheduleProperties"/> for deserialization. </summary>
        internal MachineLearningScheduleProperties()
        {
        }

        /// <summary> Display name of schedule. </summary>
        [WirePath("displayName")]
        public string DisplayName { get; set; }
        /// <summary> Is the schedule enabled?. </summary>
        [WirePath("isEnabled")]
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// [Required] Specifies the trigger details
        /// Please note <see cref="MachineLearningTriggerBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CronTrigger"/> and <see cref="MachineLearningRecurrenceTrigger"/>.
        /// </summary>
        [WirePath("trigger")]
        public MachineLearningTriggerBase Trigger { get; set; }
        /// <summary>
        /// [Required] Specifies the action of the schedule
        /// Please note <see cref="MachineLearningScheduleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningJobScheduleAction"/>, <see cref="CreateMonitorAction"/> and <see cref="MachineLearningEndpointScheduleAction"/>.
        /// </summary>
        [WirePath("action")]
        public MachineLearningScheduleAction Action { get; set; }
        /// <summary> Provisioning state for the schedule. </summary>
        [WirePath("provisioningState")]
        public MachineLearningScheduleProvisioningStatus? ProvisioningState { get; }
    }
}
