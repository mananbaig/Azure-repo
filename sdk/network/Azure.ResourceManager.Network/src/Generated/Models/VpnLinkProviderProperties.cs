// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of properties of a link provider. </summary>
    public partial class VpnLinkProviderProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VpnLinkProviderProperties"/>. </summary>
        public VpnLinkProviderProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VpnLinkProviderProperties"/>. </summary>
        /// <param name="linkProviderName"> Name of the link provider. </param>
        /// <param name="linkSpeedInMbps"> Link speed. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnLinkProviderProperties(string linkProviderName, int? linkSpeedInMbps, Dictionary<string, BinaryData> rawData)
        {
            LinkProviderName = linkProviderName;
            LinkSpeedInMbps = linkSpeedInMbps;
            _rawData = rawData;
        }

        /// <summary> Name of the link provider. </summary>
        public string LinkProviderName { get; set; }
        /// <summary> Link speed. </summary>
        public int? LinkSpeedInMbps { get; set; }
    }
}
