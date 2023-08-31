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

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class VirtualDiskUpdate : IUtf8JsonSerializable, IModelJsonSerializable<VirtualDiskUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualDiskUpdate>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualDiskUpdate>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB"u8);
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(DeviceKey))
            {
                writer.WritePropertyName("deviceKey"u8);
                writer.WriteNumberValue(DeviceKey.Value);
            }
            if (Optional.IsDefined(DiskMode))
            {
                writer.WritePropertyName("diskMode"u8);
                writer.WriteStringValue(DiskMode.Value.ToString());
            }
            if (Optional.IsDefined(ControllerKey))
            {
                writer.WritePropertyName("controllerKey"u8);
                writer.WriteNumberValue(ControllerKey.Value);
            }
            if (Optional.IsDefined(UnitNumber))
            {
                writer.WritePropertyName("unitNumber"u8);
                writer.WriteNumberValue(UnitNumber.Value);
            }
            if (Optional.IsDefined(DeviceName))
            {
                writer.WritePropertyName("deviceName"u8);
                writer.WriteStringValue(DeviceName);
            }
            if (Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType.Value.ToString());
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

        internal static VirtualDiskUpdate DeserializeVirtualDiskUpdate(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<int> diskSizeGB = default;
            Optional<int> deviceKey = default;
            Optional<DiskMode> diskMode = default;
            Optional<int> controllerKey = default;
            Optional<int> unitNumber = default;
            Optional<string> deviceName = default;
            Optional<DiskType> diskType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deviceKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceKey = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskMode = new DiskMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controllerKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controllerKey = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unitNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unitNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deviceName"u8))
                {
                    deviceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskType = new DiskType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualDiskUpdate(name.Value, Optional.ToNullable(diskSizeGB), Optional.ToNullable(deviceKey), Optional.ToNullable(diskMode), Optional.ToNullable(controllerKey), Optional.ToNullable(unitNumber), deviceName.Value, Optional.ToNullable(diskType), rawData);
        }

        VirtualDiskUpdate IModelJsonSerializable<VirtualDiskUpdate>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualDiskUpdate(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualDiskUpdate>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualDiskUpdate IModelSerializable<VirtualDiskUpdate>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualDiskUpdate(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualDiskUpdate"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualDiskUpdate"/> to convert. </param>
        public static implicit operator RequestContent(VirtualDiskUpdate model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualDiskUpdate"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualDiskUpdate(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualDiskUpdate(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
