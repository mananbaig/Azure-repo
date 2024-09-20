// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// A set of rules governing the network accessibility of a managed hsm pool.
/// </summary>
public partial class ManagedHsmNetworkRuleSet : ProvisioningConstruct
{
    /// <summary>
    /// Tells what traffic can bypass network rules. This can be
    /// &apos;AzureServices&apos; or &apos;None&apos;.  If not specified the
    /// default is &apos;AzureServices&apos;.
    /// </summary>
    public BicepValue<ManagedHsmNetworkRuleBypassOption> Bypass { get => _bypass; set => _bypass.Assign(value); }
    private readonly BicepValue<ManagedHsmNetworkRuleBypassOption> _bypass;

    /// <summary>
    /// The default action when no rule from ipRules and from
    /// virtualNetworkRules match. This is only used after the bypass property
    /// has been evaluated.
    /// </summary>
    public BicepValue<ManagedHsmNetworkRuleAction> DefaultAction { get => _defaultAction; set => _defaultAction.Assign(value); }
    private readonly BicepValue<ManagedHsmNetworkRuleAction> _defaultAction;

    /// <summary>
    /// The list of IP address rules.
    /// </summary>
    public BicepList<ManagedHsmIPRule> IPRules { get => _iPRules; set => _iPRules.Assign(value); }
    private readonly BicepList<ManagedHsmIPRule> _iPRules;

    /// <summary>
    /// The list of virtual network rules.
    /// </summary>
    public BicepList<ManagedHsmVirtualNetworkRule> VirtualNetworkRules { get => _virtualNetworkRules; set => _virtualNetworkRules.Assign(value); }
    private readonly BicepList<ManagedHsmVirtualNetworkRule> _virtualNetworkRules;

    /// <summary>
    /// Creates a new ManagedHsmNetworkRuleSet.
    /// </summary>
    public ManagedHsmNetworkRuleSet()
    {
        _bypass = BicepValue<ManagedHsmNetworkRuleBypassOption>.DefineProperty(this, "Bypass", ["bypass"]);
        _defaultAction = BicepValue<ManagedHsmNetworkRuleAction>.DefineProperty(this, "DefaultAction", ["defaultAction"]);
        _iPRules = BicepList<ManagedHsmIPRule>.DefineProperty(this, "IPRules", ["ipRules"]);
        _virtualNetworkRules = BicepList<ManagedHsmVirtualNetworkRule>.DefineProperty(this, "VirtualNetworkRules", ["virtualNetworkRules"]);
    }
}
