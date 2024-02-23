// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    public partial class ConfidentialLedgerProperties : IUtf8JsonSerializable, IJsonModel<ConfidentialLedgerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfidentialLedgerProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfidentialLedgerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfidentialLedgerProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && LedgerName != null)
            {
                writer.WritePropertyName("ledgerName"u8);
                writer.WriteStringValue(LedgerName);
            }
            if (options.Format != "W" && LedgerUri != null)
            {
                writer.WritePropertyName("ledgerUri"u8);
                writer.WriteStringValue(LedgerUri.AbsoluteUri);
            }
            if (options.Format != "W" && IdentityServiceUri != null)
            {
                writer.WritePropertyName("identityServiceUri"u8);
                writer.WriteStringValue(IdentityServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && LedgerInternalNamespace != null)
            {
                writer.WritePropertyName("ledgerInternalNamespace"u8);
                writer.WriteStringValue(LedgerInternalNamespace);
            }
            if (RunningState.HasValue)
            {
                writer.WritePropertyName("runningState"u8);
                writer.WriteStringValue(RunningState.Value.ToString());
            }
            if (LedgerType.HasValue)
            {
                writer.WritePropertyName("ledgerType"u8);
                writer.WriteStringValue(LedgerType.Value.ToString());
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (!(AadBasedSecurityPrincipals is ChangeTrackingList<AadBasedSecurityPrincipal> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("aadBasedSecurityPrincipals"u8);
                writer.WriteStartArray();
                foreach (var item in AadBasedSecurityPrincipals)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(CertBasedSecurityPrincipals is ChangeTrackingList<CertBasedSecurityPrincipal> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("certBasedSecurityPrincipals"u8);
                writer.WriteStartArray();
                foreach (var item in CertBasedSecurityPrincipals)
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

        ConfidentialLedgerProperties IJsonModel<ConfidentialLedgerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfidentialLedgerProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfidentialLedgerProperties(document.RootElement, options);
        }

        internal static ConfidentialLedgerProperties DeserializeConfidentialLedgerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ledgerName = default;
            Optional<Uri> ledgerUri = default;
            Optional<Uri> identityServiceUri = default;
            Optional<string> ledgerInternalNamespace = default;
            Optional<ConfidentialLedgerRunningState> runningState = default;
            Optional<ConfidentialLedgerType> ledgerType = default;
            Optional<ConfidentialLedgerProvisioningState> provisioningState = default;
            Optional<IList<AadBasedSecurityPrincipal>> aadBasedSecurityPrincipals = default;
            Optional<IList<CertBasedSecurityPrincipal>> certBasedSecurityPrincipals = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ledgerName"u8))
                {
                    ledgerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ledgerUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ledgerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ledgerInternalNamespace"u8))
                {
                    ledgerInternalNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runningState = new ConfidentialLedgerRunningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ledgerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ledgerType = new ConfidentialLedgerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ConfidentialLedgerProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aadBasedSecurityPrincipals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AadBasedSecurityPrincipal> array = new List<AadBasedSecurityPrincipal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AadBasedSecurityPrincipal.DeserializeAadBasedSecurityPrincipal(item, options));
                    }
                    aadBasedSecurityPrincipals = array;
                    continue;
                }
                if (property.NameEquals("certBasedSecurityPrincipals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CertBasedSecurityPrincipal> array = new List<CertBasedSecurityPrincipal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CertBasedSecurityPrincipal.DeserializeCertBasedSecurityPrincipal(item, options));
                    }
                    certBasedSecurityPrincipals = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConfidentialLedgerProperties(ledgerName.Value, ledgerUri.Value, identityServiceUri.Value, ledgerInternalNamespace.Value, Optional.ToNullable(runningState), Optional.ToNullable(ledgerType), Optional.ToNullable(provisioningState), Optional.ToList(aadBasedSecurityPrincipals), Optional.ToList(certBasedSecurityPrincipals), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfidentialLedgerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfidentialLedgerProperties)} does not support '{options.Format}' format.");
            }
        }

        ConfidentialLedgerProperties IPersistableModel<ConfidentialLedgerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfidentialLedgerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfidentialLedgerProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfidentialLedgerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
