// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Application gateway BackendHealthHttp settings. </summary>
    public partial class ApplicationGatewayBackendHealthHttpSettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthHttpSettings"/>. </summary>
        internal ApplicationGatewayBackendHealthHttpSettings()
        {
            Servers = new ChangeTrackingList<ApplicationGatewayBackendHealthServer>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthHttpSettings"/>. </summary>
        /// <param name="backendHttpSettings"> Reference to an ApplicationGatewayBackendHttpSettings resource. </param>
        /// <param name="servers"> List of ApplicationGatewayBackendHealthServer resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayBackendHealthHttpSettings(ApplicationGatewayBackendHttpSettings backendHttpSettings, IReadOnlyList<ApplicationGatewayBackendHealthServer> servers, Dictionary<string, BinaryData> rawData)
        {
            BackendHttpSettings = backendHttpSettings;
            Servers = servers;
            _rawData = rawData;
        }

        /// <summary> Reference to an ApplicationGatewayBackendHttpSettings resource. </summary>
        public ApplicationGatewayBackendHttpSettings BackendHttpSettings { get; }
        /// <summary> List of ApplicationGatewayBackendHealthServer resources. </summary>
        public IReadOnlyList<ApplicationGatewayBackendHealthServer> Servers { get; }
    }
}
