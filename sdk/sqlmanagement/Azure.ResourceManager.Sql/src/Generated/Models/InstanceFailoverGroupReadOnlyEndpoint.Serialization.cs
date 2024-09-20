// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class InstanceFailoverGroupReadOnlyEndpoint : IUtf8JsonSerializable, IJsonModel<InstanceFailoverGroupReadOnlyEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InstanceFailoverGroupReadOnlyEndpoint>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InstanceFailoverGroupReadOnlyEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceFailoverGroupReadOnlyEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InstanceFailoverGroupReadOnlyEndpoint)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FailoverPolicy))
            {
                writer.WritePropertyName("failoverPolicy"u8);
                writer.WriteStringValue(FailoverPolicy.Value.ToString());
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

        InstanceFailoverGroupReadOnlyEndpoint IJsonModel<InstanceFailoverGroupReadOnlyEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceFailoverGroupReadOnlyEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InstanceFailoverGroupReadOnlyEndpoint)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInstanceFailoverGroupReadOnlyEndpoint(document.RootElement, options);
        }

        internal static InstanceFailoverGroupReadOnlyEndpoint DeserializeInstanceFailoverGroupReadOnlyEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReadOnlyEndpointFailoverPolicy? failoverPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failoverPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failoverPolicy = new ReadOnlyEndpointFailoverPolicy(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InstanceFailoverGroupReadOnlyEndpoint(failoverPolicy, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FailoverPolicy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  failoverPolicy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FailoverPolicy))
                {
                    builder.Append("  failoverPolicy: ");
                    builder.AppendLine($"'{FailoverPolicy.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<InstanceFailoverGroupReadOnlyEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceFailoverGroupReadOnlyEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(InstanceFailoverGroupReadOnlyEndpoint)} does not support writing '{options.Format}' format.");
            }
        }

        InstanceFailoverGroupReadOnlyEndpoint IPersistableModel<InstanceFailoverGroupReadOnlyEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceFailoverGroupReadOnlyEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInstanceFailoverGroupReadOnlyEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InstanceFailoverGroupReadOnlyEndpoint)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InstanceFailoverGroupReadOnlyEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
