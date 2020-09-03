// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static class SensitivityLabelRankExtensions
    {
        public static string ToSerialString(this SensitivityLabelRank value) => value switch
        {
            SensitivityLabelRank.None => "None",
            SensitivityLabelRank.Low => "Low",
            SensitivityLabelRank.Medium => "Medium",
            SensitivityLabelRank.High => "High",
            SensitivityLabelRank.Critical => "Critical",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SensitivityLabelRank value.")
        };

        public static SensitivityLabelRank ToSensitivityLabelRank(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return SensitivityLabelRank.None;
            if (string.Equals(value, "Low", StringComparison.InvariantCultureIgnoreCase)) return SensitivityLabelRank.Low;
            if (string.Equals(value, "Medium", StringComparison.InvariantCultureIgnoreCase)) return SensitivityLabelRank.Medium;
            if (string.Equals(value, "High", StringComparison.InvariantCultureIgnoreCase)) return SensitivityLabelRank.High;
            if (string.Equals(value, "Critical", StringComparison.InvariantCultureIgnoreCase)) return SensitivityLabelRank.Critical;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SensitivityLabelRank value.");
        }
    }
}
