// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    internal static partial class SecurityAlertPolicyStateExtensions
    {
        public static string ToSerialString(this SecurityAlertPolicyState value) => value switch
        {
            SecurityAlertPolicyState.New => "New",
            SecurityAlertPolicyState.Enabled => "Enabled",
            SecurityAlertPolicyState.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SecurityAlertPolicyState value.")
        };

        public static SecurityAlertPolicyState ToSecurityAlertPolicyState(this string value)
        {
            if (string.Equals(value, "New", StringComparison.InvariantCultureIgnoreCase)) return SecurityAlertPolicyState.New;
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return SecurityAlertPolicyState.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return SecurityAlertPolicyState.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SecurityAlertPolicyState value.");
        }
    }
}
