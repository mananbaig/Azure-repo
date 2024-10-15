// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ConfigurationFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hierarchyInformation"u8);
            writer.WriteObjectValue(HierarchyInformation);
            if (Optional.IsCollectionDefined(FilterableProperty))
            {
                writer.WritePropertyName("filterableProperty"u8);
                writer.WriteStartArray();
                foreach (var item in FilterableProperty)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ChildConfigurationFilter))
            {
                writer.WritePropertyName("childConfigurationFilter"u8);
                writer.WriteObjectValue(ChildConfigurationFilter);
            }
            writer.WriteEndObject();
        }
    }
}
