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
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    public partial class MySqlFlexibleServerConfigurationData : IUtf8JsonSerializable, IModelJsonSerializable<MySqlFlexibleServerConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MySqlFlexibleServerConfigurationData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MySqlFlexibleServerConfigurationData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(CurrentValue))
            {
                writer.WritePropertyName("currentValue"u8);
                writer.WriteStringValue(CurrentValue);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source.Value.ToString());
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static MySqlFlexibleServerConfigurationData DeserializeMySqlFlexibleServerConfigurationData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<string> value = default;
            Optional<string> currentValue = default;
            Optional<string> description = default;
            Optional<string> documentationLink = default;
            Optional<string> defaultValue = default;
            Optional<string> dataType = default;
            Optional<string> allowedValues = default;
            Optional<MySqlFlexibleServerConfigurationSource> source = default;
            Optional<MySqlFlexibleServerConfigReadOnlyState> isReadOnly = default;
            Optional<MySqlFlexibleServerConfigPendingRestartState> isConfigPendingRestart = default;
            Optional<MySqlFlexibleServerConfigDynamicState> isDynamicConfig = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("value"u8))
                        {
                            value = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentValue"u8))
                        {
                            currentValue = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentationLink"u8))
                        {
                            documentationLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultValue"u8))
                        {
                            defaultValue = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataType"u8))
                        {
                            dataType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowedValues"u8))
                        {
                            allowedValues = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = new MySqlFlexibleServerConfigurationSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isReadOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isReadOnly = new MySqlFlexibleServerConfigReadOnlyState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isConfigPendingRestart"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isConfigPendingRestart = new MySqlFlexibleServerConfigPendingRestartState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isDynamicConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDynamicConfig = new MySqlFlexibleServerConfigDynamicState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MySqlFlexibleServerConfigurationData(id, name, type, systemData.Value, value.Value, currentValue.Value, description.Value, documentationLink.Value, defaultValue.Value, dataType.Value, allowedValues.Value, Optional.ToNullable(source), Optional.ToNullable(isReadOnly), Optional.ToNullable(isConfigPendingRestart), Optional.ToNullable(isDynamicConfig), rawData);
        }

        MySqlFlexibleServerConfigurationData IModelJsonSerializable<MySqlFlexibleServerConfigurationData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerConfigurationData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MySqlFlexibleServerConfigurationData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MySqlFlexibleServerConfigurationData IModelSerializable<MySqlFlexibleServerConfigurationData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMySqlFlexibleServerConfigurationData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MySqlFlexibleServerConfigurationData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MySqlFlexibleServerConfigurationData"/> to convert. </param>
        public static implicit operator RequestContent(MySqlFlexibleServerConfigurationData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MySqlFlexibleServerConfigurationData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MySqlFlexibleServerConfigurationData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMySqlFlexibleServerConfigurationData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
