// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class MetricCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("operator");
            writer.WriteStringValue(Operator.ToString());
            writer.WritePropertyName("threshold");
            writer.WriteNumberValue(Threshold);
            writer.WritePropertyName("criterionType");
            writer.WriteStringValue(CriterionType.ToString());
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("metricName");
            writer.WriteStringValue(MetricName);
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace");
                writer.WriteStringValue(MetricNamespace);
            }
            writer.WritePropertyName("timeAggregation");
            writer.WriteStringValue(TimeAggregation.ToSerialString());
            if (Optional.IsCollectionDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions");
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static MetricCriteria DeserializeMetricCriteria(JsonElement element)
        {
            Operator @operator = default;
            double threshold = default;
            CriterionType criterionType = default;
            string name = default;
            string metricName = default;
            Optional<string> metricNamespace = default;
            AggregationType timeAggregation = default;
            Optional<IList<MetricDimension>> dimensions = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operator"))
                {
                    @operator = new Operator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threshold"))
                {
                    threshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("criterionType"))
                {
                    criterionType = new CriterionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricName"))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNamespace"))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeAggregation"))
                {
                    timeAggregation = property.Value.GetString().ToAggregationType();
                    continue;
                }
                if (property.NameEquals("dimensions"))
                {
                    List<MetricDimension> array = new List<MetricDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricDimension.DeserializeMetricDimension(item));
                    }
                    dimensions = array;
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new MetricCriteria(criterionType, name, metricName, metricNamespace.Value, timeAggregation, Optional.ToList(dimensions), additionalProperties, @operator, threshold);
        }
    }
}
