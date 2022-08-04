// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineDataDisk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("lun");
            writer.WriteNumberValue(Lun);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Vhd))
            {
                writer.WritePropertyName("vhd");
                writer.WriteObjectValue(Vhd);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image");
                writer.WriteObjectValue(Image);
            }
            if (Optional.IsDefined(Caching))
            {
                writer.WritePropertyName("caching");
                writer.WriteStringValue(Caching.Value.ToSerialString());
            }
            if (Optional.IsDefined(WriteAcceleratorEnabled))
            {
                writer.WritePropertyName("writeAcceleratorEnabled");
                writer.WriteBooleanValue(WriteAcceleratorEnabled.Value);
            }
            writer.WritePropertyName("createOption");
            writer.WriteStringValue(CreateOption.ToString());
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB");
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(ManagedDisk))
            {
                writer.WritePropertyName("managedDisk");
                writer.WriteObjectValue(ManagedDisk);
            }
            if (Optional.IsDefined(ToBeDetached))
            {
                writer.WritePropertyName("toBeDetached");
                writer.WriteBooleanValue(ToBeDetached.Value);
            }
            if (Optional.IsDefined(DetachOption))
            {
                writer.WritePropertyName("detachOption");
                writer.WriteStringValue(DetachOption.Value.ToString());
            }
            if (Optional.IsDefined(DeleteOption))
            {
                writer.WritePropertyName("deleteOption");
                writer.WriteStringValue(DeleteOption.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineDataDisk DeserializeVirtualMachineDataDisk(JsonElement element)
        {
            int lun = default;
            Optional<string> name = default;
            Optional<VirtualHardDisk> vhd = default;
            Optional<VirtualHardDisk> image = default;
            Optional<CachingType> caching = default;
            Optional<bool> writeAcceleratorEnabled = default;
            DiskCreateOptionType createOption = default;
            Optional<int> diskSizeGB = default;
            Optional<VirtualMachineManagedDisk> managedDisk = default;
            Optional<bool> toBeDetached = default;
            Optional<long> diskIOPSReadWrite = default;
            Optional<long> diskMBpsReadWrite = default;
            Optional<DiskDetachOptionType> detachOption = default;
            Optional<DiskDeleteOptionType> deleteOption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"))
                {
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhd"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vhd = VirtualHardDisk.DeserializeVirtualHardDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("image"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    image = VirtualHardDisk.DeserializeVirtualHardDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("caching"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    caching = property.Value.GetString().ToCachingType();
                    continue;
                }
                if (property.NameEquals("writeAcceleratorEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeAcceleratorEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("createOption"))
                {
                    createOption = new DiskCreateOptionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskSizeGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("managedDisk"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    managedDisk = VirtualMachineManagedDisk.DeserializeVirtualMachineManagedDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("toBeDetached"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    toBeDetached = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("diskIOPSReadWrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskIOPSReadWrite = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("diskMBpsReadWrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskMBpsReadWrite = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("detachOption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    detachOption = new DiskDetachOptionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deleteOption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deleteOption = new DiskDeleteOptionType(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualMachineDataDisk(lun, name.Value, vhd.Value, image.Value, Optional.ToNullable(caching), Optional.ToNullable(writeAcceleratorEnabled), createOption, Optional.ToNullable(diskSizeGB), managedDisk.Value, Optional.ToNullable(toBeDetached), Optional.ToNullable(diskIOPSReadWrite), Optional.ToNullable(diskMBpsReadWrite), Optional.ToNullable(detachOption), Optional.ToNullable(deleteOption));
        }
    }
}
