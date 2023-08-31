// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> QoS policy. </summary>
    public partial class MobileNetworkQosPolicy
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkQosPolicy"/>. </summary>
        /// <param name="maximumBitRate"> The maximum bit rate (MBR) for all service data flows that use this data flow policy rule or service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maximumBitRate"/> is null. </exception>
        public MobileNetworkQosPolicy(Ambr maximumBitRate)
        {
            Argument.AssertNotNull(maximumBitRate, nameof(maximumBitRate));

            MaximumBitRate = maximumBitRate;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkQosPolicy"/>. </summary>
        /// <param name="fiveQi"> 5G QoS Flow Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. See 3GPP TS23.501 section 5.7.2.1 for a full description of the 5QI parameter, and table 5.7.4-1 for the definition the 5QI values. </param>
        /// <param name="allocationAndRetentionPriorityLevel"> QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority, if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority. If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="preemptionCapability"> QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="preemptionVulnerability"> QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="maximumBitRate"> The maximum bit rate (MBR) for all service data flows that use this data flow policy rule or service. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkQosPolicy(int? fiveQi, int? allocationAndRetentionPriorityLevel, MobileNetworkPreemptionCapability? preemptionCapability, MobileNetworkPreemptionVulnerability? preemptionVulnerability, Ambr maximumBitRate, Dictionary<string, BinaryData> rawData)
        {
            FiveQi = fiveQi;
            AllocationAndRetentionPriorityLevel = allocationAndRetentionPriorityLevel;
            PreemptionCapability = preemptionCapability;
            PreemptionVulnerability = preemptionVulnerability;
            MaximumBitRate = maximumBitRate;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkQosPolicy"/> for deserialization. </summary>
        internal MobileNetworkQosPolicy()
        {
        }

        /// <summary> 5G QoS Flow Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. See 3GPP TS23.501 section 5.7.2.1 for a full description of the 5QI parameter, and table 5.7.4-1 for the definition the 5QI values. </summary>
        public int? FiveQi { get; set; }
        /// <summary> QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority, if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority. If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </summary>
        public int? AllocationAndRetentionPriorityLevel { get; set; }
        /// <summary> QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </summary>
        public MobileNetworkPreemptionCapability? PreemptionCapability { get; set; }
        /// <summary> QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </summary>
        public MobileNetworkPreemptionVulnerability? PreemptionVulnerability { get; set; }
        /// <summary> The maximum bit rate (MBR) for all service data flows that use this data flow policy rule or service. </summary>
        public Ambr MaximumBitRate { get; set; }
    }
}
