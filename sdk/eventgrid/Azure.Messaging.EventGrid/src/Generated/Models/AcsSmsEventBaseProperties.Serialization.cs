// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsSmsEventBaseProperties
    {
        internal static AcsSmsEventBaseProperties DeserializeAcsSmsEventBaseProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> messageId = default;
            Core.Optional<string> @from = default;
            Core.Optional<string> to = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("from"u8))
                {
                    @from = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetString();
                    continue;
                }
            }
            return new AcsSmsEventBaseProperties(messageId.Value, @from.Value, to.Value);
        }
    }
}
