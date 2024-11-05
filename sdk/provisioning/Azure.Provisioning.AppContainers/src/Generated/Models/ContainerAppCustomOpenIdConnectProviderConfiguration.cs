// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

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
    public BicepValue<bool> IsEnabled 
    {
        get { Initialize(); return _isEnabled!; }
        set { Initialize(); _isEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isEnabled;

    /// <summary>
    /// The configuration settings of the app registration for the custom Open
    /// ID Connect provider.
    /// </summary>
    public ContainerAppOpenIdConnectRegistration Registration 
    {
        get { Initialize(); return _registration!; }
        set { Initialize(); AssignOrReplace(ref _registration, value); }
    }
    private ContainerAppOpenIdConnectRegistration? _registration;

    /// <summary>
    /// The configuration settings of the login flow of the custom Open ID
    /// Connect provider.
    /// </summary>
    public ContainerAppOpenIdConnectLogin Login 
    {
        get { Initialize(); return _login!; }
        set { Initialize(); AssignOrReplace(ref _login, value); }
    }
    private ContainerAppOpenIdConnectLogin? _login;

    /// <summary>
    /// Creates a new ContainerAppCustomOpenIdConnectProviderConfiguration.
    /// </summary>
    public ContainerAppCustomOpenIdConnectProviderConfiguration()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerAppCustomOpenIdConnectProviderConfiguration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _isEnabled = DefineProperty<bool>("IsEnabled", ["enabled"]);
        _registration = DefineModelProperty<ContainerAppOpenIdConnectRegistration>("Registration", ["registration"]);
        _login = DefineModelProperty<ContainerAppOpenIdConnectLogin>("Login", ["login"]);
    }
}
