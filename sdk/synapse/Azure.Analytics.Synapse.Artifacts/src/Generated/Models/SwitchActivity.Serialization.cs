// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SwitchActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn");
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties");
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("on");
            writer.WriteObjectValue(On);
            if (Optional.IsCollectionDefined(Cases))
            {
                writer.WritePropertyName("cases");
                writer.WriteStartArray();
                foreach (var item in Cases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DefaultActivities))
            {
                writer.WritePropertyName("defaultActivities");
                writer.WriteStartArray();
                foreach (var item in DefaultActivities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SwitchActivity DeserializeSwitchActivity(JsonElement element)
        {
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            Expression @on = default;
            Optional<IList<SwitchCase>> cases = default;
            Optional<IList<Activity>> defaultActivities = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"))
                {
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"))
                {
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("on"))
                        {
                            @on = Expression.DeserializeExpression(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cases"))
                        {
                            List<SwitchCase> array = new List<SwitchCase>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SwitchCase.DeserializeSwitchCase(item));
                            }
                            cases = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultActivities"))
                        {
                            List<Activity> array = new List<Activity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeActivity(item));
                            }
                            defaultActivities = array;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SwitchActivity(name, type, description.Value, Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, @on, Optional.ToList(cases), Optional.ToList(defaultActivities));
        }
    }
}
