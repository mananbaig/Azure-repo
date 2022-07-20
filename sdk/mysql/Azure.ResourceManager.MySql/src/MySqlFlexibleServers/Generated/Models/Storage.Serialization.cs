// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class Storage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageSizeGB))
            {
                writer.WritePropertyName("storageSizeGB");
                writer.WriteNumberValue(StorageSizeGB.Value);
            }
            if (Optional.IsDefined(Iops))
            {
                writer.WritePropertyName("iops");
                writer.WriteNumberValue(Iops.Value);
            }
            if (Optional.IsDefined(AutoGrow))
            {
                writer.WritePropertyName("autoGrow");
                writer.WriteStringValue(AutoGrow.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static Storage DeserializeStorage(JsonElement element)
        {
            Optional<int> storageSizeGB = default;
            Optional<int> iops = default;
            Optional<EnableStatusEnum> autoGrow = default;
            Optional<string> storageSku = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageSizeGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("iops"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    iops = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoGrow"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoGrow = new EnableStatusEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageSku"))
                {
                    storageSku = property.Value.GetString();
                    continue;
                }
            }
            return new Storage(Optional.ToNullable(storageSizeGB), Optional.ToNullable(iops), Optional.ToNullable(autoGrow), storageSku.Value);
        }
    }
}
