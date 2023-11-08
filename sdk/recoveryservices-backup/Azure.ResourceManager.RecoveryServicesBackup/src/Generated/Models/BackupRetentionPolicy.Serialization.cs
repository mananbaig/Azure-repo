// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [ModelReaderProxy(typeof(UnknownRetentionPolicy))]
    public partial class BackupRetentionPolicy : IUtf8JsonSerializable, IJsonModel<BackupRetentionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupRetentionPolicy>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<BackupRetentionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("retentionPolicyType"u8);
            writer.WriteStringValue(RetentionPolicyType);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        BackupRetentionPolicy IJsonModel<BackupRetentionPolicy>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupRetentionPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupRetentionPolicy(document.RootElement, options);
        }

        internal static BackupRetentionPolicy DeserializeBackupRetentionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("retentionPolicyType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "LongTermRetentionPolicy": return LongTermRetentionPolicy.DeserializeLongTermRetentionPolicy(element);
                    case "SimpleRetentionPolicy": return SimpleRetentionPolicy.DeserializeSimpleRetentionPolicy(element);
                }
            }
            return UnknownRetentionPolicy.DeserializeUnknownRetentionPolicy(element);
        }

        BinaryData IModel<BackupRetentionPolicy>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupRetentionPolicy)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BackupRetentionPolicy IModel<BackupRetentionPolicy>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupRetentionPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBackupRetentionPolicy(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<BackupRetentionPolicy>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
