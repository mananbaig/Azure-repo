// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class RootCauseList
    {
        internal static RootCauseList DeserializeRootCauseList(JsonElement element)
        {
            IReadOnlyList<IncidentRootCause> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<IncidentRootCause> array = new List<IncidentRootCause>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IncidentRootCause.DeserializeIncidentRootCause(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new RootCauseList(value);
        }
    }
}
