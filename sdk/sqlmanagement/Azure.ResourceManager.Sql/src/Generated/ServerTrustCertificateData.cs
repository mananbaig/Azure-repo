// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ServerTrustCertificate data model.
    /// Server trust certificate imported from box to enable connection between box and Sql Managed Instance.
    /// </summary>
    public partial class ServerTrustCertificateData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ServerTrustCertificateData"/>. </summary>
        public ServerTrustCertificateData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServerTrustCertificateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="publicBlob"> The certificate public blob. </param>
        /// <param name="thumbprint"> The certificate thumbprint. </param>
        /// <param name="certificateName"> The certificate name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServerTrustCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string publicBlob, string thumbprint, string certificateName, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            PublicBlob = publicBlob;
            Thumbprint = thumbprint;
            CertificateName = certificateName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The certificate public blob. </summary>
        public string PublicBlob { get; set; }
        /// <summary> The certificate thumbprint. </summary>
        public string Thumbprint { get; }
        /// <summary> The certificate name. </summary>
        public string CertificateName { get; }
    }
}
