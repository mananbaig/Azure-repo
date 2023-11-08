// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    [ModelReaderProxy(typeof(UnknownPlannedFailoverModelCustomProperties))]
    public partial class PlannedFailoverModelCustomProperties : IUtf8JsonSerializable, IJsonModel<PlannedFailoverModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PlannedFailoverModelCustomProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<PlannedFailoverModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        PlannedFailoverModelCustomProperties IJsonModel<PlannedFailoverModelCustomProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PlannedFailoverModelCustomProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePlannedFailoverModelCustomProperties(document.RootElement, options);
        }

        internal static PlannedFailoverModelCustomProperties DeserializePlannedFailoverModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "HyperVToAzStackHCI": return HyperVToAzStackHciPlannedFailoverModelCustomProperties.DeserializeHyperVToAzStackHciPlannedFailoverModelCustomProperties(element);
                    case "PlannedFailoverModelCustomProperties": return GeneralPlannedFailoverModelCustomProperties.DeserializeGeneralPlannedFailoverModelCustomProperties(element);
                    case "VMwareToAzStackHCI": return VMwareToAzStackHciPlannedFailoverModelCustomProperties.DeserializeVMwareToAzStackHciPlannedFailoverModelCustomProperties(element);
                }
            }
            return UnknownPlannedFailoverModelCustomProperties.DeserializeUnknownPlannedFailoverModelCustomProperties(element);
        }

        BinaryData IModel<PlannedFailoverModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PlannedFailoverModelCustomProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PlannedFailoverModelCustomProperties IModel<PlannedFailoverModelCustomProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PlannedFailoverModelCustomProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePlannedFailoverModelCustomProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<PlannedFailoverModelCustomProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
