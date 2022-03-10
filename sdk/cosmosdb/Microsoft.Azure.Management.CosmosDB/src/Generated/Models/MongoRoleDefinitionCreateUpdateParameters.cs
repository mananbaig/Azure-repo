// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters to create and update an Azure Cosmos DB Mongo Role
    /// Definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MongoRoleDefinitionCreateUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MongoRoleDefinitionCreateUpdateParameters class.
        /// </summary>
        public MongoRoleDefinitionCreateUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MongoRoleDefinitionCreateUpdateParameters class.
        /// </summary>
        /// <param name="roleName">A user-friendly name for the Role
        /// Definition. Must be unique for the database account.</param>
        /// <param name="type">Indicates whether the Role Definition was
        /// built-in or user created. Possible values include: 'BuiltInRole',
        /// 'CustomRole'</param>
        /// <param name="databaseName">The database name for which access is
        /// being granted for this Role Definition.</param>
        /// <param name="privileges">A set of privileges contained by the Role
        /// Definition. This will allow application of this Role Definition on
        /// the entire database account or any underlying Database /
        /// Collection. Scopes higher than Database are not enforceable as
        /// privilege.</param>
        /// <param name="roles">The set of roles inherited by this Role
        /// Definition.</param>
        public MongoRoleDefinitionCreateUpdateParameters(string roleName = default(string), MongoRoleDefinitionType? type = default(MongoRoleDefinitionType?), string databaseName = default(string), IList<Privilege> privileges = default(IList<Privilege>), IList<Role> roles = default(IList<Role>))
        {
            RoleName = roleName;
            Type = type;
            DatabaseName = databaseName;
            Privileges = privileges;
            Roles = roles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a user-friendly name for the Role Definition. Must be
        /// unique for the database account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.roleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the Role Definition was built-in or
        /// user created. Possible values include: 'BuiltInRole', 'CustomRole'
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public MongoRoleDefinitionType? Type { get; set; }

        /// <summary>
        /// Gets or sets the database name for which access is being granted
        /// for this Role Definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets a set of privileges contained by the Role Definition.
        /// This will allow application of this Role Definition on the entire
        /// database account or any underlying Database / Collection. Scopes
        /// higher than Database are not enforceable as privilege.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privileges")]
        public IList<Privilege> Privileges { get; set; }

        /// <summary>
        /// Gets or sets the set of roles inherited by this Role Definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.roles")]
        public IList<Role> Roles { get; set; }

    }
}
