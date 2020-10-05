// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class ActivityLogAlertAllOfCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("allOf");
            writer.WriteStartArray();
            foreach (var item in AllOf)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ActivityLogAlertAllOfCondition DeserializeActivityLogAlertAllOfCondition(JsonElement element)
        {
            IList<ActivityLogAlertLeafCondition> allOf = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allOf"))
                {
                    List<ActivityLogAlertLeafCondition> array = new List<ActivityLogAlertLeafCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityLogAlertLeafCondition.DeserializeActivityLogAlertLeafCondition(item));
                    }
                    allOf = array;
                    continue;
                }
            }
            return new ActivityLogAlertAllOfCondition(allOf);
        }
    }
}
