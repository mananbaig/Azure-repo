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
    /// Azure Storage-specific protectable containers
    /// </summary>
    [Newtonsoft.Json.JsonObject("StorageContainer")]
    public partial class AzureStorageProtectableContainer : ProtectableContainer
    {
        /// <summary>
        /// Initializes a new instance of the AzureStorageProtectableContainer
        /// class.
        /// </summary>
        public AzureStorageProtectableContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureStorageProtectableContainer
        /// class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the container.</param>
        /// <param name="backupManagementType">Type of backup managemenent for
        /// the container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql', 'AzureStorage',
        /// 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="healthStatus">Status of health of the
        /// container.</param>
        /// <param name="containerId">Fabric Id of the container such as ARM
        /// Id.</param>
        public AzureStorageProtectableContainer(string friendlyName = default(string), string backupManagementType = default(string), string healthStatus = default(string), string containerId = default(string))
            : base(friendlyName, backupManagementType, healthStatus, containerId)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
