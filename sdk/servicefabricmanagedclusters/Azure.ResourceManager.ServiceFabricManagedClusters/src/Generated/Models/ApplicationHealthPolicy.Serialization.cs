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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ApplicationHealthPolicy : IUtf8JsonSerializable, IJsonModel<ApplicationHealthPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationHealthPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationHealthPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationHealthPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("considerWarningAsError"u8);
            writer.WriteBooleanValue(ConsiderWarningAsError);
            writer.WritePropertyName("maxPercentUnhealthyDeployedApplications"u8);
            writer.WriteNumberValue(MaxPercentUnhealthyDeployedApplications);
            if (Optional.IsDefined(DefaultServiceTypeHealthPolicy))
            {
                writer.WritePropertyName("defaultServiceTypeHealthPolicy"u8);
                writer.WriteObjectValue(DefaultServiceTypeHealthPolicy);
            }
            if (Optional.IsCollectionDefined(ServiceTypeHealthPolicyMap))
            {
                writer.WritePropertyName("serviceTypeHealthPolicyMap"u8);
                writer.WriteStartObject();
                foreach (var item in ServiceTypeHealthPolicyMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        ApplicationHealthPolicy IJsonModel<ApplicationHealthPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationHealthPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationHealthPolicy(document.RootElement, options);
        }

        internal static ApplicationHealthPolicy DeserializeApplicationHealthPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool considerWarningAsError = default;
            int maxPercentUnhealthyDeployedApplications = default;
            Optional<ServiceTypeHealthPolicy> defaultServiceTypeHealthPolicy = default;
            Optional<IDictionary<string, ServiceTypeHealthPolicy>> serviceTypeHealthPolicyMap = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("considerWarningAsError"u8))
                {
                    considerWarningAsError = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyDeployedApplications"u8))
                {
                    maxPercentUnhealthyDeployedApplications = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("defaultServiceTypeHealthPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultServiceTypeHealthPolicy = ServiceTypeHealthPolicy.DeserializeServiceTypeHealthPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("serviceTypeHealthPolicyMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ServiceTypeHealthPolicy> dictionary = new Dictionary<string, ServiceTypeHealthPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ServiceTypeHealthPolicy.DeserializeServiceTypeHealthPolicy(property0.Value));
                    }
                    serviceTypeHealthPolicyMap = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationHealthPolicy(considerWarningAsError, maxPercentUnhealthyDeployedApplications, defaultServiceTypeHealthPolicy.Value, Optional.ToDictionary(serviceTypeHealthPolicyMap), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ConsiderWarningAsError))
            {
                builder.Append("  considerWarningAsError:");
                var boolValue = ConsiderWarningAsError == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(MaxPercentUnhealthyDeployedApplications))
            {
                builder.Append("  maxPercentUnhealthyDeployedApplications:");
                builder.AppendLine($" {MaxPercentUnhealthyDeployedApplications}");
            }

            if (Optional.IsDefined(DefaultServiceTypeHealthPolicy))
            {
                builder.Append("  defaultServiceTypeHealthPolicy:");
                AppendChildObject(builder, DefaultServiceTypeHealthPolicy, options, 2, false);
            }

            if (Optional.IsCollectionDefined(ServiceTypeHealthPolicyMap))
            {
                if (ServiceTypeHealthPolicyMap.Any())
                {
                    builder.Append("  serviceTypeHealthPolicyMap:");
                    builder.AppendLine(" {");
                    foreach (var item in ServiceTypeHealthPolicyMap)
                    {
                        builder.Append($"    {item.Key}: ");
                        AppendChildObject(builder, item.Value, options, 4, false);
                    }
                    builder.AppendLine("  }");
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

        BinaryData IPersistableModel<ApplicationHealthPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        ApplicationHealthPolicy IPersistableModel<ApplicationHealthPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationHealthPolicy(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ApplicationHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationHealthPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
