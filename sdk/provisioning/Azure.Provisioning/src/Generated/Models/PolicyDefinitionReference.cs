// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// The policy definition reference.
/// </summary>
public partial class PolicyDefinitionReference : ProvisionableConstruct
{
    /// <summary>
    /// The ID of the policy definition or policy set definition.
    /// </summary>
    public BicepValue<string> PolicyDefinitionId { get => _policyDefinitionId; set => _policyDefinitionId.Assign(value); }
    private readonly BicepValue<string> _policyDefinitionId;

    /// <summary>
    /// The parameter values for the referenced policy rule. The keys are the
    /// parameter names.
    /// </summary>
    public BicepDictionary<ArmPolicyParameterValue> Parameters { get => _parameters; set => _parameters.Assign(value); }
    private readonly BicepDictionary<ArmPolicyParameterValue> _parameters;

    /// <summary>
    /// A unique id (within the policy set definition) for this policy
    /// definition reference.
    /// </summary>
    public BicepValue<string> PolicyDefinitionReferenceId { get => _policyDefinitionReferenceId; set => _policyDefinitionReferenceId.Assign(value); }
    private readonly BicepValue<string> _policyDefinitionReferenceId;

    /// <summary>
    /// The name of the groups that this policy definition reference belongs to.
    /// </summary>
    public BicepList<string> GroupNames { get => _groupNames; set => _groupNames.Assign(value); }
    private readonly BicepList<string> _groupNames;

    /// <summary>
    /// Creates a new PolicyDefinitionReference.
    /// </summary>
    public PolicyDefinitionReference()
    {
        _policyDefinitionId = BicepValue<string>.DefineProperty(this, "PolicyDefinitionId", ["policyDefinitionId"]);
        _parameters = BicepDictionary<ArmPolicyParameterValue>.DefineProperty(this, "Parameters", ["parameters"]);
        _policyDefinitionReferenceId = BicepValue<string>.DefineProperty(this, "PolicyDefinitionReferenceId", ["policyDefinitionReferenceId"]);
        _groupNames = BicepList<string>.DefineProperty(this, "GroupNames", ["groupNames"]);
    }
}
