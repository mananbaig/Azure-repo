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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    internal partial class LinuxProfilePropertiesSsh : IUtf8JsonSerializable, IModelJsonSerializable<LinuxProfilePropertiesSsh>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LinuxProfilePropertiesSsh>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LinuxProfilePropertiesSsh>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PublicKeys))
            {
                writer.WritePropertyName("publicKeys"u8);
                writer.WriteStartArray();
                foreach (var item in PublicKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static LinuxProfilePropertiesSsh DeserializeLinuxProfilePropertiesSsh(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<LinuxProfilePropertiesSshPublicKeysItem>> publicKeys = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinuxProfilePropertiesSshPublicKeysItem> array = new List<LinuxProfilePropertiesSshPublicKeysItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinuxProfilePropertiesSshPublicKeysItem.DeserializeLinuxProfilePropertiesSshPublicKeysItem(item));
                    }
                    publicKeys = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LinuxProfilePropertiesSsh(Optional.ToList(publicKeys), rawData);
        }

        LinuxProfilePropertiesSsh IModelJsonSerializable<LinuxProfilePropertiesSsh>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLinuxProfilePropertiesSsh(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LinuxProfilePropertiesSsh>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LinuxProfilePropertiesSsh IModelSerializable<LinuxProfilePropertiesSsh>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLinuxProfilePropertiesSsh(doc.RootElement, options);
        }

        public static implicit operator RequestContent(LinuxProfilePropertiesSsh model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator LinuxProfilePropertiesSsh(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLinuxProfilePropertiesSsh(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
