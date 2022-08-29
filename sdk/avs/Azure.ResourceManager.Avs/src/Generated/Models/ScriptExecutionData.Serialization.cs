// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    public partial class ScriptExecutionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ScriptCmdletId))
            {
                writer.WritePropertyName("scriptCmdletId");
                writer.WriteStringValue(ScriptCmdletId);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HiddenParameters))
            {
                writer.WritePropertyName("hiddenParameters");
                writer.WriteStartArray();
                foreach (var item in HiddenParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FailureReason))
            {
                writer.WritePropertyName("failureReason");
                writer.WriteStringValue(FailureReason);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout");
                writer.WriteStringValue(Timeout);
            }
            if (Optional.IsDefined(Retention))
            {
                writer.WritePropertyName("retention");
                writer.WriteStringValue(Retention);
            }
            if (Optional.IsCollectionDefined(Output))
            {
                writer.WritePropertyName("output");
                writer.WriteStartArray();
                foreach (var item in Output)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NamedOutputs))
            {
                writer.WritePropertyName("namedOutputs");
                writer.WriteStartObject();
                foreach (var item in NamedOutputs)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ScriptExecutionData DeserializeScriptExecutionData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> scriptCmdletId = default;
            Optional<IList<ScriptExecutionParameter>> parameters = default;
            Optional<IList<ScriptExecutionParameter>> hiddenParameters = default;
            Optional<string> failureReason = default;
            Optional<string> timeout = default;
            Optional<string> retention = default;
            Optional<DateTimeOffset> submittedAt = default;
            Optional<DateTimeOffset> startedAt = default;
            Optional<DateTimeOffset> finishedAt = default;
            Optional<ScriptExecutionProvisioningState> provisioningState = default;
            Optional<IList<string>> output = default;
            Optional<IDictionary<string, BinaryData>> namedOutputs = default;
            Optional<IReadOnlyList<string>> information = default;
            Optional<IReadOnlyList<string>> warnings = default;
            Optional<IReadOnlyList<string>> errors = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("scriptCmdletId"))
                        {
                            scriptCmdletId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ScriptExecutionParameter> array = new List<ScriptExecutionParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ScriptExecutionParameter.DeserializeScriptExecutionParameter(item));
                            }
                            parameters = array;
                            continue;
                        }
                        if (property0.NameEquals("hiddenParameters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ScriptExecutionParameter> array = new List<ScriptExecutionParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ScriptExecutionParameter.DeserializeScriptExecutionParameter(item));
                            }
                            hiddenParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("failureReason"))
                        {
                            failureReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeout"))
                        {
                            timeout = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retention"))
                        {
                            retention = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("submittedAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            submittedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startedAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("finishedAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            finishedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ScriptExecutionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("output"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            output = array;
                            continue;
                        }
                        if (property0.NameEquals("namedOutputs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                            }
                            namedOutputs = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("information"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            information = array;
                            continue;
                        }
                        if (property0.NameEquals("warnings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            warnings = array;
                            continue;
                        }
                        if (property0.NameEquals("errors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            errors = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ScriptExecutionData(id, name, type, systemData.Value, scriptCmdletId.Value, Optional.ToList(parameters), Optional.ToList(hiddenParameters), failureReason.Value, timeout.Value, retention.Value, Optional.ToNullable(submittedAt), Optional.ToNullable(startedAt), Optional.ToNullable(finishedAt), Optional.ToNullable(provisioningState), Optional.ToList(output), Optional.ToDictionary(namedOutputs), Optional.ToList(information), Optional.ToList(warnings), Optional.ToList(errors));
        }
    }
}
