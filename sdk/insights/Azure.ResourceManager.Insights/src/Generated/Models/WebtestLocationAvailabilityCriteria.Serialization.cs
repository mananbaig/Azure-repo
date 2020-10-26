// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class WebtestLocationAvailabilityCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("webTestId");
            writer.WriteStringValue(WebTestId);
            writer.WritePropertyName("componentId");
            writer.WriteStringValue(ComponentId);
            writer.WritePropertyName("failedLocationCount");
            writer.WriteNumberValue(FailedLocationCount);
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType.ToString());
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static WebtestLocationAvailabilityCriteria DeserializeWebtestLocationAvailabilityCriteria(JsonElement element)
        {
            string webTestId = default;
            string componentId = default;
            float failedLocationCount = default;
            Odatatype odataType = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("webTestId"))
                {
                    webTestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("componentId"))
                {
                    componentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failedLocationCount"))
                {
                    failedLocationCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("odata.type"))
                {
                    odataType = new Odatatype(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new WebtestLocationAvailabilityCriteria(odataType, additionalProperties, webTestId, componentId, failedLocationCount);
        }
    }
}
