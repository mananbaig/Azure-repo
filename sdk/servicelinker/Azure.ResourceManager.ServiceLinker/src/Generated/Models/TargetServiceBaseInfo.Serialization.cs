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

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class TargetServiceBaseInfo : IUtf8JsonSerializable, IModelJsonSerializable<TargetServiceBaseInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TargetServiceBaseInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TargetServiceBaseInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetServiceBaseInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TargetServiceType.ToString());
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

        internal static TargetServiceBaseInfo DeserializeTargetServiceBaseInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureResource": return AzureResourceInfo.DeserializeAzureResourceInfo(element);
                    case "ConfluentBootstrapServer": return ConfluentBootstrapServerInfo.DeserializeConfluentBootstrapServerInfo(element);
                    case "ConfluentSchemaRegistry": return ConfluentSchemaRegistryInfo.DeserializeConfluentSchemaRegistryInfo(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            TargetServiceType type = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new TargetServiceType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownTargetServiceBase(type, serializedAdditionalRawData);
        }

        TargetServiceBaseInfo IModelJsonSerializable<TargetServiceBaseInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetServiceBaseInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTargetServiceBaseInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TargetServiceBaseInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetServiceBaseInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TargetServiceBaseInfo IModelSerializable<TargetServiceBaseInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetServiceBaseInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTargetServiceBaseInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TargetServiceBaseInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TargetServiceBaseInfo"/> to convert. </param>
        public static implicit operator RequestContent(TargetServiceBaseInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TargetServiceBaseInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TargetServiceBaseInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTargetServiceBaseInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
