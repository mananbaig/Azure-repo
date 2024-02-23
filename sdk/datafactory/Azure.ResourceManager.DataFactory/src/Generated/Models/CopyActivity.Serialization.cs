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
    public partial class CopyActivity : IUtf8JsonSerializable, IJsonModel<CopyActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CopyActivity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CopyActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyActivity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Inputs is ChangeTrackingList<DatasetReference> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Outputs is ChangeTrackingList<DatasetReference> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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
            if (!(DependsOn is ChangeTrackingList<PipelineActivityDependency> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(UserProperties is ChangeTrackingList<PipelineActivityUserProperty> collection2 && collection2.IsUndefined))
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
            writer.WritePropertyName("sink"u8);
            writer.WriteObjectValue(Sink);
            if (Translator != null)
            {
                writer.WritePropertyName("translator"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Translator);
#else
                using (JsonDocument document = JsonDocument.Parse(Translator))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (EnableStaging != null)
            {
                writer.WritePropertyName("enableStaging"u8);
                JsonSerializer.Serialize(writer, EnableStaging);
            }
            if (StagingSettings != null)
            {
                writer.WritePropertyName("stagingSettings"u8);
                writer.WriteObjectValue(StagingSettings);
            }
            if (ParallelCopies != null)
            {
                writer.WritePropertyName("parallelCopies"u8);
                JsonSerializer.Serialize(writer, ParallelCopies);
            }
            if (DataIntegrationUnits != null)
            {
                writer.WritePropertyName("dataIntegrationUnits"u8);
                JsonSerializer.Serialize(writer, DataIntegrationUnits);
            }
            if (EnableSkipIncompatibleRow != null)
            {
                writer.WritePropertyName("enableSkipIncompatibleRow"u8);
                JsonSerializer.Serialize(writer, EnableSkipIncompatibleRow);
            }
            if (RedirectIncompatibleRowSettings != null)
            {
                writer.WritePropertyName("redirectIncompatibleRowSettings"u8);
                writer.WriteObjectValue(RedirectIncompatibleRowSettings);
            }
            if (LogStorageSettings != null)
            {
                writer.WritePropertyName("logStorageSettings"u8);
                writer.WriteObjectValue(LogStorageSettings);
            }
            if (LogSettings != null)
            {
                writer.WritePropertyName("logSettings"u8);
                writer.WriteObjectValue(LogSettings);
            }
            if (!(PreserveRules is ChangeTrackingList<BinaryData> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("preserveRules"u8);
                writer.WriteStartArray();
                foreach (var item in PreserveRules)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (!(Preserve is ChangeTrackingList<BinaryData> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("preserve"u8);
                writer.WriteStartArray();
                foreach (var item in Preserve)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (ValidateDataConsistency != null)
            {
                writer.WritePropertyName("validateDataConsistency"u8);
                JsonSerializer.Serialize(writer, ValidateDataConsistency);
            }
            if (SkipErrorFile != null)
            {
                writer.WritePropertyName("skipErrorFile"u8);
                writer.WriteObjectValue(SkipErrorFile);
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

        CopyActivity IJsonModel<CopyActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyActivity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCopyActivity(document.RootElement, options);
        }

        internal static CopyActivity DeserializeCopyActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DatasetReference>> inputs = default;
            Optional<IList<DatasetReference>> outputs = default;
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
            CopySink sink = default;
            Optional<BinaryData> translator = default;
            Optional<DataFactoryElement<bool>> enableStaging = default;
            Optional<StagingSettings> stagingSettings = default;
            Optional<DataFactoryElement<int>> parallelCopies = default;
            Optional<DataFactoryElement<int>> dataIntegrationUnits = default;
            Optional<DataFactoryElement<bool>> enableSkipIncompatibleRow = default;
            Optional<RedirectIncompatibleRowSettings> redirectIncompatibleRowSettings = default;
            Optional<LogStorageSettings> logStorageSettings = default;
            Optional<DataFactoryLogSettings> logSettings = default;
            Optional<IList<BinaryData>> preserveRules = default;
            Optional<IList<BinaryData>> preserve = default;
            Optional<DataFactoryElement<bool>> validateDataConsistency = default;
            Optional<SkipErrorFile> skipErrorFile = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasetReference> array = new List<DatasetReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetReference.DeserializeDatasetReference(item, options));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasetReference> array = new List<DatasetReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetReference.DeserializeDatasetReference(item, options));
                    }
                    outputs = array;
                    continue;
                }
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
                        if (property0.NameEquals("sink"u8))
                        {
                            sink = CopySink.DeserializeCopySink(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("translator"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            translator = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("enableStaging"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableStaging = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("stagingSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stagingSettings = StagingSettings.DeserializeStagingSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("parallelCopies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            parallelCopies = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("dataIntegrationUnits"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataIntegrationUnits = JsonSerializer.Deserialize<DataFactoryElement<int>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("enableSkipIncompatibleRow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableSkipIncompatibleRow = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("redirectIncompatibleRowSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redirectIncompatibleRowSettings = RedirectIncompatibleRowSettings.DeserializeRedirectIncompatibleRowSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("logStorageSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logStorageSettings = LogStorageSettings.DeserializeLogStorageSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("logSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logSettings = DataFactoryLogSettings.DeserializeDataFactoryLogSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("preserveRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(BinaryData.FromString(item.GetRawText()));
                                }
                            }
                            preserveRules = array;
                            continue;
                        }
                        if (property0.NameEquals("preserve"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(BinaryData.FromString(item.GetRawText()));
                                }
                            }
                            preserve = array;
                            continue;
                        }
                        if (property0.NameEquals("validateDataConsistency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validateDataConsistency = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("skipErrorFile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            skipErrorFile = SkipErrorFile.DeserializeSkipErrorFile(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CopyActivity(name, type, description.Value, Optional.ToNullable(state), Optional.ToNullable(onInactiveMarkAs), Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, linkedServiceName, policy.Value, Optional.ToList(inputs), Optional.ToList(outputs), source, sink, translator.Value, enableStaging.Value, stagingSettings.Value, parallelCopies.Value, dataIntegrationUnits.Value, enableSkipIncompatibleRow.Value, redirectIncompatibleRowSettings.Value, logStorageSettings.Value, logSettings.Value, Optional.ToList(preserveRules), Optional.ToList(preserve), validateDataConsistency.Value, skipErrorFile.Value);
        }

        BinaryData IPersistableModel<CopyActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CopyActivity)} does not support '{options.Format}' format.");
            }
        }

        CopyActivity IPersistableModel<CopyActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCopyActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CopyActivity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CopyActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
