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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsAlertRuleEntityMapping : IUtf8JsonSerializable, IModelJsonSerializable<SecurityInsightsAlertRuleEntityMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityInsightsAlertRuleEntityMapping>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityInsightsAlertRuleEntityMapping>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAlertRuleEntityMapping>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EntityType))
            {
                writer.WritePropertyName("entityType"u8);
                writer.WriteStringValue(EntityType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FieldMappings))
            {
                writer.WritePropertyName("fieldMappings"u8);
                writer.WriteStartArray();
                foreach (var item in FieldMappings)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SecurityInsightsFieldMapping>)item).Serialize(writer, options);
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

        internal static SecurityInsightsAlertRuleEntityMapping DeserializeSecurityInsightsAlertRuleEntityMapping(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SecurityInsightsAlertRuleEntityMappingType> entityType = default;
            Optional<IList<SecurityInsightsFieldMapping>> fieldMappings = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    entityType = new SecurityInsightsAlertRuleEntityMappingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fieldMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsFieldMapping> array = new List<SecurityInsightsFieldMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsFieldMapping.DeserializeSecurityInsightsFieldMapping(item));
                    }
                    fieldMappings = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityInsightsAlertRuleEntityMapping(Optional.ToNullable(entityType), Optional.ToList(fieldMappings), serializedAdditionalRawData);
        }

        SecurityInsightsAlertRuleEntityMapping IModelJsonSerializable<SecurityInsightsAlertRuleEntityMapping>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAlertRuleEntityMapping>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAlertRuleEntityMapping(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityInsightsAlertRuleEntityMapping>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAlertRuleEntityMapping>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityInsightsAlertRuleEntityMapping IModelSerializable<SecurityInsightsAlertRuleEntityMapping>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsAlertRuleEntityMapping>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsAlertRuleEntityMapping(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecurityInsightsAlertRuleEntityMapping"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecurityInsightsAlertRuleEntityMapping"/> to convert. </param>
        public static implicit operator RequestContent(SecurityInsightsAlertRuleEntityMapping model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecurityInsightsAlertRuleEntityMapping"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecurityInsightsAlertRuleEntityMapping(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityInsightsAlertRuleEntityMapping(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
