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
    internal partial class SynapseKustoPoolPrivateLinkList : IUtf8JsonSerializable, IModelJsonSerializable<SynapseKustoPoolPrivateLinkList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseKustoPoolPrivateLinkList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseKustoPoolPrivateLinkList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseKustoPoolPrivateLinkList>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
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
                        ((IModelJsonSerializable<SynapseKustoPoolPrivateLinkData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static SynapseKustoPoolPrivateLinkList DeserializeSynapseKustoPoolPrivateLinkList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SynapseKustoPoolPrivateLinkData>> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseKustoPoolPrivateLinkData> array = new List<SynapseKustoPoolPrivateLinkData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseKustoPoolPrivateLinkData.DeserializeSynapseKustoPoolPrivateLinkData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseKustoPoolPrivateLinkList(Optional.ToList(value), serializedAdditionalRawData);
        }

        SynapseKustoPoolPrivateLinkList IModelJsonSerializable<SynapseKustoPoolPrivateLinkList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseKustoPoolPrivateLinkList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseKustoPoolPrivateLinkList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseKustoPoolPrivateLinkList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseKustoPoolPrivateLinkList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseKustoPoolPrivateLinkList IModelSerializable<SynapseKustoPoolPrivateLinkList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseKustoPoolPrivateLinkList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseKustoPoolPrivateLinkList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseKustoPoolPrivateLinkList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseKustoPoolPrivateLinkList"/> to convert. </param>
        public static implicit operator RequestContent(SynapseKustoPoolPrivateLinkList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseKustoPoolPrivateLinkList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseKustoPoolPrivateLinkList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseKustoPoolPrivateLinkList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
