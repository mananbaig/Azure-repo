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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ServiceFabricManagedServicePatch : IUtf8JsonSerializable, IModelJsonSerializable<ServiceFabricManagedServicePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceFabricManagedServicePatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceFabricManagedServicePatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricManagedServicePatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static ServiceFabricManagedServicePatch DeserializeServiceFabricManagedServicePatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceFabricManagedServicePatch(Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        ServiceFabricManagedServicePatch IModelJsonSerializable<ServiceFabricManagedServicePatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricManagedServicePatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricManagedServicePatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceFabricManagedServicePatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricManagedServicePatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceFabricManagedServicePatch IModelSerializable<ServiceFabricManagedServicePatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricManagedServicePatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceFabricManagedServicePatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceFabricManagedServicePatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceFabricManagedServicePatch"/> to convert. </param>
        public static implicit operator RequestContent(ServiceFabricManagedServicePatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceFabricManagedServicePatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceFabricManagedServicePatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceFabricManagedServicePatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
