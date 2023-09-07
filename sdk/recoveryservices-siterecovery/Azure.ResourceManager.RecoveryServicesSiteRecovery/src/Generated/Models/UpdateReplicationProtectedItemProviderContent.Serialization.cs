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
    public partial class UpdateReplicationProtectedItemProviderContent : IUtf8JsonSerializable, IModelJsonSerializable<UpdateReplicationProtectedItemProviderContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UpdateReplicationProtectedItemProviderContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UpdateReplicationProtectedItemProviderContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateReplicationProtectedItemProviderContent>(this, options.Format);

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

        internal static UpdateReplicationProtectedItemProviderContent DeserializeUpdateReplicationProtectedItemProviderContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2AUpdateReplicationProtectedItemContent.DeserializeA2AUpdateReplicationProtectedItemContent(element);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureUpdateReplicationProtectedItemContent.DeserializeHyperVReplicaAzureUpdateReplicationProtectedItemContent(element);
                    case "InMageAzureV2": return InMageAzureV2UpdateReplicationProtectedItemContent.DeserializeInMageAzureV2UpdateReplicationProtectedItemContent(element);
                    case "InMageRcm": return InMageRcmUpdateReplicationProtectedItemContent.DeserializeInMageRcmUpdateReplicationProtectedItemContent(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
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
            return new Models.UpdateReplicationProtectedItemProviderContent(instanceType, serializedAdditionalRawData);
        }

        UpdateReplicationProtectedItemProviderContent IModelJsonSerializable<UpdateReplicationProtectedItemProviderContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateReplicationProtectedItemProviderContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateReplicationProtectedItemProviderContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UpdateReplicationProtectedItemProviderContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateReplicationProtectedItemProviderContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UpdateReplicationProtectedItemProviderContent IModelSerializable<UpdateReplicationProtectedItemProviderContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateReplicationProtectedItemProviderContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUpdateReplicationProtectedItemProviderContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UpdateReplicationProtectedItemProviderContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UpdateReplicationProtectedItemProviderContent"/> to convert. </param>
        public static implicit operator RequestContent(UpdateReplicationProtectedItemProviderContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UpdateReplicationProtectedItemProviderContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UpdateReplicationProtectedItemProviderContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUpdateReplicationProtectedItemProviderContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
