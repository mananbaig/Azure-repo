// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ApplicationInsights;

/// <summary>
/// The private link scope resource reference.
/// </summary>
public partial class PrivateLinkScopedResourceReference : ProvisionableConstruct
{
    /// <summary>
    /// The full resource Id of the private link scope resource.
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId { get => _resourceId; }
    private readonly BicepValue<ResourceIdentifier> _resourceId;

    /// <summary>
    /// The private link scope unique Identifier.
    /// </summary>
    public BicepValue<string> ScopeId { get => _scopeId; }
    private readonly BicepValue<string> _scopeId;

    /// <summary>
    /// Creates a new PrivateLinkScopedResourceReference.
    /// </summary>
    public PrivateLinkScopedResourceReference()
    {
        _resourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "ResourceId", ["ResourceId"], isOutput: true);
        _scopeId = BicepValue<string>.DefineProperty(this, "ScopeId", ["ScopeId"], isOutput: true);
    }
}
