// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotCentral;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> List of private endpoint connections associated with the specified resource. </summary>
    internal partial class IotCentralPrivateEndpointConnectionListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IotCentralPrivateEndpointConnectionListResult"/>. </summary>
        internal IotCentralPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<IotCentralPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="IotCentralPrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IotCentralPrivateEndpointConnectionListResult(IReadOnlyList<IotCentralPrivateEndpointConnectionData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<IotCentralPrivateEndpointConnectionData> Value { get; }
    }
}
