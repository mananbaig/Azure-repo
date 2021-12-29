// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class CreateAudioGroupResult
    {
        internal static CreateAudioGroupResult DeserializeCreateAudioGroupResult(JsonElement element)
        {
            Optional<string> audioGroupId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("audioGroupId"))
                {
                    audioGroupId = property.Value.GetString();
                    continue;
                }
            }
            return new CreateAudioGroupResult(audioGroupId.Value);
        }
    }
}
