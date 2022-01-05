// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    public partial class PremierAddOnData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteStringValue(Sku);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product");
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(Vendor))
            {
                writer.WritePropertyName("vendor");
                writer.WriteStringValue(Vendor);
            }
            if (Optional.IsDefined(MarketplacePublisher))
            {
                writer.WritePropertyName("marketplacePublisher");
                writer.WriteStringValue(MarketplacePublisher);
            }
            if (Optional.IsDefined(MarketplaceOffer))
            {
                writer.WritePropertyName("marketplaceOffer");
                writer.WriteStringValue(MarketplaceOffer);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PremierAddOnData DeserializePremierAddOnData(JsonElement element)
        {
            Optional<string> kind = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> sku = default;
            Optional<string> product = default;
            Optional<string> vendor = default;
            Optional<string> marketplacePublisher = default;
            Optional<string> marketplaceOffer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sku"))
                        {
                            sku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vendor"))
                        {
                            vendor = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("marketplacePublisher"))
                        {
                            marketplacePublisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("marketplaceOffer"))
                        {
                            marketplaceOffer = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PremierAddOnData(id, name, type, tags, location, kind.Value, sku.Value, product.Value, vendor.Value, marketplacePublisher.Value, marketplaceOffer.Value);
        }
    }
}
