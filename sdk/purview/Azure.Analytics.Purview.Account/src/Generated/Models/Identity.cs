// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Account.Models
{
    /// <summary> The Managed Identity of the resource. </summary>
    public partial class Identity
    {
        /// <summary> Initializes a new instance of Identity. </summary>
        internal Identity()
        {
        }

        /// <summary> Initializes a new instance of Identity. </summary>
        /// <param name="principalId"> Service principal object Id. </param>
        /// <param name="tenantId"> Tenant Id. </param>
        /// <param name="type"> Identity Type. </param>
        internal Identity(string principalId, string tenantId, Type? type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }

        /// <summary> Service principal object Id. </summary>
        public string PrincipalId { get; }
        /// <summary> Tenant Id. </summary>
        public string TenantId { get; }
        /// <summary> Identity Type. </summary>
        public Type? Type { get; }
    }
}
