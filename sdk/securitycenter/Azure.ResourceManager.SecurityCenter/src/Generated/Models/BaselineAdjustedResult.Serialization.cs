// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class BaselineAdjustedResult : IUtf8JsonSerializable, IJsonModel<BaselineAdjustedResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BaselineAdjustedResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BaselineAdjustedResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaselineAdjustedResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BaselineAdjustedResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Baseline))
            {
                writer.WritePropertyName("baseline"u8);
                writer.WriteObjectValue(Baseline);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ResultsNotInBaseline))
            {
                writer.WritePropertyName("resultsNotInBaseline"u8);
                writer.WriteStartArray();
                foreach (var item in ResultsNotInBaseline)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResultsOnlyInBaseline))
            {
                writer.WritePropertyName("resultsOnlyInBaseline"u8);
                writer.WriteStartArray();
                foreach (var item in ResultsOnlyInBaseline)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
            }
            writer.WriteEndObject();
        }

        BaselineAdjustedResult IJsonModel<BaselineAdjustedResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaselineAdjustedResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BaselineAdjustedResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBaselineAdjustedResult(document.RootElement, options);
        }

        internal static BaselineAdjustedResult DeserializeBaselineAdjustedResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlVulnerabilityAssessmentBaseline> baseline = default;
            Optional<SqlVulnerabilityAssessmentScanResultRuleStatus> status = default;
            Optional<IList<IList<string>>> resultsNotInBaseline = default;
            Optional<IList<IList<string>>> resultsOnlyInBaseline = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    baseline = SqlVulnerabilityAssessmentBaseline.DeserializeSqlVulnerabilityAssessmentBaseline(property.Value);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SqlVulnerabilityAssessmentScanResultRuleStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resultsNotInBaseline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<string>> array = new List<IList<string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<string> array0 = new List<string>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(item0.GetString());
                            }
                            array.Add(array0);
                        }
                    }
                    resultsNotInBaseline = array;
                    continue;
                }
                if (property.NameEquals("resultsOnlyInBaseline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<string>> array = new List<IList<string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<string> array0 = new List<string>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(item0.GetString());
                            }
                            array.Add(array0);
                        }
                    }
                    resultsOnlyInBaseline = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BaselineAdjustedResult(baseline.Value, Optional.ToNullable(status), Optional.ToList(resultsNotInBaseline), Optional.ToList(resultsOnlyInBaseline), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Baseline))
            {
                builder.Append("  baseline:");
                AppendChildObject(builder, Baseline, options, 2, false);
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                builder.AppendLine($" '{Status.ToString()}'");
            }

            if (Optional.IsCollectionDefined(ResultsNotInBaseline))
            {
                if (ResultsNotInBaseline.Any())
                {
                    builder.Append("  resultsNotInBaseline:");
                    builder.AppendLine(" [");
                    foreach (var item in ResultsNotInBaseline)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine(" [");
                        foreach (var item0 in item)
                        {
                            if (item0 == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"    '{item0}'");
                        }
                        builder.AppendLine("  ]");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(ResultsOnlyInBaseline))
            {
                if (ResultsOnlyInBaseline.Any())
                {
                    builder.Append("  resultsOnlyInBaseline:");
                    builder.AppendLine(" [");
                    foreach (var item in ResultsOnlyInBaseline)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine(" [");
                        foreach (var item0 in item)
                        {
                            if (item0 == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"    '{item0}'");
                        }
                        builder.AppendLine("  ]");
                    }
                    builder.AppendLine("  ]");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<BaselineAdjustedResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaselineAdjustedResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BaselineAdjustedResult)} does not support '{options.Format}' format.");
            }
        }

        BaselineAdjustedResult IPersistableModel<BaselineAdjustedResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaselineAdjustedResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBaselineAdjustedResult(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(BaselineAdjustedResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BaselineAdjustedResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
