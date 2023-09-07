// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class UnknownSingleServerCustomResourceNames : IUtf8JsonSerializable, IModelJsonSerializable<SingleServerCustomResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SingleServerCustomResourceNames>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SingleServerCustomResourceNames>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SingleServerCustomResourceNames>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("namingPatternType"u8);
            writer.WriteStringValue(NamingPatternType.ToString());
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

        internal static SingleServerCustomResourceNames DeserializeUnknownSingleServerCustomResourceNames(JsonElement element, ModelSerializerOptions options = default) => DeserializeSingleServerCustomResourceNames(element, options);

        SingleServerCustomResourceNames IModelJsonSerializable<SingleServerCustomResourceNames>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SingleServerCustomResourceNames>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownSingleServerCustomResourceNames(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SingleServerCustomResourceNames>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SingleServerCustomResourceNames>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SingleServerCustomResourceNames IModelSerializable<SingleServerCustomResourceNames>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SingleServerCustomResourceNames>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSingleServerCustomResourceNames(doc.RootElement, options);
        }
    }
}
