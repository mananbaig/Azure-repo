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

from .azure_vm_workload_protectable_item import AzureVmWorkloadProtectableItem


class AzureVmWorkloadSAPHanaDatabaseProtectableItem(AzureVmWorkloadProtectableItem):
    """Azure VM workload-specific protectable item representing SAP Hana Database.

    :param backup_management_type: Type of backup managemenent to backup an
     item.
    :type backup_management_type: str
    :param workload_type: Type of workload for the backup management
    :type workload_type: str
    :param friendly_name: Friendly name of the backup item.
    :type friendly_name: str
    :param protection_state: State of the back up item. Possible values
     include: 'Invalid', 'NotProtected', 'Protecting', 'Protected',
     'ProtectionFailed'
    :type protection_state: str or
     ~azure.mgmt.recoveryservicesbackup.models.ProtectionStatus
    :param protectable_item_type: Constant filled by server.
    :type protectable_item_type: str
    :param parent_name: Name for instance or AG
    :type parent_name: str
    :param parent_unique_name: Parent Unique Name is added to provide the
     service formatted URI Name of the Parent
     Only Applicable for data bases where the parent would be either Instance
     or a SQL AG.
    :type parent_unique_name: str
    :param server_name: Host/Cluster Name for instance or AG
    :type server_name: str
    :param is_auto_protectable: Indicates if protectable item is
     auto-protectable
    :type is_auto_protectable: bool
    :param subinquireditemcount: For instance or AG, indicates number of DB's
     present
    :type subinquireditemcount: int
    :param subprotectableitemcount: For instance or AG, indicates number of
     DB's to be protected
    :type subprotectableitemcount: int
    :param prebackupvalidation: Pre-backup validation for protectable objects
    :type prebackupvalidation:
     ~azure.mgmt.recoveryservicesbackup.models.PreBackupValidation
    """

    _validation = {
        'protectable_item_type': {'required': True},
    }

    def __init__(self, backup_management_type=None, workload_type=None, friendly_name=None, protection_state=None, parent_name=None, parent_unique_name=None, server_name=None, is_auto_protectable=None, subinquireditemcount=None, subprotectableitemcount=None, prebackupvalidation=None):
        super(AzureVmWorkloadSAPHanaDatabaseProtectableItem, self).__init__(backup_management_type=backup_management_type, workload_type=workload_type, friendly_name=friendly_name, protection_state=protection_state, parent_name=parent_name, parent_unique_name=parent_unique_name, server_name=server_name, is_auto_protectable=is_auto_protectable, subinquireditemcount=subinquireditemcount, subprotectableitemcount=subprotectableitemcount, prebackupvalidation=prebackupvalidation)
        self.protectable_item_type = 'SAPHanaDatabase'
