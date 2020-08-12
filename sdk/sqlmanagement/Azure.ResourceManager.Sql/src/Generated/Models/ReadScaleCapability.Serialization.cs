// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ReadScaleCapability
    {
        internal static ReadScaleCapability DeserializeReadScaleCapability(JsonElement element)
        {
            Optional<int> maxNumberOfReplicas = default;
            Optional<CapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxNumberOfReplicas"))
                {
                    maxNumberOfReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new ReadScaleCapability(Optional.ToNullable(maxNumberOfReplicas), Optional.ToNullable(status), reason.Value);
        }
    }
}
