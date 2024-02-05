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
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InstanceFailoverGroupReadOnlyEndpoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InstanceFailoverGroupReadOnlyEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceFailoverGroupReadOnlyEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InstanceFailoverGroupReadOnlyEndpoint)} does not support '{format}' format.");
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
                throw new FormatException($"The model {nameof(InstanceFailoverGroupReadOnlyEndpoint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInstanceFailoverGroupReadOnlyEndpoint(document.RootElement, options);
        }

        internal static InstanceFailoverGroupReadOnlyEndpoint DeserializeInstanceFailoverGroupReadOnlyEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReadOnlyEndpointFailoverPolicy> failoverPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InstanceFailoverGroupReadOnlyEndpoint(Optional.ToNullable(failoverPolicy), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(FailoverPolicy))
            {
                builder.Append("  failoverPolicy:");
                builder.AppendLine($" '{FailoverPolicy.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<InstanceFailoverGroupReadOnlyEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceFailoverGroupReadOnlyEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(InstanceFailoverGroupReadOnlyEndpoint)} does not support '{options.Format}' format.");
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
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(InstanceFailoverGroupReadOnlyEndpoint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InstanceFailoverGroupReadOnlyEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
