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

namespace Azure.ResourceManager.StoragePool.Models
{
    public partial class DiskPoolIscsiTargetPortalGroupAcl : IUtf8JsonSerializable, IModelJsonSerializable<DiskPoolIscsiTargetPortalGroupAcl>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DiskPoolIscsiTargetPortalGroupAcl>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DiskPoolIscsiTargetPortalGroupAcl>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiskPoolIscsiTargetPortalGroupAcl>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("initiatorIqn"u8);
            writer.WriteStringValue(InitiatorIqn);
            writer.WritePropertyName("mappedLuns"u8);
            writer.WriteStartArray();
            foreach (var item in MappedLuns)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        internal static DiskPoolIscsiTargetPortalGroupAcl DeserializeDiskPoolIscsiTargetPortalGroupAcl(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string initiatorIqn = default;
            IList<string> mappedLuns = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initiatorIqn"u8))
                {
                    initiatorIqn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mappedLuns"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    mappedLuns = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DiskPoolIscsiTargetPortalGroupAcl(initiatorIqn, mappedLuns, serializedAdditionalRawData);
        }

        DiskPoolIscsiTargetPortalGroupAcl IModelJsonSerializable<DiskPoolIscsiTargetPortalGroupAcl>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiskPoolIscsiTargetPortalGroupAcl>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskPoolIscsiTargetPortalGroupAcl(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DiskPoolIscsiTargetPortalGroupAcl>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiskPoolIscsiTargetPortalGroupAcl>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DiskPoolIscsiTargetPortalGroupAcl IModelSerializable<DiskPoolIscsiTargetPortalGroupAcl>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DiskPoolIscsiTargetPortalGroupAcl>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDiskPoolIscsiTargetPortalGroupAcl(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DiskPoolIscsiTargetPortalGroupAcl"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DiskPoolIscsiTargetPortalGroupAcl"/> to convert. </param>
        public static implicit operator RequestContent(DiskPoolIscsiTargetPortalGroupAcl model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DiskPoolIscsiTargetPortalGroupAcl"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DiskPoolIscsiTargetPortalGroupAcl(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDiskPoolIscsiTargetPortalGroupAcl(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
