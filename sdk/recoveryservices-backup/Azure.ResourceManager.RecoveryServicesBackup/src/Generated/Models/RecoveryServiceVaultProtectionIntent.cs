// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Azure Recovery Services Vault specific protection intent item.
    /// Please note <see cref="RecoveryServiceVaultProtectionIntent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="WorkloadAutoProtectionIntent"/> and <see cref="WorkloadSqlAutoProtectionIntent"/>.
    /// </summary>
    public partial class RecoveryServiceVaultProtectionIntent : BackupGenericProtectionIntent
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryServiceVaultProtectionIntent"/>. </summary>
        public RecoveryServiceVaultProtectionIntent()
        {
            ProtectionIntentItemType = ProtectionIntentItemType.RecoveryServiceVaultItem;
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryServiceVaultProtectionIntent"/>. </summary>
        /// <param name="protectionIntentItemType"> backup protectionIntent type. </param>
        /// <param name="backupManagementType"> Type of backup management for the backed up item. </param>
        /// <param name="sourceResourceId"> ARM ID of the resource to be backed up. </param>
        /// <param name="itemId"> ID of the item which is getting protected, In case of Azure Vm , it is ProtectedItemId. </param>
        /// <param name="policyId"> ID of the backup policy with which this item is backed up. </param>
        /// <param name="protectionState"> Backup state of this backup item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryServiceVaultProtectionIntent(ProtectionIntentItemType protectionIntentItemType, BackupManagementType? backupManagementType, ResourceIdentifier sourceResourceId, ResourceIdentifier itemId, ResourceIdentifier policyId, BackupProtectionStatus? protectionState, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(protectionIntentItemType, backupManagementType, sourceResourceId, itemId, policyId, protectionState, serializedAdditionalRawData)
        {
            ProtectionIntentItemType = protectionIntentItemType;
        }
    }
}
