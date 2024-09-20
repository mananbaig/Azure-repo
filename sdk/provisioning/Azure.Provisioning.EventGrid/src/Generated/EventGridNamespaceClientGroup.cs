// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// EventGridNamespaceClientGroup.
/// </summary>
public partial class EventGridNamespaceClientGroup : Resource
{
    /// <summary>
    /// The client group name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Description for the Client Group resource.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// The grouping query for the clients.             Example :
    /// attributes.keyName IN [&apos;a&apos;, &apos;b&apos;, &apos;c&apos;].
    /// </summary>
    public BicepValue<string> Query { get => _query; set => _query.Assign(value); }
    private readonly BicepValue<string> _query;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of the ClientGroup resource.
    /// </summary>
    public BicepValue<ClientGroupProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ClientGroupProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent EventGridNamespace.
    /// </summary>
    public EventGridNamespace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<EventGridNamespace> _parent;

    /// <summary>
    /// Creates a new EventGridNamespaceClientGroup.
    /// </summary>
    /// <param name="resourceName">Name of the EventGridNamespaceClientGroup.</param>
    /// <param name="resourceVersion">Version of the EventGridNamespaceClientGroup.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public EventGridNamespaceClientGroup(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.EventGrid/namespaces/clientGroups", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["properties", "description"]);
        _query = BicepValue<string>.DefineProperty(this, "Query", ["properties", "query"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<ClientGroupProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<EventGridNamespace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing EventGridNamespaceClientGroup.
    /// </summary>
    /// <param name="resourceName">Name of the EventGridNamespaceClientGroup.</param>
    /// <param name="resourceVersion">Version of the EventGridNamespaceClientGroup.</param>
    /// <returns>The existing EventGridNamespaceClientGroup resource.</returns>
    public static EventGridNamespaceClientGroup FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
