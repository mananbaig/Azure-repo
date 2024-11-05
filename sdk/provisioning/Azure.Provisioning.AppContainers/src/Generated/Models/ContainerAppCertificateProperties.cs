// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Certificate resource specific properties.
/// </summary>
public partial class ContainerAppCertificateProperties : ProvisionableConstruct
{
    /// <summary>
    /// Provisioning state of the certificate.
    /// </summary>
    public BicepValue<ContainerAppCertificateProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<ContainerAppCertificateProvisioningState>? _provisioningState;

    /// <summary>
    /// Certificate password.
    /// </summary>
    public BicepValue<string> Password 
    {
        get { Initialize(); return _password!; }
        set { Initialize(); _password!.Assign(value); }
    }
    private BicepValue<string>? _password;

    /// <summary>
    /// Subject name of the certificate.
    /// </summary>
    public BicepValue<string> SubjectName 
    {
        get { Initialize(); return _subjectName!; }
    }
    private BicepValue<string>? _subjectName;

    /// <summary>
    /// Subject alternative names the certificate applies to.
    /// </summary>
    public BicepList<string> SubjectAlternativeNames 
    {
        get { Initialize(); return _subjectAlternativeNames!; }
    }
    private BicepList<string>? _subjectAlternativeNames;

    /// <summary>
    /// PFX or PEM blob.
    /// </summary>
    public BicepValue<BinaryData> Value 
    {
        get { Initialize(); return _value!; }
        set { Initialize(); _value!.Assign(value); }
    }
    private BicepValue<BinaryData>? _value;

    /// <summary>
    /// Certificate issuer.
    /// </summary>
    public BicepValue<string> Issuer 
    {
        get { Initialize(); return _issuer!; }
    }
    private BicepValue<string>? _issuer;

    /// <summary>
    /// Certificate issue Date.
    /// </summary>
    public BicepValue<DateTimeOffset> IssueOn 
    {
        get { Initialize(); return _issueOn!; }
    }
    private BicepValue<DateTimeOffset>? _issueOn;

    /// <summary>
    /// Certificate expiration date.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn 
    {
        get { Initialize(); return _expireOn!; }
    }
    private BicepValue<DateTimeOffset>? _expireOn;

    /// <summary>
    /// Certificate thumbprint.
    /// </summary>
    public BicepValue<string> Thumbprint 
    {
        get { Initialize(); return _thumbprint!; }
    }
    private BicepValue<string>? _thumbprint;

    /// <summary>
    /// Is the certificate valid?.
    /// </summary>
    public BicepValue<bool> IsValid 
    {
        get { Initialize(); return _isValid!; }
    }
    private BicepValue<bool>? _isValid;

    /// <summary>
    /// Public key hash.
    /// </summary>
    public BicepValue<string> PublicKeyHash 
    {
        get { Initialize(); return _publicKeyHash!; }
    }
    private BicepValue<string>? _publicKeyHash;

    /// <summary>
    /// Creates a new ContainerAppCertificateProperties.
    /// </summary>
    public ContainerAppCertificateProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerAppCertificateProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _provisioningState = DefineProperty<ContainerAppCertificateProvisioningState>("ProvisioningState", ["provisioningState"], isOutput: true);
        _password = DefineProperty<string>("Password", ["password"]);
        _subjectName = DefineProperty<string>("SubjectName", ["subjectName"], isOutput: true);
        _subjectAlternativeNames = DefineListProperty<string>("SubjectAlternativeNames", ["subjectAlternativeNames"], isOutput: true);
        _value = DefineProperty<BinaryData>("Value", ["value"]);
        _issuer = DefineProperty<string>("Issuer", ["issuer"], isOutput: true);
        _issueOn = DefineProperty<DateTimeOffset>("IssueOn", ["issueDate"], isOutput: true);
        _expireOn = DefineProperty<DateTimeOffset>("ExpireOn", ["expirationDate"], isOutput: true);
        _thumbprint = DefineProperty<string>("Thumbprint", ["thumbprint"], isOutput: true);
        _isValid = DefineProperty<bool>("IsValid", ["valid"], isOutput: true);
        _publicKeyHash = DefineProperty<string>("PublicKeyHash", ["publicKeyHash"], isOutput: true);
    }
}
