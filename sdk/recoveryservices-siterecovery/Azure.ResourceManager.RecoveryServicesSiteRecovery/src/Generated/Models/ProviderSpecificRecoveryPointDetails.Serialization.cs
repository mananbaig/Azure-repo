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
    public partial class ProviderSpecificRecoveryPointDetails : IUtf8JsonSerializable, IModelJsonSerializable<ProviderSpecificRecoveryPointDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProviderSpecificRecoveryPointDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProviderSpecificRecoveryPointDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProviderSpecificRecoveryPointDetails>(this, options.Format);

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

        internal static ProviderSpecificRecoveryPointDetails DeserializeProviderSpecificRecoveryPointDetails(JsonElement element, ModelSerializerOptions options = default)
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
                    case "A2A": return A2ARecoveryPointDetails.DeserializeA2ARecoveryPointDetails(element);
                    case "InMageAzureV2": return InMageAzureV2RecoveryPointDetails.DeserializeInMageAzureV2RecoveryPointDetails(element);
                    case "InMageRcm": return InMageRcmRecoveryPointDetails.DeserializeInMageRcmRecoveryPointDetails(element);
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
            return new UnknownProviderSpecificRecoveryPointDetails(instanceType, serializedAdditionalRawData);
        }

        ProviderSpecificRecoveryPointDetails IModelJsonSerializable<ProviderSpecificRecoveryPointDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProviderSpecificRecoveryPointDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderSpecificRecoveryPointDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProviderSpecificRecoveryPointDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProviderSpecificRecoveryPointDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProviderSpecificRecoveryPointDetails IModelSerializable<ProviderSpecificRecoveryPointDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProviderSpecificRecoveryPointDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProviderSpecificRecoveryPointDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProviderSpecificRecoveryPointDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProviderSpecificRecoveryPointDetails"/> to convert. </param>
        public static implicit operator RequestContent(ProviderSpecificRecoveryPointDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProviderSpecificRecoveryPointDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProviderSpecificRecoveryPointDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProviderSpecificRecoveryPointDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
