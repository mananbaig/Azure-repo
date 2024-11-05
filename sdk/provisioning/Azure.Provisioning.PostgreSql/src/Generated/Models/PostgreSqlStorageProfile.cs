// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Storage Profile properties of a server.
/// </summary>
public partial class PostgreSqlStorageProfile : ProvisionableConstruct
{
    /// <summary>
    /// Backup retention days for the server.
    /// </summary>
    public BicepValue<int> BackupRetentionDays 
    {
        get { Initialize(); return _backupRetentionDays!; }
        set { Initialize(); _backupRetentionDays!.Assign(value); }
    }
    private BicepValue<int>? _backupRetentionDays;

    /// <summary>
    /// Enable Geo-redundant or not for server backup.
    /// </summary>
    public BicepValue<PostgreSqlGeoRedundantBackup> GeoRedundantBackup 
    {
        get { Initialize(); return _geoRedundantBackup!; }
        set { Initialize(); _geoRedundantBackup!.Assign(value); }
    }
    private BicepValue<PostgreSqlGeoRedundantBackup>? _geoRedundantBackup;

    /// <summary>
    /// Max storage allowed for a server.
    /// </summary>
    public BicepValue<int> StorageInMB 
    {
        get { Initialize(); return _storageInMB!; }
        set { Initialize(); _storageInMB!.Assign(value); }
    }
    private BicepValue<int>? _storageInMB;

    /// <summary>
    /// Enable Storage Auto Grow.
    /// </summary>
    public BicepValue<PostgreSqlStorageAutogrow> StorageAutogrow 
    {
        get { Initialize(); return _storageAutogrow!; }
        set { Initialize(); _storageAutogrow!.Assign(value); }
    }
    private BicepValue<PostgreSqlStorageAutogrow>? _storageAutogrow;

    /// <summary>
    /// Creates a new PostgreSqlStorageProfile.
    /// </summary>
    public PostgreSqlStorageProfile()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of PostgreSqlStorageProfile.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _backupRetentionDays = DefineProperty<int>("BackupRetentionDays", ["backupRetentionDays"]);
        _geoRedundantBackup = DefineProperty<PostgreSqlGeoRedundantBackup>("GeoRedundantBackup", ["geoRedundantBackup"]);
        _storageInMB = DefineProperty<int>("StorageInMB", ["storageMB"]);
        _storageAutogrow = DefineProperty<PostgreSqlStorageAutogrow>("StorageAutogrow", ["storageAutogrow"]);
    }
}
