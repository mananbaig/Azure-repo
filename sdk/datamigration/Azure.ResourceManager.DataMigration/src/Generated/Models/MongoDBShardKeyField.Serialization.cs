// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBShardKeyField : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("order"u8);
            writer.WriteStringValue(Order.ToString());
            writer.WriteEndObject();
        }

        internal static MongoDBShardKeyField DeserializeMongoDBShardKeyField(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            MongoDBShardKeyOrder order = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    order = new MongoDBShardKeyOrder(property.Value.GetString());
                    continue;
                }
            }
            return new MongoDBShardKeyField(name, order);
        }
    }
}
