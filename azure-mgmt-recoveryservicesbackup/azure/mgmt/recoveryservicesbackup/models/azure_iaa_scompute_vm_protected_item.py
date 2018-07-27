# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from .azure_iaa_svm_protected_item import AzureIaaSVMProtectedItem


class AzureIaaSComputeVMProtectedItem(AzureIaaSVMProtectedItem):
    """IaaS VM workload-specific backup item representing the Azure Resource
    Manager VM.

    :param backup_management_type: Type of backup managemenent for the backed
     up item. Possible values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
     'AzureBackupServer', 'AzureSql', 'AzureStorage', 'AzureWorkload',
     'DefaultBackup'
    :type backup_management_type: str or
     ~azure.mgmt.recoveryservicesbackup.models.BackupManagementType
    :param workload_type: Type of workload this item represents. Possible
     values include: 'Invalid', 'VM', 'FileFolder', 'AzureSqlDb', 'SQLDB',
     'Exchange', 'Sharepoint', 'VMwareVM', 'SystemState', 'Client',
     'GenericDataSource', 'SQLDataBase', 'AzureFileShare', 'SAPHanaDatabase'
    :type workload_type: str or
     ~azure.mgmt.recoveryservicesbackup.models.DataSourceType
    :param container_name: Unique name of container
    :type container_name: str
    :param source_resource_id: ARM ID of the resource to be backed up.
    :type source_resource_id: str
    :param policy_id: ID of the backup policy with which this item is backed
     up.
    :type policy_id: str
    :param last_recovery_point: Timestamp when the last (latest) backup copy
     was created for this backup item.
    :type last_recovery_point: datetime
    :param backup_set_name: Name of the backup set the backup item belongs to
    :type backup_set_name: str
    :param create_mode: Create mode to indicate recovery of existing soft
     deleted data source or creation of new data source. Possible values
     include: 'Invalid', 'Default', 'Recover'
    :type create_mode: str or
     ~azure.mgmt.recoveryservicesbackup.models.CreateMode
    :param protected_item_type: Constant filled by server.
    :type protected_item_type: str
    :param friendly_name: Friendly name of the VM represented by this backup
     item.
    :type friendly_name: str
    :param virtual_machine_id: Fully qualified ARM ID of the virtual machine
     represented by this item.
    :type virtual_machine_id: str
    :param protection_status: Backup status of this backup item.
    :type protection_status: str
    :param protection_state: Backup state of this backup item. Possible values
     include: 'Invalid', 'IRPending', 'Protected', 'ProtectionError',
     'ProtectionStopped', 'ProtectionPaused'
    :type protection_state: str or
     ~azure.mgmt.recoveryservicesbackup.models.ProtectionState
    :param health_status: Health status of protected item. Possible values
     include: 'Passed', 'ActionRequired', 'ActionSuggested', 'Invalid'
    :type health_status: str or
     ~azure.mgmt.recoveryservicesbackup.models.HealthStatus
    :param health_details: Health details on this backup item.
    :type health_details:
     list[~azure.mgmt.recoveryservicesbackup.models.AzureIaaSVMHealthDetails]
    :param last_backup_status: Last backup operation status.
    :type last_backup_status: str
    :param last_backup_time: Timestamp of the last backup operation on this
     backup item.
    :type last_backup_time: datetime
    :param protected_item_data_id: Data ID of the protected item.
    :type protected_item_data_id: str
    :param extended_info: Additional information for this backup item.
    :type extended_info:
     ~azure.mgmt.recoveryservicesbackup.models.AzureIaaSVMProtectedItemExtendedInfo
    """

    _validation = {
        'protected_item_type': {'required': True},
    }

    def __init__(self, backup_management_type=None, workload_type=None, container_name=None, source_resource_id=None, policy_id=None, last_recovery_point=None, backup_set_name=None, create_mode=None, friendly_name=None, virtual_machine_id=None, protection_status=None, protection_state=None, health_status=None, health_details=None, last_backup_status=None, last_backup_time=None, protected_item_data_id=None, extended_info=None):
        super(AzureIaaSComputeVMProtectedItem, self).__init__(backup_management_type=backup_management_type, workload_type=workload_type, container_name=container_name, source_resource_id=source_resource_id, policy_id=policy_id, last_recovery_point=last_recovery_point, backup_set_name=backup_set_name, create_mode=create_mode, friendly_name=friendly_name, virtual_machine_id=virtual_machine_id, protection_status=protection_status, protection_state=protection_state, health_status=health_status, health_details=health_details, last_backup_status=last_backup_status, last_backup_time=last_backup_time, protected_item_data_id=protected_item_data_id, extended_info=extended_info)
        self.protected_item_type = 'Microsoft.Compute/virtualMachines'
