// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class LcmConfigurationSetting : IUtf8JsonSerializable, IJsonModel<LcmConfigurationSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LcmConfigurationSetting>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LcmConfigurationSetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LcmConfigurationSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(LcmConfigurationSetting)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ConfigurationMode))
            {
                writer.WritePropertyName("configurationMode"u8);
                writer.WriteStringValue(ConfigurationMode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IsModuleOverwriteAllowed))
            {
                writer.WritePropertyName("allowModuleOverwrite"u8);
                writer.WriteBooleanValue(IsModuleOverwriteAllowed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ActionAfterReboot))
            {
                writer.WritePropertyName("actionAfterReboot"u8);
                writer.WriteStringValue(ActionAfterReboot.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RefreshFrequencyInMins))
            {
                writer.WritePropertyName("refreshFrequencyMins"u8);
                writer.WriteNumberValue(RefreshFrequencyInMins.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RebootIfNeeded))
            {
                writer.WritePropertyName("rebootIfNeeded"u8);
                writer.WriteBooleanValue(RebootIfNeeded.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationModeFrequencyInMins))
            {
                writer.WritePropertyName("configurationModeFrequencyMins"u8);
                writer.WriteNumberValue(ConfigurationModeFrequencyInMins.Value);
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

        LcmConfigurationSetting IJsonModel<LcmConfigurationSetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LcmConfigurationSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(LcmConfigurationSetting)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLcmConfigurationSetting(document.RootElement, options);
        }

        internal static LcmConfigurationSetting DeserializeLcmConfigurationSetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LcmConfigurationMode> configurationMode = default;
            Optional<bool> allowModuleOverwrite = default;
            Optional<ActionAfterReboot> actionAfterReboot = default;
            Optional<float> refreshFrequencyMins = default;
            Optional<bool> rebootIfNeeded = default;
            Optional<float> configurationModeFrequencyMins = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationMode = new LcmConfigurationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowModuleOverwrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowModuleOverwrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("actionAfterReboot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionAfterReboot = new ActionAfterReboot(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("refreshFrequencyMins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshFrequencyMins = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("rebootIfNeeded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootIfNeeded = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationModeFrequencyMins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationModeFrequencyMins = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LcmConfigurationSetting(Optional.ToNullable(configurationMode), Optional.ToNullable(allowModuleOverwrite), Optional.ToNullable(actionAfterReboot), Optional.ToNullable(refreshFrequencyMins), Optional.ToNullable(rebootIfNeeded), Optional.ToNullable(configurationModeFrequencyMins), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LcmConfigurationSetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LcmConfigurationSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(LcmConfigurationSetting)} does not support '{options.Format}' format.");
            }
        }

        LcmConfigurationSetting IPersistableModel<LcmConfigurationSetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LcmConfigurationSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLcmConfigurationSetting(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(LcmConfigurationSetting)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LcmConfigurationSetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
