// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class AdlsGen1FileDataSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("accountName");
            writer.WriteStringValue(AccountName);
            writer.WritePropertyName("fileName");
            writer.WriteStringValue(FileName);
            writer.WritePropertyName("folderPath");
            writer.WriteStringValue(FolderPath);
            writer.WritePropertyName("resourceGroup");
            writer.WriteStringValue(ResourceGroup);
            writer.WritePropertyName("subscriptionId");
            writer.WriteStringValue(SubscriptionId);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AdlsGen1FileDataSet DeserializeAdlsGen1FileDataSet(JsonElement element)
        {
            DataSetKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            string accountName = default;
            Optional<string> dataSetId = default;
            string fileName = default;
            string folderPath = default;
            string resourceGroup = default;
            string subscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new DataSetKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accountName"))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataSetId"))
                        {
                            dataSetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fileName"))
                        {
                            fileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("folderPath"))
                        {
                            folderPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"))
                        {
                            subscriptionId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AdlsGen1FileDataSet(id, name, type, systemData.Value, kind, accountName, dataSetId.Value, fileName, folderPath, resourceGroup, subscriptionId);
        }
    }
}
