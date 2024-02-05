// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SecurityEvent : IUtf8JsonSerializable, IJsonModel<SecurityEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityEvent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityEvent)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(EventOn))
            {
                writer.WritePropertyName("eventTime"u8);
                writer.WriteStringValue(EventOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(SecurityEventType))
            {
                writer.WritePropertyName("securityEventType"u8);
                writer.WriteStringValue(SecurityEventType.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(Subscription))
            {
                writer.WritePropertyName("subscription"u8);
                writer.WriteStringValue(Subscription);
            }
            if (options.Format != "W" && Optional.IsDefined(Server))
            {
                writer.WritePropertyName("server"u8);
                writer.WriteStringValue(Server);
            }
            if (options.Format != "W" && Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database"u8);
                writer.WriteStringValue(Database);
            }
            if (options.Format != "W" && Optional.IsDefined(ClientIP))
            {
                writer.WritePropertyName("clientIp"u8);
                writer.WriteStringValue(ClientIP.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ApplicationName))
            {
                writer.WritePropertyName("applicationName"u8);
                writer.WriteStringValue(ApplicationName);
            }
            if (options.Format != "W" && Optional.IsDefined(PrincipalName))
            {
                writer.WritePropertyName("principalName"u8);
                writer.WriteStringValue(PrincipalName);
            }
            if (options.Format != "W" && Optional.IsDefined(SecurityEventSqlInjectionAdditionalProperties))
            {
                writer.WritePropertyName("securityEventSqlInjectionAdditionalProperties"u8);
                writer.WriteObjectValue(SecurityEventSqlInjectionAdditionalProperties);
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

        SecurityEvent IJsonModel<SecurityEvent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityEvent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityEvent(document.RootElement, options);
        }

        internal static SecurityEvent DeserializeSecurityEvent(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<DateTimeOffset> eventTime = default;
            Optional<SecurityEventType> securityEventType = default;
            Optional<string> subscription = default;
            Optional<string> server = default;
            Optional<string> database = default;
            Optional<IPAddress> clientIP = default;
            Optional<string> applicationName = default;
            Optional<string> principalName = default;
            Optional<SecurityEventSqlInjectionAdditionalProperties> securityEventSqlInjectionAdditionalProperties = default;
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
                        if (property0.NameEquals("eventTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("securityEventType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityEventType = property0.Value.GetString().ToSecurityEventType();
                            continue;
                        }
                        if (property0.NameEquals("subscription"u8))
                        {
                            subscription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("server"u8))
                        {
                            server = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("database"u8))
                        {
                            database = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientIp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientIP = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applicationName"u8))
                        {
                            applicationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("principalName"u8))
                        {
                            principalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("securityEventSqlInjectionAdditionalProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityEventSqlInjectionAdditionalProperties = SecurityEventSqlInjectionAdditionalProperties.DeserializeSecurityEventSqlInjectionAdditionalProperties(property0.Value);
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
            return new SecurityEvent(id, name, type, systemData.Value, Optional.ToNullable(eventTime), Optional.ToNullable(securityEventType), subscription.Value, server.Value, database.Value, clientIP.Value, applicationName.Value, principalName.Value, securityEventSqlInjectionAdditionalProperties.Value, serializedAdditionalRawData);
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
            if (Optional.IsDefined(EventOn))
            {
                builder.Append("    eventTime:");
                var formattedDateTimeString = TypeFormatters.ToString(EventOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(SecurityEventType))
            {
                builder.Append("    securityEventType:");
                builder.AppendLine($" '{SecurityEventType.ToString()}'");
            }

            if (Optional.IsDefined(Subscription))
            {
                builder.Append("    subscription:");
                builder.AppendLine($" '{Subscription}'");
            }

            if (Optional.IsDefined(Server))
            {
                builder.Append("    server:");
                builder.AppendLine($" '{Server}'");
            }

            if (Optional.IsDefined(Database))
            {
                builder.Append("    database:");
                builder.AppendLine($" '{Database}'");
            }

            if (Optional.IsDefined(ClientIP))
            {
                builder.Append("    clientIp:");
                builder.AppendLine($" '{ClientIP.ToString()}'");
            }

            if (Optional.IsDefined(ApplicationName))
            {
                builder.Append("    applicationName:");
                builder.AppendLine($" '{ApplicationName}'");
            }

            if (Optional.IsDefined(PrincipalName))
            {
                builder.Append("    principalName:");
                builder.AppendLine($" '{PrincipalName}'");
            }

            if (Optional.IsDefined(SecurityEventSqlInjectionAdditionalProperties))
            {
                builder.Append("    securityEventSqlInjectionAdditionalProperties:");
                AppendChildObject(builder, SecurityEventSqlInjectionAdditionalProperties, options, 4, false);
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

        BinaryData IPersistableModel<SecurityEvent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityEvent)} does not support '{options.Format}' format.");
            }
        }

        SecurityEvent IPersistableModel<SecurityEvent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityEvent(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SecurityEvent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityEvent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
