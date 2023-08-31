// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class ConnectorMappingProperties : IUtf8JsonSerializable, IModelJsonSerializable<ConnectorMappingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectorMappingProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectorMappingProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath"u8);
                writer.WriteStringValue(FolderPath);
            }
            if (Optional.IsDefined(FileFilter))
            {
                writer.WritePropertyName("fileFilter"u8);
                writer.WriteStringValue(FileFilter);
            }
            if (Optional.IsDefined(HasHeader))
            {
                writer.WritePropertyName("hasHeader"u8);
                writer.WriteBooleanValue(HasHeader.Value);
            }
            writer.WritePropertyName("errorManagement"u8);
            if (ErrorManagement is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ConnectorMappingErrorManagement>)ErrorManagement).Serialize(writer, options);
            }
            writer.WritePropertyName("format"u8);
            if (Format is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ConnectorMappingFormat>)Format).Serialize(writer, options);
            }
            writer.WritePropertyName("availability"u8);
            if (Availability is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ConnectorMappingAvailability>)Availability).Serialize(writer, options);
            }
            writer.WritePropertyName("structure"u8);
            writer.WriteStartArray();
            foreach (var item in Structure)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ConnectorMappingStructure>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WritePropertyName("completeOperation"u8);
            if (CompleteOperation is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ConnectorMappingCompleteOperation>)CompleteOperation).Serialize(writer, options);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ConnectorMappingProperties DeserializeConnectorMappingProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> folderPath = default;
            Optional<string> fileFilter = default;
            Optional<bool> hasHeader = default;
            ConnectorMappingErrorManagement errorManagement = default;
            ConnectorMappingFormat format = default;
            ConnectorMappingAvailability availability = default;
            IList<ConnectorMappingStructure> structure = default;
            ConnectorMappingCompleteOperation completeOperation = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("folderPath"u8))
                {
                    folderPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileFilter"u8))
                {
                    fileFilter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hasHeader"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasHeader = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errorManagement"u8))
                {
                    errorManagement = ConnectorMappingErrorManagement.DeserializeConnectorMappingErrorManagement(property.Value);
                    continue;
                }
                if (property.NameEquals("format"u8))
                {
                    format = ConnectorMappingFormat.DeserializeConnectorMappingFormat(property.Value);
                    continue;
                }
                if (property.NameEquals("availability"u8))
                {
                    availability = ConnectorMappingAvailability.DeserializeConnectorMappingAvailability(property.Value);
                    continue;
                }
                if (property.NameEquals("structure"u8))
                {
                    List<ConnectorMappingStructure> array = new List<ConnectorMappingStructure>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectorMappingStructure.DeserializeConnectorMappingStructure(item));
                    }
                    structure = array;
                    continue;
                }
                if (property.NameEquals("completeOperation"u8))
                {
                    completeOperation = ConnectorMappingCompleteOperation.DeserializeConnectorMappingCompleteOperation(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectorMappingProperties(folderPath.Value, fileFilter.Value, Optional.ToNullable(hasHeader), errorManagement, format, availability, structure, completeOperation, rawData);
        }

        ConnectorMappingProperties IModelJsonSerializable<ConnectorMappingProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectorMappingProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectorMappingProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectorMappingProperties IModelSerializable<ConnectorMappingProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectorMappingProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectorMappingProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectorMappingProperties"/> to convert. </param>
        public static implicit operator RequestContent(ConnectorMappingProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectorMappingProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectorMappingProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectorMappingProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
