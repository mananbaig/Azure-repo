// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// ContainerRegistryService.
/// </summary>
public partial class ContainerRegistryService : ProvisionableResource
{
    /// <summary>
    /// The name of the container registry.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// The SKU of the container registry.
    /// </summary>
    public ContainerRegistrySku Sku 
    {
        get { Initialize(); return _sku!; }
        set { Initialize(); AssignOrReplace(ref _sku, value); }
    }
    private ContainerRegistrySku? _sku;

    /// <summary>
    /// The encryption settings of container registry.
    /// </summary>
    public ContainerRegistryEncryption Encryption 
    {
        get { Initialize(); return _encryption!; }
        set { Initialize(); AssignOrReplace(ref _encryption, value); }
    }
    private ContainerRegistryEncryption? _encryption;

    /// <summary>
    /// The identity of the container registry.
    /// </summary>
    public ManagedServiceIdentity Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); AssignOrReplace(ref _identity, value); }
    }
    private ManagedServiceIdentity? _identity;

    /// <summary>
    /// The value that indicates whether the admin user is enabled.
    /// </summary>
    public BicepValue<bool> IsAdminUserEnabled 
    {
        get { Initialize(); return _isAdminUserEnabled!; }
        set { Initialize(); _isAdminUserEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isAdminUserEnabled;

    /// <summary>
    /// Enable a single data endpoint per region for serving data.
    /// </summary>
    public BicepValue<bool> IsDataEndpointEnabled 
    {
        get { Initialize(); return _isDataEndpointEnabled!; }
        set { Initialize(); _isDataEndpointEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isDataEndpointEnabled;

    /// <summary>
    /// Whether to allow trusted Azure services to access a network restricted
    /// registry.
    /// </summary>
    public BicepValue<ContainerRegistryNetworkRuleBypassOption> NetworkRuleBypassOptions 
    {
        get { Initialize(); return _networkRuleBypassOptions!; }
        set { Initialize(); _networkRuleBypassOptions!.Assign(value); }
    }
    private BicepValue<ContainerRegistryNetworkRuleBypassOption>? _networkRuleBypassOptions;

    /// <summary>
    /// The network rule set for a container registry.
    /// </summary>
    public ContainerRegistryNetworkRuleSet NetworkRuleSet 
    {
        get { Initialize(); return _networkRuleSet!; }
        set { Initialize(); AssignOrReplace(ref _networkRuleSet, value); }
    }
    private ContainerRegistryNetworkRuleSet? _networkRuleSet;

    /// <summary>
    /// The policies for a container registry.
    /// </summary>
    public ContainerRegistryPolicies Policies 
    {
        get { Initialize(); return _policies!; }
        set { Initialize(); AssignOrReplace(ref _policies, value); }
    }
    private ContainerRegistryPolicies? _policies;

    /// <summary>
    /// Whether or not public network access is allowed for the container
    /// registry.
    /// </summary>
    public BicepValue<ContainerRegistryPublicNetworkAccess> PublicNetworkAccess 
    {
        get { Initialize(); return _publicNetworkAccess!; }
        set { Initialize(); _publicNetworkAccess!.Assign(value); }
    }
    private BicepValue<ContainerRegistryPublicNetworkAccess>? _publicNetworkAccess;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// Whether or not zone redundancy is enabled for this container registry.
    /// </summary>
    public BicepValue<ContainerRegistryZoneRedundancy> ZoneRedundancy 
    {
        get { Initialize(); return _zoneRedundancy!; }
        set { Initialize(); _zoneRedundancy!.Assign(value); }
    }
    private BicepValue<ContainerRegistryZoneRedundancy>? _zoneRedundancy;

    /// <summary>
    /// The creation date of the container registry in ISO8601 format.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn 
    {
        get { Initialize(); return _createdOn!; }
    }
    private BicepValue<DateTimeOffset>? _createdOn;

    /// <summary>
    /// List of host names that will serve data when dataEndpointEnabled is
    /// true.
    /// </summary>
    public BicepList<string> DataEndpointHostNames 
    {
        get { Initialize(); return _dataEndpointHostNames!; }
    }
    private BicepList<string>? _dataEndpointHostNames;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The URL that can be used to log into the container registry.
    /// </summary>
    public BicepValue<string> LoginServer 
    {
        get { Initialize(); return _loginServer!; }
    }
    private BicepValue<string>? _loginServer;

    /// <summary>
    /// List of private endpoint connections for a container registry.
    /// </summary>
    public BicepList<ContainerRegistryPrivateEndpointConnectionData> PrivateEndpointConnections 
    {
        get { Initialize(); return _privateEndpointConnections!; }
    }
    private BicepList<ContainerRegistryPrivateEndpointConnectionData>? _privateEndpointConnections;

    /// <summary>
    /// The provisioning state of the container registry at the time the
    /// operation was called.
    /// </summary>
    public BicepValue<ContainerRegistryProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<ContainerRegistryProvisioningState>? _provisioningState;

    /// <summary>
    /// The status of the container registry at the time the operation was
    /// called.
    /// </summary>
    public ContainerRegistryResourceStatus Status 
    {
        get { Initialize(); return _status!; }
    }
    private ContainerRegistryResourceStatus? _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new ContainerRegistryService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerRegistryService resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryService.</param>
    public ContainerRegistryService(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ContainerRegistry/registries", resourceVersion ?? "2023-07-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerRegistryService.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _sku = DefineModelProperty<ContainerRegistrySku>("Sku", ["sku"], isRequired: true);
        _encryption = DefineModelProperty<ContainerRegistryEncryption>("Encryption", ["properties", "encryption"]);
        _identity = DefineModelProperty<ManagedServiceIdentity>("Identity", ["identity"]);
        _isAdminUserEnabled = DefineProperty<bool>("IsAdminUserEnabled", ["properties", "adminUserEnabled"]);
        _isDataEndpointEnabled = DefineProperty<bool>("IsDataEndpointEnabled", ["properties", "dataEndpointEnabled"]);
        _networkRuleBypassOptions = DefineProperty<ContainerRegistryNetworkRuleBypassOption>("NetworkRuleBypassOptions", ["properties", "networkRuleBypassOptions"]);
        _networkRuleSet = DefineModelProperty<ContainerRegistryNetworkRuleSet>("NetworkRuleSet", ["properties", "networkRuleSet"]);
        _policies = DefineModelProperty<ContainerRegistryPolicies>("Policies", ["properties", "policies"]);
        _publicNetworkAccess = DefineProperty<ContainerRegistryPublicNetworkAccess>("PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _zoneRedundancy = DefineProperty<ContainerRegistryZoneRedundancy>("ZoneRedundancy", ["properties", "zoneRedundancy"]);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["properties", "creationDate"], isOutput: true);
        _dataEndpointHostNames = DefineListProperty<string>("DataEndpointHostNames", ["properties", "dataEndpointHostNames"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _loginServer = DefineProperty<string>("LoginServer", ["properties", "loginServer"], isOutput: true);
        _privateEndpointConnections = DefineListProperty<ContainerRegistryPrivateEndpointConnectionData>("PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _provisioningState = DefineProperty<ContainerRegistryProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _status = DefineModelProperty<ContainerRegistryResourceStatus>("Status", ["properties", "status"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ContainerRegistryService resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2019-05-01.
        /// </summary>
        public static readonly string V2019_05_01 = "2019-05-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-03-01.
        /// </summary>
        public static readonly string V2017_03_01 = "2017-03-01";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerRegistryService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerRegistryService resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerRegistryService.</param>
    /// <returns>The existing ContainerRegistryService resource.</returns>
    public static ContainerRegistryService FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ContainerRegistryService resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 5, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers);

    /// <summary>
    /// Creates a role assignment for a user-assigned identity that grants
    /// access to this ContainerRegistryService.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(ContainerRegistryBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{BicepIdentifier}_{identity.BicepIdentifier}_{ContainerRegistryBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Creates a role assignment for a principal that grants access to this
    /// ContainerRegistryService.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <param name="bicepIdentifierSuffix">Optional role assignment identifier name suffix.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(ContainerRegistryBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId, string? bicepIdentifierSuffix = default) =>
        new($"{BicepIdentifier}_{ContainerRegistryBuiltInRole.GetBuiltInRoleName(role)}{(bicepIdentifierSuffix is null ? "" : "_")}{bicepIdentifierSuffix}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
