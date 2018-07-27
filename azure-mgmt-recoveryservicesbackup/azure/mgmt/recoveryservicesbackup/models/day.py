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


class Day(Model):
    """Day of the week.

    :param date_property: Date of the month
    :type date_property: int
    :param is_last: Whether Date is last date of month
    :type is_last: bool
    """

    _attribute_map = {
        'date_property': {'key': 'date', 'type': 'int'},
        'is_last': {'key': 'isLast', 'type': 'bool'},
    }

    def __init__(self, date_property=None, is_last=None):
        super(Day, self).__init__()
        self.date_property = date_property
        self.is_last = is_last
