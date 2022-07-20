// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class SharedAccessAuthorizationRuleProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Rights))
            {
                writer.WritePropertyName("rights");
                writer.WriteStartArray();
                foreach (var item in Rights)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SharedAccessAuthorizationRuleProperties DeserializeSharedAccessAuthorizationRuleProperties(JsonElement element)
        {
            Optional<IList<AccessRight>> rights = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<string> keyName = default;
            Optional<string> claimType = default;
            Optional<string> claimValue = default;
            Optional<string> modifiedTime = default;
            Optional<string> createdTime = default;
            Optional<int> revision = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rights"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AccessRight> array = new List<AccessRight>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToAccessRight());
                    }
                    rights = array;
                    continue;
                }
                if (property.NameEquals("primaryKey"))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyName"))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("claimType"))
                {
                    claimType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("claimValue"))
                {
                    claimValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedTime"))
                {
                    modifiedTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    createdTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("revision"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    revision = property.Value.GetInt32();
                    continue;
                }
            }
            return new SharedAccessAuthorizationRuleProperties(Optional.ToList(rights), primaryKey.Value, secondaryKey.Value, keyName.Value, claimType.Value, claimValue.Value, modifiedTime.Value, createdTime.Value, Optional.ToNullable(revision));
        }
    }
}
