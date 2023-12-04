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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CapacityReservationPatch : IUtf8JsonSerializable, IJsonModel<CapacityReservationPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CapacityReservationPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CapacityReservationPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityReservationPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CapacityReservationPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ReservationId))
            {
                writer.WritePropertyName("reservationId"u8);
                writer.WriteStringValue(ReservationId);
            }
            if (options.Format != "W" && Optional.IsDefined(PlatformFaultDomainCount))
            {
                writer.WritePropertyName("platformFaultDomainCount"u8);
                writer.WriteNumberValue(PlatformFaultDomainCount.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VirtualMachinesAssociated))
            {
                writer.WritePropertyName("virtualMachinesAssociated"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualMachinesAssociated)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningOn))
            {
                writer.WritePropertyName("provisioningTime"u8);
                writer.WriteStringValue(ProvisioningOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceView))
            {
                writer.WritePropertyName("instanceView"u8);
                writer.WriteObjectValue(InstanceView);
            }
            if (options.Format != "W" && Optional.IsDefined(TimeCreated))
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(TimeCreated.Value, "O");
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

        CapacityReservationPatch IJsonModel<CapacityReservationPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityReservationPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CapacityReservationPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCapacityReservationPatch(document.RootElement, options);
        }

        internal static CapacityReservationPatch DeserializeCapacityReservationPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ComputeSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> reservationId = default;
            Optional<int> platformFaultDomainCount = default;
            Optional<IReadOnlyList<SubResource>> virtualMachinesAssociated = default;
            Optional<DateTimeOffset> provisioningTime = default;
            Optional<string> provisioningState = default;
            Optional<CapacityReservationInstanceView> instanceView = default;
            Optional<DateTimeOffset> timeCreated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ComputeSku.DeserializeComputeSku(property.Value);
                    continue;
                }
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("reservationId"u8))
                        {
                            reservationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("platformFaultDomainCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platformFaultDomainCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachinesAssociated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                            }
                            virtualMachinesAssociated = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = CapacityReservationInstanceView.DeserializeCapacityReservationInstanceView(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("timeCreated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeCreated = property0.Value.GetDateTimeOffset("O");
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
            return new CapacityReservationPatch(Optional.ToDictionary(tags), serializedAdditionalRawData, sku.Value, reservationId.Value, Optional.ToNullable(platformFaultDomainCount), Optional.ToList(virtualMachinesAssociated), Optional.ToNullable(provisioningTime), provisioningState.Value, instanceView.Value, Optional.ToNullable(timeCreated));
        }

        BinaryData IPersistableModel<CapacityReservationPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityReservationPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CapacityReservationPatch)} does not support '{options.Format}' format.");
            }
        }

        CapacityReservationPatch IPersistableModel<CapacityReservationPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityReservationPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCapacityReservationPatch(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CapacityReservationPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CapacityReservationPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
