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

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingProductProperties : IUtf8JsonSerializable, IJsonModel<BillingProductProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingProductProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingProductProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingProductProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingProductProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AutoRenew))
            {
                writer.WritePropertyName("autoRenew"u8);
                writer.WriteStringValue(AutoRenew.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AvailabilityId))
            {
                writer.WritePropertyName("availabilityId"u8);
                writer.WriteStringValue(AvailabilityId);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingFrequency))
            {
                writer.WritePropertyName("billingFrequency"u8);
                writer.WriteStringValue(BillingFrequency);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileId))
            {
                writer.WritePropertyName("billingProfileId"u8);
                writer.WriteStringValue(BillingProfileId);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileDisplayName))
            {
                writer.WritePropertyName("billingProfileDisplayName"u8);
                writer.WriteStringValue(BillingProfileDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomerId))
            {
                writer.WritePropertyName("customerId"u8);
                writer.WriteStringValue(CustomerId);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomerDisplayName))
            {
                writer.WritePropertyName("customerDisplayName"u8);
                writer.WriteStringValue(CustomerDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(EndDate))
            {
                writer.WritePropertyName("endDate"u8);
                writer.WriteStringValue(EndDate);
            }
            if (options.Format != "W" && Optional.IsDefined(InvoiceSectionId))
            {
                writer.WritePropertyName("invoiceSectionId"u8);
                writer.WriteStringValue(InvoiceSectionId);
            }
            if (options.Format != "W" && Optional.IsDefined(InvoiceSectionDisplayName))
            {
                writer.WritePropertyName("invoiceSectionDisplayName"u8);
                writer.WriteStringValue(InvoiceSectionDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(LastCharge))
            {
                writer.WritePropertyName("lastCharge"u8);
                writer.WriteObjectValue(LastCharge, options);
            }
            if (options.Format != "W" && Optional.IsDefined(LastChargeDate))
            {
                writer.WritePropertyName("lastChargeDate"u8);
                writer.WriteStringValue(LastChargeDate);
            }
            if (options.Format != "W" && Optional.IsDefined(ProductType))
            {
                writer.WritePropertyName("productType"u8);
                writer.WriteStringValue(ProductType);
            }
            if (options.Format != "W" && Optional.IsDefined(ProductTypeId))
            {
                writer.WritePropertyName("productTypeId"u8);
                writer.WriteStringValue(ProductTypeId);
            }
            if (options.Format != "W" && Optional.IsDefined(SkuId))
            {
                writer.WritePropertyName("skuId"u8);
                writer.WriteStringValue(SkuId);
            }
            if (options.Format != "W" && Optional.IsDefined(SkuDescription))
            {
                writer.WritePropertyName("skuDescription"u8);
                writer.WriteStringValue(SkuDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(PurchaseDate))
            {
                writer.WritePropertyName("purchaseDate"u8);
                writer.WriteStringValue(PurchaseDate);
            }
            if (options.Format != "W" && Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Reseller))
            {
                writer.WritePropertyName("reseller"u8);
                writer.WriteObjectValue(Reseller, options);
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
        }

        BillingProductProperties IJsonModel<BillingProductProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingProductProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingProductProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingProductProperties(document.RootElement, options);
        }

        internal static BillingProductProperties DeserializeBillingProductProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingSubscriptionAutoRenewState? autoRenew = default;
            string availabilityId = default;
            string billingFrequency = default;
            ResourceIdentifier billingProfileId = default;
            string billingProfileDisplayName = default;
            ResourceIdentifier customerId = default;
            string customerDisplayName = default;
            string displayName = default;
            string endDate = default;
            ResourceIdentifier invoiceSectionId = default;
            string invoiceSectionDisplayName = default;
            BillingAmount lastCharge = default;
            string lastChargeDate = default;
            string productType = default;
            string productTypeId = default;
            string skuId = default;
            string skuDescription = default;
            string purchaseDate = default;
            long? quantity = default;
            BillingProductStatus? status = default;
            Guid? tenantId = default;
            BillingAmount reseller = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoRenew"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoRenew = new BillingSubscriptionAutoRenewState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("availabilityId"u8))
                {
                    availabilityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingFrequency"u8))
                {
                    billingFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingProfileId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingProfileId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingProfileDisplayName"u8))
                {
                    billingProfileDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customerDisplayName"u8))
                {
                    customerDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endDate"u8))
                {
                    endDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("invoiceSectionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invoiceSectionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("invoiceSectionDisplayName"u8))
                {
                    invoiceSectionDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCharge"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastCharge = BillingAmount.DeserializeBillingAmount(property.Value, options);
                    continue;
                }
                if (property.NameEquals("lastChargeDate"u8))
                {
                    lastChargeDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productType"u8))
                {
                    productType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productTypeId"u8))
                {
                    productTypeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuId"u8))
                {
                    skuId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuDescription"u8))
                {
                    skuDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("purchaseDate"u8))
                {
                    purchaseDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quantity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new BillingProductStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("reseller"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reseller = BillingAmount.DeserializeBillingAmount(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingProductProperties(
                autoRenew,
                availabilityId,
                billingFrequency,
                billingProfileId,
                billingProfileDisplayName,
                customerId,
                customerDisplayName,
                displayName,
                endDate,
                invoiceSectionId,
                invoiceSectionDisplayName,
                lastCharge,
                lastChargeDate,
                productType,
                productTypeId,
                skuId,
                skuDescription,
                purchaseDate,
                quantity,
                status,
                tenantId,
                reseller,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AutoRenew), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  autoRenew: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AutoRenew))
                {
                    builder.Append("  autoRenew: ");
                    builder.AppendLine($"'{AutoRenew.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AvailabilityId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  availabilityId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AvailabilityId))
                {
                    builder.Append("  availabilityId: ");
                    if (AvailabilityId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AvailabilityId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AvailabilityId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingFrequency), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingFrequency: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingFrequency))
                {
                    builder.Append("  billingFrequency: ");
                    if (BillingFrequency.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BillingFrequency}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BillingFrequency}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingProfileId))
                {
                    builder.Append("  billingProfileId: ");
                    builder.AppendLine($"'{BillingProfileId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileDisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileDisplayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingProfileDisplayName))
                {
                    builder.Append("  billingProfileDisplayName: ");
                    if (BillingProfileDisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BillingProfileDisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BillingProfileDisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomerId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  customerId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomerId))
                {
                    builder.Append("  customerId: ");
                    builder.AppendLine($"'{CustomerId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomerDisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  customerDisplayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomerDisplayName))
                {
                    builder.Append("  customerDisplayName: ");
                    if (CustomerDisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CustomerDisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CustomerDisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("  displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndDate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndDate))
                {
                    builder.Append("  endDate: ");
                    if (EndDate.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EndDate}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EndDate}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InvoiceSectionId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  invoiceSectionId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InvoiceSectionId))
                {
                    builder.Append("  invoiceSectionId: ");
                    builder.AppendLine($"'{InvoiceSectionId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InvoiceSectionDisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  invoiceSectionDisplayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InvoiceSectionDisplayName))
                {
                    builder.Append("  invoiceSectionDisplayName: ");
                    if (InvoiceSectionDisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{InvoiceSectionDisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{InvoiceSectionDisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastCharge), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastCharge: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastCharge))
                {
                    builder.Append("  lastCharge: ");
                    BicepSerializationHelpers.AppendChildObject(builder, LastCharge, options, 2, false, "  lastCharge: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastChargeDate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastChargeDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastChargeDate))
                {
                    builder.Append("  lastChargeDate: ");
                    if (LastChargeDate.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastChargeDate}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastChargeDate}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProductType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  productType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProductType))
                {
                    builder.Append("  productType: ");
                    if (ProductType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProductType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProductType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProductTypeId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  productTypeId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProductTypeId))
                {
                    builder.Append("  productTypeId: ");
                    if (ProductTypeId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProductTypeId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProductTypeId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SkuId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  skuId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SkuId))
                {
                    builder.Append("  skuId: ");
                    if (SkuId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SkuId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SkuId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SkuDescription), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  skuDescription: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SkuDescription))
                {
                    builder.Append("  skuDescription: ");
                    if (SkuDescription.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SkuDescription}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SkuDescription}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PurchaseDate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  purchaseDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PurchaseDate))
                {
                    builder.Append("  purchaseDate: ");
                    if (PurchaseDate.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PurchaseDate}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PurchaseDate}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Quantity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  quantity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Quantity))
                {
                    builder.Append("  quantity: ");
                    builder.AppendLine($"'{Quantity.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    builder.AppendLine($"'{Status.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TenantId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tenantId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TenantId))
                {
                    builder.Append("  tenantId: ");
                    builder.AppendLine($"'{TenantId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Reseller), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  reseller: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Reseller))
                {
                    builder.Append("  reseller: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Reseller, options, 2, false, "  reseller: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BillingProductProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingProductProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BillingProductProperties)} does not support writing '{options.Format}' format.");
            }
        }

        BillingProductProperties IPersistableModel<BillingProductProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingProductProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingProductProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingProductProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingProductProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
