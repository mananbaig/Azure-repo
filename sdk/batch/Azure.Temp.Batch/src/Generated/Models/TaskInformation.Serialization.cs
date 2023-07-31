// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    public partial class TaskInformation
    {
        internal static TaskInformation DeserializeTaskInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> taskUrl = default;
            Optional<string> jobId = default;
            Optional<string> taskId = default;
            Optional<int> subtaskId = default;
            TaskState taskState = default;
            Optional<TaskExecutionInformation> executionInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("taskUrl"u8))
                {
                    taskUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskId"u8))
                {
                    taskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subtaskId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subtaskId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("taskState"u8))
                {
                    taskState = property.Value.GetString().ToTaskState();
                    continue;
                }
                if (property.NameEquals("executionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    executionInfo = TaskExecutionInformation.DeserializeTaskExecutionInformation(property.Value);
                    continue;
                }
            }
            return new TaskInformation(taskUrl.Value, jobId.Value, taskId.Value, Optional.ToNullable(subtaskId), taskState, executionInfo.Value);
        }
    }
}
