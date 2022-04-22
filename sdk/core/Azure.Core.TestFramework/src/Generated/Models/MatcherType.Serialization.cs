// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Core.TestFramework.Models
{
    internal static partial class MatcherTypeExtensions
    {
        public static string ToSerialString(this MatcherType value) => value switch
        {
            MatcherType.BodilessMatcher => "BodilessMatcher",
            MatcherType.CustomDefaultMatcher => "CustomDefaultMatcher",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MatcherType value.")
        };

        public static MatcherType ToMatcherType(this string value)
        {
            if (string.Equals(value, "BodilessMatcher", StringComparison.InvariantCultureIgnoreCase)) return MatcherType.BodilessMatcher;
            if (string.Equals(value, "CustomDefaultMatcher", StringComparison.InvariantCultureIgnoreCase)) return MatcherType.CustomDefaultMatcher;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MatcherType value.");
        }
    }
}
