// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The list managed private endpoints operation response. </summary>
    internal partial class ManagedPrivateEndpointListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedPrivateEndpointListResult"/>. </summary>
        internal ManagedPrivateEndpointListResult()
        {
            Value = new ChangeTrackingList<KustoManagedPrivateEndpointData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedPrivateEndpointListResult"/>. </summary>
        /// <param name="value"> The list of managed private endpoints. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedPrivateEndpointListResult(IReadOnlyList<KustoManagedPrivateEndpointData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The list of managed private endpoints. </summary>
        public IReadOnlyList<KustoManagedPrivateEndpointData> Value { get; }
    }
}
