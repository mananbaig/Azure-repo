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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ResourcesMoveContent : IUtf8JsonSerializable, IModelJsonSerializable<ResourcesMoveContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourcesMoveContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourcesMoveContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourcesMoveContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetResourceGroupId))
            {
                writer.WritePropertyName("targetResourceGroup"u8);
                writer.WriteStringValue(TargetResourceGroupId);
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

        internal static ResourcesMoveContent DeserializeResourcesMoveContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> resources = default;
            Optional<ResourceIdentifier> targetResourceGroup = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("targetResourceGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResourceGroup = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourcesMoveContent(Optional.ToList(resources), targetResourceGroup.Value, serializedAdditionalRawData);
        }

        ResourcesMoveContent IModelJsonSerializable<ResourcesMoveContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourcesMoveContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourcesMoveContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourcesMoveContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourcesMoveContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourcesMoveContent IModelSerializable<ResourcesMoveContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourcesMoveContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourcesMoveContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourcesMoveContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourcesMoveContent"/> to convert. </param>
        public static implicit operator RequestContent(ResourcesMoveContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourcesMoveContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourcesMoveContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourcesMoveContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
