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

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeReestablishReplicationContent : IUtf8JsonSerializable, IModelJsonSerializable<NetAppVolumeReestablishReplicationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetAppVolumeReestablishReplicationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetAppVolumeReestablishReplicationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceVolumeId))
            {
                writer.WritePropertyName("sourceVolumeId"u8);
                writer.WriteStringValue(SourceVolumeId);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static NetAppVolumeReestablishReplicationContent DeserializeNetAppVolumeReestablishReplicationContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> sourceVolumeId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVolumeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVolumeId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetAppVolumeReestablishReplicationContent(sourceVolumeId.Value, rawData);
        }

        NetAppVolumeReestablishReplicationContent IModelJsonSerializable<NetAppVolumeReestablishReplicationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeReestablishReplicationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetAppVolumeReestablishReplicationContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetAppVolumeReestablishReplicationContent IModelSerializable<NetAppVolumeReestablishReplicationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetAppVolumeReestablishReplicationContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetAppVolumeReestablishReplicationContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetAppVolumeReestablishReplicationContent"/> to convert. </param>
        public static implicit operator RequestContent(NetAppVolumeReestablishReplicationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetAppVolumeReestablishReplicationContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetAppVolumeReestablishReplicationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetAppVolumeReestablishReplicationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
