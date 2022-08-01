// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Akamai Signature Header authentication key. </summary>
    public partial class AkamaiSignatureHeaderAuthenticationKey
    {
        /// <summary> Initializes a new instance of AkamaiSignatureHeaderAuthenticationKey. </summary>
        public AkamaiSignatureHeaderAuthenticationKey()
        {
        }

        /// <summary> Initializes a new instance of AkamaiSignatureHeaderAuthenticationKey. </summary>
        /// <param name="identifier"> identifier of the key. </param>
        /// <param name="base64Key"> authentication key. </param>
        /// <param name="expireOn"> The expiration time of the authentication key. </param>
        internal AkamaiSignatureHeaderAuthenticationKey(string identifier, string base64Key, DateTimeOffset? expireOn)
        {
            Identifier = identifier;
            Base64Key = base64Key;
            ExpireOn = expireOn;
        }

        /// <summary> identifier of the key. </summary>
        public string Identifier { get; set; }
        /// <summary> authentication key. </summary>
        public string Base64Key { get; set; }
        /// <summary> The expiration time of the authentication key. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
    }
}
