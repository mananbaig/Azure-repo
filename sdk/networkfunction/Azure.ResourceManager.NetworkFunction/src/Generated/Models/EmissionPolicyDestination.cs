// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkFunction.Models
{
    /// <summary> Emission policy destination properties. </summary>
    public partial class EmissionPolicyDestination
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EmissionPolicyDestination"/>. </summary>
        public EmissionPolicyDestination()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EmissionPolicyDestination"/>. </summary>
        /// <param name="destinationType"> Emission destination type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EmissionPolicyDestination(EmissionDestinationType? destinationType, Dictionary<string, BinaryData> rawData)
        {
            DestinationType = destinationType;
            _rawData = rawData;
        }

        /// <summary> Emission destination type. </summary>
        public EmissionDestinationType? DestinationType { get; set; }
    }
}
