// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes the parameters for using a user's KeyVault certificate for securing custom domain. </summary>
    public partial class KeyVaultCertificateSource
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

        /// <summary> Initializes a new instance of <see cref="KeyVaultCertificateSource"/>. </summary>
        /// <param name="sourceType"></param>
        /// <param name="subscriptionId"> Subscription Id of the user's Key Vault containing the SSL certificate. </param>
        /// <param name="resourceGroupName"> Resource group of the user's Key Vault containing the SSL certificate. </param>
        /// <param name="vaultName"> The name of the user's Key Vault containing the SSL certificate. </param>
        /// <param name="secretName"> The name of Key Vault Secret (representing the full certificate PFX) in Key Vault. </param>
        /// <param name="updateRule"> Describes the action that shall be taken when the certificate is updated in Key Vault. </param>
        /// <param name="deleteRule"> Describes the action that shall be taken when the certificate is removed from Key Vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="secretName"/> is null. </exception>
        public KeyVaultCertificateSource(KeyVaultCertificateSourceType sourceType, string subscriptionId, string resourceGroupName, string vaultName, string secretName, CertificateUpdateAction updateRule, CertificateDeleteAction deleteRule)
        {
            Argument.AssertNotNull(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNull(vaultName, nameof(vaultName));
            Argument.AssertNotNull(secretName, nameof(secretName));

            SourceType = sourceType;
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            VaultName = vaultName;
            SecretName = secretName;
            UpdateRule = updateRule;
            DeleteRule = deleteRule;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultCertificateSource"/>. </summary>
        /// <param name="sourceType"></param>
        /// <param name="subscriptionId"> Subscription Id of the user's Key Vault containing the SSL certificate. </param>
        /// <param name="resourceGroupName"> Resource group of the user's Key Vault containing the SSL certificate. </param>
        /// <param name="vaultName"> The name of the user's Key Vault containing the SSL certificate. </param>
        /// <param name="secretName"> The name of Key Vault Secret (representing the full certificate PFX) in Key Vault. </param>
        /// <param name="secretVersion"> The version(GUID) of Key Vault Secret in Key Vault. </param>
        /// <param name="updateRule"> Describes the action that shall be taken when the certificate is updated in Key Vault. </param>
        /// <param name="deleteRule"> Describes the action that shall be taken when the certificate is removed from Key Vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultCertificateSource(KeyVaultCertificateSourceType sourceType, string subscriptionId, string resourceGroupName, string vaultName, string secretName, string secretVersion, CertificateUpdateAction updateRule, CertificateDeleteAction deleteRule, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceType = sourceType;
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            VaultName = vaultName;
            SecretName = secretName;
            SecretVersion = secretVersion;
            UpdateRule = updateRule;
            DeleteRule = deleteRule;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultCertificateSource"/> for deserialization. </summary>
        internal KeyVaultCertificateSource()
        {
        }

        /// <summary> Gets or sets the source type. </summary>
        public KeyVaultCertificateSourceType SourceType { get; set; }
        /// <summary> Subscription Id of the user's Key Vault containing the SSL certificate. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> Resource group of the user's Key Vault containing the SSL certificate. </summary>
        public string ResourceGroupName { get; set; }
        /// <summary> The name of the user's Key Vault containing the SSL certificate. </summary>
        public string VaultName { get; set; }
        /// <summary> The name of Key Vault Secret (representing the full certificate PFX) in Key Vault. </summary>
        public string SecretName { get; set; }
        /// <summary> The version(GUID) of Key Vault Secret in Key Vault. </summary>
        public string SecretVersion { get; set; }
        /// <summary> Describes the action that shall be taken when the certificate is updated in Key Vault. </summary>
        public CertificateUpdateAction UpdateRule { get; set; }
        /// <summary> Describes the action that shall be taken when the certificate is removed from Key Vault. </summary>
        public CertificateDeleteAction DeleteRule { get; set; }
    }
}
