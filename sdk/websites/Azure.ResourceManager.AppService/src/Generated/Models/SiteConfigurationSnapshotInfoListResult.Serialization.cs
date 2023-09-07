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
    internal partial class SiteConfigurationSnapshotInfoListResult : IUtf8JsonSerializable, IModelJsonSerializable<SiteConfigurationSnapshotInfoListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteConfigurationSnapshotInfoListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteConfigurationSnapshotInfoListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteConfigurationSnapshotInfoListResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SiteConfigurationSnapshotInfo>)item).Serialize(writer, options);
                }
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

        internal static SiteConfigurationSnapshotInfoListResult DeserializeSiteConfigurationSnapshotInfoListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SiteConfigurationSnapshotInfo> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SiteConfigurationSnapshotInfo> array = new List<SiteConfigurationSnapshotInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteConfigurationSnapshotInfo.DeserializeSiteConfigurationSnapshotInfo(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteConfigurationSnapshotInfoListResult(value, nextLink.Value, serializedAdditionalRawData);
        }

        SiteConfigurationSnapshotInfoListResult IModelJsonSerializable<SiteConfigurationSnapshotInfoListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteConfigurationSnapshotInfoListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteConfigurationSnapshotInfoListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteConfigurationSnapshotInfoListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteConfigurationSnapshotInfoListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteConfigurationSnapshotInfoListResult IModelSerializable<SiteConfigurationSnapshotInfoListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteConfigurationSnapshotInfoListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteConfigurationSnapshotInfoListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteConfigurationSnapshotInfoListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteConfigurationSnapshotInfoListResult"/> to convert. </param>
        public static implicit operator RequestContent(SiteConfigurationSnapshotInfoListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteConfigurationSnapshotInfoListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteConfigurationSnapshotInfoListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteConfigurationSnapshotInfoListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
