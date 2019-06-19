// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SSL certificate details.
    /// </summary>
    public partial class CertificateDetails
    {
        /// <summary>
        /// Initializes a new instance of the CertificateDetails class.
        /// </summary>
        public CertificateDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateDetails class.
        /// </summary>
        /// <param name="version">Certificate Version.</param>
        /// <param name="serialNumber">Certificate Serial Number.</param>
        /// <param name="thumbprint">Certificate Thumbprint.</param>
        /// <param name="subject">Certificate Subject.</param>
        /// <param name="notBefore">Date Certificate is valid from.</param>
        /// <param name="notAfter">Date Certificate is valid to.</param>
        /// <param name="signatureAlgorithm">Certificate Signature
        /// algorithm.</param>
        /// <param name="issuer">Certificate Issuer.</param>
        /// <param name="rawData">Raw certificate data.</param>
        public CertificateDetails(int? version = default(int?), string serialNumber = default(string), string thumbprint = default(string), string subject = default(string), System.DateTime? notBefore = default(System.DateTime?), System.DateTime? notAfter = default(System.DateTime?), string signatureAlgorithm = default(string), string issuer = default(string), string rawData = default(string))
        {
            Version = version;
            SerialNumber = serialNumber;
            Thumbprint = thumbprint;
            Subject = subject;
            NotBefore = notBefore;
            NotAfter = notAfter;
            SignatureAlgorithm = signatureAlgorithm;
            Issuer = issuer;
            RawData = rawData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets certificate Version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; private set; }

        /// <summary>
        /// Gets certificate Serial Number.
        /// </summary>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; private set; }

        /// <summary>
        /// Gets certificate Thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; private set; }

        /// <summary>
        /// Gets certificate Subject.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; private set; }

        /// <summary>
        /// Gets date Certificate is valid from.
        /// </summary>
        [JsonProperty(PropertyName = "notBefore")]
        public System.DateTime? NotBefore { get; private set; }

        /// <summary>
        /// Gets date Certificate is valid to.
        /// </summary>
        [JsonProperty(PropertyName = "notAfter")]
        public System.DateTime? NotAfter { get; private set; }

        /// <summary>
        /// Gets certificate Signature algorithm.
        /// </summary>
        [JsonProperty(PropertyName = "signatureAlgorithm")]
        public string SignatureAlgorithm { get; private set; }

        /// <summary>
        /// Gets certificate Issuer.
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string Issuer { get; private set; }

        /// <summary>
        /// Gets raw certificate data.
        /// </summary>
        [JsonProperty(PropertyName = "rawData")]
        public string RawData { get; private set; }

    }
}
