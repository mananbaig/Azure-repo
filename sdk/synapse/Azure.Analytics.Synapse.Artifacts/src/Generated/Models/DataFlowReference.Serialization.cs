// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class DataFlowReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("referenceName");
            writer.WriteStringValue(ReferenceName);
            if (Optional.IsDefined(DatasetParameters))
            {
                writer.WritePropertyName("datasetParameters");
                writer.WriteObjectValue(DatasetParameters);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowReference DeserializeDataFlowReference(JsonElement element)
        {
            DataFlowReferenceType type = default;
            string referenceName = default;
            Optional<object> datasetParameters = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new DataFlowReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"))
                {
                    referenceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datasetParameters"))
                {
                    datasetParameters = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFlowReference(type, referenceName, datasetParameters.Value, additionalProperties);
        }
    }
}
