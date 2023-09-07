// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class UnknownApplianceSpecificDetails : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryApplianceSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryApplianceSpecificDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryApplianceSpecificDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryApplianceSpecificDetails>(this, options.Format);

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

        internal static SiteRecoveryApplianceSpecificDetails DeserializeUnknownApplianceSpecificDetails(JsonElement element, ModelSerializerOptions options = default) => DeserializeSiteRecoveryApplianceSpecificDetails(element, options);

        SiteRecoveryApplianceSpecificDetails IModelJsonSerializable<SiteRecoveryApplianceSpecificDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryApplianceSpecificDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownApplianceSpecificDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryApplianceSpecificDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryApplianceSpecificDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryApplianceSpecificDetails IModelSerializable<SiteRecoveryApplianceSpecificDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryApplianceSpecificDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryApplianceSpecificDetails(doc.RootElement, options);
        }
    }
}
