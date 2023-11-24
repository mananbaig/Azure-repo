// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class IscsiTargetInfo : IUtf8JsonSerializable, IJsonModel<IscsiTargetInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IscsiTargetInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IscsiTargetInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IscsiTargetInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(IscsiTargetInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TargetIqn))
            {
                writer.WritePropertyName("targetIqn"u8);
                writer.WriteStringValue(TargetIqn);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetPortalHostname))
            {
                writer.WritePropertyName("targetPortalHostname"u8);
                writer.WriteStringValue(TargetPortalHostname);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetPortalPort))
            {
                writer.WritePropertyName("targetPortalPort"u8);
                writer.WriteNumberValue(TargetPortalPort.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        IscsiTargetInfo IJsonModel<IscsiTargetInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IscsiTargetInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(IscsiTargetInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIscsiTargetInfo(document.RootElement, options);
        }

        internal static IscsiTargetInfo DeserializeIscsiTargetInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> targetIqn = default;
            Optional<string> targetPortalHostname = default;
            Optional<int> targetPortalPort = default;
            Optional<ElasticSanProvisioningState> provisioningState = default;
            Optional<ResourceOperationalStatus> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetIqn"u8))
                {
                    targetIqn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetPortalHostname"u8))
                {
                    targetPortalHostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetPortalPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetPortalPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ElasticSanProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ResourceOperationalStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IscsiTargetInfo(targetIqn.Value, targetPortalHostname.Value, Optional.ToNullable(targetPortalPort), Optional.ToNullable(provisioningState), Optional.ToNullable(status), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IscsiTargetInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IscsiTargetInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(IscsiTargetInfo)} does not support '{options.Format}' format.");
            }
        }

        IscsiTargetInfo IPersistableModel<IscsiTargetInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IscsiTargetInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIscsiTargetInfo(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(IscsiTargetInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IscsiTargetInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
