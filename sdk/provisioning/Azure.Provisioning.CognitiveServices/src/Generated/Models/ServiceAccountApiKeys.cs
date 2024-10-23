// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// The access keys for the cognitive services account.
/// </summary>
public partial class ServiceAccountApiKeys : ProvisionableConstruct
{
    /// <summary>
    /// Gets the value of key 1.
    /// </summary>
    public BicepValue<string> Key1 { get => _key1; }
    private readonly BicepValue<string> _key1;

    /// <summary>
    /// Gets the value of key 2.
    /// </summary>
    public BicepValue<string> Key2 { get => _key2; }
    private readonly BicepValue<string> _key2;

    /// <summary>
    /// Creates a new ServiceAccountApiKeys.
    /// </summary>
    public ServiceAccountApiKeys()
    {
        _key1 = BicepValue<string>.DefineProperty(this, "Key1", ["key1"], isOutput: true, isSecure: true);
        _key2 = BicepValue<string>.DefineProperty(this, "Key2", ["key2"], isOutput: true, isSecure: true);
    }

    /// <summary>
    /// Creates a new ServiceAccountApiKeys resource from a Bicep expression
    /// that evaluates to a ServiceAccountApiKeys.
    /// </summary>
    /// <param name="expression">
    /// A Bicep expression that evaluates to a ServiceAccountApiKeys resource.
    /// </param>
    /// <returns>A ServiceAccountApiKeys resource.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static ServiceAccountApiKeys FromExpression(BicepExpression expression)
    {
        ServiceAccountApiKeys resource = new();
        resource.OverrideWithExpression(expression);
        return resource;
    }
}
