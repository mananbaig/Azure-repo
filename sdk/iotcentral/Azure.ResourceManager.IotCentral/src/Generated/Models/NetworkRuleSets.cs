// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> Network Rule Set Properties of this IoT Central application. </summary>
    public partial class NetworkRuleSets
    {
        /// <summary> Initializes a new instance of NetworkRuleSets. </summary>
        public NetworkRuleSets()
        {
            IPRules = new ChangeTrackingList<NetworkRuleSetIPRule>();
        }

        /// <summary> Initializes a new instance of NetworkRuleSets. </summary>
        /// <param name="applyToDevices"> Whether these rules apply for device connectivity to IoT Hub and Device Provisioning service associated with this application. </param>
        /// <param name="applyToIoTCentral"> Whether these rules apply for connectivity via IoT Central web portal and APIs. </param>
        /// <param name="defaultAction"> The default network action to apply. </param>
        /// <param name="ipRules"> List of IP rules. </param>
        internal NetworkRuleSets(bool? applyToDevices, bool? applyToIoTCentral, NetworkAction? defaultAction, IList<NetworkRuleSetIPRule> ipRules)
        {
            ApplyToDevices = applyToDevices;
            ApplyToIoTCentral = applyToIoTCentral;
            DefaultAction = defaultAction;
            IPRules = ipRules;
        }

        /// <summary> Whether these rules apply for device connectivity to IoT Hub and Device Provisioning service associated with this application. </summary>
        public bool? ApplyToDevices { get; set; }
        /// <summary> Whether these rules apply for connectivity via IoT Central web portal and APIs. </summary>
        public bool? ApplyToIoTCentral { get; set; }
        /// <summary> The default network action to apply. </summary>
        public NetworkAction? DefaultAction { get; set; }
        /// <summary> List of IP rules. </summary>
        public IList<NetworkRuleSetIPRule> IPRules { get; }
    }
}
