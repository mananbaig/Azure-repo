// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CdnOriginGroupPatch : IUtf8JsonSerializable, IJsonModel<CdnOriginGroupPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CdnOriginGroupPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CdnOriginGroupPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnOriginGroupPatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(HealthProbeSettings))
            {
                if (HealthProbeSettings != null)
                {
                    writer.WritePropertyName("healthProbeSettings"u8);
                    writer.WriteObjectValue(HealthProbeSettings, options);
                }
                else
                {
                    writer.WriteNull("healthProbeSettings");
                }
            }
            if (Optional.IsCollectionDefined(Origins))
            {
                writer.WritePropertyName("origins"u8);
                writer.WriteStartArray();
                foreach (var item in Origins)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrafficRestorationTimeToHealedOrNewEndpointsInMinutes))
            {
                if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes != null)
                {
                    writer.WritePropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"u8);
                    writer.WriteNumberValue(TrafficRestorationTimeToHealedOrNewEndpointsInMinutes.Value);
                }
                else
                {
                    writer.WriteNull("trafficRestorationTimeToHealedOrNewEndpointsInMinutes");
                }
            }
            if (Optional.IsDefined(ResponseBasedOriginErrorDetectionSettings))
            {
                if (ResponseBasedOriginErrorDetectionSettings != null)
                {
                    writer.WritePropertyName("responseBasedOriginErrorDetectionSettings"u8);
                    writer.WriteObjectValue(ResponseBasedOriginErrorDetectionSettings, options);
                }
                else
                {
                    writer.WriteNull("responseBasedOriginErrorDetectionSettings");
                }
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

        CdnOriginGroupPatch IJsonModel<CdnOriginGroupPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnOriginGroupPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnOriginGroupPatch(document.RootElement, options);
        }

        internal static CdnOriginGroupPatch DeserializeCdnOriginGroupPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthProbeSettings healthProbeSettings = default;
            IList<WritableSubResource> origins = default;
            int? trafficRestorationTimeToHealedOrNewEndpointsInMinutes = default;
            ResponseBasedOriginErrorDetectionSettings responseBasedOriginErrorDetectionSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("healthProbeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                healthProbeSettings = null;
                                continue;
                            }
                            healthProbeSettings = HealthProbeSettings.DeserializeHealthProbeSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("origins"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            origins = array;
                            continue;
                        }
                        if (property0.NameEquals("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                trafficRestorationTimeToHealedOrNewEndpointsInMinutes = null;
                                continue;
                            }
                            trafficRestorationTimeToHealedOrNewEndpointsInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("responseBasedOriginErrorDetectionSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                responseBasedOriginErrorDetectionSettings = null;
                                continue;
                            }
                            responseBasedOriginErrorDetectionSettings = ResponseBasedOriginErrorDetectionSettings.DeserializeResponseBasedOriginErrorDetectionSettings(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CdnOriginGroupPatch(healthProbeSettings, origins ?? new ChangeTrackingList<WritableSubResource>(), trafficRestorationTimeToHealedOrNewEndpointsInMinutes, responseBasedOriginErrorDetectionSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CdnOriginGroupPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CdnOriginGroupPatch)} does not support writing '{options.Format}' format.");
            }
        }

        CdnOriginGroupPatch IPersistableModel<CdnOriginGroupPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnOriginGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCdnOriginGroupPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CdnOriginGroupPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CdnOriginGroupPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
