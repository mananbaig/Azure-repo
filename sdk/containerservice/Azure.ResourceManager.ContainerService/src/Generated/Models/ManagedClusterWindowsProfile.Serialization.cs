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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterWindowsProfile : IUtf8JsonSerializable, IModelJsonSerializable<ManagedClusterWindowsProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedClusterWindowsProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedClusterWindowsProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("adminUsername"u8);
            writer.WriteStringValue(AdminUsername);
            if (Optional.IsDefined(AdminPassword))
            {
                writer.WritePropertyName("adminPassword"u8);
                writer.WriteStringValue(AdminPassword);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(IsCsiProxyEnabled))
            {
                writer.WritePropertyName("enableCSIProxy"u8);
                writer.WriteBooleanValue(IsCsiProxyEnabled.Value);
            }
            if (Optional.IsDefined(GmsaProfile))
            {
                writer.WritePropertyName("gmsaProfile"u8);
                if (GmsaProfile is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<WindowsGmsaProfile>)GmsaProfile).Serialize(writer, options);
                }
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

        internal static ManagedClusterWindowsProfile DeserializeManagedClusterWindowsProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string adminUsername = default;
            Optional<string> adminPassword = default;
            Optional<WindowsVmLicenseType> licenseType = default;
            Optional<bool> enableCsiProxy = default;
            Optional<WindowsGmsaProfile> gmsaProfile = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminUsername"u8))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminPassword"u8))
                {
                    adminPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new WindowsVmLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableCSIProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCsiProxy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("gmsaProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gmsaProfile = WindowsGmsaProfile.DeserializeWindowsGmsaProfile(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedClusterWindowsProfile(adminUsername, adminPassword.Value, Optional.ToNullable(licenseType), Optional.ToNullable(enableCsiProxy), gmsaProfile.Value, rawData);
        }

        ManagedClusterWindowsProfile IModelJsonSerializable<ManagedClusterWindowsProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterWindowsProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedClusterWindowsProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedClusterWindowsProfile IModelSerializable<ManagedClusterWindowsProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedClusterWindowsProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedClusterWindowsProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedClusterWindowsProfile"/> to convert. </param>
        public static implicit operator RequestContent(ManagedClusterWindowsProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedClusterWindowsProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedClusterWindowsProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedClusterWindowsProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
