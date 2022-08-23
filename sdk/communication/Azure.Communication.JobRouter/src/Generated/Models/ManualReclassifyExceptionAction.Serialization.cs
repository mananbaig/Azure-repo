// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class ManualReclassifyExceptionAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(QueueId))
            {
                writer.WritePropertyName("queueId");
                writer.WriteStringValue(QueueId);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsCollectionDefined(WorkerSelectors))
            {
                writer.WritePropertyName("workerSelectors");
                writer.WriteStartArray();
                foreach (var item in WorkerSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static ManualReclassifyExceptionAction DeserializeManualReclassifyExceptionAction(JsonElement element)
        {
            Optional<string> queueId = default;
            Optional<int> priority = default;
            Optional<IList<WorkerSelector>> workerSelectors = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueId"))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("workerSelectors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WorkerSelector> array = new List<WorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkerSelector.DeserializeWorkerSelector(item));
                    }
                    workerSelectors = array;
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new ManualReclassifyExceptionAction(kind, queueId.Value, Optional.ToNullable(priority), Optional.ToList(workerSelectors));
        }
    }
}
