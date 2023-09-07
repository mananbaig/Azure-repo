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

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverResourceDependencyOverride : IUtf8JsonSerializable, IModelJsonSerializable<MoverResourceDependencyOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MoverResourceDependencyOverride>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MoverResourceDependencyOverride>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoverResourceDependencyOverride>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(TargetId))
            {
                writer.WritePropertyName("targetId"u8);
                writer.WriteStringValue(TargetId);
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

        internal static MoverResourceDependencyOverride DeserializeMoverResourceDependencyOverride(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<ResourceIdentifier> targetId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MoverResourceDependencyOverride(id.Value, targetId.Value, serializedAdditionalRawData);
        }

        MoverResourceDependencyOverride IModelJsonSerializable<MoverResourceDependencyOverride>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoverResourceDependencyOverride>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverResourceDependencyOverride(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MoverResourceDependencyOverride>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoverResourceDependencyOverride>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MoverResourceDependencyOverride IModelSerializable<MoverResourceDependencyOverride>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoverResourceDependencyOverride>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMoverResourceDependencyOverride(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MoverResourceDependencyOverride"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MoverResourceDependencyOverride"/> to convert. </param>
        public static implicit operator RequestContent(MoverResourceDependencyOverride model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MoverResourceDependencyOverride"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MoverResourceDependencyOverride(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMoverResourceDependencyOverride(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
