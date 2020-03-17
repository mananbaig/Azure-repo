// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    public partial class TextWeights : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("weights");
            writer.WriteStartObject();
            foreach (var item in Weights)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteNumberValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static TextWeights DeserializeTextWeights(JsonElement element)
        {
            TextWeights result = new TextWeights();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("weights"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        result.Weights.Add(property0.Name, property0.Value.GetDouble());
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
