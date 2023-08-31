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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicApiResourceGeneralInformation : IUtf8JsonSerializable, IModelJsonSerializable<LogicApiResourceGeneralInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogicApiResourceGeneralInformation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogicApiResourceGeneralInformation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IconUri))
            {
                writer.WritePropertyName("iconUrl"u8);
                writer.WriteStringValue(IconUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(TermsOfUseUri))
            {
                writer.WritePropertyName("termsOfUseUrl"u8);
                writer.WriteStringValue(TermsOfUseUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ReleaseTag))
            {
                writer.WritePropertyName("releaseTag"u8);
                writer.WriteStringValue(ReleaseTag);
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier.Value.ToString());
            }
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

        internal static LogicApiResourceGeneralInformation DeserializeLogicApiResourceGeneralInformation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> iconUrl = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<Uri> termsOfUseUrl = default;
            Optional<string> releaseTag = default;
            Optional<LogicApiTier> tier = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("iconUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iconUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termsOfUseUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    termsOfUseUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("releaseTag"u8))
                {
                    releaseTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new LogicApiTier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogicApiResourceGeneralInformation(iconUrl.Value, displayName.Value, description.Value, termsOfUseUrl.Value, releaseTag.Value, Optional.ToNullable(tier), rawData);
        }

        LogicApiResourceGeneralInformation IModelJsonSerializable<LogicApiResourceGeneralInformation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicApiResourceGeneralInformation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogicApiResourceGeneralInformation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogicApiResourceGeneralInformation IModelSerializable<LogicApiResourceGeneralInformation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogicApiResourceGeneralInformation(doc.RootElement, options);
        }

        public static implicit operator RequestContent(LogicApiResourceGeneralInformation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator LogicApiResourceGeneralInformation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogicApiResourceGeneralInformation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
