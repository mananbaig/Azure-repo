// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridCompute;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class LicenseProfileArmEsuPropertiesWithoutAssignedLicense : IUtf8JsonSerializable, IJsonModel<LicenseProfileArmEsuPropertiesWithoutAssignedLicense>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LicenseProfileArmEsuPropertiesWithoutAssignedLicense>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LicenseProfileArmEsuPropertiesWithoutAssignedLicense>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileArmEsuPropertiesWithoutAssignedLicense>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LicenseProfileArmEsuPropertiesWithoutAssignedLicense)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ServerType))
            {
                writer.WritePropertyName("serverType"u8);
                writer.WriteStringValue(ServerType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(EsuEligibility))
            {
                writer.WritePropertyName("esuEligibility"u8);
                writer.WriteStringValue(EsuEligibility.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(EsuKeyState))
            {
                writer.WritePropertyName("esuKeyState"u8);
                writer.WriteStringValue(EsuKeyState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AssignedLicenseImmutableId))
            {
                writer.WritePropertyName("assignedLicenseImmutableId"u8);
                writer.WriteStringValue(AssignedLicenseImmutableId.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(EsuKeys))
            {
                writer.WritePropertyName("esuKeys"u8);
                writer.WriteStartArray();
                foreach (var item in EsuKeys)
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

        LicenseProfileArmEsuPropertiesWithoutAssignedLicense IJsonModel<LicenseProfileArmEsuPropertiesWithoutAssignedLicense>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileArmEsuPropertiesWithoutAssignedLicense>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LicenseProfileArmEsuPropertiesWithoutAssignedLicense)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLicenseProfileArmEsuPropertiesWithoutAssignedLicense(document.RootElement, options);
        }

        internal static LicenseProfileArmEsuPropertiesWithoutAssignedLicense DeserializeLicenseProfileArmEsuPropertiesWithoutAssignedLicense(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EsuServerType? serverType = default;
            EsuEligibility? esuEligibility = default;
            EsuKeyState? esuKeyState = default;
            Guid? assignedLicenseImmutableId = default;
            IReadOnlyList<EsuKey> esuKeys = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverType = new EsuServerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("esuEligibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    esuEligibility = new EsuEligibility(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("esuKeyState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    esuKeyState = new EsuKeyState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assignedLicenseImmutableId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignedLicenseImmutableId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("esuKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EsuKey> array = new List<EsuKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EsuKey.DeserializeEsuKey(item, options));
                    }
                    esuKeys = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LicenseProfileArmEsuPropertiesWithoutAssignedLicense(
                assignedLicenseImmutableId,
                esuKeys ?? new ChangeTrackingList<EsuKey>(),
                serializedAdditionalRawData,
                serverType,
                esuEligibility,
                esuKeyState);
        }

        BinaryData IPersistableModel<LicenseProfileArmEsuPropertiesWithoutAssignedLicense>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileArmEsuPropertiesWithoutAssignedLicense>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LicenseProfileArmEsuPropertiesWithoutAssignedLicense)} does not support '{options.Format}' format.");
            }
        }

        LicenseProfileArmEsuPropertiesWithoutAssignedLicense IPersistableModel<LicenseProfileArmEsuPropertiesWithoutAssignedLicense>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileArmEsuPropertiesWithoutAssignedLicense>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLicenseProfileArmEsuPropertiesWithoutAssignedLicense(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LicenseProfileArmEsuPropertiesWithoutAssignedLicense)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LicenseProfileArmEsuPropertiesWithoutAssignedLicense>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
