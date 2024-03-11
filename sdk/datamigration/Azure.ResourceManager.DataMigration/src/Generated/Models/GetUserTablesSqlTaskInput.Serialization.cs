// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class GetUserTablesSqlTaskInput : IUtf8JsonSerializable, IJsonModel<GetUserTablesSqlTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GetUserTablesSqlTaskInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GetUserTablesSqlTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesSqlTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetUserTablesSqlTaskInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("connectionInfo"u8);
            writer.WriteObjectValue(ConnectionInfo);
            writer.WritePropertyName("selectedDatabases"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(EncryptedKeyForSecureFields))
            {
                writer.WritePropertyName("encryptedKeyForSecureFields"u8);
                writer.WriteStringValue(EncryptedKeyForSecureFields);
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

        GetUserTablesSqlTaskInput IJsonModel<GetUserTablesSqlTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesSqlTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetUserTablesSqlTaskInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGetUserTablesSqlTaskInput(document.RootElement, options);
        }

        internal static GetUserTablesSqlTaskInput DeserializeGetUserTablesSqlTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlConnectionInfo connectionInfo = default;
            IList<string> selectedDatabases = default;
            string encryptedKeyForSecureFields = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionInfo"u8))
                {
                    connectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("encryptedKeyForSecureFields"u8))
                {
                    encryptedKeyForSecureFields = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GetUserTablesSqlTaskInput(connectionInfo, selectedDatabases, encryptedKeyForSecureFields, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GetUserTablesSqlTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesSqlTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GetUserTablesSqlTaskInput)} does not support '{options.Format}' format.");
            }
        }

        GetUserTablesSqlTaskInput IPersistableModel<GetUserTablesSqlTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesSqlTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGetUserTablesSqlTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GetUserTablesSqlTaskInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GetUserTablesSqlTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
