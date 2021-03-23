// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Customer Certificate used for https
    /// </summary>
    public partial class CustomerCertificate : Certificate
    {
        /// <summary>
        /// Initializes a new instance of the CustomerCertificate class.
        /// </summary>
        public CustomerCertificate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomerCertificate class.
        /// </summary>
        /// <param name="certificateUrl">Complete Url to the
        /// certificate</param>
        /// <param name="subject">Subject name in the certificate.</param>
        /// <param name="expirationDate">Certificate expiration date.</param>
        /// <param name="thumbprint">Certificate thumbprint.</param>
        /// <param name="version">Certificate version.</param>
        /// <param name="certificateAuthority">Certificate issuing
        /// authority.</param>
        /// <param name="useLatestVersion">Whether to use the latest version
        /// for the certificate</param>
        /// <param name="subjectAlternativeNames">The list of SANs.</param>
        public CustomerCertificate(string certificateUrl, string subject = default(string), string expirationDate = default(string), string thumbprint = default(string), string version = default(string), string certificateAuthority = default(string), bool? useLatestVersion = default(bool?), IList<string> subjectAlternativeNames = default(IList<string>))
            : base(subject, expirationDate, thumbprint)
        {
            Version = version;
            CertificateAuthority = certificateAuthority;
            CertificateUrl = certificateUrl;
            UseLatestVersion = useLatestVersion;
            SubjectAlternativeNames = subjectAlternativeNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets certificate version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets certificate issuing authority.
        /// </summary>
        [JsonProperty(PropertyName = "certificateAuthority")]
        public string CertificateAuthority { get; set; }

        /// <summary>
        /// Gets or sets complete Url to the certificate
        /// </summary>
        [JsonProperty(PropertyName = "certificateUrl")]
        public string CertificateUrl { get; set; }

        /// <summary>
        /// Gets or sets whether to use the latest version for the certificate
        /// </summary>
        [JsonProperty(PropertyName = "useLatestVersion")]
        public bool? UseLatestVersion { get; set; }

        /// <summary>
        /// Gets or sets the list of SANs.
        /// </summary>
        [JsonProperty(PropertyName = "subjectAlternativeNames")]
        public IList<string> SubjectAlternativeNames { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CertificateUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CertificateUrl");
            }
        }
    }
}
