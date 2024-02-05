// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sphere.Models;

namespace Azure.ResourceManager.Sphere
{
    public partial class SphereImageData : IUtf8JsonSerializable, IJsonModel<SphereImageData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SphereImageData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SphereImageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SphereImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SphereImageData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteStringValue(Image);
            }
            if (Optional.IsDefined(ImageId))
            {
                writer.WritePropertyName("imageId"u8);
                writer.WriteStringValue(ImageId);
            }
            if (options.Format != "W" && Optional.IsDefined(ImageName))
            {
                writer.WritePropertyName("imageName"u8);
                writer.WriteStringValue(ImageName);
            }
            if (Optional.IsDefined(RegionalDataBoundary))
            {
                writer.WritePropertyName("regionalDataBoundary"u8);
                writer.WriteStringValue(RegionalDataBoundary.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(ComponentId))
            {
                writer.WritePropertyName("componentId"u8);
                writer.WriteStringValue(ComponentId);
            }
            if (options.Format != "W" && Optional.IsDefined(ImageType))
            {
                writer.WritePropertyName("imageType"u8);
                writer.WriteStringValue(ImageType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
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

        SphereImageData IJsonModel<SphereImageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SphereImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SphereImageData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSphereImageData(document.RootElement, options);
        }

        internal static SphereImageData DeserializeSphereImageData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> image = default;
            Optional<string> imageId = default;
            Optional<string> imageName = default;
            Optional<RegionalDataBoundary> regionalDataBoundary = default;
            Optional<Uri> uri = default;
            Optional<string> description = default;
            Optional<string> componentId = default;
            Optional<SphereImageType> imageType = default;
            Optional<SphereProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("image"u8))
                        {
                            image = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageId"u8))
                        {
                            imageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageName"u8))
                        {
                            imageName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("regionalDataBoundary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            regionalDataBoundary = new RegionalDataBoundary(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("componentId"u8))
                        {
                            componentId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            imageType = new SphereImageType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SphereProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SphereImageData(id, name, type, systemData.Value, image.Value, imageId.Value, imageName.Value, Optional.ToNullable(regionalDataBoundary), uri.Value, description.Value, componentId.Value, Optional.ToNullable(imageType), Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(Image))
            {
                builder.Append("    image:");
                builder.AppendLine($" '{Image}'");
            }

            if (Optional.IsDefined(ImageId))
            {
                builder.Append("    imageId:");
                builder.AppendLine($" '{ImageId}'");
            }

            if (Optional.IsDefined(ImageName))
            {
                builder.Append("    imageName:");
                builder.AppendLine($" '{ImageName}'");
            }

            if (Optional.IsDefined(RegionalDataBoundary))
            {
                builder.Append("    regionalDataBoundary:");
                builder.AppendLine($" '{RegionalDataBoundary.ToString()}'");
            }

            if (Optional.IsDefined(Uri))
            {
                builder.Append("    uri:");
                builder.AppendLine($" '{Uri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("    description:");
                builder.AppendLine($" '{Description}'");
            }

            if (Optional.IsDefined(ComponentId))
            {
                builder.Append("    componentId:");
                builder.AppendLine($" '{ComponentId}'");
            }

            if (Optional.IsDefined(ImageType))
            {
                builder.Append("    imageType:");
                builder.AppendLine($" '{ImageType.ToString()}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("    provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            builder.AppendLine("  }");
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

        BinaryData IPersistableModel<SphereImageData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SphereImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SphereImageData)} does not support '{options.Format}' format.");
            }
        }

        SphereImageData IPersistableModel<SphereImageData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SphereImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSphereImageData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SphereImageData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SphereImageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
