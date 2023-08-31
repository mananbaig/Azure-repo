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
    public partial class RestorePointSourceVmDataDisk : IUtf8JsonSerializable, IModelJsonSerializable<RestorePointSourceVmDataDisk>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RestorePointSourceVmDataDisk>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RestorePointSourceVmDataDisk>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedDisk))
            {
                writer.WritePropertyName("managedDisk"u8);
                if (ManagedDisk is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VirtualMachineManagedDisk>)ManagedDisk).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DiskRestorePoint))
            {
                writer.WritePropertyName("diskRestorePoint"u8);
                if (DiskRestorePoint is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DiskRestorePointAttributes>)DiskRestorePoint).Serialize(writer, options);
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

        internal static RestorePointSourceVmDataDisk DeserializeRestorePointSourceVmDataDisk(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> lun = default;
            Optional<string> name = default;
            Optional<CachingType> caching = default;
            Optional<int> diskSizeGB = default;
            Optional<VirtualMachineManagedDisk> managedDisk = default;
            Optional<DiskRestorePointAttributes> diskRestorePoint = default;
            Optional<bool> writeAcceleratorEnabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("caching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    caching = property.Value.GetString().ToCachingType();
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
                if (property.NameEquals("managedDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedDisk = VirtualMachineManagedDisk.DeserializeVirtualMachineManagedDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("diskRestorePoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskRestorePoint = DiskRestorePointAttributes.DeserializeDiskRestorePointAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("writeAcceleratorEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeAcceleratorEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RestorePointSourceVmDataDisk(Optional.ToNullable(lun), name.Value, Optional.ToNullable(caching), Optional.ToNullable(diskSizeGB), managedDisk.Value, diskRestorePoint.Value, Optional.ToNullable(writeAcceleratorEnabled), rawData);
        }

        RestorePointSourceVmDataDisk IModelJsonSerializable<RestorePointSourceVmDataDisk>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRestorePointSourceVmDataDisk(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RestorePointSourceVmDataDisk>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RestorePointSourceVmDataDisk IModelSerializable<RestorePointSourceVmDataDisk>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRestorePointSourceVmDataDisk(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RestorePointSourceVmDataDisk"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RestorePointSourceVmDataDisk"/> to convert. </param>
        public static implicit operator RequestContent(RestorePointSourceVmDataDisk model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RestorePointSourceVmDataDisk"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RestorePointSourceVmDataDisk(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRestorePointSourceVmDataDisk(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
