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
    public partial class RecoveryProximityPlacementGroupCustomDetails : IUtf8JsonSerializable, IModelJsonSerializable<RecoveryProximityPlacementGroupCustomDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecoveryProximityPlacementGroupCustomDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecoveryProximityPlacementGroupCustomDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryProximityPlacementGroupCustomDetails>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
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

        internal static RecoveryProximityPlacementGroupCustomDetails DeserializeRecoveryProximityPlacementGroupCustomDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Existing": return ExistingRecoveryProximityPlacementGroup.DeserializeExistingRecoveryProximityPlacementGroup(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string resourceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownRecoveryProximityPlacementGroupCustomDetails(resourceType, serializedAdditionalRawData);
        }

        RecoveryProximityPlacementGroupCustomDetails IModelJsonSerializable<RecoveryProximityPlacementGroupCustomDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryProximityPlacementGroupCustomDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryProximityPlacementGroupCustomDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecoveryProximityPlacementGroupCustomDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryProximityPlacementGroupCustomDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecoveryProximityPlacementGroupCustomDetails IModelSerializable<RecoveryProximityPlacementGroupCustomDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryProximityPlacementGroupCustomDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecoveryProximityPlacementGroupCustomDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RecoveryProximityPlacementGroupCustomDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RecoveryProximityPlacementGroupCustomDetails"/> to convert. </param>
        public static implicit operator RequestContent(RecoveryProximityPlacementGroupCustomDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RecoveryProximityPlacementGroupCustomDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RecoveryProximityPlacementGroupCustomDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecoveryProximityPlacementGroupCustomDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
