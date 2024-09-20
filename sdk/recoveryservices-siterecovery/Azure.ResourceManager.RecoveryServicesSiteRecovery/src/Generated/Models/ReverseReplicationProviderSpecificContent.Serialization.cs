// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownReverseReplicationProviderSpecificContent))]
    public partial class ReverseReplicationProviderSpecificContent : IUtf8JsonSerializable, IJsonModel<ReverseReplicationProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReverseReplicationProviderSpecificContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ReverseReplicationProviderSpecificContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReverseReplicationProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReverseReplicationProviderSpecificContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        ReverseReplicationProviderSpecificContent IJsonModel<ReverseReplicationProviderSpecificContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReverseReplicationProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReverseReplicationProviderSpecificContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReverseReplicationProviderSpecificContent(document.RootElement, options);
        }

        internal static ReverseReplicationProviderSpecificContent DeserializeReverseReplicationProviderSpecificContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2AReprotectContent.DeserializeA2AReprotectContent(element, options);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureReprotectContent.DeserializeHyperVReplicaAzureReprotectContent(element, options);
                    case "InMage": return InMageReprotectContent.DeserializeInMageReprotectContent(element, options);
                    case "InMageAzureV2": return InMageAzureV2ReprotectContent.DeserializeInMageAzureV2ReprotectContent(element, options);
                    case "InMageRcm": return InMageRcmReprotectContent.DeserializeInMageRcmReprotectContent(element, options);
                    case "InMageRcmFailback": return InMageRcmFailbackReprotectContent.DeserializeInMageRcmFailbackReprotectContent(element, options);
                }
            }
            return UnknownReverseReplicationProviderSpecificContent.DeserializeUnknownReverseReplicationProviderSpecificContent(element, options);
        }

        BinaryData IPersistableModel<ReverseReplicationProviderSpecificContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReverseReplicationProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReverseReplicationProviderSpecificContent)} does not support writing '{options.Format}' format.");
            }
        }

        ReverseReplicationProviderSpecificContent IPersistableModel<ReverseReplicationProviderSpecificContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReverseReplicationProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReverseReplicationProviderSpecificContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReverseReplicationProviderSpecificContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReverseReplicationProviderSpecificContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
