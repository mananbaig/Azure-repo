// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlFirewallRule.
/// </summary>
public partial class SqlFirewallRule : Resource
{
    /// <summary>
    /// The name of the firewall rule.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The end IP address of the firewall rule. Must be IPv4 format. Must be
    /// greater than or equal to startIpAddress. Use value &apos;0.0.0.0&apos;
    /// for all Azure-internal IP addresses.
    /// </summary>
    public BicepValue<string> EndIPAddress { get => _endIPAddress; set => _endIPAddress.Assign(value); }
    private readonly BicepValue<string> _endIPAddress;

    /// <summary>
    /// The start IP address of the firewall rule. Must be IPv4 format. Use
    /// value &apos;0.0.0.0&apos; for all Azure-internal IP addresses.
    /// </summary>
    public BicepValue<string> StartIPAddress { get => _startIPAddress; set => _startIPAddress.Assign(value); }
    private readonly BicepValue<string> _startIPAddress;

    /// <summary>
    /// Resource ID.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets or sets a reference to the parent SqlServer.
    /// </summary>
    public SqlServer? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlServer> _parent;

    /// <summary>
    /// Creates a new SqlFirewallRule.
    /// </summary>
    /// <param name="resourceName">Name of the SqlFirewallRule.</param>
    /// <param name="resourceVersion">Version of the SqlFirewallRule.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SqlFirewallRule(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Sql/servers/firewallRules", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _endIPAddress = BicepValue<string>.DefineProperty(this, "EndIPAddress", ["properties", "endIpAddress"]);
        _startIPAddress = BicepValue<string>.DefineProperty(this, "StartIPAddress", ["properties", "startIpAddress"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _parent = ResourceReference<SqlServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing SqlFirewallRule.
    /// </summary>
    /// <param name="resourceName">Name of the SqlFirewallRule.</param>
    /// <param name="resourceVersion">Version of the SqlFirewallRule.</param>
    /// <returns>The existing SqlFirewallRule resource.</returns>
    public static SqlFirewallRule FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this SqlFirewallRule resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 128, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period | ResourceNameCharacters.Parentheses);
}
