// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties to secure a domain. </summary>
    public partial class FrontDoorCustomDomainHttpsContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorCustomDomainHttpsContent"/>. </summary>
        /// <param name="certificateType"> Defines the source of the SSL certificate. </param>
        public FrontDoorCustomDomainHttpsContent(FrontDoorCertificateType certificateType)
        {
            CertificateType = certificateType;
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorCustomDomainHttpsContent"/>. </summary>
        /// <param name="certificateType"> Defines the source of the SSL certificate. </param>
        /// <param name="minimumTlsVersion"> TLS protocol version that will be used for Https. </param>
        /// <param name="secret"> Resource reference to the secret. ie. subs/rg/profile/secret. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorCustomDomainHttpsContent(FrontDoorCertificateType certificateType, FrontDoorMinimumTlsVersion? minimumTlsVersion, FrontDoorCustomDomainHttpsContentSecret secret, Dictionary<string, BinaryData> rawData)
        {
            CertificateType = certificateType;
            MinimumTlsVersion = minimumTlsVersion;
            Secret = secret;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorCustomDomainHttpsContent"/> for deserialization. </summary>
        internal FrontDoorCustomDomainHttpsContent()
        {
        }

        /// <summary> Defines the source of the SSL certificate. </summary>
        public FrontDoorCertificateType CertificateType { get; set; }
        /// <summary> TLS protocol version that will be used for Https. </summary>
        public FrontDoorMinimumTlsVersion? MinimumTlsVersion { get; set; }
        /// <summary> Resource reference to the secret. ie. subs/rg/profile/secret. </summary>
        internal FrontDoorCustomDomainHttpsContentSecret Secret { get; set; }
        /// <summary> Resource ID. </summary>
        public ResourceIdentifier SecretId
        {
            get => Secret is null ? default : Secret.Id;
            set
            {
                if (Secret is null)
                    Secret = new FrontDoorCustomDomainHttpsContentSecret();
                Secret.Id = value;
            }
        }
    }
}
