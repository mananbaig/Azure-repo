// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> Data Lake Store account information to update. </summary>
    public partial class DataLakeStoreAccountPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountPatch"/>. </summary>
        public DataLakeStoreAccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            FirewallRules = new ChangeTrackingList<FirewallRuleForDataLakeStoreAccountUpdateContent>();
            VirtualNetworkRules = new ChangeTrackingList<VirtualNetworkRuleForDataLakeStoreAccountUpdateContent>();
            TrustedIdProviders = new ChangeTrackingList<TrustedIdProviderForDataLakeStoreAccountUpdateContent>();
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="defaultGroup"> The default owner group for all new folders and files created in the Data Lake Store account. </param>
        /// <param name="encryptionConfig"> Used for rotation of user managed Key Vault keys. Can only be used to rotate a user managed encryption Key Vault key. </param>
        /// <param name="firewallRules"> The list of firewall rules associated with this Data Lake Store account. </param>
        /// <param name="virtualNetworkRules"> The list of virtual network rules associated with this Data Lake Store account. </param>
        /// <param name="firewallState"> The current state of the IP address firewall for this Data Lake Store account. Disabling the firewall does not remove existing rules, they will just be ignored until the firewall is re-enabled. </param>
        /// <param name="firewallAllowAzureIPs"> The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced. </param>
        /// <param name="trustedIdProviders"> The list of trusted identity providers associated with this Data Lake Store account. </param>
        /// <param name="trustedIdProviderState"> The current state of the trusted identity provider feature for this Data Lake Store account. Disabling trusted identity provider functionality does not remove the providers, they will just be ignored until this feature is re-enabled. </param>
        /// <param name="newTier"> The commitment tier to use for next month. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreAccountPatch(IDictionary<string, string> tags, string defaultGroup, UpdateEncryptionConfig encryptionConfig, IList<FirewallRuleForDataLakeStoreAccountUpdateContent> firewallRules, IList<VirtualNetworkRuleForDataLakeStoreAccountUpdateContent> virtualNetworkRules, DataLakeStoreFirewallState? firewallState, DataLakeStoreFirewallAllowAzureIPsState? firewallAllowAzureIPs, IList<TrustedIdProviderForDataLakeStoreAccountUpdateContent> trustedIdProviders, DataLakeStoreTrustedIdProviderState? trustedIdProviderState, DataLakeStoreCommitmentTierType? newTier, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            DefaultGroup = defaultGroup;
            EncryptionConfig = encryptionConfig;
            FirewallRules = firewallRules;
            VirtualNetworkRules = virtualNetworkRules;
            FirewallState = firewallState;
            FirewallAllowAzureIPs = firewallAllowAzureIPs;
            TrustedIdProviders = trustedIdProviders;
            TrustedIdProviderState = trustedIdProviderState;
            NewTier = newTier;
            _rawData = rawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The default owner group for all new folders and files created in the Data Lake Store account. </summary>
        public string DefaultGroup { get; set; }
        /// <summary> Used for rotation of user managed Key Vault keys. Can only be used to rotate a user managed encryption Key Vault key. </summary>
        internal UpdateEncryptionConfig EncryptionConfig { get; set; }
        /// <summary> The version of the user managed encryption key to update through a key rotation. </summary>
        public string EncryptionKeyVersion
        {
            get => EncryptionConfig is null ? default : EncryptionConfig.EncryptionKeyVersion;
            set
            {
                if (EncryptionConfig is null)
                    EncryptionConfig = new UpdateEncryptionConfig();
                EncryptionConfig.EncryptionKeyVersion = value;
            }
        }

        /// <summary> The list of firewall rules associated with this Data Lake Store account. </summary>
        public IList<FirewallRuleForDataLakeStoreAccountUpdateContent> FirewallRules { get; }
        /// <summary> The list of virtual network rules associated with this Data Lake Store account. </summary>
        public IList<VirtualNetworkRuleForDataLakeStoreAccountUpdateContent> VirtualNetworkRules { get; }
        /// <summary> The current state of the IP address firewall for this Data Lake Store account. Disabling the firewall does not remove existing rules, they will just be ignored until the firewall is re-enabled. </summary>
        public DataLakeStoreFirewallState? FirewallState { get; set; }
        /// <summary> The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced. </summary>
        public DataLakeStoreFirewallAllowAzureIPsState? FirewallAllowAzureIPs { get; set; }
        /// <summary> The list of trusted identity providers associated with this Data Lake Store account. </summary>
        public IList<TrustedIdProviderForDataLakeStoreAccountUpdateContent> TrustedIdProviders { get; }
        /// <summary> The current state of the trusted identity provider feature for this Data Lake Store account. Disabling trusted identity provider functionality does not remove the providers, they will just be ignored until this feature is re-enabled. </summary>
        public DataLakeStoreTrustedIdProviderState? TrustedIdProviderState { get; set; }
        /// <summary> The commitment tier to use for next month. </summary>
        public DataLakeStoreCommitmentTierType? NewTier { get; set; }
    }
}
