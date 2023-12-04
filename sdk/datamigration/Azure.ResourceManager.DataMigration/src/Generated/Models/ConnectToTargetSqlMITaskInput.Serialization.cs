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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToTargetSqlMITaskInput : IUtf8JsonSerializable, IJsonModel<ConnectToTargetSqlMITaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToTargetSqlMITaskInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectToTargetSqlMITaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetSqlMITaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ConnectToTargetSqlMITaskInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("targetConnectionInfo"u8);
            writer.WriteObjectValue(TargetConnectionInfo);
            if (Optional.IsDefined(CollectLogins))
            {
                writer.WritePropertyName("collectLogins"u8);
                writer.WriteBooleanValue(CollectLogins.Value);
            }
            if (Optional.IsDefined(CollectAgentJobs))
            {
                writer.WritePropertyName("collectAgentJobs"u8);
                writer.WriteBooleanValue(CollectAgentJobs.Value);
            }
            if (Optional.IsDefined(ValidateSsisCatalogOnly))
            {
                writer.WritePropertyName("validateSsisCatalogOnly"u8);
                writer.WriteBooleanValue(ValidateSsisCatalogOnly.Value);
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

        ConnectToTargetSqlMITaskInput IJsonModel<ConnectToTargetSqlMITaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetSqlMITaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ConnectToTargetSqlMITaskInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToTargetSqlMITaskInput(document.RootElement, options);
        }

        internal static ConnectToTargetSqlMITaskInput DeserializeConnectToTargetSqlMITaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlConnectionInfo targetConnectionInfo = default;
            Optional<bool> collectLogins = default;
            Optional<bool> collectAgentJobs = default;
            Optional<bool> validateSsisCatalogOnly = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("collectLogins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    collectLogins = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("collectAgentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    collectAgentJobs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateSsisCatalogOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateSsisCatalogOnly = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectToTargetSqlMITaskInput(targetConnectionInfo, Optional.ToNullable(collectLogins), Optional.ToNullable(collectAgentJobs), Optional.ToNullable(validateSsisCatalogOnly), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectToTargetSqlMITaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetSqlMITaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ConnectToTargetSqlMITaskInput)} does not support '{options.Format}' format.");
            }
        }

        ConnectToTargetSqlMITaskInput IPersistableModel<ConnectToTargetSqlMITaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetSqlMITaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectToTargetSqlMITaskInput(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ConnectToTargetSqlMITaskInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToTargetSqlMITaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
