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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class VirtualDirectory : IUtf8JsonSerializable, IModelJsonSerializable<VirtualDirectory>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualDirectory>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualDirectory>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualDirectory>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualPath))
            {
                writer.WritePropertyName("virtualPath"u8);
                writer.WriteStringValue(VirtualPath);
            }
            if (Optional.IsDefined(PhysicalPath))
            {
                writer.WritePropertyName("physicalPath"u8);
                writer.WriteStringValue(PhysicalPath);
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

        internal static VirtualDirectory DeserializeVirtualDirectory(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> virtualPath = default;
            Optional<string> physicalPath = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualPath"u8))
                {
                    virtualPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalPath"u8))
                {
                    physicalPath = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualDirectory(virtualPath.Value, physicalPath.Value, serializedAdditionalRawData);
        }

        VirtualDirectory IModelJsonSerializable<VirtualDirectory>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualDirectory>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualDirectory(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualDirectory>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualDirectory>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualDirectory IModelSerializable<VirtualDirectory>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualDirectory>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualDirectory(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualDirectory"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualDirectory"/> to convert. </param>
        public static implicit operator RequestContent(VirtualDirectory model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualDirectory"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualDirectory(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualDirectory(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
