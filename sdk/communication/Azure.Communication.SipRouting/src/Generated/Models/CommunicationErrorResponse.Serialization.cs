// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.SipRouting.Models
{
    internal partial class CommunicationErrorResponse
    {
        internal static CommunicationErrorResponse DeserializeCommunicationErrorResponse(JsonElement element)
        {
            CommunicationError error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    error = CommunicationError.DeserializeCommunicationError(property.Value);
                    continue;
                }
            }
            return new CommunicationErrorResponse(error);
        }
    }
}
