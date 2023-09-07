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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ConnectionStringDictionary : IUtf8JsonSerializable, IModelJsonSerializable<ConnectionStringDictionary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectionStringDictionary>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectionStringDictionary>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionStringDictionary>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ConnStringValueTypePair>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static ConnectionStringDictionary DeserializeConnectionStringDictionary(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, ConnStringValueTypePair>> properties = default;
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ConnStringValueTypePair> dictionary = new Dictionary<string, ConnStringValueTypePair>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ConnStringValueTypePair.DeserializeConnStringValueTypePair(property0.Value));
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectionStringDictionary(id, name, type, systemData.Value, Optional.ToDictionary(properties), kind.Value, serializedAdditionalRawData);
        }

        ConnectionStringDictionary IModelJsonSerializable<ConnectionStringDictionary>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionStringDictionary>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionStringDictionary(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectionStringDictionary>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionStringDictionary>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectionStringDictionary IModelSerializable<ConnectionStringDictionary>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionStringDictionary>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectionStringDictionary(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectionStringDictionary"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectionStringDictionary"/> to convert. </param>
        public static implicit operator RequestContent(ConnectionStringDictionary model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectionStringDictionary"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectionStringDictionary(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectionStringDictionary(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
