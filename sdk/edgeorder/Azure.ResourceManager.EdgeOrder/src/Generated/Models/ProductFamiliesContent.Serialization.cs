// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductFamiliesContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("filterableProperties"u8);
            writer.WriteStartObject();
            foreach (var item in FilterableProperties)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStartArray();
                foreach (var item0 in item.Value)
                {
                    writer.WriteObjectValue(item0);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (Core.Optional.IsDefined(CustomerSubscriptionDetails))
            {
                writer.WritePropertyName("customerSubscriptionDetails"u8);
                writer.WriteObjectValue(CustomerSubscriptionDetails);
            }
            writer.WriteEndObject();
        }
    }
}
