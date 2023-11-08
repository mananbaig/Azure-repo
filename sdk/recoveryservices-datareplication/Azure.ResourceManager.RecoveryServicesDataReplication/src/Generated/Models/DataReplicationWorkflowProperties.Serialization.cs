// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationWorkflowProperties : IUtf8JsonSerializable, IJsonModel<DataReplicationWorkflowProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataReplicationWorkflowProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DataReplicationWorkflowProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DisplayName))
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(State))
                {
                    writer.WritePropertyName("state"u8);
                    writer.WriteStringValue(State.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(StartOn))
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(EndOn))
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ObjectId))
                {
                    writer.WritePropertyName("objectId"u8);
                    writer.WriteStringValue(ObjectId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ObjectName))
                {
                    writer.WritePropertyName("objectName"u8);
                    writer.WriteStringValue(ObjectName);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ObjectInternalId))
                {
                    writer.WritePropertyName("objectInternalId"u8);
                    writer.WriteStringValue(ObjectInternalId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ObjectInternalName))
                {
                    writer.WritePropertyName("objectInternalName"u8);
                    writer.WriteStringValue(ObjectInternalName);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ObjectType))
                {
                    writer.WritePropertyName("objectType"u8);
                    writer.WriteStringValue(ObjectType.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ReplicationProviderId))
                {
                    writer.WritePropertyName("replicationProviderId"u8);
                    writer.WriteStringValue(ReplicationProviderId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SourceFabricProviderId))
                {
                    writer.WritePropertyName("sourceFabricProviderId"u8);
                    writer.WriteStringValue(SourceFabricProviderId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(TargetFabricProviderId))
                {
                    writer.WritePropertyName("targetFabricProviderId"u8);
                    writer.WriteStringValue(TargetFabricProviderId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(AllowedActions))
                {
                    writer.WritePropertyName("allowedActions"u8);
                    writer.WriteStartArray();
                    foreach (var item in AllowedActions)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ActivityId))
                {
                    writer.WritePropertyName("activityId"u8);
                    writer.WriteStringValue(ActivityId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Tasks))
                {
                    writer.WritePropertyName("tasks"u8);
                    writer.WriteStartArray();
                    foreach (var item in Tasks)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Errors))
                {
                    writer.WritePropertyName("errors"u8);
                    writer.WriteStartArray();
                    foreach (var item in Errors)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            writer.WritePropertyName("customProperties"u8);
            writer.WriteObjectValue(CustomProperties);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DataReplicationWorkflowProperties IJsonModel<DataReplicationWorkflowProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataReplicationWorkflowProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataReplicationWorkflowProperties(document.RootElement, options);
        }

        internal static DataReplicationWorkflowProperties DeserializeDataReplicationWorkflowProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<DataReplicationWorkflowState> state = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> objectId = default;
            Optional<string> objectName = default;
            Optional<string> objectInternalId = default;
            Optional<string> objectInternalName = default;
            Optional<WorkflowObjectType> objectType = default;
            Optional<string> replicationProviderId = default;
            Optional<string> sourceFabricProviderId = default;
            Optional<string> targetFabricProviderId = default;
            Optional<IReadOnlyList<string>> allowedActions = default;
            Optional<string> activityId = default;
            Optional<IReadOnlyList<DataReplicationTask>> tasks = default;
            Optional<IReadOnlyList<DataReplicationErrorInfo>> errors = default;
            WorkflowModelCustomProperties customProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new DataReplicationWorkflowState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("objectId"u8))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectName"u8))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectInternalId"u8))
                {
                    objectInternalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectInternalName"u8))
                {
                    objectInternalName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectType = new WorkflowObjectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationProviderId"u8))
                {
                    replicationProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceFabricProviderId"u8))
                {
                    sourceFabricProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetFabricProviderId"u8))
                {
                    targetFabricProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedActions = array;
                    continue;
                }
                if (property.NameEquals("activityId"u8))
                {
                    activityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataReplicationTask> array = new List<DataReplicationTask>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataReplicationTask.DeserializeDataReplicationTask(item));
                    }
                    tasks = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataReplicationErrorInfo> array = new List<DataReplicationErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataReplicationErrorInfo.DeserializeDataReplicationErrorInfo(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("customProperties"u8))
                {
                    customProperties = WorkflowModelCustomProperties.DeserializeWorkflowModelCustomProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataReplicationWorkflowProperties(displayName.Value, Optional.ToNullable(state), Optional.ToNullable(startTime), Optional.ToNullable(endTime), objectId.Value, objectName.Value, objectInternalId.Value, objectInternalName.Value, Optional.ToNullable(objectType), replicationProviderId.Value, sourceFabricProviderId.Value, targetFabricProviderId.Value, Optional.ToList(allowedActions), activityId.Value, Optional.ToList(tasks), Optional.ToList(errors), customProperties, serializedAdditionalRawData);
        }

        BinaryData IModel<DataReplicationWorkflowProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataReplicationWorkflowProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataReplicationWorkflowProperties IModel<DataReplicationWorkflowProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataReplicationWorkflowProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataReplicationWorkflowProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DataReplicationWorkflowProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
