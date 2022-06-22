// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ModelVersionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Flavors))
            {
                if (Flavors != null)
                {
                    writer.WritePropertyName("flavors");
                    writer.WriteStartObject();
                    foreach (var item in Flavors)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("flavors");
                }
            }
            if (Optional.IsDefined(JobName))
            {
                if (JobName != null)
                {
                    writer.WritePropertyName("jobName");
                    writer.WriteStringValue(JobName);
                }
                else
                {
                    writer.WriteNull("jobName");
                }
            }
            if (Optional.IsDefined(ModelType))
            {
                writer.WritePropertyName("modelType");
                writer.WriteStringValue(ModelType.Value.ToString());
            }
            if (Optional.IsDefined(ModelUri))
            {
                if (ModelUri != null)
                {
                    writer.WritePropertyName("modelUri");
                    writer.WriteStringValue(ModelUri);
                }
                else
                {
                    writer.WriteNull("modelUri");
                }
            }
            if (Optional.IsDefined(IsAnonymous))
            {
                writer.WritePropertyName("isAnonymous");
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (Optional.IsDefined(IsArchived))
            {
                writer.WritePropertyName("isArchived");
                writer.WriteBooleanValue(IsArchived.Value);
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description");
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties");
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
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags");
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
                }
            }
            writer.WriteEndObject();
        }

        internal static ModelVersionProperties DeserializeModelVersionProperties(JsonElement element)
        {
            Optional<IDictionary<string, FlavorData>> flavors = default;
            Optional<string> jobName = default;
            Optional<ModelType> modelType = default;
            Optional<string> modelUri = default;
            Optional<bool> isAnonymous = default;
            Optional<bool> isArchived = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, string>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("flavors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        flavors = null;
                        continue;
                    }
                    Dictionary<string, FlavorData> dictionary = new Dictionary<string, FlavorData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, FlavorData.DeserializeFlavorData(property0.Value));
                        }
                    }
                    flavors = dictionary;
                    continue;
                }
                if (property.NameEquals("jobName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobName = null;
                        continue;
                    }
                    jobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modelType = new ModelType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelUri = null;
                        continue;
                    }
                    modelUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAnonymous"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isArchived"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new ModelVersionProperties(description.Value, Optional.ToDictionary(properties), Optional.ToDictionary(tags), Optional.ToNullable(isAnonymous), Optional.ToNullable(isArchived), Optional.ToDictionary(flavors), jobName.Value, Optional.ToNullable(modelType), modelUri.Value);
        }
    }
}
