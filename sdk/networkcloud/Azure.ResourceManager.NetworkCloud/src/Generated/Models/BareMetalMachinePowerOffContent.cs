// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachinePowerOffParameters represents the body of the request to power off bare metal machine. </summary>
    public partial class BareMetalMachinePowerOffContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BareMetalMachinePowerOffContent"/>. </summary>
        public BareMetalMachinePowerOffContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BareMetalMachinePowerOffContent"/>. </summary>
        /// <param name="skipShutdown"> The indicator of whether to skip the graceful OS shutdown and power off the bare metal machine immediately. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BareMetalMachinePowerOffContent(BareMetalMachineSkipShutdown? skipShutdown, Dictionary<string, BinaryData> rawData)
        {
            SkipShutdown = skipShutdown;
            _rawData = rawData;
        }

        /// <summary> The indicator of whether to skip the graceful OS shutdown and power off the bare metal machine immediately. </summary>
        public BareMetalMachineSkipShutdown? SkipShutdown { get; set; }
    }
}
