// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> TLS settings for the resource. </summary>
    internal partial class WebPubSubTlsSettings
    {
        /// <summary> Initializes a new instance of <see cref="WebPubSubTlsSettings"/>. </summary>
        public WebPubSubTlsSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebPubSubTlsSettings"/>. </summary>
        /// <param name="clientCertEnabled"> Request client certificate during TLS handshake if enabled. </param>
        internal WebPubSubTlsSettings(bool? clientCertEnabled)
        {
            ClientCertEnabled = clientCertEnabled;
        }

        /// <summary> Request client certificate during TLS handshake if enabled. </summary>
        public bool? ClientCertEnabled { get; set; }
    }
}
