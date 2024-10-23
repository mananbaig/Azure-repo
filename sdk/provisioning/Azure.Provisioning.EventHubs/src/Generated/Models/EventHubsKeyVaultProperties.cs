// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// Properties to configure keyVault Properties.
/// </summary>
public partial class EventHubsKeyVaultProperties : ProvisionableConstruct
{
    /// <summary>
    /// Name of the Key from KeyVault.
    /// </summary>
    public BicepValue<string> KeyName { get => _keyName; set => _keyName.Assign(value); }
    private readonly BicepValue<string> _keyName;

    /// <summary>
    /// Uri of KeyVault.
    /// </summary>
    public BicepValue<Uri> KeyVaultUri { get => _keyVaultUri; set => _keyVaultUri.Assign(value); }
    private readonly BicepValue<Uri> _keyVaultUri;

    /// <summary>
    /// Key Version.
    /// </summary>
    public BicepValue<string> KeyVersion { get => _keyVersion; set => _keyVersion.Assign(value); }
    private readonly BicepValue<string> _keyVersion;

    /// <summary>
    /// ARM ID of user Identity selected for encryption.
    /// </summary>
    public BicepValue<string> UserAssignedIdentity { get => _userAssignedIdentity; set => _userAssignedIdentity.Assign(value); }
    private readonly BicepValue<string> _userAssignedIdentity;

    /// <summary>
    /// Creates a new EventHubsKeyVaultProperties.
    /// </summary>
    public EventHubsKeyVaultProperties()
    {
        _keyName = BicepValue<string>.DefineProperty(this, "KeyName", ["keyName"]);
        _keyVaultUri = BicepValue<Uri>.DefineProperty(this, "KeyVaultUri", ["keyVaultUri"]);
        _keyVersion = BicepValue<string>.DefineProperty(this, "KeyVersion", ["keyVersion"]);
        _userAssignedIdentity = BicepValue<string>.DefineProperty(this, "UserAssignedIdentity", ["identity", "userAssignedIdentity"]);
    }
}
