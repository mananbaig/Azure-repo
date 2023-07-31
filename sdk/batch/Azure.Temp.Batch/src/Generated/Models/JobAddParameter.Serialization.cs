// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    public partial class JobAddParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(MaxParallelTasks))
            {
                writer.WritePropertyName("maxParallelTasks"u8);
                writer.WriteNumberValue(MaxParallelTasks.Value);
            }
            if (Optional.IsDefined(AllowTaskPreemption))
            {
                writer.WritePropertyName("allowTaskPreemption"u8);
                writer.WriteBooleanValue(AllowTaskPreemption.Value);
            }
            if (Optional.IsDefined(Constraints))
            {
                writer.WritePropertyName("constraints"u8);
                writer.WriteObjectValue(Constraints);
            }
            if (Optional.IsDefined(JobManagerTask))
            {
                writer.WritePropertyName("jobManagerTask"u8);
                writer.WriteObjectValue(JobManagerTask);
            }
            if (Optional.IsDefined(JobPreparationTask))
            {
                writer.WritePropertyName("jobPreparationTask"u8);
                writer.WriteObjectValue(JobPreparationTask);
            }
            if (Optional.IsDefined(JobReleaseTask))
            {
                writer.WritePropertyName("jobReleaseTask"u8);
                writer.WriteObjectValue(JobReleaseTask);
            }
            if (Optional.IsCollectionDefined(CommonEnvironmentSettings))
            {
                writer.WritePropertyName("commonEnvironmentSettings"u8);
                writer.WriteStartArray();
                foreach (var item in CommonEnvironmentSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("poolInfo"u8);
            writer.WriteObjectValue(PoolInfo);
            if (Optional.IsDefined(OnAllTasksComplete))
            {
                writer.WritePropertyName("onAllTasksComplete"u8);
                writer.WriteStringValue(OnAllTasksComplete.Value.ToSerialString());
            }
            if (Optional.IsDefined(OnTaskFailure))
            {
                writer.WritePropertyName("onTaskFailure"u8);
                writer.WriteStringValue(OnTaskFailure.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UsesTaskDependencies))
            {
                writer.WritePropertyName("usesTaskDependencies"u8);
                writer.WriteBooleanValue(UsesTaskDependencies.Value);
            }
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration);
            }
            writer.WriteEndObject();
        }
    }
}
