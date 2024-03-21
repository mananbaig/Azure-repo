// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FunctionAppRuntimeSettings : IUtf8JsonSerializable, IJsonModel<FunctionAppRuntimeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FunctionAppRuntimeSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FunctionAppRuntimeSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppRuntimeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionAppRuntimeSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(IsRemoteDebuggingSupported))
            {
                writer.WritePropertyName("remoteDebuggingSupported"u8);
                writer.WriteBooleanValue(IsRemoteDebuggingSupported.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AppInsightsSettings))
            {
                writer.WritePropertyName("appInsightsSettings"u8);
                writer.WriteObjectValue(AppInsightsSettings);
            }
            if (options.Format != "W" && Optional.IsDefined(GitHubActionSettings))
            {
                writer.WritePropertyName("gitHubActionSettings"u8);
                writer.WriteObjectValue(GitHubActionSettings);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AppSettingsDictionary))
            {
                writer.WritePropertyName("appSettingsDictionary"u8);
                writer.WriteStartObject();
                foreach (var item in AppSettingsDictionary)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(SiteConfigPropertiesDictionary))
            {
                writer.WritePropertyName("siteConfigPropertiesDictionary"u8);
                writer.WriteObjectValue(SiteConfigPropertiesDictionary);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedFunctionsExtensionVersions))
            {
                writer.WritePropertyName("supportedFunctionsExtensionVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedFunctionsExtensionVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("isPreview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsDeprecated))
            {
                writer.WritePropertyName("isDeprecated"u8);
                writer.WriteBooleanValue(IsDeprecated.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsHidden))
            {
                writer.WritePropertyName("isHidden"u8);
                writer.WriteBooleanValue(IsHidden.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EndOfLifeOn))
            {
                writer.WritePropertyName("endOfLifeDate"u8);
                writer.WriteStringValue(EndOfLifeOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(IsAutoUpdate))
            {
                writer.WritePropertyName("isAutoUpdate"u8);
                writer.WriteBooleanValue(IsAutoUpdate.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsEarlyAccess))
            {
                writer.WritePropertyName("isEarlyAccess"u8);
                writer.WriteBooleanValue(IsEarlyAccess.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsDefault))
            {
                writer.WritePropertyName("isDefault"u8);
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        FunctionAppRuntimeSettings IJsonModel<FunctionAppRuntimeSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppRuntimeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionAppRuntimeSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionAppRuntimeSettings(document.RootElement, options);
        }

        internal static FunctionAppRuntimeSettings DeserializeFunctionAppRuntimeSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string runtimeVersion = default;
            bool? remoteDebuggingSupported = default;
            AppInsightsWebAppStackSettings appInsightsSettings = default;
            GitHubActionWebAppStackSettings gitHubActionSettings = default;
            IReadOnlyDictionary<string, string> appSettingsDictionary = default;
            SiteConfigPropertiesDictionary siteConfigPropertiesDictionary = default;
            IReadOnlyList<string> supportedFunctionsExtensionVersions = default;
            bool? isPreview = default;
            bool? isDeprecated = default;
            bool? isHidden = default;
            DateTimeOffset? endOfLifeDate = default;
            bool? isAutoUpdate = default;
            bool? isEarlyAccess = default;
            bool? isDefault = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                    appInsightsSettings = AppInsightsWebAppStackSettings.DeserializeAppInsightsWebAppStackSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("gitHubActionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitHubActionSettings = GitHubActionWebAppStackSettings.DeserializeGitHubActionWebAppStackSettings(property.Value, options);
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
                    siteConfigPropertiesDictionary = SiteConfigPropertiesDictionary.DeserializeSiteConfigPropertiesDictionary(property.Value, options);
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FunctionAppRuntimeSettings(
                runtimeVersion,
                remoteDebuggingSupported,
                appInsightsSettings,
                gitHubActionSettings,
                appSettingsDictionary ?? new ChangeTrackingDictionary<string, string>(),
                siteConfigPropertiesDictionary,
                supportedFunctionsExtensionVersions ?? new ChangeTrackingList<string>(),
                isPreview,
                isDeprecated,
                isHidden,
                endOfLifeDate,
                isAutoUpdate,
                isEarlyAccess,
                isDefault,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FunctionAppRuntimeSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppRuntimeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FunctionAppRuntimeSettings)} does not support writing '{options.Format}' format.");
            }
        }

        FunctionAppRuntimeSettings IPersistableModel<FunctionAppRuntimeSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppRuntimeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFunctionAppRuntimeSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FunctionAppRuntimeSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FunctionAppRuntimeSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
