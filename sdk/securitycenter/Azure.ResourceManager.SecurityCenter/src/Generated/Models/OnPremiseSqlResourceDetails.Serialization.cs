// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class OnPremiseSqlResourceDetails : IUtf8JsonSerializable, IJsonModel<OnPremiseSqlResourceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OnPremiseSqlResourceDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OnPremiseSqlResourceDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnPremiseSqlResourceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnPremiseSqlResourceDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("serverName"u8);
            writer.WriteStringValue(ServerName);
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("workspaceId"u8);
            writer.WriteStringValue(WorkspaceId);
            writer.WritePropertyName("vmuuid"u8);
            writer.WriteStringValue(VmUuid);
            writer.WritePropertyName("sourceComputerId"u8);
            writer.WriteStringValue(SourceComputerId);
            writer.WritePropertyName("machineName"u8);
            writer.WriteStringValue(MachineName);
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source.ToString());
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

        OnPremiseSqlResourceDetails IJsonModel<OnPremiseSqlResourceDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnPremiseSqlResourceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnPremiseSqlResourceDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOnPremiseSqlResourceDetails(document.RootElement, options);
        }

        internal static OnPremiseSqlResourceDetails DeserializeOnPremiseSqlResourceDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serverName = default;
            string databaseName = default;
            ResourceIdentifier workspaceId = default;
            Guid vmuuid = default;
            string sourceComputerId = default;
            string machineName = default;
            HealthReportSource source = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmuuid"u8))
                {
                    vmuuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("sourceComputerId"u8))
                {
                    sourceComputerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = new HealthReportSource(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OnPremiseSqlResourceDetails(source, serializedAdditionalRawData, workspaceId, vmuuid, sourceComputerId, machineName, serverName, databaseName);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ServerName))
            {
                builder.Append("  serverName:");
                builder.AppendLine($" '{ServerName}'");
            }

            if (Optional.IsDefined(DatabaseName))
            {
                builder.Append("  databaseName:");
                builder.AppendLine($" '{DatabaseName}'");
            }

            if (Optional.IsDefined(WorkspaceId))
            {
                builder.Append("  workspaceId:");
                builder.AppendLine($" '{WorkspaceId.ToString()}'");
            }

            if (Optional.IsDefined(VmUuid))
            {
                builder.Append("  vmuuid:");
                builder.AppendLine($" '{VmUuid.ToString()}'");
            }

            if (Optional.IsDefined(SourceComputerId))
            {
                builder.Append("  sourceComputerId:");
                builder.AppendLine($" '{SourceComputerId}'");
            }

            if (Optional.IsDefined(MachineName))
            {
                builder.Append("  machineName:");
                builder.AppendLine($" '{MachineName}'");
            }

            if (Optional.IsDefined(Source))
            {
                builder.Append("  source:");
                builder.AppendLine($" '{Source.ToString()}'");
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

        BinaryData IPersistableModel<OnPremiseSqlResourceDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnPremiseSqlResourceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OnPremiseSqlResourceDetails)} does not support '{options.Format}' format.");
            }
        }

        OnPremiseSqlResourceDetails IPersistableModel<OnPremiseSqlResourceDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnPremiseSqlResourceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOnPremiseSqlResourceDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(OnPremiseSqlResourceDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OnPremiseSqlResourceDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
