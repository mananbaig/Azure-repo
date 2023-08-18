// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsChatThreadEventInThreadBaseProperties
    {
        internal static AcsChatThreadEventInThreadBaseProperties DeserializeAcsChatThreadEventInThreadBaseProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateTimeOffset> createTime = default;
            Core.Optional<long> version = default;
            Core.Optional<string> transactionId = default;
            Core.Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transactionId"u8))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"u8))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsChatThreadEventInThreadBaseProperties(transactionId.Value, threadId.Value, Core.Optional.ToNullable(createTime), Core.Optional.ToNullable(version));
        }
    }
}
