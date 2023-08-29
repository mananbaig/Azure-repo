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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformConfigServerProperties : IUtf8JsonSerializable, IModelJsonSerializable<AppPlatformConfigServerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppPlatformConfigServerProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppPlatformConfigServerProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
            if (Optional.IsDefined(ConfigServer))
            {
                writer.WritePropertyName("configServer"u8);
                writer.WriteObjectValue(ConfigServer);
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

        internal static AppPlatformConfigServerProperties DeserializeAppPlatformConfigServerProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformConfigServerState> provisioningState = default;
            Optional<AppPlatformErrorInfo> error = default;
            Optional<ConfigServerSettings> configServer = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformConfigServerState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = AppPlatformErrorInfo.DeserializeAppPlatformErrorInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("configServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configServer = ConfigServerSettings.DeserializeConfigServerSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppPlatformConfigServerProperties(Optional.ToNullable(provisioningState), error.Value, configServer.Value, rawData);
        }

        AppPlatformConfigServerProperties IModelJsonSerializable<AppPlatformConfigServerProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformConfigServerProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppPlatformConfigServerProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppPlatformConfigServerProperties IModelSerializable<AppPlatformConfigServerProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppPlatformConfigServerProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AppPlatformConfigServerProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AppPlatformConfigServerProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppPlatformConfigServerProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
