// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Upstream auth settings. If not set, no auth is used for upstream messages. </summary>
    public partial class UpstreamAuthSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UpstreamAuthSettings"/>. </summary>
        public UpstreamAuthSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpstreamAuthSettings"/>. </summary>
        /// <param name="authType"> Upstream auth type enum. </param>
        /// <param name="managedIdentity"> Managed identity settings for upstream. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpstreamAuthSettings(UpstreamAuthType? authType, ManagedIdentitySettings managedIdentity, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AuthType = authType;
            ManagedIdentity = managedIdentity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Upstream auth type enum. </summary>
        public UpstreamAuthType? AuthType { get; set; }
        /// <summary> Managed identity settings for upstream. </summary>
        internal ManagedIdentitySettings ManagedIdentity { get; set; }
        /// <summary>
        /// The Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </summary>
        public string ManagedIdentityResource
        {
            get => ManagedIdentity is null ? default : ManagedIdentity.Resource;
            set
            {
                if (ManagedIdentity is null)
                    ManagedIdentity = new ManagedIdentitySettings();
                ManagedIdentity.Resource = value;
            }
        }
    }
}
