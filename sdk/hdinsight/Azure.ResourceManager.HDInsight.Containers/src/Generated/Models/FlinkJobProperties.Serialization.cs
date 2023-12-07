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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class FlinkJobProperties : IUtf8JsonSerializable, IJsonModel<FlinkJobProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FlinkJobProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FlinkJobProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FlinkJobProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("jobName"u8);
            writer.WriteStringValue(JobName);
            if (Optional.IsDefined(JobJarDirectory))
            {
                writer.WritePropertyName("jobJarDirectory"u8);
                writer.WriteStringValue(JobJarDirectory);
            }
            if (Optional.IsDefined(JarName))
            {
                writer.WritePropertyName("jarName"u8);
                writer.WriteStringValue(JarName);
            }
            if (Optional.IsDefined(EntryClass))
            {
                writer.WritePropertyName("entryClass"u8);
                writer.WriteStringValue(EntryClass);
            }
            if (Optional.IsDefined(Args))
            {
                writer.WritePropertyName("args"u8);
                writer.WriteStringValue(Args);
            }
            if (Optional.IsDefined(SavePointName))
            {
                writer.WritePropertyName("savePointName"u8);
                writer.WriteStringValue(SavePointName);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FlinkConfiguration))
            {
                writer.WritePropertyName("flinkConfiguration"u8);
                writer.WriteStartObject();
                foreach (var item in FlinkConfiguration)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(JobOutput))
            {
                writer.WritePropertyName("jobOutput"u8);
                writer.WriteStringValue(JobOutput);
            }
            if (options.Format != "W" && Optional.IsDefined(ActionResult))
            {
                writer.WritePropertyName("actionResult"u8);
                writer.WriteStringValue(ActionResult);
            }
            if (options.Format != "W" && Optional.IsDefined(LastSavePoint))
            {
                writer.WritePropertyName("lastSavePoint"u8);
                writer.WriteStringValue(LastSavePoint);
            }
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType.ToString());
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

        FlinkJobProperties IJsonModel<FlinkJobProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(FlinkJobProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFlinkJobProperties(document.RootElement, options);
        }

        internal static FlinkJobProperties DeserializeFlinkJobProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string jobName = default;
            Optional<string> jobJarDirectory = default;
            Optional<string> jarName = default;
            Optional<string> entryClass = default;
            Optional<string> args = default;
            Optional<string> savePointName = default;
            Optional<FlinkJobAction> action = default;
            Optional<IDictionary<string, string>> flinkConfiguration = default;
            Optional<string> jobId = default;
            Optional<string> status = default;
            Optional<string> jobOutput = default;
            Optional<string> actionResult = default;
            Optional<string> lastSavePoint = default;
            ClusterJobType jobType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobName"u8))
                {
                    jobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobJarDirectory"u8))
                {
                    jobJarDirectory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jarName"u8))
                {
                    jarName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entryClass"u8))
                {
                    entryClass = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("args"u8))
                {
                    args = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("savePointName"u8))
                {
                    savePointName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new FlinkJobAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("flinkConfiguration"u8))
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
                    flinkConfiguration = dictionary;
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobOutput"u8))
                {
                    jobOutput = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionResult"u8))
                {
                    actionResult = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastSavePoint"u8))
                {
                    lastSavePoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobType"u8))
                {
                    jobType = new ClusterJobType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FlinkJobProperties(jobType, serializedAdditionalRawData, jobName, jobJarDirectory.Value, jarName.Value, entryClass.Value, args.Value, savePointName.Value, Optional.ToNullable(action), Optional.ToDictionary(flinkConfiguration), jobId.Value, status.Value, jobOutput.Value, actionResult.Value, lastSavePoint.Value);
        }

        BinaryData IPersistableModel<FlinkJobProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(FlinkJobProperties)} does not support '{options.Format}' format.");
            }
        }

        FlinkJobProperties IPersistableModel<FlinkJobProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFlinkJobProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(FlinkJobProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FlinkJobProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
