// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class RuntimeScriptActionDetail : IUtf8JsonSerializable, IJsonModel<RuntimeScriptActionDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RuntimeScriptActionDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RuntimeScriptActionDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuntimeScriptActionDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuntimeScriptActionDetail)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ScriptExecutionId))
            {
                writer.WritePropertyName("scriptExecutionId"u8);
                writer.WriteNumberValue(ScriptExecutionId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExecutionSummary))
            {
                writer.WritePropertyName("executionSummary"u8);
                writer.WriteStartArray();
                foreach (var item in ExecutionSummary)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(DebugInformation))
            {
                writer.WritePropertyName("debugInformation"u8);
                writer.WriteStringValue(DebugInformation);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStringValue(Parameters);
            }
            writer.WritePropertyName("roles"u8);
            writer.WriteStartArray();
            foreach (var item in Roles)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && Optional.IsDefined(ApplicationName))
            {
                writer.WritePropertyName("applicationName"u8);
                writer.WriteStringValue(ApplicationName);
            }
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

        RuntimeScriptActionDetail IJsonModel<RuntimeScriptActionDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuntimeScriptActionDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuntimeScriptActionDetail)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRuntimeScriptActionDetail(document.RootElement, options);
        }

        internal static RuntimeScriptActionDetail DeserializeRuntimeScriptActionDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? scriptExecutionId = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            string status = default;
            string operation = default;
            IReadOnlyList<ScriptActionExecutionSummary> executionSummary = default;
            string debugInformation = default;
            string name = default;
            Uri uri = default;
            string parameters = default;
            IList<string> roles = default;
            string applicationName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scriptExecutionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scriptExecutionId = property.Value.GetInt64();
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
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    operation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("executionSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScriptActionExecutionSummary> array = new List<ScriptActionExecutionSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptActionExecutionSummary.DeserializeScriptActionExecutionSummary(item, options));
                    }
                    executionSummary = array;
                    continue;
                }
                if (property.NameEquals("debugInformation"u8))
                {
                    debugInformation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    parameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roles"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    roles = array;
                    continue;
                }
                if (property.NameEquals("applicationName"u8))
                {
                    applicationName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RuntimeScriptActionDetail(
                name,
                uri,
                parameters,
                roles,
                applicationName,
                serializedAdditionalRawData,
                scriptExecutionId,
                startTime,
                endTime,
                status,
                operation,
                executionSummary ?? new ChangeTrackingList<ScriptActionExecutionSummary>(),
                debugInformation);
        }

        BinaryData IPersistableModel<RuntimeScriptActionDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuntimeScriptActionDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RuntimeScriptActionDetail)} does not support '{options.Format}' format.");
            }
        }

        RuntimeScriptActionDetail IPersistableModel<RuntimeScriptActionDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuntimeScriptActionDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRuntimeScriptActionDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RuntimeScriptActionDetail)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RuntimeScriptActionDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
