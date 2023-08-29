// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    /// <summary> The ServicePrincipalInKVCredential. </summary>
    public partial class ServicePrincipalInKeyVaultCredentialEntity : DataSourceCredentialEntity
    {
        /// <summary> Initializes a new instance of <see cref="ServicePrincipalInKeyVaultCredentialEntity"/>. </summary>
        /// <param name="credentialKind"> Type of data source credential. </param>
        /// <param name="id"> Unique id of data source credential. </param>
        /// <param name="name"> Name of data source credential. </param>
        /// <param name="description"> Description of data source credential. </param>
        /// <param name="parameters"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServicePrincipalInKeyVaultCredentialEntity(DataSourceCredentialKind credentialKind, string id, string name, string description, ServicePrincipalInKVParam parameters, Dictionary<string, BinaryData> rawData) : base(credentialKind, id, name, description, rawData)
        {
            Parameters = parameters;
            CredentialKind = credentialKind;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalInKeyVaultCredentialEntity"/> for deserialization. </summary>
        internal ServicePrincipalInKeyVaultCredentialEntity()
        {
        }
    }
}
