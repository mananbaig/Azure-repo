// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static class AutomaticTuningModeExtensions
    {
        public static string ToSerialString(this AutomaticTuningMode value) => value switch
        {
            AutomaticTuningMode.Inherit => "Inherit",
            AutomaticTuningMode.Custom => "Custom",
            AutomaticTuningMode.Auto => "Auto",
            AutomaticTuningMode.Unspecified => "Unspecified",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutomaticTuningMode value.")
        };

        public static AutomaticTuningMode ToAutomaticTuningMode(this string value)
        {
            if (string.Equals(value, "Inherit", StringComparison.InvariantCultureIgnoreCase)) return AutomaticTuningMode.Inherit;
            if (string.Equals(value, "Custom", StringComparison.InvariantCultureIgnoreCase)) return AutomaticTuningMode.Custom;
            if (string.Equals(value, "Auto", StringComparison.InvariantCultureIgnoreCase)) return AutomaticTuningMode.Auto;
            if (string.Equals(value, "Unspecified", StringComparison.InvariantCultureIgnoreCase)) return AutomaticTuningMode.Unspecified;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutomaticTuningMode value.");
        }
    }
}
