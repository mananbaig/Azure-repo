// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class GetCallRecordingStateResponse
    {
        internal static GetCallRecordingStateResponse DeserializeGetCallRecordingStateResponse(JsonElement element)
        {
            Optional<RecordingState> recordingState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordingState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recordingState = new RecordingState(property.Value.GetString());
                    continue;
                }
            }
            return new GetCallRecordingStateResponse(Optional.ToNullable(recordingState));
        }
    }
}
