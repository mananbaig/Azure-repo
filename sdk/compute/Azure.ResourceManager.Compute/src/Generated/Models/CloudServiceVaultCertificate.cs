// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a single certificate reference in a Key Vault, and where the certificate should reside on the role instance. </summary>
    public partial class CloudServiceVaultCertificate
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudServiceVaultCertificate"/>. </summary>
        public CloudServiceVaultCertificate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceVaultCertificate"/>. </summary>
        /// <param name="certificateUri"> This is the URL of a certificate that has been uploaded to Key Vault as a secret. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudServiceVaultCertificate(Uri certificateUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CertificateUri = certificateUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> This is the URL of a certificate that has been uploaded to Key Vault as a secret. </summary>
        public Uri CertificateUri { get; set; }
    }
}
