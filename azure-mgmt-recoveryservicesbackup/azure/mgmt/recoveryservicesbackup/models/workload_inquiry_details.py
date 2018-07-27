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


class WorkloadInquiryDetails(Model):
    """Details of an inquired protectable item.

    :param type: Type of the Workload such as SQL, Oracle etc.
    :type type: str
    :param item_count: Contains the protectable item Count inside this
     Container.
    :type item_count: long
    :param inquiry_validation: Inquiry validation such as permissions and
     other backup validations.
    :type inquiry_validation:
     ~azure.mgmt.recoveryservicesbackup.models.InquiryValidation
    """

    _attribute_map = {
        'type': {'key': 'type', 'type': 'str'},
        'item_count': {'key': 'itemCount', 'type': 'long'},
        'inquiry_validation': {'key': 'inquiryValidation', 'type': 'InquiryValidation'},
    }

    def __init__(self, type=None, item_count=None, inquiry_validation=None):
        super(WorkloadInquiryDetails, self).__init__()
        self.type = type
        self.item_count = item_count
        self.inquiry_validation = inquiry_validation
