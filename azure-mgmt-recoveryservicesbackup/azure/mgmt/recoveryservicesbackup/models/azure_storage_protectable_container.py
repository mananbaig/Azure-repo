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

from .protectable_container import ProtectableContainer


class AzureStorageProtectableContainer(ProtectableContainer):
    """Azure Storage-specific protectable containers.

    :param friendly_name: Friendly name of the container.
    :type friendly_name: str
    :param backup_management_type: Type of backup managemenent for the
     container. Possible values include: 'Invalid', 'AzureIaasVM', 'MAB',
     'DPM', 'AzureBackupServer', 'AzureSql', 'AzureStorage', 'AzureWorkload',
     'DefaultBackup'
    :type backup_management_type: str or
     ~azure.mgmt.recoveryservicesbackup.models.BackupManagementType
    :param health_status: Status of health of the container.
    :type health_status: str
    :param container_id: Fabric Id of the container such as ARM Id.
    :type container_id: str
    :param protectable_container_type: Constant filled by server.
    :type protectable_container_type: str
    """

    _validation = {
        'protectable_container_type': {'required': True},
    }

    def __init__(self, friendly_name=None, backup_management_type=None, health_status=None, container_id=None):
        super(AzureStorageProtectableContainer, self).__init__(friendly_name=friendly_name, backup_management_type=backup_management_type, health_status=health_status, container_id=container_id)
        self.protectable_container_type = 'StorageContainer'
