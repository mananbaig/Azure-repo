// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningJobService : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Endpoint))
            {
                if (Endpoint != null)
                {
                    writer.WritePropertyName("endpoint"u8);
                    writer.WriteStringValue(Endpoint);
                }
                else
                {
                    writer.WriteNull("endpoint");
                }
            }
            if (Core.Optional.IsDefined(JobServiceType))
            {
                if (JobServiceType != null)
                {
                    writer.WritePropertyName("jobServiceType"u8);
                    writer.WriteStringValue(JobServiceType);
                }
                else
                {
                    writer.WriteNull("jobServiceType");
                }
            }
            if (Core.Optional.IsDefined(Port))
            {
                if (Port != null)
                {
                    writer.WritePropertyName("port"u8);
                    writer.WriteNumberValue(Port.Value);
                }
                else
                {
                    writer.WriteNull("port");
                }
            }
            if (Core.Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningJobService DeserializeMachineLearningJobService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> endpoint = default;
            Core.Optional<string> errorMessage = default;
            Core.Optional<string> jobServiceType = default;
            Core.Optional<int?> port = default;
            Core.Optional<IDictionary<string, string>> properties = default;
            Core.Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endpoint = null;
                        continue;
                    }
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errorMessage = null;
                        continue;
                    }
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobServiceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobServiceType = null;
                        continue;
                    }
                    jobServiceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        port = null;
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        status = null;
                        continue;
                    }
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new MachineLearningJobService(endpoint.Value, errorMessage.Value, jobServiceType.Value, Core.Optional.ToNullable(port), Core.Optional.ToDictionary(properties), status.Value);
        }
    }
}
