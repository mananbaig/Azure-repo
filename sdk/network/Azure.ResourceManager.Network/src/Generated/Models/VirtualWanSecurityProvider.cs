// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Collection of SecurityProviders. </summary>
    public partial class VirtualWanSecurityProvider
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualWanSecurityProvider"/>. </summary>
        internal VirtualWanSecurityProvider()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualWanSecurityProvider"/>. </summary>
        /// <param name="name"> Name of the security provider. </param>
        /// <param name="uri"> Url of the security provider. </param>
        /// <param name="providerType"> Name of the security provider. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualWanSecurityProvider(string name, Uri uri, VirtualWanSecurityProviderType? providerType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Uri = uri;
            ProviderType = providerType;
            _rawData = rawData;
        }

        /// <summary> Name of the security provider. </summary>
        public string Name { get; }
        /// <summary> Url of the security provider. </summary>
        public Uri Uri { get; }
        /// <summary> Name of the security provider. </summary>
        public VirtualWanSecurityProviderType? ProviderType { get; }
    }
}
