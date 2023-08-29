// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MetricAlertCriteria : IUtf8JsonSerializable, IModelJsonSerializable<MetricAlertCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MetricAlertCriteria>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MetricAlertCriteria>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("odata.type"u8);
            writer.WriteStringValue(OdataType.ToString());
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static MetricAlertCriteria DeserializeMetricAlertCriteria(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.Azure.Monitor.MultipleResourceMultipleMetricCriteria": return MetricAlertMultipleResourceMultipleMetricCriteria.DeserializeMetricAlertMultipleResourceMultipleMetricCriteria(element);
                    case "Microsoft.Azure.Monitor.SingleResourceMultipleMetricCriteria": return MetricAlertSingleResourceMultipleMetricCriteria.DeserializeMetricAlertSingleResourceMultipleMetricCriteria(element);
                    case "Microsoft.Azure.Monitor.WebtestLocationAvailabilityCriteria": return WebtestLocationAvailabilityCriteria.DeserializeWebtestLocationAvailabilityCriteria(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            MonitorOdataType odataType = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = new MonitorOdataType(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new UnknownMetricAlertCriteria(odataType, additionalProperties);
        }

        MetricAlertCriteria IModelJsonSerializable<MetricAlertCriteria>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricAlertCriteria(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MetricAlertCriteria>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MetricAlertCriteria IModelSerializable<MetricAlertCriteria>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMetricAlertCriteria(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MetricAlertCriteria model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MetricAlertCriteria(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMetricAlertCriteria(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
