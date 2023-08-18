// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    public partial class IotCentralAppSkuInfo : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
            writer.WriteEndObject();
        }

        internal static IotCentralAppSkuInfo DeserializeIotCentralAppSkuInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IotCentralAppSku name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = new IotCentralAppSku(property.Value.GetString());
                    continue;
                }
            }
            return new IotCentralAppSkuInfo(name);
        }
    }
}
