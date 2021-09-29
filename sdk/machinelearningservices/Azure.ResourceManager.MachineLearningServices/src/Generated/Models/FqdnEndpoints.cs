// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The FqdnEndpoints. </summary>
    public partial class FqdnEndpoints
    {
        /// <summary> Initializes a new instance of FqdnEndpoints. </summary>
        internal FqdnEndpoints()
        {
        }

        /// <summary> Initializes a new instance of FqdnEndpoints. </summary>
        /// <param name="properties"></param>
        internal FqdnEndpoints(FqdnEndpointsProperties properties)
        {
            Properties = properties;
        }

        /// <summary> Gets the properties. </summary>
        public FqdnEndpointsProperties Properties { get; }
    }
}
