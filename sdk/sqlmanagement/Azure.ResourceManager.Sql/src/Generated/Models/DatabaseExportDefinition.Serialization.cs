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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class DatabaseExportDefinition : IUtf8JsonSerializable, IJsonModel<DatabaseExportDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatabaseExportDefinition>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DatabaseExportDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageKeyType"u8);
            writer.WriteStringValue(StorageKeyType.ToString());
            writer.WritePropertyName("storageKey"u8);
            writer.WriteStringValue(StorageKey);
            writer.WritePropertyName("storageUri"u8);
            writer.WriteStringValue(StorageUri.AbsoluteUri);
            writer.WritePropertyName("administratorLogin"u8);
            writer.WriteStringValue(AdministratorLogin);
            writer.WritePropertyName("administratorLoginPassword"u8);
            writer.WriteStringValue(AdministratorLoginPassword);
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType);
            }
            if (Optional.IsDefined(NetworkIsolation))
            {
                writer.WritePropertyName("networkIsolation"u8);
                writer.WriteObjectValue(NetworkIsolation);
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

        DatabaseExportDefinition IJsonModel<DatabaseExportDefinition>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DatabaseExportDefinition)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseExportDefinition(document.RootElement, options);
        }

        internal static DatabaseExportDefinition DeserializeDatabaseExportDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageKeyType storageKeyType = default;
            string storageKey = default;
            Uri storageUri = default;
            string administratorLogin = default;
            string administratorLoginPassword = default;
            Optional<string> authenticationType = default;
            Optional<NetworkIsolationSettings> networkIsolation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageKeyType"u8))
                {
                    storageKeyType = new StorageKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageKey"u8))
                {
                    storageKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageUri"u8))
                {
                    storageUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("administratorLogin"u8))
                {
                    administratorLogin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("administratorLoginPassword"u8))
                {
                    administratorLoginPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkIsolation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkIsolation = NetworkIsolationSettings.DeserializeNetworkIsolationSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DatabaseExportDefinition(storageKeyType, storageKey, storageUri, administratorLogin, administratorLoginPassword, authenticationType.Value, networkIsolation.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<DatabaseExportDefinition>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DatabaseExportDefinition)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DatabaseExportDefinition IModel<DatabaseExportDefinition>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DatabaseExportDefinition)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDatabaseExportDefinition(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DatabaseExportDefinition>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
