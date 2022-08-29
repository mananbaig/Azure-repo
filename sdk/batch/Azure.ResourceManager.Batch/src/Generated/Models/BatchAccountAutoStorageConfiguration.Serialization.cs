// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountAutoStorageConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("lastKeySync");
            writer.WriteStringValue(LastKeySyncedOn, "O");
            writer.WritePropertyName("storageAccountId");
            writer.WriteStringValue(StorageAccountId);
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode");
                writer.WriteStringValue(AuthenticationMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(NodeIdentity))
            {
                writer.WritePropertyName("nodeIdentityReference");
                writer.WriteObjectValue(NodeIdentity);
            }
            writer.WriteEndObject();
        }

        internal static BatchAccountAutoStorageConfiguration DeserializeBatchAccountAutoStorageConfiguration(JsonElement element)
        {
            DateTimeOffset lastKeySync = default;
            ResourceIdentifier storageAccountId = default;
            Optional<BatchAutoStorageAuthenticationMode> authenticationMode = default;
            Optional<ComputeNodeIdentityReference> nodeIdentityReference = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastKeySync"))
                {
                    lastKeySync = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("storageAccountId"))
                {
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authenticationMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    authenticationMode = property.Value.GetString().ToBatchAutoStorageAuthenticationMode();
                    continue;
                }
                if (property.NameEquals("nodeIdentityReference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nodeIdentityReference = ComputeNodeIdentityReference.DeserializeComputeNodeIdentityReference(property.Value);
                    continue;
                }
            }
            return new BatchAccountAutoStorageConfiguration(storageAccountId, Optional.ToNullable(authenticationMode), nodeIdentityReference.Value, lastKeySync);
        }
    }
}
