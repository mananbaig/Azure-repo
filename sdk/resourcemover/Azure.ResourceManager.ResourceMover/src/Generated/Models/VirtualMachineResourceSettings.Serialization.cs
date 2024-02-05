// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class VirtualMachineResourceSettings : IUtf8JsonSerializable, IJsonModel<VirtualMachineResourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineResourceSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineResourceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineResourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineResourceSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(UserManagedIdentities))
            {
                writer.WritePropertyName("userManagedIdentities"u8);
                writer.WriteStartArray();
                foreach (var item in UserManagedIdentities)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetAvailabilityZone))
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone.Value.ToString());
            }
            if (Optional.IsDefined(TargetVmSize))
            {
                writer.WritePropertyName("targetVmSize"u8);
                writer.WriteStringValue(TargetVmSize);
            }
            if (Optional.IsDefined(TargetAvailabilitySetId))
            {
                writer.WritePropertyName("targetAvailabilitySetId"u8);
                writer.WriteStringValue(TargetAvailabilitySetId);
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
            if (Optional.IsDefined(TargetResourceName))
            {
                writer.WritePropertyName("targetResourceName"u8);
                writer.WriteStringValue(TargetResourceName);
            }
            if (Optional.IsDefined(TargetResourceGroupName))
            {
                writer.WritePropertyName("targetResourceGroupName"u8);
                writer.WriteStringValue(TargetResourceGroupName);
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

        VirtualMachineResourceSettings IJsonModel<VirtualMachineResourceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineResourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineResourceSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineResourceSettings(document.RootElement, options);
        }

        internal static VirtualMachineResourceSettings DeserializeVirtualMachineResourceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<ResourceIdentifier>> userManagedIdentities = default;
            Optional<MoverTargetAvailabilityZone> targetAvailabilityZone = default;
            Optional<string> targetVmSize = default;
            Optional<ResourceIdentifier> targetAvailabilitySetId = default;
            string resourceType = default;
            Optional<string> targetResourceName = default;
            Optional<string> targetResourceGroupName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("userManagedIdentities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    userManagedIdentities = array;
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAvailabilityZone = new MoverTargetAvailabilityZone(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmSize"u8))
                {
                    targetVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupName"u8))
                {
                    targetResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineResourceSettings(resourceType, targetResourceName.Value, targetResourceGroupName.Value, serializedAdditionalRawData, Optional.ToDictionary(tags), Optional.ToList(userManagedIdentities), Optional.ToNullable(targetAvailabilityZone), targetVmSize.Value, targetAvailabilitySetId.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags.Any())
                {
                    builder.Append("  tags:");
                    builder.AppendLine(" {");
                    foreach (var item in Tags)
                    {
                        builder.Append($"    {item.Key}: ");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value}'");
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsCollectionDefined(UserManagedIdentities))
            {
                if (UserManagedIdentities.Any())
                {
                    builder.Append("  userManagedIdentities:");
                    builder.AppendLine(" [");
                    foreach (var item in UserManagedIdentities)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"    '{item.ToString()}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(TargetAvailabilityZone))
            {
                builder.Append("  targetAvailabilityZone:");
                builder.AppendLine($" '{TargetAvailabilityZone.ToString()}'");
            }

            if (Optional.IsDefined(TargetVmSize))
            {
                builder.Append("  targetVmSize:");
                builder.AppendLine($" '{TargetVmSize}'");
            }

            if (Optional.IsDefined(TargetAvailabilitySetId))
            {
                builder.Append("  targetAvailabilitySetId:");
                builder.AppendLine($" '{TargetAvailabilitySetId.ToString()}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  resourceType:");
                builder.AppendLine($" '{ResourceType}'");
            }

            if (Optional.IsDefined(TargetResourceName))
            {
                builder.Append("  targetResourceName:");
                builder.AppendLine($" '{TargetResourceName}'");
            }

            if (Optional.IsDefined(TargetResourceGroupName))
            {
                builder.Append("  targetResourceGroupName:");
                builder.AppendLine($" '{TargetResourceGroupName}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<VirtualMachineResourceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineResourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineResourceSettings)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineResourceSettings IPersistableModel<VirtualMachineResourceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineResourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineResourceSettings(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineResourceSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineResourceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
