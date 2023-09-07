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
using Azure.ResourceManager.DigitalTwins.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DigitalTwins
{
    public partial class DigitalTwinsEndpointResourceData : IUtf8JsonSerializable, IModelJsonSerializable<DigitalTwinsEndpointResourceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DigitalTwinsEndpointResourceData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DigitalTwinsEndpointResourceData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsEndpointResourceData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            if (Properties is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DigitalTwinsEndpointResourceProperties>)Properties).Serialize(writer, options);
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

        internal static DigitalTwinsEndpointResourceData DeserializeDigitalTwinsEndpointResourceData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DigitalTwinsEndpointResourceProperties properties = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = DigitalTwinsEndpointResourceProperties.DeserializeDigitalTwinsEndpointResourceProperties(property.Value);
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
            return new DigitalTwinsEndpointResourceData(id, name, type, systemData.Value, properties, serializedAdditionalRawData);
        }

        DigitalTwinsEndpointResourceData IModelJsonSerializable<DigitalTwinsEndpointResourceData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsEndpointResourceData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsEndpointResourceData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DigitalTwinsEndpointResourceData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsEndpointResourceData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DigitalTwinsEndpointResourceData IModelSerializable<DigitalTwinsEndpointResourceData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DigitalTwinsEndpointResourceData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDigitalTwinsEndpointResourceData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DigitalTwinsEndpointResourceData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DigitalTwinsEndpointResourceData"/> to convert. </param>
        public static implicit operator RequestContent(DigitalTwinsEndpointResourceData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DigitalTwinsEndpointResourceData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DigitalTwinsEndpointResourceData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDigitalTwinsEndpointResourceData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
