// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PublicIPDdosProtectionStatusResult : IUtf8JsonSerializable, IJsonModel<PublicIPDdosProtectionStatusResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PublicIPDdosProtectionStatusResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PublicIPDdosProtectionStatusResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PublicIPDdosProtectionStatusResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PublicIPDdosProtectionStatusResult>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PublicIPAddressId))
            {
                writer.WritePropertyName("publicIpAddressId"u8);
                writer.WriteStringValue(PublicIPAddressId);
            }
            if (Optional.IsDefined(PublicIPAddress))
            {
                writer.WritePropertyName("publicIpAddress"u8);
                writer.WriteStringValue(PublicIPAddress.ToString());
            }
            if (Optional.IsDefined(IsWorkloadProtected))
            {
                writer.WritePropertyName("isWorkloadProtected"u8);
                writer.WriteStringValue(IsWorkloadProtected.Value.ToString());
            }
            if (Optional.IsDefined(DdosProtectionPlanId))
            {
                writer.WritePropertyName("ddosProtectionPlanId"u8);
                writer.WriteStringValue(DdosProtectionPlanId);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        PublicIPDdosProtectionStatusResult IJsonModel<PublicIPDdosProtectionStatusResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PublicIPDdosProtectionStatusResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePublicIPDdosProtectionStatusResult(document.RootElement, options);
        }

        internal static PublicIPDdosProtectionStatusResult DeserializePublicIPDdosProtectionStatusResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> publicIPAddressId = default;
            Optional<IPAddress> publicIPAddress = default;
            Optional<WorkloadProtectedFlag> isWorkloadProtected = default;
            Optional<ResourceIdentifier> ddosProtectionPlanId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIpAddressId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIPAddressId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isWorkloadProtected"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWorkloadProtected = new WorkloadProtectedFlag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ddosProtectionPlanId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ddosProtectionPlanId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PublicIPDdosProtectionStatusResult(publicIPAddressId.Value, publicIPAddress.Value, Optional.ToNullable(isWorkloadProtected), ddosProtectionPlanId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PublicIPDdosProtectionStatusResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PublicIPDdosProtectionStatusResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PublicIPDdosProtectionStatusResult IPersistableModel<PublicIPDdosProtectionStatusResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PublicIPDdosProtectionStatusResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePublicIPDdosProtectionStatusResult(document.RootElement, options);
        }

        string IPersistableModel<PublicIPDdosProtectionStatusResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
