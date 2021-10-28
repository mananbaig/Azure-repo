// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class RemoteDeviceAdapterCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContinuationToken))
            {
                writer.WritePropertyName("@continuationToken");
                writer.WriteStringValue(ContinuationToken);
            }
            writer.WriteEndObject();
        }

        internal static RemoteDeviceAdapterCollection DeserializeRemoteDeviceAdapterCollection(JsonElement element)
        {
            Optional<IList<RemoteDeviceAdapter>> value = default;
            Optional<string> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RemoteDeviceAdapter> array = new List<RemoteDeviceAdapter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RemoteDeviceAdapter.DeserializeRemoteDeviceAdapter(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@continuationToken"))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new RemoteDeviceAdapterCollection(Optional.ToList(value), continuationToken.Value);
        }
    }
}
