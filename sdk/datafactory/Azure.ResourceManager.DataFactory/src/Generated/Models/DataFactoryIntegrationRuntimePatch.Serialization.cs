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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryIntegrationRuntimePatch : IUtf8JsonSerializable, IJsonModel<DataFactoryIntegrationRuntimePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryIntegrationRuntimePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryIntegrationRuntimePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryIntegrationRuntimePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataFactoryIntegrationRuntimePatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AutoUpdate))
            {
                writer.WritePropertyName("autoUpdate"u8);
                writer.WriteStringValue(AutoUpdate.Value.ToString());
            }
            if (Optional.IsDefined(UpdateDelayOffset))
            {
                writer.WritePropertyName("updateDelayOffset"u8);
                writer.WriteStringValue(UpdateDelayOffset.Value, "P");
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

        DataFactoryIntegrationRuntimePatch IJsonModel<DataFactoryIntegrationRuntimePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryIntegrationRuntimePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataFactoryIntegrationRuntimePatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryIntegrationRuntimePatch(document.RootElement, options);
        }

        internal static DataFactoryIntegrationRuntimePatch DeserializeDataFactoryIntegrationRuntimePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IntegrationRuntimeAutoUpdateState> autoUpdate = default;
            Optional<TimeSpan> updateDelayOffset = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoUpdate = new IntegrationRuntimeAutoUpdateState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateDelayOffset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateDelayOffset = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataFactoryIntegrationRuntimePatch(Optional.ToNullable(autoUpdate), Optional.ToNullable(updateDelayOffset), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFactoryIntegrationRuntimePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryIntegrationRuntimePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DataFactoryIntegrationRuntimePatch)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryIntegrationRuntimePatch IPersistableModel<DataFactoryIntegrationRuntimePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryIntegrationRuntimePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryIntegrationRuntimePatch(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DataFactoryIntegrationRuntimePatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryIntegrationRuntimePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
