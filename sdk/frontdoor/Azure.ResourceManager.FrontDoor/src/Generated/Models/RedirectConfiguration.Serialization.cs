// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RedirectConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(RedirectType))
            {
                writer.WritePropertyName("redirectType"u8);
                writer.WriteStringValue(RedirectType.Value.ToString());
            }
            if (Core.Optional.IsDefined(RedirectProtocol))
            {
                writer.WritePropertyName("redirectProtocol"u8);
                writer.WriteStringValue(RedirectProtocol.Value.ToString());
            }
            if (Core.Optional.IsDefined(CustomHost))
            {
                writer.WritePropertyName("customHost"u8);
                writer.WriteStringValue(CustomHost);
            }
            if (Core.Optional.IsDefined(CustomPath))
            {
                writer.WritePropertyName("customPath"u8);
                writer.WriteStringValue(CustomPath);
            }
            if (Core.Optional.IsDefined(CustomFragment))
            {
                writer.WritePropertyName("customFragment"u8);
                writer.WriteStringValue(CustomFragment);
            }
            if (Core.Optional.IsDefined(CustomQueryString))
            {
                writer.WritePropertyName("customQueryString"u8);
                writer.WriteStringValue(CustomQueryString);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static RedirectConfiguration DeserializeRedirectConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<FrontDoorRedirectType> redirectType = default;
            Core.Optional<FrontDoorRedirectProtocol> redirectProtocol = default;
            Core.Optional<string> customHost = default;
            Core.Optional<string> customPath = default;
            Core.Optional<string> customFragment = default;
            Core.Optional<string> customQueryString = default;
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("redirectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redirectType = new FrontDoorRedirectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("redirectProtocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redirectProtocol = new FrontDoorRedirectProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customHost"u8))
                {
                    customHost = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customPath"u8))
                {
                    customPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customFragment"u8))
                {
                    customFragment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customQueryString"u8))
                {
                    customQueryString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new RedirectConfiguration(odataType, Core.Optional.ToNullable(redirectType), Core.Optional.ToNullable(redirectProtocol), customHost.Value, customPath.Value, customFragment.Value, customQueryString.Value);
        }
    }
}
