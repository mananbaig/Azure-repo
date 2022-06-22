// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Collection of SecurityProviders. </summary>
    public partial class VirtualWanSecurityProvider
    {
        /// <summary> Initializes a new instance of VirtualWanSecurityProvider. </summary>
        internal VirtualWanSecurityProvider()
        {
        }

        /// <summary> Initializes a new instance of VirtualWanSecurityProvider. </summary>
        /// <param name="name"> Name of the security provider. </param>
        /// <param name="uri"> Url of the security provider. </param>
        /// <param name="providerType"> Name of the security provider. </param>
        internal VirtualWanSecurityProvider(string name, string uri, VirtualWanSecurityProviderType? providerType)
        {
            Name = name;
            Uri = uri;
            ProviderType = providerType;
        }

        /// <summary> Name of the security provider. </summary>
        public string Name { get; }
        /// <summary> Url of the security provider. </summary>
        public string Uri { get; }
        /// <summary> Name of the security provider. </summary>
        public VirtualWanSecurityProviderType? ProviderType { get; }
    }
}
