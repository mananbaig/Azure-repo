// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.MetricsAdvisor.Administration;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The UnknownDataSourceCredential. </summary>
    internal partial class UnknownDataSourceCredential : DataSourceCredentialEntity
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDataSourceCredential"/>. </summary>
        /// <param name="credentialKind"> Type of data source credential. </param>
        /// <param name="id"> Unique id of data source credential. </param>
        /// <param name="name"> Name of data source credential. </param>
        /// <param name="description"> Description of data source credential. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDataSourceCredential(DataSourceCredentialKind credentialKind, string id, string name, string description, Dictionary<string, BinaryData> rawData) : base(credentialKind, id, name, description, rawData)
        {
            CredentialKind = credentialKind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownDataSourceCredential"/> for deserialization. </summary>
        internal UnknownDataSourceCredential()
        {
        }
    }
}
