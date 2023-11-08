// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanPlannedFailoverProperties : IUtf8JsonSerializable, IJsonModel<RecoveryPlanPlannedFailoverProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanPlannedFailoverProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RecoveryPlanPlannedFailoverProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("failoverDirection"u8);
            writer.WriteStringValue(FailoverDirection.ToString());
            if (Optional.IsCollectionDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderSpecificDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        RecoveryPlanPlannedFailoverProperties IJsonModel<RecoveryPlanPlannedFailoverProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPlanPlannedFailoverProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanPlannedFailoverProperties(document.RootElement, options);
        }

        internal static RecoveryPlanPlannedFailoverProperties DeserializeRecoveryPlanPlannedFailoverProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PossibleOperationsDirection failoverDirection = default;
            Optional<IList<RecoveryPlanProviderSpecificFailoverContent>> providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failoverDirection"u8))
                {
                    failoverDirection = new PossibleOperationsDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanProviderSpecificFailoverContent> array = new List<RecoveryPlanProviderSpecificFailoverContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanProviderSpecificFailoverContent.DeserializeRecoveryPlanProviderSpecificFailoverContent(item));
                    }
                    providerSpecificDetails = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryPlanPlannedFailoverProperties(failoverDirection, Optional.ToList(providerSpecificDetails), serializedAdditionalRawData);
        }

        BinaryData IModel<RecoveryPlanPlannedFailoverProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPlanPlannedFailoverProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RecoveryPlanPlannedFailoverProperties IModel<RecoveryPlanPlannedFailoverProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPlanPlannedFailoverProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRecoveryPlanPlannedFailoverProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RecoveryPlanPlannedFailoverProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
