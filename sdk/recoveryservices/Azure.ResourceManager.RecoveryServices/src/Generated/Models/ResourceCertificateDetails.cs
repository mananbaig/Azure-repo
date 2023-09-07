// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary>
    /// Certificate details representing the Vault credentials.
    /// Please note <see cref="ResourceCertificateDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ResourceCertificateAndAcsDetails"/> and <see cref="ResourceCertificateAndAadDetails"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownResourceCertificateDetails))]
    public abstract partial class ResourceCertificateDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceCertificateDetails"/>. </summary>
        protected ResourceCertificateDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceCertificateDetails"/>. </summary>
        /// <param name="authType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="certificate"> The base64 encoded certificate raw data string. </param>
        /// <param name="friendlyName"> Certificate friendly name. </param>
        /// <param name="issuer"> Certificate issuer. </param>
        /// <param name="resourceId"> Resource ID of the vault. </param>
        /// <param name="subject"> Certificate Subject Name. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        /// <param name="validStartOn"> Certificate Validity start Date time. </param>
        /// <param name="validEndOn"> Certificate Validity End Date time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceCertificateDetails(string authType, byte[] certificate, string friendlyName, string issuer, long? resourceId, string subject, BinaryData thumbprint, DateTimeOffset? validStartOn, DateTimeOffset? validEndOn, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AuthType = authType;
            Certificate = certificate;
            FriendlyName = friendlyName;
            Issuer = issuer;
            ResourceId = resourceId;
            Subject = subject;
            Thumbprint = thumbprint;
            ValidStartOn = validStartOn;
            ValidEndOn = validEndOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </summary>
        internal string AuthType { get; set; }
        /// <summary> The base64 encoded certificate raw data string. </summary>
        public byte[] Certificate { get; }
        /// <summary> Certificate friendly name. </summary>
        public string FriendlyName { get; }
        /// <summary> Certificate issuer. </summary>
        public string Issuer { get; }
        /// <summary> Resource ID of the vault. </summary>
        public long? ResourceId { get; }
        /// <summary> Certificate Subject Name. </summary>
        public string Subject { get; }
        /// <summary>
        /// Certificate thumbprint.
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
        public BinaryData Thumbprint { get; }
        /// <summary> Certificate Validity start Date time. </summary>
        public DateTimeOffset? ValidStartOn { get; }
        /// <summary> Certificate Validity End Date time. </summary>
        public DateTimeOffset? ValidEndOn { get; }
    }
}
