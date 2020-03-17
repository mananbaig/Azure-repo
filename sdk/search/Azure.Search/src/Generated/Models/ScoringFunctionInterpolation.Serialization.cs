// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Models
{
    internal static class ScoringFunctionInterpolationExtensions
    {
        public static string ToSerialString(this ScoringFunctionInterpolation value) => value switch
        {
            ScoringFunctionInterpolation.Linear => "linear",
            ScoringFunctionInterpolation.Constant => "constant",
            ScoringFunctionInterpolation.Quadratic => "quadratic",
            ScoringFunctionInterpolation.Logarithmic => "logarithmic",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ScoringFunctionInterpolation value.")
        };

        public static ScoringFunctionInterpolation ToScoringFunctionInterpolation(this string value)
        {
            if (string.Equals(value, "linear", StringComparison.InvariantCultureIgnoreCase)) return ScoringFunctionInterpolation.Linear;
            if (string.Equals(value, "constant", StringComparison.InvariantCultureIgnoreCase)) return ScoringFunctionInterpolation.Constant;
            if (string.Equals(value, "quadratic", StringComparison.InvariantCultureIgnoreCase)) return ScoringFunctionInterpolation.Quadratic;
            if (string.Equals(value, "logarithmic", StringComparison.InvariantCultureIgnoreCase)) return ScoringFunctionInterpolation.Logarithmic;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ScoringFunctionInterpolation value.");
        }
    }
}
