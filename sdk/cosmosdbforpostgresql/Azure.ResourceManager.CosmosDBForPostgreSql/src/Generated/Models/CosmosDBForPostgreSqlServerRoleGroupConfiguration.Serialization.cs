// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    public partial class CosmosDBForPostgreSqlServerRoleGroupConfiguration : IUtf8JsonSerializable, IJsonModel<CosmosDBForPostgreSqlServerRoleGroupConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBForPostgreSqlServerRoleGroupConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CosmosDBForPostgreSqlServerRoleGroupConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlServerRoleGroupConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlServerRoleGroupConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("role"u8);
            writer.WriteStringValue(Role.ToString());
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            if (options.Format != "W" && Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
            }
            if (options.Format != "W" && Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
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

        CosmosDBForPostgreSqlServerRoleGroupConfiguration IJsonModel<CosmosDBForPostgreSqlServerRoleGroupConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlServerRoleGroupConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlServerRoleGroupConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBForPostgreSqlServerRoleGroupConfiguration(document.RootElement, options);
        }

        internal static CosmosDBForPostgreSqlServerRoleGroupConfiguration DeserializeCosmosDBForPostgreSqlServerRoleGroupConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CosmosDBForPostgreSqlServerRole role = default;
            string value = default;
            string defaultValue = default;
            string source = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("role"u8))
                {
                    role = new CosmosDBForPostgreSqlServerRole(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CosmosDBForPostgreSqlServerRoleGroupConfiguration(role, value, defaultValue, source, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBForPostgreSqlServerRoleGroupConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlServerRoleGroupConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlServerRoleGroupConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBForPostgreSqlServerRoleGroupConfiguration IPersistableModel<CosmosDBForPostgreSqlServerRoleGroupConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlServerRoleGroupConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBForPostgreSqlServerRoleGroupConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlServerRoleGroupConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBForPostgreSqlServerRoleGroupConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
