// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kubernetes.Models
{
    /// <summary> The list of credential result response. </summary>
    public partial class CredentialResults
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CredentialResults"/>. </summary>
        internal CredentialResults()
        {
            Kubeconfigs = new ChangeTrackingList<CredentialResult>();
        }

        /// <summary> Initializes a new instance of <see cref="CredentialResults"/>. </summary>
        /// <param name="hybridConnectionConfig"> Contains the REP (rendezvous endpoint) and “Sender” access token. </param>
        /// <param name="kubeconfigs"> Base64-encoded Kubernetes configuration file. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CredentialResults(HybridConnectionConfig hybridConnectionConfig, IReadOnlyList<CredentialResult> kubeconfigs, Dictionary<string, BinaryData> rawData)
        {
            HybridConnectionConfig = hybridConnectionConfig;
            Kubeconfigs = kubeconfigs;
            _rawData = rawData;
        }

        /// <summary> Contains the REP (rendezvous endpoint) and “Sender” access token. </summary>
        public HybridConnectionConfig HybridConnectionConfig { get; }
        /// <summary> Base64-encoded Kubernetes configuration file. </summary>
        public IReadOnlyList<CredentialResult> Kubeconfigs { get; }
    }
}
