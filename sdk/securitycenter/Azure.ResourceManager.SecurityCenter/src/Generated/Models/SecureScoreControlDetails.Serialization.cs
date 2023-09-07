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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecureScoreControlDetails : IUtf8JsonSerializable, IModelJsonSerializable<SecureScoreControlDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecureScoreControlDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecureScoreControlDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecureScoreControlDetails>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Definition))
            {
                writer.WritePropertyName("definition"u8);
                if (Definition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecureScoreControlDefinitionItem>)Definition).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("score"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
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

        internal static SecureScoreControlDetails DeserializeSecureScoreControlDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<int> healthyResourceCount = default;
            Optional<int> unhealthyResourceCount = default;
            Optional<int> notApplicableResourceCount = default;
            Optional<long> weight = default;
            Optional<SecureScoreControlDefinitionItem> definition = default;
            Optional<int> max = default;
            Optional<double> current = default;
            Optional<double> percentage = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("healthyResourceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthyResourceCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("unhealthyResourceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unhealthyResourceCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("notApplicableResourceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notApplicableResourceCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("weight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weight = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("definition"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            definition = SecureScoreControlDefinitionItem.DeserializeSecureScoreControlDefinitionItem(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("score"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("max"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    max = property1.Value.GetInt32();
                                    continue;
                                }
                                if (property1.NameEquals("current"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    current = property1.Value.GetDouble();
                                    continue;
                                }
                                if (property1.NameEquals("percentage"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    percentage = property1.Value.GetDouble();
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecureScoreControlDetails(id, name, type, systemData.Value, displayName.Value, Optional.ToNullable(healthyResourceCount), Optional.ToNullable(unhealthyResourceCount), Optional.ToNullable(notApplicableResourceCount), Optional.ToNullable(weight), definition.Value, Optional.ToNullable(max), Optional.ToNullable(current), Optional.ToNullable(percentage), serializedAdditionalRawData);
        }

        SecureScoreControlDetails IModelJsonSerializable<SecureScoreControlDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecureScoreControlDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecureScoreControlDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecureScoreControlDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecureScoreControlDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecureScoreControlDetails IModelSerializable<SecureScoreControlDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecureScoreControlDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecureScoreControlDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecureScoreControlDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecureScoreControlDetails"/> to convert. </param>
        public static implicit operator RequestContent(SecureScoreControlDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecureScoreControlDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecureScoreControlDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecureScoreControlDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
