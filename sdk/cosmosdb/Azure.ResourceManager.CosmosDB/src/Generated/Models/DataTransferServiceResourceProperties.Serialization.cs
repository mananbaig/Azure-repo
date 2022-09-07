// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class DataTransferServiceResourceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InstanceSize))
            {
                writer.WritePropertyName("instanceSize");
                writer.WriteStringValue(InstanceSize.Value.ToString());
            }
            if (Optional.IsDefined(InstanceCount))
            {
                writer.WritePropertyName("instanceCount");
                writer.WriteNumberValue(InstanceCount.Value);
            }
            writer.WritePropertyName("serviceType");
            writer.WriteStringValue(ServiceType.ToString());
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

        internal static DataTransferServiceResourceProperties DeserializeDataTransferServiceResourceProperties(JsonElement element)
        {
            Optional<IReadOnlyList<DataTransferRegionalServiceResource>> locations = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<ServiceSize> instanceSize = default;
            Optional<int> instanceCount = default;
            ServiceType serviceType = default;
            Optional<ServiceStatus> status = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataTransferRegionalServiceResource> array = new List<DataTransferRegionalServiceResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataTransferRegionalServiceResource.DeserializeDataTransferRegionalServiceResource(item));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("creationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("instanceSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    instanceSize = new ServiceSize(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serviceType"))
                {
                    serviceType = new ServiceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new ServiceStatus(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataTransferServiceResourceProperties(Optional.ToNullable(creationTime), Optional.ToNullable(instanceSize), Optional.ToNullable(instanceCount), serviceType, Optional.ToNullable(status), additionalProperties, Optional.ToList(locations));
        }
    }
}
