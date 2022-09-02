// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    internal partial class TransferConfigurationTransferFilterDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Include))
            {
                writer.WritePropertyName("include");
                writer.WriteObjectValue(Include);
            }
            writer.WriteEndObject();
        }

        internal static TransferConfigurationTransferFilterDetails DeserializeTransferConfigurationTransferFilterDetails(JsonElement element)
        {
            Optional<TransferFilterDetails> include = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("include"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    include = TransferFilterDetails.DeserializeTransferFilterDetails(property.Value);
                    continue;
                }
            }
            return new TransferConfigurationTransferFilterDetails(include.Value);
        }
    }
}
