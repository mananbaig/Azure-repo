// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> List of private endpoint connection associated with the specified workspace. </summary>
    internal partial class MachineLearningPrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of MachineLearningPrivateEndpointConnectionListResult. </summary>
        internal MachineLearningPrivateEndpointConnectionListResult()
        {
            Value = new Core.ChangeTrackingList<MachineLearningPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of MachineLearningPrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        internal MachineLearningPrivateEndpointConnectionListResult(IReadOnlyList<MachineLearningPrivateEndpointConnectionData> value)
        {
            Value = value;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<MachineLearningPrivateEndpointConnectionData> Value { get; }
    }
}
