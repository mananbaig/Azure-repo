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
    public partial class SiteRecoveryEventProperties : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryEventProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryEventProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryEventProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryEventProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EventCode))
            {
                writer.WritePropertyName("eventCode"u8);
                writer.WriteStringValue(EventCode);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteStringValue(EventType);
            }
            if (Optional.IsDefined(AffectedObjectFriendlyName))
            {
                writer.WritePropertyName("affectedObjectFriendlyName"u8);
                writer.WriteStringValue(AffectedObjectFriendlyName);
            }
            if (Optional.IsDefined(AffectedObjectCorrelationId))
            {
                writer.WritePropertyName("affectedObjectCorrelationId"u8);
                writer.WriteStringValue(AffectedObjectCorrelationId);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity);
            }
            if (Optional.IsDefined(OccurredOn))
            {
                writer.WritePropertyName("timeOfOccurrence"u8);
                writer.WriteStringValue(OccurredOn.Value, "O");
            }
            if (Optional.IsDefined(FabricId))
            {
                writer.WritePropertyName("fabricId"u8);
                writer.WriteStringValue(FabricId);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                if (ProviderSpecificDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SiteRecoveryEventProviderSpecificDetails>)ProviderSpecificDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(EventSpecificDetails))
            {
                writer.WritePropertyName("eventSpecificDetails"u8);
                if (EventSpecificDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SiteRecoveryEventSpecificDetails>)EventSpecificDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SiteRecoveryHealthError>)item).Serialize(writer, options);
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

        internal static SiteRecoveryEventProperties DeserializeSiteRecoveryEventProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> eventCode = default;
            Optional<string> description = default;
            Optional<string> eventType = default;
            Optional<string> affectedObjectFriendlyName = default;
            Optional<string> affectedObjectCorrelationId = default;
            Optional<string> severity = default;
            Optional<DateTimeOffset> timeOfOccurrence = default;
            Optional<ResourceIdentifier> fabricId = default;
            Optional<SiteRecoveryEventProviderSpecificDetails> providerSpecificDetails = default;
            Optional<SiteRecoveryEventSpecificDetails> eventSpecificDetails = default;
            Optional<IReadOnlyList<SiteRecoveryHealthError>> healthErrors = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventCode"u8))
                {
                    eventCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventType"u8))
                {
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectFriendlyName"u8))
                {
                    affectedObjectFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectCorrelationId"u8))
                {
                    affectedObjectCorrelationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeOfOccurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeOfOccurrence = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fabricId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = SiteRecoveryEventProviderSpecificDetails.DeserializeSiteRecoveryEventProviderSpecificDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("eventSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventSpecificDetails = SiteRecoveryEventSpecificDetails.DeserializeSiteRecoveryEventSpecificDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item));
                    }
                    healthErrors = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryEventProperties(eventCode.Value, description.Value, eventType.Value, affectedObjectFriendlyName.Value, affectedObjectCorrelationId.Value, severity.Value, Optional.ToNullable(timeOfOccurrence), fabricId.Value, providerSpecificDetails.Value, eventSpecificDetails.Value, Optional.ToList(healthErrors), serializedAdditionalRawData);
        }

        SiteRecoveryEventProperties IModelJsonSerializable<SiteRecoveryEventProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryEventProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryEventProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryEventProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryEventProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryEventProperties IModelSerializable<SiteRecoveryEventProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryEventProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryEventProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryEventProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryEventProperties"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryEventProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryEventProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryEventProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryEventProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
