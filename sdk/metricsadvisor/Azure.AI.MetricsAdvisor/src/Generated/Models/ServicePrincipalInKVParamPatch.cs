// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The ServicePrincipalInKVParamPatch. </summary>
    internal partial class ServicePrincipalInKVParamPatch
    {
        /// <summary> Initializes a new instance of ServicePrincipalInKVParamPatch. </summary>
        public ServicePrincipalInKVParamPatch()
        {
        }

        /// <summary> The Key Vault endpoint that storing the service principal. </summary>
        public string KeyVaultEndpoint { get; set; }
        /// <summary> The Client Id to access the Key Vault. </summary>
        public string KeyVaultClientId { get; set; }
        /// <summary> The Client Secret to access the Key Vault. </summary>
        public string KeyVaultClientSecret { get; set; }
        /// <summary> The secret name of the service principal's client Id in the Key Vault. </summary>
        public string ServicePrincipalIdNameInKV { get; set; }
        /// <summary> The secret name of the service principal's client secret in the Key Vault. </summary>
        public string ServicePrincipalSecretNameInKV { get; set; }
        /// <summary> The tenant id of your service principal. </summary>
        public string TenantId { get; set; }
    }
}
