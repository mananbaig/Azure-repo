// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A list of PEM formatted certificates.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.VideoAnalyzer.PemCertificateList")]
    public partial class PemCertificateList : CertificateSource
    {
        /// <summary>
        /// Initializes a new instance of the PemCertificateList class.
        /// </summary>
        public PemCertificateList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PemCertificateList class.
        /// </summary>
        /// <param name="certificates">PEM formatted public certificates. One
        /// certificate per entry.</param>
        public PemCertificateList(IList<string> certificates)
        {
            Certificates = certificates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets PEM formatted public certificates. One certificate per
        /// entry.
        /// </summary>
        [JsonProperty(PropertyName = "certificates")]
        public IList<string> Certificates { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Certificates == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Certificates");
            }
        }
    }
}
