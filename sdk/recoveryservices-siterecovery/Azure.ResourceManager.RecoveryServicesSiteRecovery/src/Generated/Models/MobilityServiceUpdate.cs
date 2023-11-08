// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The Mobility Service update details. </summary>
    public partial class MobilityServiceUpdate
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MobilityServiceUpdate"/>. </summary>
        internal MobilityServiceUpdate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MobilityServiceUpdate"/>. </summary>
        /// <param name="version"> The version of the latest update. </param>
        /// <param name="rebootStatus"> The reboot status of the update - whether it is required or not. </param>
        /// <param name="osType"> The OS type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MobilityServiceUpdate(string version, string rebootStatus, string osType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Version = version;
            RebootStatus = rebootStatus;
            OSType = osType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The version of the latest update. </summary>
        public string Version { get; }
        /// <summary> The reboot status of the update - whether it is required or not. </summary>
        public string RebootStatus { get; }
        /// <summary> The OS type. </summary>
        public string OSType { get; }
    }
}
