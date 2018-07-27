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

from msrest.serialization import Model


class AzureStorageJobExtendedInfo(Model):
    """Azure Storage workload-specific additional information for job.

    :param tasks_list: List of tasks for this job
    :type tasks_list:
     list[~azure.mgmt.recoveryservicesbackup.models.AzureStorageJobTaskDetails]
    :param property_bag: Job properties.
    :type property_bag: dict[str, str]
    :param dynamic_error_message: Non localized error message on job
     execution.
    :type dynamic_error_message: str
    """

    _attribute_map = {
        'tasks_list': {'key': 'tasksList', 'type': '[AzureStorageJobTaskDetails]'},
        'property_bag': {'key': 'propertyBag', 'type': '{str}'},
        'dynamic_error_message': {'key': 'dynamicErrorMessage', 'type': 'str'},
    }

    def __init__(self, tasks_list=None, property_bag=None, dynamic_error_message=None):
        super(AzureStorageJobExtendedInfo, self).__init__()
        self.tasks_list = tasks_list
        self.property_bag = property_bag
        self.dynamic_error_message = dynamic_error_message
