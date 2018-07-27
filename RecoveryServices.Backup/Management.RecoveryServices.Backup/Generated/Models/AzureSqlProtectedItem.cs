// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure SQL workload-specific backup item.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Sql/servers/databases")]
    public partial class AzureSqlProtectedItem : ProtectedItem
    {
        /// <summary>
        /// Initializes a new instance of the AzureSqlProtectedItem class.
        /// </summary>
        public AzureSqlProtectedItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSqlProtectedItem class.
        /// </summary>
        /// <param name="backupManagementType">Type of backup managemenent for
        /// the backed up item. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql',
        /// 'AzureStorage', 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="workloadType">Type of workload this item represents.
        /// Possible values include: 'Invalid', 'VM', 'FileFolder',
        /// 'AzureSqlDb', 'SQLDB', 'Exchange', 'Sharepoint', 'VMwareVM',
        /// 'SystemState', 'Client', 'GenericDataSource', 'SQLDataBase',
        /// 'AzureFileShare', 'SAPHanaDatabase'</param>
        /// <param name="containerName">Unique name of container</param>
        /// <param name="sourceResourceId">ARM ID of the resource to be backed
        /// up.</param>
        /// <param name="policyId">ID of the backup policy with which this item
        /// is backed up.</param>
        /// <param name="lastRecoveryPoint">Timestamp when the last (latest)
        /// backup copy was created for this backup item.</param>
        /// <param name="backupSetName">Name of the backup set the backup item
        /// belongs to</param>
        /// <param name="createMode">Create mode to indicate recovery of
        /// existing soft deleted data source or creation of new data source.
        /// Possible values include: 'Invalid', 'Default', 'Recover'</param>
        /// <param name="protectedItemDataId">Internal ID of a backup item.
        /// Used by Azure SQL Backup engine to contact Recovery
        /// Services.</param>
        /// <param name="protectionState">Backup state of the backed up item.
        /// Possible values include: 'Invalid', 'IRPending', 'Protected',
        /// 'ProtectionError', 'ProtectionStopped', 'ProtectionPaused'</param>
        /// <param name="extendedInfo">Additional information for this backup
        /// item.</param>
        public AzureSqlProtectedItem(BackupManagementType? backupManagementType = default(BackupManagementType?), DataSourceType? workloadType = default(DataSourceType?), string containerName = default(string), string sourceResourceId = default(string), string policyId = default(string), System.DateTime? lastRecoveryPoint = default(System.DateTime?), string backupSetName = default(string), CreateMode? createMode = default(CreateMode?), string protectedItemDataId = default(string), ProtectedItemState? protectionState = default(ProtectedItemState?), AzureSqlProtectedItemExtendedInfo extendedInfo = default(AzureSqlProtectedItemExtendedInfo))
            : base(backupManagementType, workloadType, containerName, sourceResourceId, policyId, lastRecoveryPoint, backupSetName, createMode)
        {
            ProtectedItemDataId = protectedItemDataId;
            ProtectionState = protectionState;
            ExtendedInfo = extendedInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets internal ID of a backup item. Used by Azure SQL Backup
        /// engine to contact Recovery Services.
        /// </summary>
        [JsonProperty(PropertyName = "protectedItemDataId")]
        public string ProtectedItemDataId { get; set; }

        /// <summary>
        /// Gets or sets backup state of the backed up item. Possible values
        /// include: 'Invalid', 'IRPending', 'Protected', 'ProtectionError',
        /// 'ProtectionStopped', 'ProtectionPaused'
        /// </summary>
        [JsonProperty(PropertyName = "protectionState")]
        public ProtectedItemState? ProtectionState { get; set; }

        /// <summary>
        /// Gets or sets additional information for this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "extendedInfo")]
        public AzureSqlProtectedItemExtendedInfo ExtendedInfo { get; set; }

    }
}
