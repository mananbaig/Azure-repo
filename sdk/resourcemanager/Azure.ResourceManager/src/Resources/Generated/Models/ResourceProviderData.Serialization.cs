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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class ResourceProviderData : IUtf8JsonSerializable, IJsonModel<ResourceProviderData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceProviderData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceProviderData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceProviderData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (options.Format != "W" && Optional.IsDefined(RegistrationState))
            {
                writer.WritePropertyName("registrationState"u8);
                writer.WriteStringValue(RegistrationState);
            }
            if (options.Format != "W" && Optional.IsDefined(RegistrationPolicy))
            {
                writer.WritePropertyName("registrationPolicy"u8);
                writer.WriteStringValue(RegistrationPolicy);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ResourceTypes))
            {
                writer.WritePropertyName("resourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProviderAuthorizationConsentState))
            {
                writer.WritePropertyName("providerAuthorizationConsentState"u8);
                writer.WriteStringValue(ProviderAuthorizationConsentState.Value.ToString());
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

        ResourceProviderData IJsonModel<ResourceProviderData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceProviderData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceProviderData(document.RootElement, options);
        }

        internal static ResourceProviderData DeserializeResourceProviderData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> @namespace = default;
            Optional<string> registrationState = default;
            Optional<string> registrationPolicy = default;
            Optional<IReadOnlyList<ProviderResourceType>> resourceTypes = default;
            Optional<ProviderAuthorizationConsentState> providerAuthorizationConsentState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationState"u8))
                {
                    registrationState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationPolicy"u8))
                {
                    registrationPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderResourceType> array = new List<ProviderResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderResourceType.DeserializeProviderResourceType(item));
                    }
                    resourceTypes = array;
                    continue;
                }
                if (property.NameEquals("providerAuthorizationConsentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerAuthorizationConsentState = new ProviderAuthorizationConsentState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceProviderData(id.Value, @namespace.Value, registrationState.Value, registrationPolicy.Value, Optional.ToList(resourceTypes), Optional.ToNullable(providerAuthorizationConsentState), serializedAdditionalRawData);
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

            if (Optional.IsDefined(Namespace))
            {
                builder.Append("  namespace:");
                builder.AppendLine($" '{Namespace}'");
            }

            if (Optional.IsDefined(RegistrationState))
            {
                builder.Append("  registrationState:");
                builder.AppendLine($" '{RegistrationState}'");
            }

            if (Optional.IsDefined(RegistrationPolicy))
            {
                builder.Append("  registrationPolicy:");
                builder.AppendLine($" '{RegistrationPolicy}'");
            }

            if (Optional.IsCollectionDefined(ResourceTypes))
            {
                if (ResourceTypes.Any())
                {
                    builder.Append("  resourceTypes:");
                    builder.AppendLine(" [");
                    foreach (var item in ResourceTypes)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(ProviderAuthorizationConsentState))
            {
                builder.Append("  providerAuthorizationConsentState:");
                builder.AppendLine($" '{ProviderAuthorizationConsentState.ToString()}'");
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

        BinaryData IPersistableModel<ResourceProviderData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ResourceProviderData)} does not support '{options.Format}' format.");
            }
        }

        ResourceProviderData IPersistableModel<ResourceProviderData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceProviderData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ResourceProviderData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceProviderData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
