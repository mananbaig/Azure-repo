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

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class FrontDoorExperimentEndpointProperties : IUtf8JsonSerializable, IModelJsonSerializable<FrontDoorExperimentEndpointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FrontDoorExperimentEndpointProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FrontDoorExperimentEndpointProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorExperimentEndpointProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
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

        internal static FrontDoorExperimentEndpointProperties DeserializeFrontDoorExperimentEndpointProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> endpoint = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FrontDoorExperimentEndpointProperties(name.Value, endpoint.Value, serializedAdditionalRawData);
        }

        FrontDoorExperimentEndpointProperties IModelJsonSerializable<FrontDoorExperimentEndpointProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorExperimentEndpointProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorExperimentEndpointProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FrontDoorExperimentEndpointProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorExperimentEndpointProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FrontDoorExperimentEndpointProperties IModelSerializable<FrontDoorExperimentEndpointProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FrontDoorExperimentEndpointProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFrontDoorExperimentEndpointProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FrontDoorExperimentEndpointProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FrontDoorExperimentEndpointProperties"/> to convert. </param>
        public static implicit operator RequestContent(FrontDoorExperimentEndpointProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FrontDoorExperimentEndpointProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FrontDoorExperimentEndpointProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFrontDoorExperimentEndpointProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
