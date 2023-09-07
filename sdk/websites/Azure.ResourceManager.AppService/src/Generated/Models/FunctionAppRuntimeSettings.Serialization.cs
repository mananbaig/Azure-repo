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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FunctionAppRuntimeSettings : IUtf8JsonSerializable, IModelJsonSerializable<FunctionAppRuntimeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FunctionAppRuntimeSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FunctionAppRuntimeSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FunctionAppRuntimeSettings>(this, options.Format);

            writer.WriteStartObject();
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

        internal static FunctionAppRuntimeSettings DeserializeFunctionAppRuntimeSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> runtimeVersion = default;
            Optional<bool> remoteDebuggingSupported = default;
            Optional<AppInsightsWebAppStackSettings> appInsightsSettings = default;
            Optional<GitHubActionWebAppStackSettings> gitHubActionSettings = default;
            Optional<IReadOnlyDictionary<string, string>> appSettingsDictionary = default;
            Optional<SiteConfigPropertiesDictionary> siteConfigPropertiesDictionary = default;
            Optional<IReadOnlyList<string>> supportedFunctionsExtensionVersions = default;
            Optional<bool> isPreview = default;
            Optional<bool> isDeprecated = default;
            Optional<bool> isHidden = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<bool> isAutoUpdate = default;
            Optional<bool> isEarlyAccess = default;
            Optional<bool> isDefault = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteDebuggingSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteDebuggingSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appInsightsSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appInsightsSettings = AppInsightsWebAppStackSettings.DeserializeAppInsightsWebAppStackSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("gitHubActionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitHubActionSettings = GitHubActionWebAppStackSettings.DeserializeGitHubActionWebAppStackSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("appSettingsDictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    appSettingsDictionary = dictionary;
                    continue;
                }
                if (property.NameEquals("siteConfigPropertiesDictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    siteConfigPropertiesDictionary = SiteConfigPropertiesDictionary.DeserializeSiteConfigPropertiesDictionary(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedFunctionsExtensionVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedFunctionsExtensionVersions = array;
                    continue;
                }
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeprecated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeprecated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isAutoUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEarlyAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEarlyAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FunctionAppRuntimeSettings(runtimeVersion.Value, Optional.ToNullable(remoteDebuggingSupported), appInsightsSettings.Value, gitHubActionSettings.Value, Optional.ToDictionary(appSettingsDictionary), siteConfigPropertiesDictionary.Value, Optional.ToList(supportedFunctionsExtensionVersions), Optional.ToNullable(isPreview), Optional.ToNullable(isDeprecated), Optional.ToNullable(isHidden), Optional.ToNullable(endOfLifeDate), Optional.ToNullable(isAutoUpdate), Optional.ToNullable(isEarlyAccess), Optional.ToNullable(isDefault), serializedAdditionalRawData);
        }

        FunctionAppRuntimeSettings IModelJsonSerializable<FunctionAppRuntimeSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FunctionAppRuntimeSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionAppRuntimeSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FunctionAppRuntimeSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FunctionAppRuntimeSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FunctionAppRuntimeSettings IModelSerializable<FunctionAppRuntimeSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FunctionAppRuntimeSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFunctionAppRuntimeSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FunctionAppRuntimeSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FunctionAppRuntimeSettings"/> to convert. </param>
        public static implicit operator RequestContent(FunctionAppRuntimeSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FunctionAppRuntimeSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FunctionAppRuntimeSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFunctionAppRuntimeSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
