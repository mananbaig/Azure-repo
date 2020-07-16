// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class IntegrationRuntimeReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("referenceName");
            writer.WriteStringValue(ReferenceName);
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeReference DeserializeIntegrationRuntimeReference(JsonElement element)
        {
            IntegrationRuntimeReferenceType type = default;
            string referenceName = default;
            Optional<IDictionary<string, object>> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new IntegrationRuntimeReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"))
                {
                    referenceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    parameters = dictionary;
                    continue;
                }
            }
            return new IntegrationRuntimeReference(type, referenceName, Optional.ToDictionary(parameters));
        }
    }
}
