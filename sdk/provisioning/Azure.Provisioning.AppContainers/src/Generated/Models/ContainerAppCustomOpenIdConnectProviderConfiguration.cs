// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings of the custom Open ID Connect provider.
/// </summary>
public partial class ContainerAppCustomOpenIdConnectProviderConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// &lt;code&gt;false&lt;/code&gt; if the custom Open ID provider provider
    /// should not be enabled; otherwise, &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// The configuration settings of the app registration for the custom Open
    /// ID Connect provider.
    /// </summary>
    public BicepValue<ContainerAppOpenIdConnectRegistration> Registration { get => _registration; set => _registration.Assign(value); }
    private readonly BicepValue<ContainerAppOpenIdConnectRegistration> _registration;

    /// <summary>
    /// The configuration settings of the login flow of the custom Open ID
    /// Connect provider.
    /// </summary>
    public BicepValue<ContainerAppOpenIdConnectLogin> Login { get => _login; set => _login.Assign(value); }
    private readonly BicepValue<ContainerAppOpenIdConnectLogin> _login;

    /// <summary>
    /// Creates a new ContainerAppCustomOpenIdConnectProviderConfiguration.
    /// </summary>
    public ContainerAppCustomOpenIdConnectProviderConfiguration()
    {
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["enabled"]);
        _registration = BicepValue<ContainerAppOpenIdConnectRegistration>.DefineProperty(this, "Registration", ["registration"]);
        _login = BicepValue<ContainerAppOpenIdConnectLogin>.DefineProperty(this, "Login", ["login"]);
    }
}
