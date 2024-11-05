// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtNicContent : IUtf8JsonSerializable, IJsonModel<VMwareCbtNicContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareCbtNicContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VMwareCbtNicContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtNicContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtNicContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("nicId"u8);
            writer.WriteStringValue(NicId);
            writer.WritePropertyName("isPrimaryNic"u8);
            writer.WriteStringValue(IsPrimaryNic);
            if (Optional.IsDefined(TargetSubnetName))
            {
                writer.WritePropertyName("targetSubnetName"u8);
                writer.WriteStringValue(TargetSubnetName);
            }
            if (Optional.IsDefined(TargetStaticIPAddress))
            {
                writer.WritePropertyName("targetStaticIPAddress"u8);
                writer.WriteStringValue(TargetStaticIPAddress.ToString());
            }
            if (Optional.IsDefined(IsSelectedForMigration))
            {
                writer.WritePropertyName("isSelectedForMigration"u8);
                writer.WriteStringValue(IsSelectedForMigration);
            }
            if (Optional.IsDefined(TargetNicName))
            {
                writer.WritePropertyName("targetNicName"u8);
                writer.WriteStringValue(TargetNicName);
            }
            if (Optional.IsDefined(TestSubnetName))
            {
                writer.WritePropertyName("testSubnetName"u8);
                writer.WriteStringValue(TestSubnetName);
            }
            if (Optional.IsDefined(TestStaticIPAddress))
            {
                writer.WritePropertyName("testStaticIPAddress"u8);
                writer.WriteStringValue(TestStaticIPAddress.ToString());
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

        VMwareCbtNicContent IJsonModel<VMwareCbtNicContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtNicContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtNicContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtNicContent(document.RootElement, options);
        }

        internal static VMwareCbtNicContent DeserializeVMwareCbtNicContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nicId = default;
            string isPrimaryNic = default;
            string targetSubnetName = default;
            IPAddress targetStaticIPAddress = default;
            string isSelectedForMigration = default;
            string targetNicName = default;
            string testSubnetName = default;
            IPAddress testStaticIPAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrimaryNic"u8))
                {
                    isPrimaryNic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetSubnetName"u8))
                {
                    targetSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetStaticIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetStaticIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isSelectedForMigration"u8))
                {
                    isSelectedForMigration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetNicName"u8))
                {
                    targetNicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testSubnetName"u8))
                {
                    testSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testStaticIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testStaticIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VMwareCbtNicContent(
                nicId,
                isPrimaryNic,
                targetSubnetName,
                targetStaticIPAddress,
                isSelectedForMigration,
                targetNicName,
                testSubnetName,
                testStaticIPAddress,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareCbtNicContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtNicContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtNicContent)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareCbtNicContent IPersistableModel<VMwareCbtNicContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtNicContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareCbtNicContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtNicContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareCbtNicContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
