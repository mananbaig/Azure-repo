// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a single certificate reference in a Key Vault, and where the
    /// certificate should reside on the VM.
    /// </summary>
    public partial class VaultCertificate
    {
        /// <summary>
        /// Initializes a new instance of the VaultCertificate class.
        /// </summary>
        public VaultCertificate() { }

        /// <summary>
        /// Initializes a new instance of the VaultCertificate class.
        /// </summary>
        /// <param name="certificateUrl">the URL referencing a secret in a Key
        /// Vault which contains a properly formatted certificate.</param>
        /// <param name="certificateStore">the Certificate store in
        /// LocalMachine to add the certificate to on Windows, leave empty on
        /// Linux.</param>
        public VaultCertificate(string certificateUrl = default(string), string certificateStore = default(string))
        {
            CertificateUrl = certificateUrl;
            CertificateStore = certificateStore;
        }

        /// <summary>
        /// Gets or sets the URL referencing a secret in a Key Vault which
        /// contains a properly formatted certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateUrl")]
        public string CertificateUrl { get; set; }

        /// <summary>
        /// Gets or sets the Certificate store in LocalMachine to add the
        /// certificate to on Windows, leave empty on Linux.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateStore")]
        public string CertificateStore { get; set; }

    }
}
