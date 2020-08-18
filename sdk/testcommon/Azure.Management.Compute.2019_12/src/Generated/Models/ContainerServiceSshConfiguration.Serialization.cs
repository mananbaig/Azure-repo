// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ContainerServiceSshConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("publicKeys");
            writer.WriteStartArray();
            foreach (var item in PublicKeys)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ContainerServiceSshConfiguration DeserializeContainerServiceSshConfiguration(JsonElement element)
        {
            IList<ContainerServiceSshPublicKey> publicKeys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicKeys"))
                {
                    List<ContainerServiceSshPublicKey> array = new List<ContainerServiceSshPublicKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceSshPublicKey.DeserializeContainerServiceSshPublicKey(item));
                    }
                    publicKeys = array;
                    continue;
                }
            }
            return new ContainerServiceSshConfiguration(publicKeys);
        }
    }
}
