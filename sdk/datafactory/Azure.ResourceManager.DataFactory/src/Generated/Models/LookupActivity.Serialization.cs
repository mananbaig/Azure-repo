// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class LookupActivity : IUtf8JsonSerializable, IJsonModel<LookupActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LookupActivity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LookupActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LookupActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LookupActivity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (LinkedServiceName != null)
            {
                writer.WritePropertyName("linkedServiceName"u8);
                JsonSerializer.Serialize(writer, LinkedServiceName);
            }
            if (Policy != null)
            {
                writer.WritePropertyName("policy"u8);
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ActivityType);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (OnInactiveMarkAs.HasValue)
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (!(DependsOn is ChangeTrackingList<PipelineActivityDependency> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(UserProperties is ChangeTrackingList<PipelineActivityUserProperty> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteObjectValue(Source);
            writer.WritePropertyName("dataset"u8);
            writer.WriteObjectValue(Dataset);
            if (FirstRowOnly != null)
            {
                writer.WritePropertyName("firstRowOnly"u8);
                JsonSerializer.Serialize(writer, FirstRowOnly);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        LookupActivity IJsonModel<LookupActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LookupActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LookupActivity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLookupActivity(document.RootElement, options);
        }

        internal static LookupActivity DeserializeLookupActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryLinkedServiceReference> linkedServiceName = default;
            Optional<PipelineActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<PipelineActivityState> state = default;
            Optional<ActivityOnInactiveMarkAs> onInactiveMarkAs = default;
            Optional<IList<PipelineActivityDependency>> dependsOn = default;
            Optional<IList<PipelineActivityUserProperty>> userProperties = default;
            CopyActivitySource source = default;
            DatasetReference dataset = default;
            Optional<DataFactoryElement<bool>> firstRowOnly = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = PipelineActivityPolicy.DeserializePipelineActivityPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PipelineActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityDependency> array = new List<PipelineActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityDependency.DeserializePipelineActivityDependency(item, options));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityUserProperty> array = new List<PipelineActivityUserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityUserProperty.DeserializePipelineActivityUserProperty(item, options));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("source"u8))
                        {
                            source = CopyActivitySource.DeserializeCopyActivitySource(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dataset"u8))
                        {
                            dataset = DatasetReference.DeserializeDatasetReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("firstRowOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firstRowOnly = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new LookupActivity(name, type, description.Value, Optional.ToNullable(state), Optional.ToNullable(onInactiveMarkAs), Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, linkedServiceName, policy.Value, source, dataset, firstRowOnly.Value);
        }

        BinaryData IPersistableModel<LookupActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LookupActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LookupActivity)} does not support '{options.Format}' format.");
            }
        }

        LookupActivity IPersistableModel<LookupActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LookupActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLookupActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LookupActivity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LookupActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
