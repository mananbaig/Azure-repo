// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.CancerProfiling
{
    public partial class OncoPhenotypeData : IUtf8JsonSerializable, IJsonModel<OncoPhenotypeData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OncoPhenotypeData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OncoPhenotypeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<OncoPhenotypeData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<OncoPhenotypeData>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("patients"u8);
            writer.WriteStartArray();
            foreach (var item in Patients)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration);
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

        OncoPhenotypeData IJsonModel<OncoPhenotypeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OncoPhenotypeData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOncoPhenotypeData(document.RootElement, options);
        }

        internal static OncoPhenotypeData DeserializeOncoPhenotypeData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<PatientRecord> patients = default;
            Optional<OncoPhenotypeModelConfiguration> configuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patients"u8))
                {
                    List<PatientRecord> array = new List<PatientRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PatientRecord.DeserializePatientRecord(item));
                    }
                    patients = array;
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = OncoPhenotypeModelConfiguration.DeserializeOncoPhenotypeModelConfiguration(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OncoPhenotypeData(patients, configuration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OncoPhenotypeData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OncoPhenotypeData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        OncoPhenotypeData IPersistableModel<OncoPhenotypeData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OncoPhenotypeData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeOncoPhenotypeData(document.RootElement, options);
        }

        string IPersistableModel<OncoPhenotypeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OncoPhenotypeData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOncoPhenotypeData(document.RootElement, new ModelReaderWriterOptions("W"));
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
