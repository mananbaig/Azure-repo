// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
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
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer',
        /// 'AzureSql'</param>
        /// <param name="workloadType">Type of workload this item represents.
        /// Possible values include: 'Invalid', 'VM', 'FileFolder',
        /// 'AzureSqlDb', 'SQLDB', 'Exchange', 'Sharepoint', 'VMwareVM',
        /// 'SystemState', 'Client', 'GenericDataSource'</param>
        /// <param name="containerName">Unique name of container</param>
        /// <param name="sourceResourceId">ARM ID of the resource to be backed
        /// up.</param>
        /// <param name="policyId">ID of the backup policy with which this item
        /// is backed up.</param>
        /// <param name="lastRecoveryPoint">Timestamp when the last (latest)
        /// backup copy was created for this backup item.</param>
        /// <param name="protectedItemDataId">Internal ID of a backup item.
        /// Used by Azure SQL Backup engine to contact Recovery
        /// Services.</param>
        /// <param name="protectionState">Backup state of the backed up item.
        /// Possible values include: 'Invalid', 'IRPending', 'Protected',
        /// 'ProtectionError', 'ProtectionStopped', 'ProtectionPaused'</param>
        /// <param name="extendedInfo">Additional information for this backup
        /// item.</param>
        public AzureSqlProtectedItem(string backupManagementType = default(string), string workloadType = default(string), string containerName = default(string), string sourceResourceId = default(string), string policyId = default(string), System.DateTime? lastRecoveryPoint = default(System.DateTime?), string protectedItemDataId = default(string), string protectionState = default(string), AzureSqlProtectedItemExtendedInfo extendedInfo = default(AzureSqlProtectedItemExtendedInfo))
            : base(backupManagementType, workloadType, containerName, sourceResourceId, policyId, lastRecoveryPoint)
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
        public string ProtectionState { get; set; }

        /// <summary>
        /// Gets or sets additional information for this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "extendedInfo")]
        public AzureSqlProtectedItemExtendedInfo ExtendedInfo { get; set; }

    }
}
