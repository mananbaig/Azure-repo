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
    public partial class LinuxProfilePropertiesSshPublicKeysItem : IUtf8JsonSerializable, IModelJsonSerializable<LinuxProfilePropertiesSshPublicKeysItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LinuxProfilePropertiesSshPublicKeysItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LinuxProfilePropertiesSshPublicKeysItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyData))
            {
                writer.WritePropertyName("keyData"u8);
                writer.WriteStringValue(KeyData);
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

        internal static LinuxProfilePropertiesSshPublicKeysItem DeserializeLinuxProfilePropertiesSshPublicKeysItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> keyData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyData"u8))
                {
                    keyData = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LinuxProfilePropertiesSshPublicKeysItem(keyData.Value, rawData);
        }

        LinuxProfilePropertiesSshPublicKeysItem IModelJsonSerializable<LinuxProfilePropertiesSshPublicKeysItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLinuxProfilePropertiesSshPublicKeysItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LinuxProfilePropertiesSshPublicKeysItem>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LinuxProfilePropertiesSshPublicKeysItem IModelSerializable<LinuxProfilePropertiesSshPublicKeysItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLinuxProfilePropertiesSshPublicKeysItem(doc.RootElement, options);
        }

        public static implicit operator RequestContent(LinuxProfilePropertiesSshPublicKeysItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator LinuxProfilePropertiesSshPublicKeysItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLinuxProfilePropertiesSshPublicKeysItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
