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
    public partial class ManagedServicePartitionScheme : IUtf8JsonSerializable, IModelJsonSerializable<ManagedServicePartitionScheme>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedServicePartitionScheme>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedServicePartitionScheme>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicePartitionScheme>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
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

        internal static ManagedServicePartitionScheme DeserializeManagedServicePartitionScheme(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("partitionScheme", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Named": return NamedPartitionScheme.DeserializeNamedPartitionScheme(element);
                    case "Singleton": return SingletonPartitionScheme.DeserializeSingletonPartitionScheme(element);
                    case "UniformInt64Range": return UniformInt64RangePartitionScheme.DeserializeUniformInt64RangePartitionScheme(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            PartitionScheme partitionScheme = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionScheme"u8))
                {
                    partitionScheme = new PartitionScheme(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownPartition(partitionScheme, serializedAdditionalRawData);
        }

        ManagedServicePartitionScheme IModelJsonSerializable<ManagedServicePartitionScheme>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicePartitionScheme>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicePartitionScheme(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedServicePartitionScheme>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicePartitionScheme>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedServicePartitionScheme IModelSerializable<ManagedServicePartitionScheme>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicePartitionScheme>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedServicePartitionScheme(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedServicePartitionScheme"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedServicePartitionScheme"/> to convert. </param>
        public static implicit operator RequestContent(ManagedServicePartitionScheme model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedServicePartitionScheme"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedServicePartitionScheme(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedServicePartitionScheme(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
