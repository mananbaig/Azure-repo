// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountBatchReleaseCriteria : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(MessageCount))
            {
                writer.WritePropertyName("messageCount"u8);
                writer.WriteNumberValue(MessageCount.Value);
            }
            if (Core.Optional.IsDefined(BatchSize))
            {
                writer.WritePropertyName("batchSize"u8);
                writer.WriteNumberValue(BatchSize.Value);
            }
            if (Core.Optional.IsDefined(Recurrence))
            {
                writer.WritePropertyName("recurrence"u8);
                writer.WriteObjectValue(Recurrence);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationAccountBatchReleaseCriteria DeserializeIntegrationAccountBatchReleaseCriteria(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> messageCount = default;
            Core.Optional<int> batchSize = default;
            Core.Optional<LogicWorkflowTriggerRecurrence> recurrence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("batchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    batchSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recurrence = LogicWorkflowTriggerRecurrence.DeserializeLogicWorkflowTriggerRecurrence(property.Value);
                    continue;
                }
            }
            return new IntegrationAccountBatchReleaseCriteria(Core.Optional.ToNullable(messageCount), Core.Optional.ToNullable(batchSize), recurrence.Value);
        }
    }
}
