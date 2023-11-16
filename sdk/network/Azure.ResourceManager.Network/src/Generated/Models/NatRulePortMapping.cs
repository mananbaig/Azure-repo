// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Individual port mappings for inbound NAT rule created for backend pool. </summary>
    public partial class NatRulePortMapping
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NatRulePortMapping"/>. </summary>
        internal NatRulePortMapping()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NatRulePortMapping"/>. </summary>
        /// <param name="inboundNatRuleName"> Name of inbound NAT rule. </param>
        /// <param name="frontendPort"> Frontend port. </param>
        /// <param name="backendPort"> Backend port. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NatRulePortMapping(string inboundNatRuleName, int? frontendPort, int? backendPort, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InboundNatRuleName = inboundNatRuleName;
            FrontendPort = frontendPort;
            BackendPort = backendPort;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of inbound NAT rule. </summary>
        public string InboundNatRuleName { get; }
        /// <summary> Frontend port. </summary>
        public int? FrontendPort { get; }
        /// <summary> Backend port. </summary>
        public int? BackendPort { get; }
    }
}
