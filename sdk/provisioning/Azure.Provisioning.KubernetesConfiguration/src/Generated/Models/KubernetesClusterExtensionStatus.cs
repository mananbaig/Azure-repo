// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.KubernetesConfiguration;

/// <summary>
/// Status from the extension.
/// </summary>
public partial class KubernetesClusterExtensionStatus : ProvisionableConstruct
{
    /// <summary>
    /// Status code provided by the Extension.
    /// </summary>
    public BicepValue<string> Code 
    {
        get { Initialize(); return _code!; }
        set { Initialize(); _code!.Assign(value); }
    }
    private BicepValue<string>? _code;

    /// <summary>
    /// Short description of status of the extension.
    /// </summary>
    public BicepValue<string> DisplayStatus 
    {
        get { Initialize(); return _displayStatus!; }
        set { Initialize(); _displayStatus!.Assign(value); }
    }
    private BicepValue<string>? _displayStatus;

    /// <summary>
    /// Level of the status.
    /// </summary>
    public BicepValue<KubernetesClusterExtensionStatusLevel> Level 
    {
        get { Initialize(); return _level!; }
        set { Initialize(); _level!.Assign(value); }
    }
    private BicepValue<KubernetesClusterExtensionStatusLevel>? _level;

    /// <summary>
    /// Detailed message of the status from the Extension.
    /// </summary>
    public BicepValue<string> Message 
    {
        get { Initialize(); return _message!; }
        set { Initialize(); _message!.Assign(value); }
    }
    private BicepValue<string>? _message;

    /// <summary>
    /// DateLiteral (per ISO8601) noting the time of installation status.
    /// </summary>
    public BicepValue<string> Time 
    {
        get { Initialize(); return _time!; }
        set { Initialize(); _time!.Assign(value); }
    }
    private BicepValue<string>? _time;

    /// <summary>
    /// Creates a new KubernetesClusterExtensionStatus.
    /// </summary>
    public KubernetesClusterExtensionStatus()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// KubernetesClusterExtensionStatus.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _code = DefineProperty<string>("Code", ["code"]);
        _displayStatus = DefineProperty<string>("DisplayStatus", ["displayStatus"]);
        _level = DefineProperty<KubernetesClusterExtensionStatusLevel>("Level", ["level"]);
        _message = DefineProperty<string>("Message", ["message"]);
        _time = DefineProperty<string>("Time", ["time"]);
    }
}
