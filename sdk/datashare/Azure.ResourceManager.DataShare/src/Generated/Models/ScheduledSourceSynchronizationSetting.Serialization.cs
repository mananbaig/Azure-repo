// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class ScheduledSourceSynchronizationSetting
    {
        internal static ScheduledSourceSynchronizationSetting DeserializeScheduledSourceSynchronizationSetting(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceShareSynchronizationSettingKind kind = default;
            Core.Optional<DataShareSynchronizationRecurrenceInterval> recurrenceInterval = default;
            Core.Optional<DateTimeOffset> synchronizationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SourceShareSynchronizationSettingKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("recurrenceInterval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recurrenceInterval = new DataShareSynchronizationRecurrenceInterval(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("synchronizationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            synchronizationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ScheduledSourceSynchronizationSetting(kind, Core.Optional.ToNullable(recurrenceInterval), Core.Optional.ToNullable(synchronizationTime));
        }
    }
}
