// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    [PersistableModelProxy(typeof(UnknownJobSecrets))]
    public partial class JobSecrets : IUtf8JsonSerializable, IJsonModel<JobSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobSecrets>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JobSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(JobSecrets)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("jobSecretsType"u8);
            writer.WriteStringValue(JobSecretsType.ToSerialString());
            if (options.Format != "W" && Optional.IsDefined(DataCenterAccessSecurityCode))
            {
                writer.WritePropertyName("dcAccessSecurityCode"u8);
                writer.WriteObjectValue(DataCenterAccessSecurityCode);
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
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

        JobSecrets IJsonModel<JobSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(JobSecrets)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobSecrets(document.RootElement, options);
        }

        internal static JobSecrets DeserializeJobSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobSecretsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DataBox": return DataboxJobSecrets.DeserializeDataboxJobSecrets(element);
                    case "DataBoxCustomerDisk": return CustomerDiskJobSecrets.DeserializeCustomerDiskJobSecrets(element);
                    case "DataBoxDisk": return DataBoxDiskJobSecrets.DeserializeDataBoxDiskJobSecrets(element);
                    case "DataBoxHeavy": return DataBoxHeavyJobSecrets.DeserializeDataBoxHeavyJobSecrets(element);
                }
            }
            return UnknownJobSecrets.DeserializeUnknownJobSecrets(element);
        }

        BinaryData IPersistableModel<JobSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(JobSecrets)} does not support '{options.Format}' format.");
            }
        }

        JobSecrets IPersistableModel<JobSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJobSecrets(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(JobSecrets)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JobSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
