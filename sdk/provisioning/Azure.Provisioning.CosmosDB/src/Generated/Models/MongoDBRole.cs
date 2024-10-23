// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The set of roles permitted through this Role Definition.
/// </summary>
public partial class MongoDBRole : ProvisionableConstruct
{
    /// <summary>
    /// The database name the role is applied.
    /// </summary>
    public BicepValue<string> DBName { get => _dBName; set => _dBName.Assign(value); }
    private readonly BicepValue<string> _dBName;

    /// <summary>
    /// The role name.
    /// </summary>
    public BicepValue<string> Role { get => _role; set => _role.Assign(value); }
    private readonly BicepValue<string> _role;

    /// <summary>
    /// Creates a new MongoDBRole.
    /// </summary>
    public MongoDBRole()
    {
        _dBName = BicepValue<string>.DefineProperty(this, "DBName", ["db"]);
        _role = BicepValue<string>.DefineProperty(this, "Role", ["role"]);
    }
}
