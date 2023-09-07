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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class PauseReplicationProperties : IUtf8JsonSerializable, IModelJsonSerializable<PauseReplicationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PauseReplicationProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PauseReplicationProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PauseReplicationProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static PauseReplicationProperties DeserializePauseReplicationProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PauseReplicationProperties(instanceType, serializedAdditionalRawData);
        }

        PauseReplicationProperties IModelJsonSerializable<PauseReplicationProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PauseReplicationProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePauseReplicationProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PauseReplicationProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PauseReplicationProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PauseReplicationProperties IModelSerializable<PauseReplicationProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PauseReplicationProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePauseReplicationProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PauseReplicationProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PauseReplicationProperties"/> to convert. </param>
        public static implicit operator RequestContent(PauseReplicationProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PauseReplicationProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PauseReplicationProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePauseReplicationProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
