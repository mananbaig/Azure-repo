// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ArmApplicationHealthPolicy : IUtf8JsonSerializable, IJsonModel<ArmApplicationHealthPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmApplicationHealthPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArmApplicationHealthPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmApplicationHealthPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ConsiderWarningAsError))
            {
                writer.WritePropertyName("considerWarningAsError"u8);
                writer.WriteBooleanValue(ConsiderWarningAsError.Value);
            }
            if (Optional.IsDefined(MaxPercentUnhealthyDeployedApplications))
            {
                writer.WritePropertyName("maxPercentUnhealthyDeployedApplications"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyDeployedApplications.Value);
            }
            if (Optional.IsDefined(DefaultServiceTypeHealthPolicy))
            {
                writer.WritePropertyName("defaultServiceTypeHealthPolicy"u8);
                writer.WriteObjectValue(DefaultServiceTypeHealthPolicy, options);
            }
            if (Optional.IsCollectionDefined(ServiceTypeHealthPolicyMap))
            {
                writer.WritePropertyName("serviceTypeHealthPolicyMap"u8);
                writer.WriteStartObject();
                foreach (var item in ServiceTypeHealthPolicyMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
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

        ArmApplicationHealthPolicy IJsonModel<ArmApplicationHealthPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmApplicationHealthPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmApplicationHealthPolicy(document.RootElement, options);
        }

        internal static ArmApplicationHealthPolicy DeserializeArmApplicationHealthPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? considerWarningAsError = default;
            int? maxPercentUnhealthyDeployedApplications = default;
            ArmServiceTypeHealthPolicy defaultServiceTypeHealthPolicy = default;
            IDictionary<string, ArmServiceTypeHealthPolicy> serviceTypeHealthPolicyMap = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("considerWarningAsError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    considerWarningAsError = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyDeployedApplications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyDeployedApplications = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("defaultServiceTypeHealthPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultServiceTypeHealthPolicy = ArmServiceTypeHealthPolicy.DeserializeArmServiceTypeHealthPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serviceTypeHealthPolicyMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ArmServiceTypeHealthPolicy> dictionary = new Dictionary<string, ArmServiceTypeHealthPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ArmServiceTypeHealthPolicy.DeserializeArmServiceTypeHealthPolicy(property0.Value, options));
                    }
                    serviceTypeHealthPolicyMap = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ArmApplicationHealthPolicy(considerWarningAsError, maxPercentUnhealthyDeployedApplications, defaultServiceTypeHealthPolicy, serviceTypeHealthPolicyMap ?? new ChangeTrackingDictionary<string, ArmServiceTypeHealthPolicy>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArmApplicationHealthPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArmApplicationHealthPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ArmApplicationHealthPolicy IPersistableModel<ArmApplicationHealthPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmApplicationHealthPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmApplicationHealthPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmApplicationHealthPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
