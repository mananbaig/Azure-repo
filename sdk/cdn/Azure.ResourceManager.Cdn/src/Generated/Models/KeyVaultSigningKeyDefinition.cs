// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes the parameters for using a user&apos;s KeyVault for URL Signing Key. </summary>
    public partial class KeyVaultSigningKeyDefinition
    {
        /// <summary> Initializes a new instance of KeyVaultSigningKeyDefinition. </summary>
        /// <param name="typeDefinition"></param>
        /// <param name="subscriptionId"> Subscription Id of the user&apos;s Key Vault containing the secret. </param>
        /// <param name="resourceGroupName"> Resource group of the user&apos;s Key Vault containing the secret. </param>
        /// <param name="vaultName"> The name of the user&apos;s Key Vault containing the secret. </param>
        /// <param name="secretName"> The name of secret in Key Vault. </param>
        /// <param name="secretVersion"> The version(GUID) of secret in Key Vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="secretName"/> or <paramref name="secretVersion"/> is null. </exception>
        public KeyVaultSigningKeyDefinition(KeyVaultSigningKeyType typeDefinition, string subscriptionId, string resourceGroupName, string vaultName, string secretName, string secretVersion)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }
            if (secretVersion == null)
            {
                throw new ArgumentNullException(nameof(secretVersion));
            }

            TypeDefinition = typeDefinition;
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            VaultName = vaultName;
            SecretName = secretName;
            SecretVersion = secretVersion;
        }

        /// <summary> Gets or sets the type definition. </summary>
        public KeyVaultSigningKeyType TypeDefinition { get; set; }
        /// <summary> Subscription Id of the user&apos;s Key Vault containing the secret. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> Resource group of the user&apos;s Key Vault containing the secret. </summary>
        public string ResourceGroupName { get; set; }
        /// <summary> The name of the user&apos;s Key Vault containing the secret. </summary>
        public string VaultName { get; set; }
        /// <summary> The name of secret in Key Vault. </summary>
        public string SecretName { get; set; }
        /// <summary> The version(GUID) of secret in Key Vault. </summary>
        public string SecretVersion { get; set; }
    }
}
