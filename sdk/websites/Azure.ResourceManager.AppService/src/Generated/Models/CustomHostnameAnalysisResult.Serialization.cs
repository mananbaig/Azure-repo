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
    public partial class CustomHostnameAnalysisResult : IUtf8JsonSerializable, IJsonModel<CustomHostnameAnalysisResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomHostnameAnalysisResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomHostnameAnalysisResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support writing '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(IsHostnameAlreadyVerified))
            {
                writer.WritePropertyName("isHostnameAlreadyVerified"u8);
                writer.WriteBooleanValue(IsHostnameAlreadyVerified.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomDomainVerificationTest))
            {
                writer.WritePropertyName("customDomainVerificationTest"u8);
                writer.WriteStringValue(CustomDomainVerificationTest.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(CustomDomainVerificationFailureInfo))
            {
                writer.WritePropertyName("customDomainVerificationFailureInfo"u8);
                JsonSerializer.Serialize(writer, CustomDomainVerificationFailureInfo);
            }
            if (options.Format != "W" && Optional.IsDefined(HasConflictOnScaleUnit))
            {
                writer.WritePropertyName("hasConflictOnScaleUnit"u8);
                writer.WriteBooleanValue(HasConflictOnScaleUnit.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(HasConflictAcrossSubscription))
            {
                writer.WritePropertyName("hasConflictAcrossSubscription"u8);
                writer.WriteBooleanValue(HasConflictAcrossSubscription.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConflictingAppResourceId))
            {
                writer.WritePropertyName("conflictingAppResourceId"u8);
                writer.WriteStringValue(ConflictingAppResourceId);
            }
            if (Optional.IsCollectionDefined(CNameRecords))
            {
                writer.WritePropertyName("cNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in CNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TxtRecords))
            {
                writer.WritePropertyName("txtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in TxtRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ARecords))
            {
                writer.WritePropertyName("aRecords"u8);
                writer.WriteStartArray();
                foreach (var item in ARecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlternateCNameRecords))
            {
                writer.WritePropertyName("alternateCNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateCNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlternateTxtRecords))
            {
                writer.WritePropertyName("alternateTxtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateTxtRecords)
                {
                    writer.WriteStringValue(item);
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

        CustomHostnameAnalysisResult IJsonModel<CustomHostnameAnalysisResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomHostnameAnalysisResult(document.RootElement, options);
        }

        internal static CustomHostnameAnalysisResult DeserializeCustomHostnameAnalysisResult(JsonElement element, ModelReaderWriterOptions options = null)
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
            bool? isHostnameAlreadyVerified = default;
            DnsVerificationTestResult? customDomainVerificationTest = default;
            ResponseError customDomainVerificationFailureInfo = default;
            bool? hasConflictOnScaleUnit = default;
            bool? hasConflictAcrossSubscription = default;
            string conflictingAppResourceId = default;
            IList<string> cNameRecords = default;
            IList<string> txtRecords = default;
            IList<string> aRecords = default;
            IList<string> alternateCNameRecords = default;
            IList<string> alternateTxtRecords = default;
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
                        if (property0.NameEquals("isHostnameAlreadyVerified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isHostnameAlreadyVerified = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("customDomainVerificationTest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customDomainVerificationTest = property0.Value.GetString().ToDnsVerificationTestResult();
                            continue;
                        }
                        if (property0.NameEquals("customDomainVerificationFailureInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customDomainVerificationFailureInfo = JsonSerializer.Deserialize<ResponseError>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hasConflictOnScaleUnit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasConflictOnScaleUnit = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hasConflictAcrossSubscription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasConflictAcrossSubscription = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("conflictingAppResourceId"u8))
                        {
                            conflictingAppResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cNameRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            cNameRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("txtRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            txtRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("aRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            aRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("alternateCNameRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            alternateCNameRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("alternateTxtRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            alternateTxtRecords = array;
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
            return new CustomHostnameAnalysisResult(
                id,
                name,
                type,
                systemData,
                isHostnameAlreadyVerified,
                customDomainVerificationTest,
                customDomainVerificationFailureInfo,
                hasConflictOnScaleUnit,
                hasConflictAcrossSubscription,
                conflictingAppResourceId,
                cNameRecords ?? new ChangeTrackingList<string>(),
                txtRecords ?? new ChangeTrackingList<string>(),
                aRecords ?? new ChangeTrackingList<string>(),
                alternateCNameRecords ?? new ChangeTrackingList<string>(),
                alternateTxtRecords ?? new ChangeTrackingList<string>(),
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomHostnameAnalysisResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support writing '{options.Format}' format.");
            }
        }

        CustomHostnameAnalysisResult IPersistableModel<CustomHostnameAnalysisResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomHostnameAnalysisResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomHostnameAnalysisResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
