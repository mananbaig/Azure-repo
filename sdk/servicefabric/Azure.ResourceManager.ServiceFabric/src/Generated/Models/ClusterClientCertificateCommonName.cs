// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the client certificate details using common name. </summary>
    public partial class ClusterClientCertificateCommonName
    {
        /// <summary> Initializes a new instance of ClusterClientCertificateCommonName. </summary>
        /// <param name="isAdmin"> Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster. </param>
        /// <param name="certificateCommonName"> The common name of the client certificate. </param>
        /// <param name="certificateIssuerThumbprint"> The issuer thumbprint of the client certificate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateCommonName"/> or <paramref name="certificateIssuerThumbprint"/> is null. </exception>
        public ClusterClientCertificateCommonName(bool isAdmin, string certificateCommonName, BinaryData certificateIssuerThumbprint)
        {
            if (certificateCommonName == null)
            {
                throw new ArgumentNullException(nameof(certificateCommonName));
            }
            if (certificateIssuerThumbprint == null)
            {
                throw new ArgumentNullException(nameof(certificateIssuerThumbprint));
            }

            IsAdmin = isAdmin;
            CertificateCommonName = certificateCommonName;
            CertificateIssuerThumbprint = certificateIssuerThumbprint;
        }

        /// <summary> Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster. </summary>
        public bool IsAdmin { get; set; }
        /// <summary> The common name of the client certificate. </summary>
        public string CertificateCommonName { get; set; }
        /// <summary>
        /// The issuer thumbprint of the client certificate.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData CertificateIssuerThumbprint { get; set; }
    }
}
