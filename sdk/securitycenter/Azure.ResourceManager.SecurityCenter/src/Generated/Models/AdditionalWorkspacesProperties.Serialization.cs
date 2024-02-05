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
    public partial class AdditionalWorkspacesProperties : IUtf8JsonSerializable, IJsonModel<AdditionalWorkspacesProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdditionalWorkspacesProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AdditionalWorkspacesProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalWorkspacesProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdditionalWorkspacesProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Workspace))
            {
                writer.WritePropertyName("workspace"u8);
                writer.WriteStringValue(Workspace);
            }
            if (Optional.IsDefined(WorkspaceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(WorkspaceType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DataTypes))
            {
                writer.WritePropertyName("dataTypes"u8);
                writer.WriteStartArray();
                foreach (var item in DataTypes)
                {
                    writer.WriteStringValue(item.ToString());
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

        AdditionalWorkspacesProperties IJsonModel<AdditionalWorkspacesProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalWorkspacesProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdditionalWorkspacesProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdditionalWorkspacesProperties(document.RootElement, options);
        }

        internal static AdditionalWorkspacesProperties DeserializeAdditionalWorkspacesProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> workspace = default;
            Optional<AdditionalWorkspaceType> type = default;
            Optional<IList<AdditionalWorkspaceDataType>> dataTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspace"u8))
                {
                    workspace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AdditionalWorkspaceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AdditionalWorkspaceDataType> array = new List<AdditionalWorkspaceDataType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AdditionalWorkspaceDataType(item.GetString()));
                    }
                    dataTypes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AdditionalWorkspacesProperties(workspace.Value, Optional.ToNullable(type), Optional.ToList(dataTypes), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Workspace))
            {
                builder.Append("  workspace:");
                builder.AppendLine($" '{Workspace}'");
            }

            if (Optional.IsDefined(WorkspaceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{WorkspaceType.ToString()}'");
            }

            if (Optional.IsCollectionDefined(DataTypes))
            {
                if (DataTypes.Any())
                {
                    builder.Append("  dataTypes:");
                    builder.AppendLine(" [");
                    foreach (var item in DataTypes)
                    {
                        builder.AppendLine($"    '{item.ToString()}'");
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

        BinaryData IPersistableModel<AdditionalWorkspacesProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalWorkspacesProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AdditionalWorkspacesProperties)} does not support '{options.Format}' format.");
            }
        }

        AdditionalWorkspacesProperties IPersistableModel<AdditionalWorkspacesProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalWorkspacesProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAdditionalWorkspacesProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AdditionalWorkspacesProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdditionalWorkspacesProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
