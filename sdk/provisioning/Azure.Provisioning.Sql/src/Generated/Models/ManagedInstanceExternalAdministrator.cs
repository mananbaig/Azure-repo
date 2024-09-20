// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Properties of a active directory administrator.
/// </summary>
public partial class ManagedInstanceExternalAdministrator : ProvisioningConstruct
{
    /// <summary>
    /// Type of the sever administrator.
    /// </summary>
    public BicepValue<SqlAdministratorType> AdministratorType { get => _administratorType; set => _administratorType.Assign(value); }
    private readonly BicepValue<SqlAdministratorType> _administratorType;

    /// <summary>
    /// Principal Type of the sever administrator.
    /// </summary>
    public BicepValue<SqlServerPrincipalType> PrincipalType { get => _principalType; set => _principalType.Assign(value); }
    private readonly BicepValue<SqlServerPrincipalType> _principalType;

    /// <summary>
    /// Login name of the server administrator.
    /// </summary>
    public BicepValue<string> Login { get => _login; set => _login.Assign(value); }
    private readonly BicepValue<string> _login;

    /// <summary>
    /// SID (object ID) of the server administrator.
    /// </summary>
    public BicepValue<Guid> Sid { get => _sid; set => _sid.Assign(value); }
    private readonly BicepValue<Guid> _sid;

    /// <summary>
    /// Tenant ID of the administrator.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; set => _tenantId.Assign(value); }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// Azure Active Directory only Authentication enabled.
    /// </summary>
    public BicepValue<bool> IsAzureADOnlyAuthenticationEnabled { get => _isAzureADOnlyAuthenticationEnabled; set => _isAzureADOnlyAuthenticationEnabled.Assign(value); }
    private readonly BicepValue<bool> _isAzureADOnlyAuthenticationEnabled;

    /// <summary>
    /// Creates a new ManagedInstanceExternalAdministrator.
    /// </summary>
    public ManagedInstanceExternalAdministrator()
    {
        _administratorType = BicepValue<SqlAdministratorType>.DefineProperty(this, "AdministratorType", ["administratorType"]);
        _principalType = BicepValue<SqlServerPrincipalType>.DefineProperty(this, "PrincipalType", ["principalType"]);
        _login = BicepValue<string>.DefineProperty(this, "Login", ["login"]);
        _sid = BicepValue<Guid>.DefineProperty(this, "Sid", ["sid"]);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["tenantId"]);
        _isAzureADOnlyAuthenticationEnabled = BicepValue<bool>.DefineProperty(this, "IsAzureADOnlyAuthenticationEnabled", ["azureADOnlyAuthentication"]);
    }
}
