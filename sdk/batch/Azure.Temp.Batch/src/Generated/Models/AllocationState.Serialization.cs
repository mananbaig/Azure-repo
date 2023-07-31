// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Temp.Batch.Models
{
    internal static partial class AllocationStateExtensions
    {
        public static string ToSerialString(this AllocationState value) => value switch
        {
            AllocationState.Steady => "steady",
            AllocationState.Resizing => "resizing",
            AllocationState.Stopping => "stopping",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AllocationState value.")
        };

        public static AllocationState ToAllocationState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "steady")) return AllocationState.Steady;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "resizing")) return AllocationState.Resizing;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "stopping")) return AllocationState.Stopping;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AllocationState value.");
        }
    }
}
