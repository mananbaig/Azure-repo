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
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsIncidentData : IUtf8JsonSerializable, IModelJsonSerializable<SecurityInsightsIncidentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityInsightsIncidentData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityInsightsIncidentData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsIncidentData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Classification))
            {
                writer.WritePropertyName("classification"u8);
                writer.WriteStringValue(Classification.Value.ToString());
            }
            if (Optional.IsDefined(ClassificationComment))
            {
                writer.WritePropertyName("classificationComment"u8);
                writer.WriteStringValue(ClassificationComment);
            }
            if (Optional.IsDefined(ClassificationReason))
            {
                writer.WritePropertyName("classificationReason"u8);
                writer.WriteStringValue(ClassificationReason.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(FirstActivityOn))
            {
                writer.WritePropertyName("firstActivityTimeUtc"u8);
                writer.WriteStringValue(FirstActivityOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SecurityInsightsIncidentLabel>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LastActivityOn))
            {
                writer.WritePropertyName("lastActivityTimeUtc"u8);
                writer.WriteStringValue(LastActivityOn.Value, "O");
            }
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner"u8);
                if (Owner is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SecurityInsightsIncidentOwnerInfo>)Owner).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
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

        internal static SecurityInsightsIncidentData DeserializeSecurityInsightsIncidentData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SecurityInsightsIncidentAdditionalInfo> additionalData = default;
            Optional<SecurityInsightsIncidentClassification> classification = default;
            Optional<string> classificationComment = default;
            Optional<SecurityInsightsIncidentClassificationReason> classificationReason = default;
            Optional<DateTimeOffset> createdTimeUtc = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> firstActivityTimeUtc = default;
            Optional<Uri> incidentUrl = default;
            Optional<int> incidentNumber = default;
            Optional<IList<SecurityInsightsIncidentLabel>> labels = default;
            Optional<DateTimeOffset> lastActivityTimeUtc = default;
            Optional<DateTimeOffset> lastModifiedTimeUtc = default;
            Optional<SecurityInsightsIncidentOwnerInfo> owner = default;
            Optional<IReadOnlyList<ResourceIdentifier>> relatedAnalyticRuleIds = default;
            Optional<SecurityInsightsIncidentSeverity> severity = default;
            Optional<SecurityInsightsIncidentStatus> status = default;
            Optional<string> title = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            additionalData = SecurityInsightsIncidentAdditionalInfo.DeserializeSecurityInsightsIncidentAdditionalInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("classification"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            classification = new SecurityInsightsIncidentClassification(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("classificationComment"u8))
                        {
                            classificationComment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("classificationReason"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            classificationReason = new SecurityInsightsIncidentClassificationReason(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createdTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("firstActivityTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firstActivityTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("incidentUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            incidentUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("incidentNumber"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            incidentNumber = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("labels"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsIncidentLabel> array = new List<SecurityInsightsIncidentLabel>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityInsightsIncidentLabel.DeserializeSecurityInsightsIncidentLabel(item));
                            }
                            labels = array;
                            continue;
                        }
                        if (property0.NameEquals("lastActivityTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastActivityTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("owner"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            owner = SecurityInsightsIncidentOwnerInfo.DeserializeSecurityInsightsIncidentOwnerInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("relatedAnalyticRuleIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            relatedAnalyticRuleIds = array;
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new SecurityInsightsIncidentSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SecurityInsightsIncidentStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("title"u8))
                        {
                            title = property0.Value.GetString();
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
            return new SecurityInsightsIncidentData(id, name, type, systemData.Value, additionalData.Value, Optional.ToNullable(classification), classificationComment.Value, Optional.ToNullable(classificationReason), Optional.ToNullable(createdTimeUtc), description.Value, Optional.ToNullable(firstActivityTimeUtc), incidentUrl.Value, Optional.ToNullable(incidentNumber), Optional.ToList(labels), Optional.ToNullable(lastActivityTimeUtc), Optional.ToNullable(lastModifiedTimeUtc), owner.Value, Optional.ToList(relatedAnalyticRuleIds), Optional.ToNullable(severity), Optional.ToNullable(status), title.Value, Optional.ToNullable(etag), serializedAdditionalRawData);
        }

        SecurityInsightsIncidentData IModelJsonSerializable<SecurityInsightsIncidentData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsIncidentData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsIncidentData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityInsightsIncidentData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsIncidentData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityInsightsIncidentData IModelSerializable<SecurityInsightsIncidentData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityInsightsIncidentData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsIncidentData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecurityInsightsIncidentData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecurityInsightsIncidentData"/> to convert. </param>
        public static implicit operator RequestContent(SecurityInsightsIncidentData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecurityInsightsIncidentData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecurityInsightsIncidentData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityInsightsIncidentData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
