// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The Transaction Manager Communication Settings of managed instance DTC. </summary>
    public partial class ManagedInstanceDtcTransactionManagerCommunicationSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceDtcTransactionManagerCommunicationSettings"/>. </summary>
        public ManagedInstanceDtcTransactionManagerCommunicationSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceDtcTransactionManagerCommunicationSettings"/>. </summary>
        /// <param name="allowInboundEnabled"> Allow Inbound traffic to managed instance DTC. </param>
        /// <param name="allowOutboundEnabled"> Allow Outbound traffic of managed instance DTC. </param>
        /// <param name="authentication"> Authentication type of managed instance DTC. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceDtcTransactionManagerCommunicationSettings(bool? allowInboundEnabled, bool? allowOutboundEnabled, string authentication, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowInboundEnabled = allowInboundEnabled;
            AllowOutboundEnabled = allowOutboundEnabled;
            Authentication = authentication;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Allow Inbound traffic to managed instance DTC. </summary>
        public bool? AllowInboundEnabled { get; set; }
        /// <summary> Allow Outbound traffic of managed instance DTC. </summary>
        public bool? AllowOutboundEnabled { get; set; }
        /// <summary> Authentication type of managed instance DTC. </summary>
        public string Authentication { get; set; }
    }
}
