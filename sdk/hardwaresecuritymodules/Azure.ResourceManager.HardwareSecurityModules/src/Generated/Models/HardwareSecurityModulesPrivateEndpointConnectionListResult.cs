// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HardwareSecurityModules;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    /// <summary> List of private endpoint connections associated with the specified resource. </summary>
    internal partial class HardwareSecurityModulesPrivateEndpointConnectionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HardwareSecurityModulesPrivateEndpointConnectionListResult"/>. </summary>
        internal HardwareSecurityModulesPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<HardwareSecurityModulesPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="HardwareSecurityModulesPrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        /// <param name="nextLink"> The URL to get the next set of private endpoint connections. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HardwareSecurityModulesPrivateEndpointConnectionListResult(IReadOnlyList<HardwareSecurityModulesPrivateEndpointConnectionData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<HardwareSecurityModulesPrivateEndpointConnectionData> Value { get; }
        /// <summary> The URL to get the next set of private endpoint connections. </summary>
        public string NextLink { get; }
    }
}
