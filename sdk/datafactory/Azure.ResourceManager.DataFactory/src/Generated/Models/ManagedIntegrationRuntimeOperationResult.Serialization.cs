// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ManagedIntegrationRuntimeOperationResult : IUtf8JsonSerializable, IJsonModel<ManagedIntegrationRuntimeOperationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedIntegrationRuntimeOperationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedIntegrationRuntimeOperationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIntegrationRuntimeOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedIntegrationRuntimeOperationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ManagedIntegrationRuntimeOperationResultType != null)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ManagedIntegrationRuntimeOperationResultType);
            }
            if (options.Format != "W" && StartOn.HasValue)
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Result != null)
            {
                writer.WritePropertyName("result"u8);
                writer.WriteStringValue(Result);
            }
            if (options.Format != "W" && ErrorCode != null)
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (options.Format != "W" && !(Parameters is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ActivityId != null)
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

        ManagedIntegrationRuntimeOperationResult IJsonModel<ManagedIntegrationRuntimeOperationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIntegrationRuntimeOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedIntegrationRuntimeOperationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedIntegrationRuntimeOperationResult(document.RootElement, options);
        }

        internal static ManagedIntegrationRuntimeOperationResult DeserializeManagedIntegrationRuntimeOperationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> type = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> result = default;
            Optional<string> errorCode = default;
            Optional<IReadOnlyList<string>> parameters = default;
            Optional<string> activityId = default;
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
            return new ManagedIntegrationRuntimeOperationResult(type.Value, Optional.ToNullable(startTime), result.Value, errorCode.Value, Optional.ToList(parameters), activityId.Value, additionalProperties);
        }

        BinaryData IPersistableModel<ManagedIntegrationRuntimeOperationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIntegrationRuntimeOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedIntegrationRuntimeOperationResult)} does not support '{options.Format}' format.");
            }
        }

        ManagedIntegrationRuntimeOperationResult IPersistableModel<ManagedIntegrationRuntimeOperationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIntegrationRuntimeOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedIntegrationRuntimeOperationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedIntegrationRuntimeOperationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedIntegrationRuntimeOperationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
