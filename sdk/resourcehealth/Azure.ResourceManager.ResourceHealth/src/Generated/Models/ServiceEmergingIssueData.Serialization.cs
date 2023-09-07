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
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth
{
    public partial class ServiceEmergingIssueData : IUtf8JsonSerializable, IModelJsonSerializable<ServiceEmergingIssueData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceEmergingIssueData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceEmergingIssueData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceEmergingIssueData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RefreshedOn))
            {
                writer.WritePropertyName("refreshTimestamp"u8);
                writer.WriteStringValue(RefreshedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(StatusBanners))
            {
                writer.WritePropertyName("statusBanners"u8);
                writer.WriteStartArray();
                foreach (var item in StatusBanners)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<EmergingIssueBannerType>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StatusActiveEvents))
            {
                writer.WritePropertyName("statusActiveEvents"u8);
                writer.WriteStartArray();
                foreach (var item in StatusActiveEvents)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<EmergingIssueActiveEventType>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
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

        internal static ServiceEmergingIssueData DeserializeServiceEmergingIssueData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<DateTimeOffset> refreshTimestamp = default;
            Optional<IReadOnlyList<EmergingIssueBannerType>> statusBanners = default;
            Optional<IReadOnlyList<EmergingIssueActiveEventType>> statusActiveEvents = default;
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
                        if (property0.NameEquals("refreshTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            refreshTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("statusBanners"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EmergingIssueBannerType> array = new List<EmergingIssueBannerType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EmergingIssueBannerType.DeserializeEmergingIssueBannerType(item));
                            }
                            statusBanners = array;
                            continue;
                        }
                        if (property0.NameEquals("statusActiveEvents"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EmergingIssueActiveEventType> array = new List<EmergingIssueActiveEventType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EmergingIssueActiveEventType.DeserializeEmergingIssueActiveEventType(item));
                            }
                            statusActiveEvents = array;
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
            return new ServiceEmergingIssueData(id, name, type, systemData.Value, Optional.ToNullable(refreshTimestamp), Optional.ToList(statusBanners), Optional.ToList(statusActiveEvents), serializedAdditionalRawData);
        }

        ServiceEmergingIssueData IModelJsonSerializable<ServiceEmergingIssueData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceEmergingIssueData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceEmergingIssueData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceEmergingIssueData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceEmergingIssueData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceEmergingIssueData IModelSerializable<ServiceEmergingIssueData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceEmergingIssueData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceEmergingIssueData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceEmergingIssueData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceEmergingIssueData"/> to convert. </param>
        public static implicit operator RequestContent(ServiceEmergingIssueData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceEmergingIssueData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceEmergingIssueData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceEmergingIssueData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
