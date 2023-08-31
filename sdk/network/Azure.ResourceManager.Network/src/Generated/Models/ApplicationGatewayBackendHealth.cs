// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ApplicationGatewayBackendHealth API service call. </summary>
    public partial class ApplicationGatewayBackendHealth
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealth"/>. </summary>
        internal ApplicationGatewayBackendHealth()
        {
            BackendAddressPools = new ChangeTrackingList<ApplicationGatewayBackendHealthPool>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealth"/>. </summary>
        /// <param name="backendAddressPools"> A list of ApplicationGatewayBackendHealthPool resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayBackendHealth(IReadOnlyList<ApplicationGatewayBackendHealthPool> backendAddressPools, Dictionary<string, BinaryData> rawData)
        {
            BackendAddressPools = backendAddressPools;
            _rawData = rawData;
        }

        /// <summary> A list of ApplicationGatewayBackendHealthPool resources. </summary>
        public IReadOnlyList<ApplicationGatewayBackendHealthPool> BackendAddressPools { get; }
    }
}
