// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// SiteHybridConnectionNamespaceRelay.
/// </summary>
public partial class SiteHybridConnectionNamespaceRelay : Resource
{
    /// <summary>
    /// The namespace for this hybrid connection.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The relay name for this hybrid connection.
    /// </summary>
    public BicepValue<string> RelayName { get => _relayName; set => _relayName.Assign(value); }
    private readonly BicepValue<string> _relayName;

    /// <summary>
    /// The hostname of the endpoint.
    /// </summary>
    public BicepValue<string> Hostname { get => _hostname; set => _hostname.Assign(value); }
    private readonly BicepValue<string> _hostname;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// The port of the endpoint.
    /// </summary>
    public BicepValue<int> Port { get => _port; set => _port.Assign(value); }
    private readonly BicepValue<int> _port;

    /// <summary>
    /// The ARM URI to the Service Bus relay.
    /// </summary>
    public BicepValue<ResourceIdentifier> RelayArmId { get => _relayArmId; set => _relayArmId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _relayArmId;

    /// <summary>
    /// The name of the Service Bus key which has Send permissions. This is
    /// used to authenticate to Service Bus.
    /// </summary>
    public BicepValue<string> SendKeyName { get => _sendKeyName; set => _sendKeyName.Assign(value); }
    private readonly BicepValue<string> _sendKeyName;

    /// <summary>
    /// The value of the Service Bus key. This is used to authenticate to
    /// Service Bus. In ARM this key will not be returned
    /// normally, use the POST /listKeys API instead.
    /// </summary>
    public BicepValue<string> SendKeyValue { get => _sendKeyValue; set => _sendKeyValue.Assign(value); }
    private readonly BicepValue<string> _sendKeyValue;

    /// <summary>
    /// The name of the Service Bus namespace.
    /// </summary>
    public BicepValue<string> ServiceBusNamespace { get => _serviceBusNamespace; set => _serviceBusNamespace.Assign(value); }
    private readonly BicepValue<string> _serviceBusNamespace;

    /// <summary>
    /// The suffix for the service bus endpoint. By default this is
    /// .servicebus.windows.net.
    /// </summary>
    public BicepValue<string> ServiceBusSuffix { get => _serviceBusSuffix; set => _serviceBusSuffix.Assign(value); }
    private readonly BicepValue<string> _serviceBusSuffix;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new SiteHybridConnectionNamespaceRelay.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the SiteHybridConnectionNamespaceRelay
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SiteHybridConnectionNamespaceRelay.</param>
    public SiteHybridConnectionNamespaceRelay(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Web/sites/hybridConnectionNamespaces/relays", resourceVersion)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _relayName = BicepValue<string>.DefineProperty(this, "RelayName", ["properties", "relayName"], isRequired: true);
        _hostname = BicepValue<string>.DefineProperty(this, "Hostname", ["properties", "hostname"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _port = BicepValue<int>.DefineProperty(this, "Port", ["properties", "port"]);
        _relayArmId = BicepValue<ResourceIdentifier>.DefineProperty(this, "RelayArmId", ["properties", "relayArmUri"]);
        _sendKeyName = BicepValue<string>.DefineProperty(this, "SendKeyName", ["properties", "sendKeyName"]);
        _sendKeyValue = BicepValue<string>.DefineProperty(this, "SendKeyValue", ["properties", "sendKeyValue"]);
        _serviceBusNamespace = BicepValue<string>.DefineProperty(this, "ServiceBusNamespace", ["properties", "serviceBusNamespace"]);
        _serviceBusSuffix = BicepValue<string>.DefineProperty(this, "ServiceBusSuffix", ["properties", "serviceBusSuffix"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Creates a reference to an existing SiteHybridConnectionNamespaceRelay.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the SiteHybridConnectionNamespaceRelay
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SiteHybridConnectionNamespaceRelay.</param>
    /// <returns>The existing SiteHybridConnectionNamespaceRelay resource.</returns>
    public static SiteHybridConnectionNamespaceRelay FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
