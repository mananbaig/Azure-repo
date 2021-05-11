﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// TODO.
    /// </summary>
    [CodeGenModel("ServicePrincipalCredential")]
    [CodeGenSuppress(nameof(ServicePrincipalCredentialEntity), typeof(string), typeof(ServicePrincipalParam))]
    public partial class ServicePrincipalCredentialEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePrincipalCredentialEntity"/> class.
        /// </summary>
        /// <param name="name">TODO.</param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="tenantId"></param>
        public ServicePrincipalCredentialEntity(string name, string clientId, string clientSecret, string tenantId) : base(name)
        {
            Argument.AssertNotNullOrEmpty(clientId, nameof(clientId));
            Argument.AssertNotNullOrEmpty(clientSecret, nameof(clientSecret));
            Argument.AssertNotNullOrEmpty(tenantId, nameof(tenantId));

            DataSourceCredentialType = DataSourceCredentialType.ServicePrincipal;
            ClientId = clientId;
            ClientSecret = clientSecret;
            TenantId = tenantId;
        }

        internal ServicePrincipalCredentialEntity(DataSourceCredentialType dataSourceCredentialType, string id, string name, string description, ServicePrincipalParam parameters) : base(dataSourceCredentialType, id, name, description)
        {
            DataSourceCredentialType = dataSourceCredentialType;
            ClientId = parameters.ClientId;
            ClientSecret = parameters.ClientSecret;
            TenantId = parameters.TenantId;
        }

        /// <summary>
        /// TODO.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// TODO.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// TODO.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// Used by CodeGen during serialization.
        /// </summary>
        internal ServicePrincipalParam Parameters => new ServicePrincipalParam(ClientId, ClientSecret, TenantId);
    }
}
