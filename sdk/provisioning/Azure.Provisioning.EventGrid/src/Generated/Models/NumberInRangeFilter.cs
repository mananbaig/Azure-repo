// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// NumberInRange Filter.
/// </summary>
public partial class NumberInRangeFilter : EventGridFilter
{
    /// <summary>
    /// The set of filter values.
    /// </summary>
    public BicepList<BicepList<double>> Values 
    {
        get { Initialize(); return _values!; }
        set { Initialize(); _values!.Assign(value); }
    }
    private BicepList<BicepList<double>>? _values;

    /// <summary>
    /// Creates a new NumberInRangeFilter.
    /// </summary>
    public NumberInRangeFilter() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of NumberInRangeFilter.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        DefineProperty<string>("operatorType", ["operatorType"], defaultValue: "NumberInRange");
        _values = DefineListProperty<BicepList<double>>("Values", ["values"]);
    }
}
