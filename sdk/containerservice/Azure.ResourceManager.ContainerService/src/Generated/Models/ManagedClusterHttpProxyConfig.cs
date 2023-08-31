// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Cluster HTTP proxy configuration. </summary>
    public partial class ManagedClusterHttpProxyConfig
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterHttpProxyConfig"/>. </summary>
        public ManagedClusterHttpProxyConfig()
        {
            NoProxy = new ChangeTrackingList<string>();
            EffectiveNoProxy = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterHttpProxyConfig"/>. </summary>
        /// <param name="httpProxy"> The HTTP proxy server endpoint to use. </param>
        /// <param name="httpsProxy"> The HTTPS proxy server endpoint to use. </param>
        /// <param name="noProxy"> The endpoints that should not go through proxy. </param>
        /// <param name="effectiveNoProxy"> A read-only list of all endpoints for which traffic should not be sent to the proxy. This list is a superset of noProxy and values injected by AKS. </param>
        /// <param name="trustedCA"> Alternative CA cert to use for connecting to proxy servers. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterHttpProxyConfig(string httpProxy, string httpsProxy, IList<string> noProxy, IReadOnlyList<string> effectiveNoProxy, string trustedCA, Dictionary<string, BinaryData> rawData)
        {
            HttpProxy = httpProxy;
            HttpsProxy = httpsProxy;
            NoProxy = noProxy;
            EffectiveNoProxy = effectiveNoProxy;
            TrustedCA = trustedCA;
            _rawData = rawData;
        }

        /// <summary> The HTTP proxy server endpoint to use. </summary>
        public string HttpProxy { get; set; }
        /// <summary> The HTTPS proxy server endpoint to use. </summary>
        public string HttpsProxy { get; set; }
        /// <summary> The endpoints that should not go through proxy. </summary>
        public IList<string> NoProxy { get; }
        /// <summary> A read-only list of all endpoints for which traffic should not be sent to the proxy. This list is a superset of noProxy and values injected by AKS. </summary>
        public IReadOnlyList<string> EffectiveNoProxy { get; }
        /// <summary> Alternative CA cert to use for connecting to proxy servers. </summary>
        public string TrustedCA { get; set; }
    }
}
