// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> KeyVault contract details. </summary>
    public partial class KeyVaultContractProperties : KeyVaultContractCreateProperties
    {
        /// <summary> Initializes a new instance of KeyVaultContractProperties. </summary>
        public KeyVaultContractProperties()
        {
        }

        /// <summary> Initializes a new instance of KeyVaultContractProperties. </summary>
        /// <param name="secretIdentifier"> Key vault secret identifier for fetching secret. Providing a versioned secret will prevent auto-refresh. This requires API Management service to be configured with aka.ms/apimmsi. </param>
        /// <param name="identityClientId"> Null for SystemAssignedIdentity or Client Id for UserAssignedIdentity , which will be used to access key vault secret. </param>
        /// <param name="lastStatus"> Last time sync and refresh status of secret from key vault. </param>
        internal KeyVaultContractProperties(string secretIdentifier, string identityClientId, KeyVaultLastAccessStatusContractProperties lastStatus) : base(secretIdentifier, identityClientId)
        {
            LastStatus = lastStatus;
        }

        /// <summary> Last time sync and refresh status of secret from key vault. </summary>
        public KeyVaultLastAccessStatusContractProperties LastStatus { get; set; }
    }
}
