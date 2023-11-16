// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Frontend setting for Firewall. </summary>
    public partial class FirewallFrontendSetting
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FirewallFrontendSetting"/>. </summary>
        /// <param name="name"> Settings name. </param>
        /// <param name="protocol"> Protocol Type. </param>
        /// <param name="frontendConfiguration"> Frontend configurations. </param>
        /// <param name="backendConfiguration"> Backend configurations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="frontendConfiguration"/> or <paramref name="backendConfiguration"/> is null. </exception>
        public FirewallFrontendSetting(string name, FirewallProtocolType protocol, FirewallEndpointConfiguration frontendConfiguration, FirewallEndpointConfiguration backendConfiguration)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(frontendConfiguration, nameof(frontendConfiguration));
            Argument.AssertNotNull(backendConfiguration, nameof(backendConfiguration));

            Name = name;
            Protocol = protocol;
            FrontendConfiguration = frontendConfiguration;
            BackendConfiguration = backendConfiguration;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallFrontendSetting"/>. </summary>
        /// <param name="name"> Settings name. </param>
        /// <param name="protocol"> Protocol Type. </param>
        /// <param name="frontendConfiguration"> Frontend configurations. </param>
        /// <param name="backendConfiguration"> Backend configurations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallFrontendSetting(string name, FirewallProtocolType protocol, FirewallEndpointConfiguration frontendConfiguration, FirewallEndpointConfiguration backendConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Protocol = protocol;
            FrontendConfiguration = frontendConfiguration;
            BackendConfiguration = backendConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallFrontendSetting"/> for deserialization. </summary>
        internal FirewallFrontendSetting()
        {
        }

        /// <summary> Settings name. </summary>
        public string Name { get; set; }
        /// <summary> Protocol Type. </summary>
        public FirewallProtocolType Protocol { get; set; }
        /// <summary> Frontend configurations. </summary>
        public FirewallEndpointConfiguration FrontendConfiguration { get; set; }
        /// <summary> Backend configurations. </summary>
        public FirewallEndpointConfiguration BackendConfiguration { get; set; }
    }
}
