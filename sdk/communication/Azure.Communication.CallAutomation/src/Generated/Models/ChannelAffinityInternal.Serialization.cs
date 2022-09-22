// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class ChannelAffinityInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Channel))
            {
                writer.WritePropertyName("channel");
                writer.WriteNumberValue(Channel.Value);
            }
            if (Optional.IsDefined(Participant))
            {
                writer.WritePropertyName("participant");
                writer.WriteObjectValue(Participant);
            }
            writer.WriteEndObject();
        }
    }
}
