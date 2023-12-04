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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionReservationTransaction : IUtf8JsonSerializable, IJsonModel<ConsumptionReservationTransaction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionReservationTransaction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionReservationTransaction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationTransaction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ConsumptionReservationTransaction)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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
            if (options.Format != "W" && Optional.IsDefined(TransactOn))
            {
                writer.WritePropertyName("eventDate"u8);
                writer.WriteStringValue(TransactOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ReservationOrderId))
            {
                writer.WritePropertyName("reservationOrderId"u8);
                writer.WriteStringValue(ReservationOrderId);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteStringValue(EventType);
            }
            if (options.Format != "W" && Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Currency))
            {
                writer.WritePropertyName("currency"u8);
                writer.WriteStringValue(Currency);
            }
            if (options.Format != "W" && Optional.IsDefined(ReservationOrderName))
            {
                writer.WritePropertyName("reservationOrderName"u8);
                writer.WriteStringValue(ReservationOrderName);
            }
            if (options.Format != "W" && Optional.IsDefined(PurchasingEnrollment))
            {
                writer.WritePropertyName("purchasingEnrollment"u8);
                writer.WriteStringValue(PurchasingEnrollment);
            }
            if (options.Format != "W" && Optional.IsDefined(PurchasingSubscriptionGuid))
            {
                writer.WritePropertyName("purchasingSubscriptionGuid"u8);
                writer.WriteStringValue(PurchasingSubscriptionGuid.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PurchasingSubscriptionName))
            {
                writer.WritePropertyName("purchasingSubscriptionName"u8);
                writer.WriteStringValue(PurchasingSubscriptionName);
            }
            if (options.Format != "W" && Optional.IsDefined(ArmSkuName))
            {
                writer.WritePropertyName("armSkuName"u8);
                writer.WriteStringValue(ArmSkuName);
            }
            if (options.Format != "W" && Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term);
            }
            if (options.Format != "W" && Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (options.Format != "W" && Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (options.Format != "W" && Optional.IsDefined(AccountOwnerEmail))
            {
                writer.WritePropertyName("accountOwnerEmail"u8);
                writer.WriteStringValue(AccountOwnerEmail);
            }
            if (options.Format != "W" && Optional.IsDefined(DepartmentName))
            {
                writer.WritePropertyName("departmentName"u8);
                writer.WriteStringValue(DepartmentName);
            }
            if (options.Format != "W" && Optional.IsDefined(CostCenter))
            {
                writer.WritePropertyName("costCenter"u8);
                writer.WriteStringValue(CostCenter);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentEnrollment))
            {
                writer.WritePropertyName("currentEnrollment"u8);
                writer.WriteStringValue(CurrentEnrollment);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingFrequency))
            {
                writer.WritePropertyName("billingFrequency"u8);
                writer.WriteStringValue(BillingFrequency);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingMonth))
            {
                writer.WritePropertyName("billingMonth"u8);
                writer.WriteNumberValue(BillingMonth.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MonetaryCommitment))
            {
                writer.WritePropertyName("monetaryCommitment"u8);
                writer.WriteNumberValue(MonetaryCommitment.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Overage))
            {
                writer.WritePropertyName("overage"u8);
                writer.WriteNumberValue(Overage.Value);
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

        ConsumptionReservationTransaction IJsonModel<ConsumptionReservationTransaction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationTransaction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ConsumptionReservationTransaction)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionReservationTransaction(document.RootElement, options);
        }

        internal static ConsumptionReservationTransaction DeserializeConsumptionReservationTransaction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> eventDate = default;
            Optional<string> reservationOrderId = default;
            Optional<string> description = default;
            Optional<string> eventType = default;
            Optional<decimal> quantity = default;
            Optional<decimal> amount = default;
            Optional<string> currency = default;
            Optional<string> reservationOrderName = default;
            Optional<string> purchasingEnrollment = default;
            Optional<Guid> purchasingSubscriptionGuid = default;
            Optional<string> purchasingSubscriptionName = default;
            Optional<string> armSkuName = default;
            Optional<string> term = default;
            Optional<string> region = default;
            Optional<string> accountName = default;
            Optional<string> accountOwnerEmail = default;
            Optional<string> departmentName = default;
            Optional<string> costCenter = default;
            Optional<string> currentEnrollment = default;
            Optional<string> billingFrequency = default;
            Optional<int> billingMonth = default;
            Optional<decimal> monetaryCommitment = default;
            Optional<decimal> overage = default;
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
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tags = array;
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
                        if (property0.NameEquals("eventDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("reservationOrderId"u8))
                        {
                            reservationOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eventType"u8))
                        {
                            eventType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("quantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("amount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            amount = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("currency"u8))
                        {
                            currency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationOrderName"u8))
                        {
                            reservationOrderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchasingEnrollment"u8))
                        {
                            purchasingEnrollment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchasingSubscriptionGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchasingSubscriptionGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("purchasingSubscriptionName"u8))
                        {
                            purchasingSubscriptionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("armSkuName"u8))
                        {
                            armSkuName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            term = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("region"u8))
                        {
                            region = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountOwnerEmail"u8))
                        {
                            accountOwnerEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("departmentName"u8))
                        {
                            departmentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costCenter"u8))
                        {
                            costCenter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentEnrollment"u8))
                        {
                            currentEnrollment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingFrequency"u8))
                        {
                            billingFrequency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingMonth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingMonth = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("monetaryCommitment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monetaryCommitment = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("overage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overage = property0.Value.GetDecimal();
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
            return new ConsumptionReservationTransaction(id, name, type, systemData.Value, Optional.ToNullable(eventDate), reservationOrderId.Value, description.Value, eventType.Value, Optional.ToNullable(quantity), Optional.ToNullable(amount), currency.Value, reservationOrderName.Value, purchasingEnrollment.Value, Optional.ToNullable(purchasingSubscriptionGuid), purchasingSubscriptionName.Value, armSkuName.Value, term.Value, region.Value, accountName.Value, accountOwnerEmail.Value, departmentName.Value, costCenter.Value, currentEnrollment.Value, billingFrequency.Value, Optional.ToNullable(billingMonth), Optional.ToNullable(monetaryCommitment), Optional.ToNullable(overage), Optional.ToList(tags), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionReservationTransaction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationTransaction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ConsumptionReservationTransaction)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionReservationTransaction IPersistableModel<ConsumptionReservationTransaction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationTransaction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionReservationTransaction(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ConsumptionReservationTransaction)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionReservationTransaction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
