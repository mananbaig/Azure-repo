// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MicrosoftTeamsUserIdentifierModel
    {
        internal static MicrosoftTeamsUserIdentifierModel DeserializeMicrosoftTeamsUserIdentifierModel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userId = default;
            Core.Optional<bool> isAnonymous = default;
            Core.Optional<CommunicationCloudEnvironmentModel> cloud = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAnonymous"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloud"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloud = new CommunicationCloudEnvironmentModel(property.Value.GetString());
                    continue;
                }
            }
            return new MicrosoftTeamsUserIdentifierModel(userId, Core.Optional.ToNullable(isAnonymous), Core.Optional.ToNullable(cloud));
        }
    }
}
