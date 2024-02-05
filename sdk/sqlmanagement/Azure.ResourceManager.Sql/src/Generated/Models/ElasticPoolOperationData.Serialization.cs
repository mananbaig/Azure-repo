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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolOperationData : IUtf8JsonSerializable, IJsonModel<ElasticPoolOperationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticPoolOperationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ElasticPoolOperationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolOperationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolOperationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ElasticPoolName))
            {
                writer.WritePropertyName("elasticPoolName"u8);
                writer.WriteStringValue(ElasticPoolName);
            }
            if (options.Format != "W" && Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation);
            }
            if (options.Format != "W" && Optional.IsDefined(OperationFriendlyName))
            {
                writer.WritePropertyName("operationFriendlyName"u8);
                writer.WriteStringValue(OperationFriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(PercentComplete))
            {
                writer.WritePropertyName("percentComplete"u8);
                writer.WriteNumberValue(PercentComplete.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteNumberValue(ErrorCode.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorDescription))
            {
                writer.WritePropertyName("errorDescription"u8);
                writer.WriteStringValue(ErrorDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorSeverity))
            {
                writer.WritePropertyName("errorSeverity"u8);
                writer.WriteNumberValue(ErrorSeverity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsUserError))
            {
                writer.WritePropertyName("isUserError"u8);
                writer.WriteBooleanValue(IsUserError.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EstimatedCompleteOn))
            {
                writer.WritePropertyName("estimatedCompletionTime"u8);
                writer.WriteStringValue(EstimatedCompleteOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(IsCancellable))
            {
                writer.WritePropertyName("isCancellable"u8);
                writer.WriteBooleanValue(IsCancellable.Value);
            }
            writer.WriteEndObject();
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

        ElasticPoolOperationData IJsonModel<ElasticPoolOperationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolOperationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolOperationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticPoolOperationData(document.RootElement, options);
        }

        internal static ElasticPoolOperationData DeserializeElasticPoolOperationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> elasticPoolName = default;
            Optional<string> operation = default;
            Optional<string> operationFriendlyName = default;
            Optional<int> percentComplete = default;
            Optional<string> serverName = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> state = default;
            Optional<int> errorCode = default;
            Optional<string> errorDescription = default;
            Optional<int> errorSeverity = default;
            Optional<bool> isUserError = default;
            Optional<DateTimeOffset> estimatedCompletionTime = default;
            Optional<string> description = default;
            Optional<bool> isCancellable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("elasticPoolName"u8))
                        {
                            elasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operation"u8))
                        {
                            operation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operationFriendlyName"u8))
                        {
                            operationFriendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("percentComplete"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentComplete = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorCode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorCode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("errorDescription"u8))
                        {
                            errorDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorSeverity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorSeverity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isUserError"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isUserError = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("estimatedCompletionTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            estimatedCompletionTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isCancellable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCancellable = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ElasticPoolOperationData(id, name, type, systemData.Value, elasticPoolName.Value, operation.Value, operationFriendlyName.Value, Optional.ToNullable(percentComplete), serverName.Value, Optional.ToNullable(startTime), state.Value, Optional.ToNullable(errorCode), errorDescription.Value, Optional.ToNullable(errorSeverity), Optional.ToNullable(isUserError), Optional.ToNullable(estimatedCompletionTime), description.Value, Optional.ToNullable(isCancellable), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(ElasticPoolName))
            {
                builder.Append("    elasticPoolName:");
                builder.AppendLine($" '{ElasticPoolName}'");
            }

            if (Optional.IsDefined(Operation))
            {
                builder.Append("    operation:");
                builder.AppendLine($" '{Operation}'");
            }

            if (Optional.IsDefined(OperationFriendlyName))
            {
                builder.Append("    operationFriendlyName:");
                builder.AppendLine($" '{OperationFriendlyName}'");
            }

            if (Optional.IsDefined(PercentComplete))
            {
                builder.Append("    percentComplete:");
                builder.AppendLine($" {PercentComplete.Value}");
            }

            if (Optional.IsDefined(ServerName))
            {
                builder.Append("    serverName:");
                builder.AppendLine($" '{ServerName}'");
            }

            if (Optional.IsDefined(StartOn))
            {
                builder.Append("    startTime:");
                var formattedDateTimeString = TypeFormatters.ToString(StartOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(State))
            {
                builder.Append("    state:");
                builder.AppendLine($" '{State}'");
            }

            if (Optional.IsDefined(ErrorCode))
            {
                builder.Append("    errorCode:");
                builder.AppendLine($" {ErrorCode.Value}");
            }

            if (Optional.IsDefined(ErrorDescription))
            {
                builder.Append("    errorDescription:");
                builder.AppendLine($" '{ErrorDescription}'");
            }

            if (Optional.IsDefined(ErrorSeverity))
            {
                builder.Append("    errorSeverity:");
                builder.AppendLine($" {ErrorSeverity.Value}");
            }

            if (Optional.IsDefined(IsUserError))
            {
                builder.Append("    isUserError:");
                var boolValue = IsUserError.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(EstimatedCompleteOn))
            {
                builder.Append("    estimatedCompletionTime:");
                var formattedDateTimeString = TypeFormatters.ToString(EstimatedCompleteOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(Description))
            {
                builder.Append("    description:");
                builder.AppendLine($" '{Description}'");
            }

            if (Optional.IsDefined(IsCancellable))
            {
                builder.Append("    isCancellable:");
                var boolValue = IsCancellable.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            builder.AppendLine("  }");
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

        BinaryData IPersistableModel<ElasticPoolOperationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolOperationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolOperationData)} does not support '{options.Format}' format.");
            }
        }

        ElasticPoolOperationData IPersistableModel<ElasticPoolOperationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolOperationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticPoolOperationData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolOperationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticPoolOperationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
