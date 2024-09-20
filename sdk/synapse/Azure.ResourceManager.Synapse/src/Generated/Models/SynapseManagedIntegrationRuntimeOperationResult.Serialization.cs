// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseManagedIntegrationRuntimeOperationResult : IUtf8JsonSerializable, IJsonModel<SynapseManagedIntegrationRuntimeOperationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseManagedIntegrationRuntimeOperationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseManagedIntegrationRuntimeOperationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeOperationResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ManagedIntegrationRuntimeOperationResultType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ManagedIntegrationRuntimeOperationResultType);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Result))
            {
                writer.WritePropertyName("result"u8);
                writer.WriteStringValue(Result);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ActivityId))
            {
                writer.WritePropertyName("activityId"u8);
                writer.WriteStringValue(ActivityId);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SynapseManagedIntegrationRuntimeOperationResult IJsonModel<SynapseManagedIntegrationRuntimeOperationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeOperationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseManagedIntegrationRuntimeOperationResult(document.RootElement, options);
        }

        internal static SynapseManagedIntegrationRuntimeOperationResult DeserializeSynapseManagedIntegrationRuntimeOperationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            DateTimeOffset? startTime = default;
            string result = default;
            string errorCode = default;
            IReadOnlyList<string> parameters = default;
            string activityId = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                if (property.NameEquals("result"u8))
                {
                    result = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
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
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("activityId"u8))
                {
                    activityId = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseManagedIntegrationRuntimeOperationResult(
                type,
                startTime,
                result,
                errorCode,
                parameters ?? new ChangeTrackingList<string>(),
                activityId,
                additionalProperties);
        }

        BinaryData IPersistableModel<SynapseManagedIntegrationRuntimeOperationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeOperationResult)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseManagedIntegrationRuntimeOperationResult IPersistableModel<SynapseManagedIntegrationRuntimeOperationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseManagedIntegrationRuntimeOperationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeOperationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseManagedIntegrationRuntimeOperationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
