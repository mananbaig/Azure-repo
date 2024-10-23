// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Configuration properties for apps environment custom domain.
/// </summary>
public partial class ContainerAppCustomDomainConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// Id used to verify domain name ownership.
    /// </summary>
    public BicepValue<string> CustomDomainVerificationId { get => _customDomainVerificationId; }
    private readonly BicepValue<string> _customDomainVerificationId;

    /// <summary>
    /// Dns suffix for the environment domain.
    /// </summary>
    public BicepValue<string> DnsSuffix { get => _dnsSuffix; set => _dnsSuffix.Assign(value); }
    private readonly BicepValue<string> _dnsSuffix;

    /// <summary>
    /// PFX or PEM blob.
    /// </summary>
    public BicepValue<BinaryData> CertificateValue { get => _certificateValue; set => _certificateValue.Assign(value); }
    private readonly BicepValue<BinaryData> _certificateValue;

    /// <summary>
    /// Certificate password.
    /// </summary>
    public BicepValue<string> CertificatePassword { get => _certificatePassword; set => _certificatePassword.Assign(value); }
    private readonly BicepValue<string> _certificatePassword;

    /// <summary>
    /// Certificate expiration date.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn { get => _expireOn; }
    private readonly BicepValue<DateTimeOffset> _expireOn;

    /// <summary>
    /// Certificate thumbprint.
    /// </summary>
    public BicepValue<string> Thumbprint { get => _thumbprint; }
    private readonly BicepValue<string> _thumbprint;

    /// <summary>
    /// Subject name of the certificate.
    /// </summary>
    public BicepValue<string> SubjectName { get => _subjectName; }
    private readonly BicepValue<string> _subjectName;

    /// <summary>
    /// Creates a new ContainerAppCustomDomainConfiguration.
    /// </summary>
    public ContainerAppCustomDomainConfiguration()
    {
        _customDomainVerificationId = BicepValue<string>.DefineProperty(this, "CustomDomainVerificationId", ["customDomainVerificationId"], isOutput: true);
        _dnsSuffix = BicepValue<string>.DefineProperty(this, "DnsSuffix", ["dnsSuffix"]);
        _certificateValue = BicepValue<BinaryData>.DefineProperty(this, "CertificateValue", ["certificateValue"]);
        _certificatePassword = BicepValue<string>.DefineProperty(this, "CertificatePassword", ["certificatePassword"]);
        _expireOn = BicepValue<DateTimeOffset>.DefineProperty(this, "ExpireOn", ["expirationDate"], isOutput: true);
        _thumbprint = BicepValue<string>.DefineProperty(this, "Thumbprint", ["thumbprint"], isOutput: true);
        _subjectName = BicepValue<string>.DefineProperty(this, "SubjectName", ["subjectName"], isOutput: true);
    }
}
