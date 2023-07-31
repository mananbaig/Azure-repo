// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Temp.Batch.Models
{
    internal static partial class JobStateExtensions
    {
        public static string ToSerialString(this JobState value) => value switch
        {
            JobState.Active => "active",
            JobState.Disabling => "disabling",
            JobState.Disabled => "disabled",
            JobState.Enabling => "enabling",
            JobState.Terminating => "terminating",
            JobState.Completed => "completed",
            JobState.Deleting => "deleting",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobState value.")
        };

        public static JobState ToJobState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "active")) return JobState.Active;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "disabling")) return JobState.Disabling;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "disabled")) return JobState.Disabled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "enabling")) return JobState.Enabling;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "terminating")) return JobState.Terminating;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "completed")) return JobState.Completed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "deleting")) return JobState.Deleting;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobState value.");
        }
    }
}
