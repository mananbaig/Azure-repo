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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class ClientCertificateSubjectDistinguishedName : IUtf8JsonSerializable, IJsonModel<ClientCertificateSubjectDistinguishedName>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClientCertificateSubjectDistinguishedName>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClientCertificateSubjectDistinguishedName>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ClientCertificateSubjectDistinguishedName>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ClientCertificateSubjectDistinguishedName>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CommonName))
            {
                writer.WritePropertyName("commonName"u8);
                writer.WriteStringValue(CommonName);
            }
            if (Optional.IsDefined(Organization))
            {
                writer.WritePropertyName("organization"u8);
                writer.WriteStringValue(Organization);
            }
            if (Optional.IsDefined(OrganizationUnit))
            {
                writer.WritePropertyName("organizationUnit"u8);
                writer.WriteStringValue(OrganizationUnit);
            }
            if (Optional.IsDefined(CountryCode))
            {
                writer.WritePropertyName("countryCode"u8);
                writer.WriteStringValue(CountryCode);
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

        ClientCertificateSubjectDistinguishedName IJsonModel<ClientCertificateSubjectDistinguishedName>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ClientCertificateSubjectDistinguishedName)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClientCertificateSubjectDistinguishedName(document.RootElement, options);
        }

        internal static ClientCertificateSubjectDistinguishedName DeserializeClientCertificateSubjectDistinguishedName(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> commonName = default;
            Optional<string> organization = default;
            Optional<string> organizationUnit = default;
            Optional<string> countryCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commonName"u8))
                {
                    commonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organization"u8))
                {
                    organization = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationUnit"u8))
                {
                    organizationUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryCode"u8))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClientCertificateSubjectDistinguishedName(commonName.Value, organization.Value, organizationUnit.Value, countryCode.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClientCertificateSubjectDistinguishedName>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ClientCertificateSubjectDistinguishedName)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ClientCertificateSubjectDistinguishedName IPersistableModel<ClientCertificateSubjectDistinguishedName>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ClientCertificateSubjectDistinguishedName)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeClientCertificateSubjectDistinguishedName(document.RootElement, options);
        }

        string IPersistableModel<ClientCertificateSubjectDistinguishedName>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
