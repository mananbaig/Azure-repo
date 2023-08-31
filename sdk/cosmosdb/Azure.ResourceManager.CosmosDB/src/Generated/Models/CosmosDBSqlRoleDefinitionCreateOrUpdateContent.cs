// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update an Azure Cosmos DB SQL Role Definition. </summary>
    public partial class CosmosDBSqlRoleDefinitionCreateOrUpdateContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlRoleDefinitionCreateOrUpdateContent"/>. </summary>
        public CosmosDBSqlRoleDefinitionCreateOrUpdateContent()
        {
            AssignableScopes = new ChangeTrackingList<string>();
            Permissions = new ChangeTrackingList<CosmosDBSqlRolePermission>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlRoleDefinitionCreateOrUpdateContent"/>. </summary>
        /// <param name="roleName"> A user-friendly name for the Role Definition. Must be unique for the database account. </param>
        /// <param name="roleDefinitionType"> Indicates whether the Role Definition was built-in or user created. </param>
        /// <param name="assignableScopes"> A set of fully qualified Scopes at or below which Role Assignments may be created using this Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Must have at least one element. Scopes higher than Database account are not enforceable as assignable Scopes. Note that resources referenced in assignable Scopes need not exist. </param>
        /// <param name="permissions"> The set of operations allowed through this Role Definition. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBSqlRoleDefinitionCreateOrUpdateContent(string roleName, CosmosDBSqlRoleDefinitionType? roleDefinitionType, IList<string> assignableScopes, IList<CosmosDBSqlRolePermission> permissions, Dictionary<string, BinaryData> rawData)
        {
            RoleName = roleName;
            RoleDefinitionType = roleDefinitionType;
            AssignableScopes = assignableScopes;
            Permissions = permissions;
            _rawData = rawData;
        }

        /// <summary> A user-friendly name for the Role Definition. Must be unique for the database account. </summary>
        public string RoleName { get; set; }
        /// <summary> Indicates whether the Role Definition was built-in or user created. </summary>
        public CosmosDBSqlRoleDefinitionType? RoleDefinitionType { get; set; }
        /// <summary> A set of fully qualified Scopes at or below which Role Assignments may be created using this Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Must have at least one element. Scopes higher than Database account are not enforceable as assignable Scopes. Note that resources referenced in assignable Scopes need not exist. </summary>
        public IList<string> AssignableScopes { get; }
        /// <summary> The set of operations allowed through this Role Definition. </summary>
        public IList<CosmosDBSqlRolePermission> Permissions { get; }
    }
}
