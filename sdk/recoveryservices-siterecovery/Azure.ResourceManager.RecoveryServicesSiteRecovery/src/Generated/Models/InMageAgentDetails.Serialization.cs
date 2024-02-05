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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageAgentDetails : IUtf8JsonSerializable, IJsonModel<InMageAgentDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageAgentDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageAgentDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageAgentDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(AgentUpdateStatus))
            {
                writer.WritePropertyName("agentUpdateStatus"u8);
                writer.WriteStringValue(AgentUpdateStatus);
            }
            if (Optional.IsDefined(PostUpdateRebootStatus))
            {
                writer.WritePropertyName("postUpdateRebootStatus"u8);
                writer.WriteStringValue(PostUpdateRebootStatus);
            }
            if (Optional.IsDefined(AgentExpireOn))
            {
                writer.WritePropertyName("agentExpiryDate"u8);
                writer.WriteStringValue(AgentExpireOn.Value, "O");
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

        InMageAgentDetails IJsonModel<InMageAgentDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageAgentDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageAgentDetails(document.RootElement, options);
        }

        internal static InMageAgentDetails DeserializeInMageAgentDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> agentVersion = default;
            Optional<string> agentUpdateStatus = default;
            Optional<string> postUpdateRebootStatus = default;
            Optional<DateTimeOffset> agentExpireOn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentUpdateStatus"u8))
                {
                    agentUpdateStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postUpdateRebootStatus"u8))
                {
                    postUpdateRebootStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageAgentDetails(agentVersion.Value, agentUpdateStatus.Value, postUpdateRebootStatus.Value, Optional.ToNullable(agentExpireOn), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(AgentVersion))
            {
                builder.Append("  agentVersion:");
                builder.AppendLine($" '{AgentVersion}'");
            }

            if (Optional.IsDefined(AgentUpdateStatus))
            {
                builder.Append("  agentUpdateStatus:");
                builder.AppendLine($" '{AgentUpdateStatus}'");
            }

            if (Optional.IsDefined(PostUpdateRebootStatus))
            {
                builder.Append("  postUpdateRebootStatus:");
                builder.AppendLine($" '{PostUpdateRebootStatus}'");
            }

            if (Optional.IsDefined(AgentExpireOn))
            {
                builder.Append("  agentExpiryDate:");
                var formattedDateTimeString = TypeFormatters.ToString(AgentExpireOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
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

        BinaryData IPersistableModel<InMageAgentDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(InMageAgentDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageAgentDetails IPersistableModel<InMageAgentDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageAgentDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(InMageAgentDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageAgentDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
