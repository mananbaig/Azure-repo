// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static class GeoBackupPolicyStateExtensions
    {
        public static string ToSerialString(this GeoBackupPolicyState value) => value switch
        {
            GeoBackupPolicyState.Disabled => "Disabled",
            GeoBackupPolicyState.Enabled => "Enabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown GeoBackupPolicyState value.")
        };

        public static GeoBackupPolicyState ToGeoBackupPolicyState(this string value)
        {
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return GeoBackupPolicyState.Disabled;
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return GeoBackupPolicyState.Enabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown GeoBackupPolicyState value.");
        }
    }
}
