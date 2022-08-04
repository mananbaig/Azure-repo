// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class MoveResourceStatus
    {
        internal static MoveResourceStatus DeserializeMoveResourceStatus(JsonElement element)
        {
            Optional<MoveResourceState> moveState = default;
            Optional<MoveResourceJobStatus> jobStatus = default;
            Optional<MoveResourceError> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("moveState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    moveState = new MoveResourceState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobStatus = MoveResourceJobStatus.DeserializeMoveResourceJobStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    errors = MoveResourceError.DeserializeMoveResourceError(property.Value);
                    continue;
                }
            }
            return new MoveResourceStatus(Optional.ToNullable(moveState), jobStatus.Value, errors.Value);
        }
    }
}
