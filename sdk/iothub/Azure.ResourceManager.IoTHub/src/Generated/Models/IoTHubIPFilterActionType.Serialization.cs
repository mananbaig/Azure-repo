// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IoTHub.Models
{
    internal static partial class IoTHubIPFilterActionTypeExtensions
    {
        public static string ToSerialString(this IoTHubIPFilterActionType value) => value switch
        {
            IoTHubIPFilterActionType.Accept => "Accept",
            IoTHubIPFilterActionType.Reject => "Reject",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IoTHubIPFilterActionType value.")
        };

        public static IoTHubIPFilterActionType ToIoTHubIPFilterActionType(this string value)
        {
            if (string.Equals(value, "Accept", StringComparison.InvariantCultureIgnoreCase)) return IoTHubIPFilterActionType.Accept;
            if (string.Equals(value, "Reject", StringComparison.InvariantCultureIgnoreCase)) return IoTHubIPFilterActionType.Reject;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IoTHubIPFilterActionType value.");
        }
    }
}
