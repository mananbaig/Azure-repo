// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// Management policy action for base blob.
/// </summary>
public partial class ManagementPolicyBaseBlob : ProvisioningConstruct
{
    /// <summary>
    /// The function to tier blobs to cool storage.
    /// </summary>
    public BicepValue<DateAfterModification> TierToCool { get => _tierToCool; set => _tierToCool.Assign(value); }
    private readonly BicepValue<DateAfterModification> _tierToCool;

    /// <summary>
    /// The function to tier blobs to archive storage.
    /// </summary>
    public BicepValue<DateAfterModification> TierToArchive { get => _tierToArchive; set => _tierToArchive.Assign(value); }
    private readonly BicepValue<DateAfterModification> _tierToArchive;

    /// <summary>
    /// The function to tier blobs to cold storage.
    /// </summary>
    public BicepValue<DateAfterModification> TierToCold { get => _tierToCold; set => _tierToCold.Assign(value); }
    private readonly BicepValue<DateAfterModification> _tierToCold;

    /// <summary>
    /// The function to tier blobs to hot storage. This action can only be used
    /// with Premium Block Blob Storage Accounts.
    /// </summary>
    public BicepValue<DateAfterModification> TierToHot { get => _tierToHot; set => _tierToHot.Assign(value); }
    private readonly BicepValue<DateAfterModification> _tierToHot;

    /// <summary>
    /// The function to delete the blob.
    /// </summary>
    public BicepValue<DateAfterModification> Delete { get => _delete; set => _delete.Assign(value); }
    private readonly BicepValue<DateAfterModification> _delete;

    /// <summary>
    /// This property enables auto tiering of a blob from cool to hot on a blob
    /// access. This property requires
    /// tierToCool.daysAfterLastAccessTimeGreaterThan.
    /// </summary>
    public BicepValue<bool> EnableAutoTierToHotFromCool { get => _enableAutoTierToHotFromCool; set => _enableAutoTierToHotFromCool.Assign(value); }
    private readonly BicepValue<bool> _enableAutoTierToHotFromCool;

    /// <summary>
    /// Creates a new ManagementPolicyBaseBlob.
    /// </summary>
    public ManagementPolicyBaseBlob()
    {
        _tierToCool = BicepValue<DateAfterModification>.DefineProperty(this, "TierToCool", ["tierToCool"]);
        _tierToArchive = BicepValue<DateAfterModification>.DefineProperty(this, "TierToArchive", ["tierToArchive"]);
        _tierToCold = BicepValue<DateAfterModification>.DefineProperty(this, "TierToCold", ["tierToCold"]);
        _tierToHot = BicepValue<DateAfterModification>.DefineProperty(this, "TierToHot", ["tierToHot"]);
        _delete = BicepValue<DateAfterModification>.DefineProperty(this, "Delete", ["delete"]);
        _enableAutoTierToHotFromCool = BicepValue<bool>.DefineProperty(this, "EnableAutoTierToHotFromCool", ["enableAutoTierToHotFromCool"]);
    }
}
