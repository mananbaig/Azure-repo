// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies Redeploy, Reboot and ScheduledEventsAdditionalPublishingTargets Scheduled Event related configurations. </summary>
    public partial class ScheduledEventsPolicy
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ScheduledEventsPolicy"/>. </summary>
        public ScheduledEventsPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScheduledEventsPolicy"/>. </summary>
        /// <param name="userInitiatedRedeploy"> The configuration parameters used while creating userInitiatedRedeploy scheduled event setting creation. </param>
        /// <param name="userInitiatedReboot"> The configuration parameters used while creating userInitiatedReboot scheduled event setting creation. </param>
        /// <param name="scheduledEventsAdditionalPublishingTargets"> The configuration parameters used while publishing scheduledEventsAdditionalPublishingTargets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScheduledEventsPolicy(UserInitiatedRedeploy userInitiatedRedeploy, UserInitiatedReboot userInitiatedReboot, ScheduledEventsAdditionalPublishingTargets scheduledEventsAdditionalPublishingTargets, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UserInitiatedRedeploy = userInitiatedRedeploy;
            UserInitiatedReboot = userInitiatedReboot;
            ScheduledEventsAdditionalPublishingTargets = scheduledEventsAdditionalPublishingTargets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The configuration parameters used while creating userInitiatedRedeploy scheduled event setting creation. </summary>
        public UserInitiatedRedeploy UserInitiatedRedeploy { get; set; }
        /// <summary> The configuration parameters used while creating userInitiatedReboot scheduled event setting creation. </summary>
        internal UserInitiatedReboot UserInitiatedReboot { get; set; }
        /// <summary> Specifies Reboot Scheduled Event related configurations. </summary>
        public bool? AutomaticallyApprove
        {
            get => UserInitiatedReboot is null ? default : UserInitiatedReboot.AutomaticallyApprove;
            set
            {
                if (UserInitiatedReboot is null)
                    UserInitiatedReboot = new UserInitiatedReboot();
                UserInitiatedReboot.AutomaticallyApprove = value;
            }
        }

        /// <summary> The configuration parameters used while publishing scheduledEventsAdditionalPublishingTargets. </summary>
        internal ScheduledEventsAdditionalPublishingTargets ScheduledEventsAdditionalPublishingTargets { get; set; }
        /// <summary> Specifies if event grid and resource graph is enabled for Scheduled event related configurations. </summary>
        public bool? Enable
        {
            get => ScheduledEventsAdditionalPublishingTargets is null ? default : ScheduledEventsAdditionalPublishingTargets.Enable;
            set
            {
                if (ScheduledEventsAdditionalPublishingTargets is null)
                    ScheduledEventsAdditionalPublishingTargets = new ScheduledEventsAdditionalPublishingTargets();
                ScheduledEventsAdditionalPublishingTargets.Enable = value;
            }
        }
    }
}
