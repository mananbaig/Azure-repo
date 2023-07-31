// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Temp.Batch.Models
{
    internal static partial class PoolIdentityTypeExtensions
    {
        public static string ToSerialString(this PoolIdentityType value) => value switch
        {
            PoolIdentityType.UserAssigned => "UserAssigned",
            PoolIdentityType.None => "None",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PoolIdentityType value.")
        };

        public static PoolIdentityType ToPoolIdentityType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "UserAssigned")) return PoolIdentityType.UserAssigned;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return PoolIdentityType.None;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PoolIdentityType value.");
        }
    }
}
