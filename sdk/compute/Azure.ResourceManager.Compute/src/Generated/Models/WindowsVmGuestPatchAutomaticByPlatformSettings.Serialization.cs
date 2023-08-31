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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class WindowsVmGuestPatchAutomaticByPlatformSettings : IUtf8JsonSerializable, IModelJsonSerializable<WindowsVmGuestPatchAutomaticByPlatformSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WindowsVmGuestPatchAutomaticByPlatformSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WindowsVmGuestPatchAutomaticByPlatformSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RebootSetting))
            {
                writer.WritePropertyName("rebootSetting"u8);
                writer.WriteStringValue(RebootSetting.Value.ToString());
            }
            if (Optional.IsDefined(BypassPlatformSafetyChecksOnUserSchedule))
            {
                writer.WritePropertyName("bypassPlatformSafetyChecksOnUserSchedule"u8);
                writer.WriteBooleanValue(BypassPlatformSafetyChecksOnUserSchedule.Value);
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

        internal static WindowsVmGuestPatchAutomaticByPlatformSettings DeserializeWindowsVmGuestPatchAutomaticByPlatformSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WindowsVmGuestPatchAutomaticByPlatformRebootSetting> rebootSetting = default;
            Optional<bool> bypassPlatformSafetyChecksOnUserSchedule = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rebootSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootSetting = new WindowsVmGuestPatchAutomaticByPlatformRebootSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bypassPlatformSafetyChecksOnUserSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bypassPlatformSafetyChecksOnUserSchedule = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WindowsVmGuestPatchAutomaticByPlatformSettings(Optional.ToNullable(rebootSetting), Optional.ToNullable(bypassPlatformSafetyChecksOnUserSchedule), rawData);
        }

        WindowsVmGuestPatchAutomaticByPlatformSettings IModelJsonSerializable<WindowsVmGuestPatchAutomaticByPlatformSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsVmGuestPatchAutomaticByPlatformSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WindowsVmGuestPatchAutomaticByPlatformSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WindowsVmGuestPatchAutomaticByPlatformSettings IModelSerializable<WindowsVmGuestPatchAutomaticByPlatformSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWindowsVmGuestPatchAutomaticByPlatformSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WindowsVmGuestPatchAutomaticByPlatformSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WindowsVmGuestPatchAutomaticByPlatformSettings"/> to convert. </param>
        public static implicit operator RequestContent(WindowsVmGuestPatchAutomaticByPlatformSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WindowsVmGuestPatchAutomaticByPlatformSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WindowsVmGuestPatchAutomaticByPlatformSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWindowsVmGuestPatchAutomaticByPlatformSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
