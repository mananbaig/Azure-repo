// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupJobSubTask : IUtf8JsonSerializable, IJsonModel<BackupJobSubTask>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupJobSubTask>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupJobSubTask>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupJobSubTask>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BackupJobSubTask)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AdditionalDetails))
            {
                writer.WritePropertyName("additionalDetails"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("taskId"u8);
            writer.WriteNumberValue(TaskId);
            writer.WritePropertyName("taskName"u8);
            writer.WriteStringValue(TaskName);
            if (options.Format != "W" && Optional.IsDefined(TaskProgress))
            {
                writer.WritePropertyName("taskProgress"u8);
                writer.WriteStringValue(TaskProgress);
            }
            writer.WritePropertyName("taskStatus"u8);
            writer.WriteStringValue(TaskStatus);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        BackupJobSubTask IJsonModel<BackupJobSubTask>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupJobSubTask>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BackupJobSubTask)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupJobSubTask(document.RootElement, options);
        }

        internal static BackupJobSubTask DeserializeBackupJobSubTask(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, string>> additionalDetails = default;
            int taskId = default;
            string taskName = default;
            Optional<string> taskProgress = default;
            string taskStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    additionalDetails = dictionary;
                    continue;
                }
                if (property.NameEquals("taskId"u8))
                {
                    taskId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskProgress"u8))
                {
                    taskProgress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskStatus"u8))
                {
                    taskStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupJobSubTask(Optional.ToDictionary(additionalDetails), taskId, taskName, taskProgress.Value, taskStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupJobSubTask>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupJobSubTask>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BackupJobSubTask)} does not support '{options.Format}' format.");
            }
        }

        BackupJobSubTask IPersistableModel<BackupJobSubTask>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupJobSubTask>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupJobSubTask(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BackupJobSubTask)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupJobSubTask>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
