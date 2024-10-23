// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// LedgerDigestUpload.
/// </summary>
public partial class LedgerDigestUpload : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The digest storage endpoint, which must be either an Azure blob storage
    /// endpoint or an URI for Azure Confidential Ledger.
    /// </summary>
    public BicepValue<string> DigestStorageEndpoint { get => _digestStorageEndpoint; set => _digestStorageEndpoint.Assign(value); }
    private readonly BicepValue<string> _digestStorageEndpoint;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Specifies the state of ledger digest upload.
    /// </summary>
    public BicepValue<LedgerDigestUploadsState> State { get => _state; }
    private readonly BicepValue<LedgerDigestUploadsState> _state;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlDatabase.
    /// </summary>
    public SqlDatabase? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlDatabase> _parent;

    /// <summary>
    /// Creates a new LedgerDigestUpload.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the LedgerDigestUpload resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the LedgerDigestUpload.</param>
    public LedgerDigestUpload(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/ledgerDigestUploads", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _digestStorageEndpoint = BicepValue<string>.DefineProperty(this, "DigestStorageEndpoint", ["properties", "digestStorageEndpoint"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _state = BicepValue<LedgerDigestUploadsState>.DefineProperty(this, "State", ["properties", "state"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlDatabase>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported LedgerDigestUpload resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing LedgerDigestUpload.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the LedgerDigestUpload resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the LedgerDigestUpload.</param>
    /// <returns>The existing LedgerDigestUpload resource.</returns>
    public static LedgerDigestUpload FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
