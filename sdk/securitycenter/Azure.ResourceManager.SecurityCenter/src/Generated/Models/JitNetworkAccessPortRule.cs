// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The JitNetworkAccessPortRule. </summary>
    public partial class JitNetworkAccessPortRule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPortRule"/>. </summary>
        /// <param name="number"></param>
        /// <param name="protocol"></param>
        /// <param name="maxRequestAccessDuration"> Maximum duration requests can be made for. In ISO 8601 duration format. Minimum 5 minutes, maximum 1 day. </param>
        public JitNetworkAccessPortRule(int number, JitNetworkAccessPortProtocol protocol, TimeSpan maxRequestAccessDuration)
        {
            Number = number;
            Protocol = protocol;
            AllowedSourceAddressPrefixes = new ChangeTrackingList<string>();
            MaxRequestAccessDuration = maxRequestAccessDuration;
        }

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPortRule"/>. </summary>
        /// <param name="number"></param>
        /// <param name="protocol"></param>
        /// <param name="allowedSourceAddressPrefix"> Mutually exclusive with the "allowedSourceAddressPrefixes" parameter. Should be an IP address or CIDR, for example "192.168.0.3" or "192.168.0.0/16". </param>
        /// <param name="allowedSourceAddressPrefixes"> Mutually exclusive with the "allowedSourceAddressPrefix" parameter. </param>
        /// <param name="maxRequestAccessDuration"> Maximum duration requests can be made for. In ISO 8601 duration format. Minimum 5 minutes, maximum 1 day. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JitNetworkAccessPortRule(int number, JitNetworkAccessPortProtocol protocol, string allowedSourceAddressPrefix, IList<string> allowedSourceAddressPrefixes, TimeSpan maxRequestAccessDuration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Number = number;
            Protocol = protocol;
            AllowedSourceAddressPrefix = allowedSourceAddressPrefix;
            AllowedSourceAddressPrefixes = allowedSourceAddressPrefixes;
            MaxRequestAccessDuration = maxRequestAccessDuration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPortRule"/> for deserialization. </summary>
        internal JitNetworkAccessPortRule()
        {
        }

        /// <summary> Gets or sets the number. </summary>
        public int Number { get; set; }
        /// <summary> Gets or sets the protocol. </summary>
        public JitNetworkAccessPortProtocol Protocol { get; set; }
        /// <summary> Mutually exclusive with the "allowedSourceAddressPrefixes" parameter. Should be an IP address or CIDR, for example "192.168.0.3" or "192.168.0.0/16". </summary>
        public string AllowedSourceAddressPrefix { get; set; }
        /// <summary> Mutually exclusive with the "allowedSourceAddressPrefix" parameter. </summary>
        public IList<string> AllowedSourceAddressPrefixes { get; }
        /// <summary> Maximum duration requests can be made for. In ISO 8601 duration format. Minimum 5 minutes, maximum 1 day. </summary>
        public TimeSpan MaxRequestAccessDuration { get; set; }
    }
}
