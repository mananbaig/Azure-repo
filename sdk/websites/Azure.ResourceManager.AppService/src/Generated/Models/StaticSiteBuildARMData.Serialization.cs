// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class StaticSiteBuildARMData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StaticSiteBuildARMData DeserializeStaticSiteBuildARMData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> buildId = default;
            Optional<string> sourceBranch = default;
            Optional<string> pullRequestTitle = default;
            Optional<string> hostname = default;
            Optional<DateTimeOffset> createdTimeUtc = default;
            Optional<DateTimeOffset> lastUpdatedOn = default;
            Optional<BuildStatus> status = default;
            Optional<IReadOnlyList<StaticSiteUserProvidedFunctionApp>> userProvidedFunctionApps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("buildId"))
                        {
                            buildId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceBranch"))
                        {
                            sourceBranch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pullRequestTitle"))
                        {
                            pullRequestTitle = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostname"))
                        {
                            hostname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdTimeUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedOn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastUpdatedOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new BuildStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userProvidedFunctionApps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<StaticSiteUserProvidedFunctionApp> array = new List<StaticSiteUserProvidedFunctionApp>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StaticSiteUserProvidedFunctionApp.DeserializeStaticSiteUserProvidedFunctionApp(item));
                            }
                            userProvidedFunctionApps = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StaticSiteBuildARMData(id, name, type, systemData.Value, buildId.Value, sourceBranch.Value, pullRequestTitle.Value, hostname.Value, Optional.ToNullable(createdTimeUtc), Optional.ToNullable(lastUpdatedOn), Optional.ToNullable(status), Optional.ToList(userProvidedFunctionApps), kind.Value);
        }
    }
}
