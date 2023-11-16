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

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlServerPrivateLinkServiceConnectionStateProperty : IUtf8JsonSerializable, IJsonModel<PostgreSqlServerPrivateLinkServiceConnectionStateProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlServerPrivateLinkServiceConnectionStateProperty>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PostgreSqlServerPrivateLinkServiceConnectionStateProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PostgreSqlServerPrivateLinkServiceConnectionStateProperty>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PostgreSqlServerPrivateLinkServiceConnectionStateProperty>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("description"u8);
            writer.WriteStringValue(Description);
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ActionsRequired))
                {
                    writer.WritePropertyName("actionsRequired"u8);
                    writer.WriteStringValue(ActionsRequired.Value.ToString());
                }
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

        PostgreSqlServerPrivateLinkServiceConnectionStateProperty IJsonModel<PostgreSqlServerPrivateLinkServiceConnectionStateProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlServerPrivateLinkServiceConnectionStateProperty)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlServerPrivateLinkServiceConnectionStateProperty(document.RootElement, options);
        }

        internal static PostgreSqlServerPrivateLinkServiceConnectionStateProperty DeserializePostgreSqlServerPrivateLinkServiceConnectionStateProperty(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PostgreSqlPrivateLinkServiceConnectionStateStatus status = default;
            string description = default;
            Optional<PostgreSqlPrivateLinkServiceConnectionStateRequiredAction> actionsRequired = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = new PostgreSqlPrivateLinkServiceConnectionStateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionsRequired = new PostgreSqlPrivateLinkServiceConnectionStateRequiredAction(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlServerPrivateLinkServiceConnectionStateProperty(status, description, Optional.ToNullable(actionsRequired), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlServerPrivateLinkServiceConnectionStateProperty>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlServerPrivateLinkServiceConnectionStateProperty)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PostgreSqlServerPrivateLinkServiceConnectionStateProperty IPersistableModel<PostgreSqlServerPrivateLinkServiceConnectionStateProperty>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PostgreSqlServerPrivateLinkServiceConnectionStateProperty)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePostgreSqlServerPrivateLinkServiceConnectionStateProperty(document.RootElement, options);
        }

        string IPersistableModel<PostgreSqlServerPrivateLinkServiceConnectionStateProperty>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
