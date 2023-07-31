// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Temp.Batch.Models
{
    internal static partial class OutputFileUploadConditionExtensions
    {
        public static string ToSerialString(this OutputFileUploadCondition value) => value switch
        {
            OutputFileUploadCondition.TaskSuccess => "tasksuccess",
            OutputFileUploadCondition.TaskFailure => "taskfailure",
            OutputFileUploadCondition.TaskCompletion => "taskcompletion",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OutputFileUploadCondition value.")
        };

        public static OutputFileUploadCondition ToOutputFileUploadCondition(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "tasksuccess")) return OutputFileUploadCondition.TaskSuccess;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "taskfailure")) return OutputFileUploadCondition.TaskFailure;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "taskcompletion")) return OutputFileUploadCondition.TaskCompletion;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OutputFileUploadCondition value.");
        }
    }
}
