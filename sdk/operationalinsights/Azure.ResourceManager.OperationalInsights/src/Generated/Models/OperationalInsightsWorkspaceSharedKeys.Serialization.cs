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

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsWorkspaceSharedKeys : IUtf8JsonSerializable, IJsonModel<OperationalInsightsWorkspaceSharedKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsWorkspaceSharedKeys>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<OperationalInsightsWorkspaceSharedKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<OperationalInsightsWorkspaceSharedKeys>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<OperationalInsightsWorkspaceSharedKeys>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimarySharedKey))
            {
                writer.WritePropertyName("primarySharedKey"u8);
                writer.WriteStringValue(PrimarySharedKey);
            }
            if (Optional.IsDefined(SecondarySharedKey))
            {
                writer.WritePropertyName("secondarySharedKey"u8);
                writer.WriteStringValue(SecondarySharedKey);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        OperationalInsightsWorkspaceSharedKeys IJsonModel<OperationalInsightsWorkspaceSharedKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceSharedKeys)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsWorkspaceSharedKeys(document.RootElement, options);
        }

        internal static OperationalInsightsWorkspaceSharedKeys DeserializeOperationalInsightsWorkspaceSharedKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primarySharedKey = default;
            Optional<string> secondarySharedKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primarySharedKey"u8))
                {
                    primarySharedKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondarySharedKey"u8))
                {
                    secondarySharedKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsWorkspaceSharedKeys(primarySharedKey.Value, secondarySharedKey.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationalInsightsWorkspaceSharedKeys>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceSharedKeys)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        OperationalInsightsWorkspaceSharedKeys IPersistableModel<OperationalInsightsWorkspaceSharedKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceSharedKeys)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeOperationalInsightsWorkspaceSharedKeys(document.RootElement, options);
        }

        string IPersistableModel<OperationalInsightsWorkspaceSharedKeys>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
