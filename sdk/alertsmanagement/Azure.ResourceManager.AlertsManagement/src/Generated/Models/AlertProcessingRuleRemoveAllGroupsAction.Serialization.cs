// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class AlertProcessingRuleRemoveAllGroupsAction : IUtf8JsonSerializable, IJsonModel<AlertProcessingRuleRemoveAllGroupsAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AlertProcessingRuleRemoveAllGroupsAction>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AlertProcessingRuleRemoveAllGroupsAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertProcessingRuleRemoveAllGroupsAction)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        AlertProcessingRuleRemoveAllGroupsAction IJsonModel<AlertProcessingRuleRemoveAllGroupsAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertProcessingRuleRemoveAllGroupsAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertProcessingRuleRemoveAllGroupsAction(document.RootElement, options);
        }

        internal static AlertProcessingRuleRemoveAllGroupsAction DeserializeAlertProcessingRuleRemoveAllGroupsAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AlertProcessingRuleActionType actionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new AlertProcessingRuleActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AlertProcessingRuleRemoveAllGroupsAction(actionType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AlertProcessingRuleRemoveAllGroupsAction)} does not support writing '{options.Format}' format.");
            }
        }

        AlertProcessingRuleRemoveAllGroupsAction IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAlertProcessingRuleRemoveAllGroupsAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AlertProcessingRuleRemoveAllGroupsAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AlertProcessingRuleRemoveAllGroupsAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
