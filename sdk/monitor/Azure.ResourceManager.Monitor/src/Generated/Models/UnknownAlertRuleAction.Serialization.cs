// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class UnknownAlertRuleAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static UnknownAlertRuleAction DeserializeUnknownAlertRuleAction(JsonElement element)
        {
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownAlertRuleAction(odataType);
        }
    }
}
