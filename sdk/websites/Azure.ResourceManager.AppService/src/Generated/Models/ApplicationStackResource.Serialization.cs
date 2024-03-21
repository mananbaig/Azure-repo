// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ApplicationStackResource : IUtf8JsonSerializable, IJsonModel<ApplicationStackResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationStackResource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationStackResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStackResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationStackResource)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (Optional.IsDefined(StackName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(StackName);
            }
            if (Optional.IsDefined(Display))
            {
                writer.WritePropertyName("display"u8);
                writer.WriteStringValue(Display);
            }
            if (Optional.IsDefined(Dependency))
            {
                writer.WritePropertyName("dependency"u8);
                writer.WriteStringValue(Dependency);
            }
            if (Optional.IsCollectionDefined(MajorVersions))
            {
                writer.WritePropertyName("majorVersions"u8);
                writer.WriteStartArray();
                foreach (var item in MajorVersions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Frameworks))
            {
                writer.WritePropertyName("frameworks"u8);
                writer.WriteStartArray();
                foreach (var item in Frameworks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IsDeprecated))
            {
                writer.WritePropertyName("isDeprecated"u8);
                writer.WriteStartArray();
                foreach (var item in IsDeprecated)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ApplicationStackResource IJsonModel<ApplicationStackResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStackResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationStackResource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationStackResource(document.RootElement, options);
        }

        internal static ApplicationStackResource DeserializeApplicationStackResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string name0 = default;
            string display = default;
            string dependency = default;
            IList<StackMajorVersion> majorVersions = default;
            IList<ApplicationStack> frameworks = default;
            IList<ApplicationStack> isDeprecated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("display"u8))
                        {
                            display = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dependency"u8))
                        {
                            dependency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("majorVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StackMajorVersion> array = new List<StackMajorVersion>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StackMajorVersion.DeserializeStackMajorVersion(item, options));
                            }
                            majorVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("frameworks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationStack> array = new List<ApplicationStack>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationStack.DeserializeApplicationStack(item, options));
                            }
                            frameworks = array;
                            continue;
                        }
                        if (property0.NameEquals("isDeprecated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationStack> array = new List<ApplicationStack>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationStack.DeserializeApplicationStack(item, options));
                            }
                            isDeprecated = array;
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
            return new ApplicationStackResource(
                id,
                name,
                type,
                systemData,
                name0,
                display,
                dependency,
                majorVersions ?? new ChangeTrackingList<StackMajorVersion>(),
                frameworks ?? new ChangeTrackingList<ApplicationStack>(),
                isDeprecated ?? new ChangeTrackingList<ApplicationStack>(),
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationStackResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStackResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationStackResource)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationStackResource IPersistableModel<ApplicationStackResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStackResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationStackResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationStackResource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationStackResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
