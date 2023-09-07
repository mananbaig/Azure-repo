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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseDataSourceCapacity : IUtf8JsonSerializable, IModelJsonSerializable<SynapseDataSourceCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseDataSourceCapacity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseDataSourceCapacity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseDataSourceCapacity>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("scaleType"u8);
            writer.WriteStringValue(ScaleType.ToString());
            writer.WritePropertyName("minimum"u8);
            writer.WriteNumberValue(Minimum);
            writer.WritePropertyName("maximum"u8);
            writer.WriteNumberValue(Maximum);
            writer.WritePropertyName("default"u8);
            writer.WriteNumberValue(Default);
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

        internal static SynapseDataSourceCapacity DeserializeSynapseDataSourceCapacity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SynapseDataSourceScaleType scaleType = default;
            int minimum = default;
            int maximum = default;
            int @default = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scaleType"u8))
                {
                    scaleType = new SynapseDataSourceScaleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimum"u8))
                {
                    minimum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    maximum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    @default = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseDataSourceCapacity(scaleType, minimum, maximum, @default, serializedAdditionalRawData);
        }

        SynapseDataSourceCapacity IModelJsonSerializable<SynapseDataSourceCapacity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseDataSourceCapacity>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseDataSourceCapacity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseDataSourceCapacity>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseDataSourceCapacity>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseDataSourceCapacity IModelSerializable<SynapseDataSourceCapacity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseDataSourceCapacity>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseDataSourceCapacity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseDataSourceCapacity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseDataSourceCapacity"/> to convert. </param>
        public static implicit operator RequestContent(SynapseDataSourceCapacity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseDataSourceCapacity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseDataSourceCapacity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseDataSourceCapacity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
