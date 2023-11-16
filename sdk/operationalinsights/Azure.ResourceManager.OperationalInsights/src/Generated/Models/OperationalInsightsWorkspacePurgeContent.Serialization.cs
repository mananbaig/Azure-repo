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
    public partial class OperationalInsightsWorkspacePurgeContent : IUtf8JsonSerializable, IJsonModel<OperationalInsightsWorkspacePurgeContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsWorkspacePurgeContent>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<OperationalInsightsWorkspacePurgeContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<OperationalInsightsWorkspacePurgeContent>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<OperationalInsightsWorkspacePurgeContent>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("table"u8);
            writer.WriteStringValue(Table);
            writer.WritePropertyName("filters"u8);
            writer.WriteStartArray();
            foreach (var item in Filters)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        OperationalInsightsWorkspacePurgeContent IJsonModel<OperationalInsightsWorkspacePurgeContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspacePurgeContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsWorkspacePurgeContent(document.RootElement, options);
        }

        internal static OperationalInsightsWorkspacePurgeContent DeserializeOperationalInsightsWorkspacePurgeContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string table = default;
            IList<OperationalInsightsWorkspacePurgeFilter> filters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("table"u8))
                {
                    table = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    List<OperationalInsightsWorkspacePurgeFilter> array = new List<OperationalInsightsWorkspacePurgeFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationalInsightsWorkspacePurgeFilter.DeserializeOperationalInsightsWorkspacePurgeFilter(item));
                    }
                    filters = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsWorkspacePurgeContent(table, filters, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationalInsightsWorkspacePurgeContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspacePurgeContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        OperationalInsightsWorkspacePurgeContent IPersistableModel<OperationalInsightsWorkspacePurgeContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspacePurgeContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeOperationalInsightsWorkspacePurgeContent(document.RootElement, options);
        }

        string IPersistableModel<OperationalInsightsWorkspacePurgeContent>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
