// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    internal partial class PhoneNumberCapabilitiesRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Calling))
            {
                writer.WritePropertyName("calling"u8);
                writer.WriteStringValue(Calling.Value.ToString());
            }
            if (Optional.IsDefined(Sms))
            {
                writer.WritePropertyName("sms"u8);
                writer.WriteStringValue(Sms.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
