// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIncidentLabel : IUtf8JsonSerializable, IJsonModel<SecurityInsightsIncidentLabel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsIncidentLabel>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SecurityInsightsIncidentLabel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("labelName"u8);
            writer.WriteStringValue(LabelName);
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LabelType))
                {
                    writer.WritePropertyName("labelType"u8);
                    writer.WriteStringValue(LabelType.Value.ToString());
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        SecurityInsightsIncidentLabel IJsonModel<SecurityInsightsIncidentLabel>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentLabel)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsIncidentLabel(document.RootElement, options);
        }

        internal static SecurityInsightsIncidentLabel DeserializeSecurityInsightsIncidentLabel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string labelName = default;
            Optional<SecurityInsightsIncidentLabelType> labelType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("labelName"u8))
                {
                    labelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labelType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    labelType = new SecurityInsightsIncidentLabelType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsIncidentLabel(labelName, Optional.ToNullable(labelType), serializedAdditionalRawData);
        }

        BinaryData IModel<SecurityInsightsIncidentLabel>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentLabel)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SecurityInsightsIncidentLabel IModel<SecurityInsightsIncidentLabel>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentLabel)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsIncidentLabel(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SecurityInsightsIncidentLabel>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
