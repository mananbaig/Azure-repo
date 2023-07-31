// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    public partial class VirtualMachineConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("imageReference"u8);
            writer.WriteObjectValue(ImageReference);
            writer.WritePropertyName("nodeAgentSKUId"u8);
            writer.WriteStringValue(NodeAgentSKUId);
            if (Optional.IsDefined(WindowsConfiguration))
            {
                writer.WritePropertyName("windowsConfiguration"u8);
                writer.WriteObjectValue(WindowsConfiguration);
            }
            if (Optional.IsCollectionDefined(DataDisks))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType);
            }
            if (Optional.IsDefined(ContainerConfiguration))
            {
                writer.WritePropertyName("containerConfiguration"u8);
                writer.WriteObjectValue(ContainerConfiguration);
            }
            if (Optional.IsDefined(DiskEncryptionConfiguration))
            {
                writer.WritePropertyName("diskEncryptionConfiguration"u8);
                writer.WriteObjectValue(DiskEncryptionConfiguration);
            }
            if (Optional.IsDefined(NodePlacementConfiguration))
            {
                writer.WritePropertyName("nodePlacementConfiguration"u8);
                writer.WriteObjectValue(NodePlacementConfiguration);
            }
            if (Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OsDisk))
            {
                writer.WritePropertyName("osDisk"u8);
                writer.WriteObjectValue(OsDisk);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineConfiguration DeserializeVirtualMachineConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImageReference imageReference = default;
            string nodeAgentSKUId = default;
            Optional<WindowsConfiguration> windowsConfiguration = default;
            Optional<IList<DataDisk>> dataDisks = default;
            Optional<string> licenseType = default;
            Optional<ContainerConfiguration> containerConfiguration = default;
            Optional<DiskEncryptionConfiguration> diskEncryptionConfiguration = default;
            Optional<NodePlacementConfiguration> nodePlacementConfiguration = default;
            Optional<IList<VMExtension>> extensions = default;
            Optional<OSDisk> osDisk = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageReference"u8))
                {
                    imageReference = ImageReference.DeserializeImageReference(property.Value);
                    continue;
                }
                if (property.NameEquals("nodeAgentSKUId"u8))
                {
                    nodeAgentSKUId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsConfiguration = WindowsConfiguration.DeserializeWindowsConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataDisk> array = new List<DataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataDisk.DeserializeDataDisk(item));
                    }
                    dataDisks = array;
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerConfiguration = ContainerConfiguration.DeserializeContainerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("diskEncryptionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionConfiguration = DiskEncryptionConfiguration.DeserializeDiskEncryptionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("nodePlacementConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodePlacementConfiguration = NodePlacementConfiguration.DeserializeNodePlacementConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("extensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VMExtension> array = new List<VMExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMExtension.DeserializeVMExtension(item));
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("osDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDisk = OSDisk.DeserializeOSDisk(property.Value);
                    continue;
                }
            }
            return new VirtualMachineConfiguration(imageReference, nodeAgentSKUId, windowsConfiguration.Value, Optional.ToList(dataDisks), licenseType.Value, containerConfiguration.Value, diskEncryptionConfiguration.Value, nodePlacementConfiguration.Value, Optional.ToList(extensions), osDisk.Value);
        }
    }
}
