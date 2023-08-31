// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network security rules evaluation result. </summary>
    public partial class NetworkSecurityRulesEvaluationResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityRulesEvaluationResult"/>. </summary>
        internal NetworkSecurityRulesEvaluationResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityRulesEvaluationResult"/>. </summary>
        /// <param name="name"> Name of the network security rule. </param>
        /// <param name="protocolMatched"> Value indicating whether protocol is matched. </param>
        /// <param name="sourceMatched"> Value indicating whether source is matched. </param>
        /// <param name="sourcePortMatched"> Value indicating whether source port is matched. </param>
        /// <param name="destinationMatched"> Value indicating whether destination is matched. </param>
        /// <param name="destinationPortMatched"> Value indicating whether destination port is matched. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityRulesEvaluationResult(string name, bool? protocolMatched, bool? sourceMatched, bool? sourcePortMatched, bool? destinationMatched, bool? destinationPortMatched, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ProtocolMatched = protocolMatched;
            SourceMatched = sourceMatched;
            SourcePortMatched = sourcePortMatched;
            DestinationMatched = destinationMatched;
            DestinationPortMatched = destinationPortMatched;
            _rawData = rawData;
        }

        /// <summary> Name of the network security rule. </summary>
        public string Name { get; }
        /// <summary> Value indicating whether protocol is matched. </summary>
        public bool? ProtocolMatched { get; }
        /// <summary> Value indicating whether source is matched. </summary>
        public bool? SourceMatched { get; }
        /// <summary> Value indicating whether source port is matched. </summary>
        public bool? SourcePortMatched { get; }
        /// <summary> Value indicating whether destination is matched. </summary>
        public bool? DestinationMatched { get; }
        /// <summary> Value indicating whether destination port is matched. </summary>
        public bool? DestinationPortMatched { get; }
    }
}
