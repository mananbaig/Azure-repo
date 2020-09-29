// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Insights.Models
{
    internal static class ScaleDirectionExtensions
    {
        public static string ToSerialString(this ScaleDirection value) => value switch
        {
            ScaleDirection.None => "None",
            ScaleDirection.Increase => "Increase",
            ScaleDirection.Decrease => "Decrease",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ScaleDirection value.")
        };

        public static ScaleDirection ToScaleDirection(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return ScaleDirection.None;
            if (string.Equals(value, "Increase", StringComparison.InvariantCultureIgnoreCase)) return ScaleDirection.Increase;
            if (string.Equals(value, "Decrease", StringComparison.InvariantCultureIgnoreCase)) return ScaleDirection.Decrease;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ScaleDirection value.");
        }
    }
}
