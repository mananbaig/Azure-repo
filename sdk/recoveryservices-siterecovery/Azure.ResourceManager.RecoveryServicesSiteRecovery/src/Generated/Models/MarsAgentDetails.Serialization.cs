// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class MarsAgentDetails : IUtf8JsonSerializable, IJsonModel<MarsAgentDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MarsAgentDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MarsAgentDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarsAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarsAgentDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(BiosId))
            {
                writer.WritePropertyName("biosId"u8);
                writer.WriteStringValue(BiosId);
            }
            if (options.Format != "W" && Optional.IsDefined(FabricObjectId))
            {
                writer.WritePropertyName("fabricObjectId"u8);
                writer.WriteStringValue(FabricObjectId);
            }
            if (options.Format != "W" && Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(LastHeartbeatReceivedOn))
            {
                writer.WritePropertyName("lastHeartbeatUtc"u8);
                writer.WriteStringValue(LastHeartbeatReceivedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Health))
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        MarsAgentDetails IJsonModel<MarsAgentDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarsAgentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarsAgentDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMarsAgentDetails(document.RootElement, options);
        }

        internal static MarsAgentDetails DeserializeMarsAgentDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            string biosId = default;
            ResourceIdentifier fabricObjectId = default;
            string fqdn = default;
            string version = default;
            DateTimeOffset? lastHeartbeatUtc = default;
            SiteRecoveryProtectionHealth? health = default;
            IReadOnlyList<SiteRecoveryHealthError> healthErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricObjectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeatUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeatUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new SiteRecoveryProtectionHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    healthErrors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MarsAgentDetails(
                id,
                name,
                biosId,
                fabricObjectId,
                fqdn,
                version,
                lastHeartbeatUtc,
                health,
                healthErrors ?? new ChangeTrackingList<SiteRecoveryHealthError>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MarsAgentDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarsAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MarsAgentDetails)} does not support '{options.Format}' format.");
            }
        }

        MarsAgentDetails IPersistableModel<MarsAgentDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarsAgentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMarsAgentDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MarsAgentDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MarsAgentDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
