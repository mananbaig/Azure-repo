// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Fleet.Models
{
    internal partial class BillingProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxPrice))
            {
                writer.WritePropertyName("maxPrice"u8);
                writer.WriteNumberValue(MaxPrice.Value);
            }
            writer.WriteEndObject();
        }

        internal static BillingProfile DeserializeBillingProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double> maxPrice = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPrice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPrice = property.Value.GetDouble();
                    continue;
                }
            }
            return new BillingProfile(Optional.ToNullable(maxPrice));
        }
    }
}
