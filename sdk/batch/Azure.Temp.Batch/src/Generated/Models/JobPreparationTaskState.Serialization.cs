// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Temp.Batch.Models
{
    internal static partial class JobPreparationTaskStateExtensions
    {
        public static string ToSerialString(this JobPreparationTaskState value) => value switch
        {
            JobPreparationTaskState.Running => "running",
            JobPreparationTaskState.Completed => "completed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobPreparationTaskState value.")
        };

        public static JobPreparationTaskState ToJobPreparationTaskState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "running")) return JobPreparationTaskState.Running;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "completed")) return JobPreparationTaskState.Completed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobPreparationTaskState value.");
        }
    }
}
