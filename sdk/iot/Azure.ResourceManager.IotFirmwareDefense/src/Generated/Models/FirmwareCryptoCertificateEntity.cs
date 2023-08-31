// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Information on an entity (distinguished name) in a cryptographic certificate. </summary>
    public partial class FirmwareCryptoCertificateEntity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoCertificateEntity"/>. </summary>
        internal FirmwareCryptoCertificateEntity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoCertificateEntity"/>. </summary>
        /// <param name="commonName"> Common name of the certificate entity. </param>
        /// <param name="organization"> Organization of the certificate entity. </param>
        /// <param name="organizationalUnit"> The organizational unit of the certificate entity. </param>
        /// <param name="state"> Geographical state or province of the certificate entity. </param>
        /// <param name="country"> Country code of the certificate entity. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FirmwareCryptoCertificateEntity(string commonName, string organization, string organizationalUnit, string state, string country, Dictionary<string, BinaryData> rawData)
        {
            CommonName = commonName;
            Organization = organization;
            OrganizationalUnit = organizationalUnit;
            State = state;
            Country = country;
            _rawData = rawData;
        }

        /// <summary> Common name of the certificate entity. </summary>
        public string CommonName { get; }
        /// <summary> Organization of the certificate entity. </summary>
        public string Organization { get; }
        /// <summary> The organizational unit of the certificate entity. </summary>
        public string OrganizationalUnit { get; }
        /// <summary> Geographical state or province of the certificate entity. </summary>
        public string State { get; }
        /// <summary> Country code of the certificate entity. </summary>
        public string Country { get; }
    }
}
