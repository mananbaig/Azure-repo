// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Collection of SecurityProviders. </summary>
    public partial class VirtualWanSecurityProviders
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualWanSecurityProviders"/>. </summary>
        internal VirtualWanSecurityProviders()
        {
            SupportedProviders = new ChangeTrackingList<VirtualWanSecurityProvider>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualWanSecurityProviders"/>. </summary>
        /// <param name="supportedProviders"> List of VirtualWAN security providers. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualWanSecurityProviders(IReadOnlyList<VirtualWanSecurityProvider> supportedProviders, Dictionary<string, BinaryData> rawData)
        {
            SupportedProviders = supportedProviders;
            _rawData = rawData;
        }

        /// <summary> List of VirtualWAN security providers. </summary>
        public IReadOnlyList<VirtualWanSecurityProvider> SupportedProviders { get; }
    }
}
