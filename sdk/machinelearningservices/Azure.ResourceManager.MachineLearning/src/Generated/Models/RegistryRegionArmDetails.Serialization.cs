// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class RegistryRegionArmDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AcrDetails))
            {
                if (AcrDetails != null)
                {
                    writer.WritePropertyName("acrDetails"u8);
                    writer.WriteStartArray();
                    foreach (var item in AcrDetails)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("acrDetails");
                }
            }
            if (Optional.IsDefined(Location))
            {
                if (Location != null)
                {
                    writer.WritePropertyName("location"u8);
                    writer.WriteStringValue(Location.Value);
                }
                else
                {
                    writer.WriteNull("location");
                }
            }
            if (Optional.IsCollectionDefined(StorageAccountDetails))
            {
                if (StorageAccountDetails != null)
                {
                    writer.WritePropertyName("storageAccountDetails"u8);
                    writer.WriteStartArray();
                    foreach (var item in StorageAccountDetails)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("storageAccountDetails");
                }
            }
            writer.WriteEndObject();
        }

        internal static RegistryRegionArmDetails DeserializeRegistryRegionArmDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AcrDetails>> acrDetails = default;
            Optional<AzureLocation?> location = default;
            Optional<IList<StorageAccountDetails>> storageAccountDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("acrDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        acrDetails = null;
                        continue;
                    }
                    List<AcrDetails> array = new List<AcrDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.AcrDetails.DeserializeAcrDetails(item));
                    }
                    acrDetails = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        location = null;
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        storageAccountDetails = null;
                        continue;
                    }
                    List<StorageAccountDetails> array = new List<StorageAccountDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.StorageAccountDetails.DeserializeStorageAccountDetails(item));
                    }
                    storageAccountDetails = array;
                    continue;
                }
            }
            return new RegistryRegionArmDetails(Optional.ToList(acrDetails), Optional.ToNullable(location), Optional.ToList(storageAccountDetails));
        }
    }
}
