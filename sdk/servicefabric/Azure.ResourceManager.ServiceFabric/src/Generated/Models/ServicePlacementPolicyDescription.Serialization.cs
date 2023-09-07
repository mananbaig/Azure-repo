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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ServicePlacementPolicyDescription : IUtf8JsonSerializable, IModelJsonSerializable<ServicePlacementPolicyDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServicePlacementPolicyDescription>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServicePlacementPolicyDescription>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePlacementPolicyDescription>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PolicyType.ToString());
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

        internal static ServicePlacementPolicyDescription DeserializeServicePlacementPolicyDescription(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ServicePlacementPolicyType type = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ServicePlacementPolicyType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownServicePlacementPolicyDescription(type, serializedAdditionalRawData);
        }

        ServicePlacementPolicyDescription IModelJsonSerializable<ServicePlacementPolicyDescription>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePlacementPolicyDescription>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServicePlacementPolicyDescription(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServicePlacementPolicyDescription>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePlacementPolicyDescription>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServicePlacementPolicyDescription IModelSerializable<ServicePlacementPolicyDescription>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePlacementPolicyDescription>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServicePlacementPolicyDescription(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServicePlacementPolicyDescription"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServicePlacementPolicyDescription"/> to convert. </param>
        public static implicit operator RequestContent(ServicePlacementPolicyDescription model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServicePlacementPolicyDescription"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServicePlacementPolicyDescription(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServicePlacementPolicyDescription(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
