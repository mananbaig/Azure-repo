// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class ConfigServerGitProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Repositories))
            {
                writer.WritePropertyName("repositories");
                writer.WriteStartArray();
                foreach (var item in Repositories)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("uri");
            writer.WriteStringValue(Uri);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Label);
            }
            if (Optional.IsCollectionDefined(SearchPaths))
            {
                writer.WritePropertyName("searchPaths");
                writer.WriteStartArray();
                foreach (var item in SearchPaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username");
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(HostKey))
            {
                writer.WritePropertyName("hostKey");
                writer.WriteStringValue(HostKey);
            }
            if (Optional.IsDefined(HostKeyAlgorithm))
            {
                writer.WritePropertyName("hostKeyAlgorithm");
                writer.WriteStringValue(HostKeyAlgorithm);
            }
            if (Optional.IsDefined(PrivateKey))
            {
                writer.WritePropertyName("privateKey");
                writer.WriteStringValue(PrivateKey);
            }
            if (Optional.IsDefined(StrictHostKeyChecking))
            {
                writer.WritePropertyName("strictHostKeyChecking");
                writer.WriteBooleanValue(StrictHostKeyChecking.Value);
            }
            writer.WriteEndObject();
        }

        internal static ConfigServerGitProperty DeserializeConfigServerGitProperty(JsonElement element)
        {
            Optional<IList<GitPatternRepository>> repositories = default;
            string uri = default;
            Optional<string> label = default;
            Optional<IList<string>> searchPaths = default;
            Optional<string> username = default;
            Optional<string> password = default;
            Optional<string> hostKey = default;
            Optional<string> hostKeyAlgorithm = default;
            Optional<string> privateKey = default;
            Optional<bool> strictHostKeyChecking = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("repositories"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GitPatternRepository> array = new List<GitPatternRepository>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GitPatternRepository.DeserializeGitPatternRepository(item));
                    }
                    repositories = array;
                    continue;
                }
                if (property.NameEquals("uri"))
                {
                    uri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchPaths"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    searchPaths = array;
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKey"))
                {
                    hostKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKeyAlgorithm"))
                {
                    hostKeyAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKey"))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("strictHostKeyChecking"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    strictHostKeyChecking = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ConfigServerGitProperty(Optional.ToList(repositories), uri, label.Value, Optional.ToList(searchPaths), username.Value, password.Value, hostKey.Value, hostKeyAlgorithm.Value, privateKey.Value, Optional.ToNullable(strictHostKeyChecking));
        }
    }
}
