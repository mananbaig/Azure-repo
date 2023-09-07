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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SitePhpErrorLogFlag : IUtf8JsonSerializable, IModelJsonSerializable<SitePhpErrorLogFlag>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SitePhpErrorLogFlag>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SitePhpErrorLogFlag>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SitePhpErrorLogFlag>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(LocalLogErrors))
            {
                writer.WritePropertyName("localLogErrors"u8);
                writer.WriteStringValue(LocalLogErrors);
            }
            if (Optional.IsDefined(MasterLogErrors))
            {
                writer.WritePropertyName("masterLogErrors"u8);
                writer.WriteStringValue(MasterLogErrors);
            }
            if (Optional.IsDefined(LocalLogErrorsMaxLength))
            {
                writer.WritePropertyName("localLogErrorsMaxLength"u8);
                writer.WriteStringValue(LocalLogErrorsMaxLength);
            }
            if (Optional.IsDefined(MasterLogErrorsMaxLength))
            {
                writer.WritePropertyName("masterLogErrorsMaxLength"u8);
                writer.WriteStringValue(MasterLogErrorsMaxLength);
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

        internal static SitePhpErrorLogFlag DeserializeSitePhpErrorLogFlag(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> localLogErrors = default;
            Optional<string> masterLogErrors = default;
            Optional<string> localLogErrorsMaxLength = default;
            Optional<string> masterLogErrorsMaxLength = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("localLogErrors"u8))
                        {
                            localLogErrors = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("masterLogErrors"u8))
                        {
                            masterLogErrors = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("localLogErrorsMaxLength"u8))
                        {
                            localLogErrorsMaxLength = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("masterLogErrorsMaxLength"u8))
                        {
                            masterLogErrorsMaxLength = property0.Value.GetString();
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
            return new SitePhpErrorLogFlag(id, name, type, systemData.Value, localLogErrors.Value, masterLogErrors.Value, localLogErrorsMaxLength.Value, masterLogErrorsMaxLength.Value, kind.Value, serializedAdditionalRawData);
        }

        SitePhpErrorLogFlag IModelJsonSerializable<SitePhpErrorLogFlag>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SitePhpErrorLogFlag>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSitePhpErrorLogFlag(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SitePhpErrorLogFlag>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SitePhpErrorLogFlag>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SitePhpErrorLogFlag IModelSerializable<SitePhpErrorLogFlag>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SitePhpErrorLogFlag>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSitePhpErrorLogFlag(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SitePhpErrorLogFlag"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SitePhpErrorLogFlag"/> to convert. </param>
        public static implicit operator RequestContent(SitePhpErrorLogFlag model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SitePhpErrorLogFlag"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SitePhpErrorLogFlag(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSitePhpErrorLogFlag(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
