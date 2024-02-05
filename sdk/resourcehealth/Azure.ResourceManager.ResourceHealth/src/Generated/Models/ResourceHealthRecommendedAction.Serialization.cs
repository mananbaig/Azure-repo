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

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthRecommendedAction : IUtf8JsonSerializable, IJsonModel<ResourceHealthRecommendedAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceHealthRecommendedAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceHealthRecommendedAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthRecommendedAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthRecommendedAction)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action);
            }
            if (Optional.IsDefined(ActionUri))
            {
                writer.WritePropertyName("actionUrl"u8);
                writer.WriteStringValue(ActionUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ActionUriComment))
            {
                writer.WritePropertyName("_ActionUrl.Comment"u8);
                writer.WriteStringValue(ActionUriComment);
            }
            if (Optional.IsDefined(ActionUriText))
            {
                writer.WritePropertyName("actionUrlText"u8);
                writer.WriteStringValue(ActionUriText);
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

        ResourceHealthRecommendedAction IJsonModel<ResourceHealthRecommendedAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthRecommendedAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthRecommendedAction)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthRecommendedAction(document.RootElement, options);
        }

        internal static ResourceHealthRecommendedAction DeserializeResourceHealthRecommendedAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> action = default;
            Optional<Uri> actionUri = default;
            Optional<string> actionUriComment = default;
            Optional<string> actionUriText = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"u8))
                {
                    action = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("_ActionUrl.Comment"u8))
                {
                    actionUriComment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionUrlText"u8))
                {
                    actionUriText = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceHealthRecommendedAction(action.Value, actionUri.Value, actionUriComment.Value, actionUriText.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Action))
            {
                builder.Append("  action:");
                builder.AppendLine($" '{Action}'");
            }

            if (Optional.IsDefined(ActionUri))
            {
                builder.Append("  actionUrl:");
                builder.AppendLine($" '{ActionUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(ActionUriComment))
            {
                builder.Append("  _ActionUrl.Comment:");
                builder.AppendLine($" '{ActionUriComment}'");
            }

            if (Optional.IsDefined(ActionUriText))
            {
                builder.Append("  actionUrlText:");
                builder.AppendLine($" '{ActionUriText}'");
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

        BinaryData IPersistableModel<ResourceHealthRecommendedAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthRecommendedAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthRecommendedAction)} does not support '{options.Format}' format.");
            }
        }

        ResourceHealthRecommendedAction IPersistableModel<ResourceHealthRecommendedAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthRecommendedAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceHealthRecommendedAction(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthRecommendedAction)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceHealthRecommendedAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
