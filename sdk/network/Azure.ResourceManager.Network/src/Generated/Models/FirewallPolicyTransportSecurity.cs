// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Configuration needed to perform TLS termination &amp; initiation. </summary>
    internal partial class FirewallPolicyTransportSecurity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyTransportSecurity"/>. </summary>
        public FirewallPolicyTransportSecurity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyTransportSecurity"/>. </summary>
        /// <param name="certificateAuthority"> The CA used for intermediate CA generation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallPolicyTransportSecurity(FirewallPolicyCertificateAuthority certificateAuthority, Dictionary<string, BinaryData> rawData)
        {
            CertificateAuthority = certificateAuthority;
            _rawData = rawData;
        }

        /// <summary> The CA used for intermediate CA generation. </summary>
        public FirewallPolicyCertificateAuthority CertificateAuthority { get; set; }
    }
}
