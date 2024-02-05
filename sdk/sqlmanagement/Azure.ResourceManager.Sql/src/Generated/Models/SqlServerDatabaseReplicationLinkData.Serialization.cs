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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerDatabaseReplicationLinkData : IUtf8JsonSerializable, IJsonModel<SqlServerDatabaseReplicationLinkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerDatabaseReplicationLinkData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlServerDatabaseReplicationLinkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseReplicationLinkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerDatabaseReplicationLinkData)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(PartnerServer))
            {
                writer.WritePropertyName("partnerServer"u8);
                writer.WriteStringValue(PartnerServer);
            }
            if (options.Format != "W" && Optional.IsDefined(PartnerDatabase))
            {
                writer.WritePropertyName("partnerDatabase"u8);
                writer.WriteStringValue(PartnerDatabase);
            }
            if (options.Format != "W" && Optional.IsDefined(PartnerLocation))
            {
                writer.WritePropertyName("partnerLocation"u8);
                writer.WriteStringValue(PartnerLocation.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(PartnerRole))
            {
                writer.WritePropertyName("partnerRole"u8);
                writer.WriteStringValue(PartnerRole.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationMode))
            {
                writer.WritePropertyName("replicationMode"u8);
                writer.WriteStringValue(ReplicationMode);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(PercentComplete))
            {
                writer.WritePropertyName("percentComplete"u8);
                writer.WriteNumberValue(PercentComplete.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationState))
            {
                writer.WritePropertyName("replicationState"u8);
                writer.WriteStringValue(ReplicationState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IsTerminationAllowed))
            {
                writer.WritePropertyName("isTerminationAllowed"u8);
                writer.WriteBooleanValue(IsTerminationAllowed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LinkType))
            {
                writer.WritePropertyName("linkType"u8);
                writer.WriteStringValue(LinkType.Value.ToString());
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

        SqlServerDatabaseReplicationLinkData IJsonModel<SqlServerDatabaseReplicationLinkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseReplicationLinkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerDatabaseReplicationLinkData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerDatabaseReplicationLinkData(document.RootElement, options);
        }

        internal static SqlServerDatabaseReplicationLinkData DeserializeSqlServerDatabaseReplicationLinkData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> partnerServer = default;
            Optional<string> partnerDatabase = default;
            Optional<AzureLocation> partnerLocation = default;
            Optional<SqlServerDatabaseReplicationRole> role = default;
            Optional<SqlServerDatabaseReplicationRole> partnerRole = default;
            Optional<string> replicationMode = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<int> percentComplete = default;
            Optional<ReplicationLinkState> replicationState = default;
            Optional<bool> isTerminationAllowed = default;
            Optional<ReplicationLinkType> linkType = default;
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
                        if (property0.NameEquals("partnerServer"u8))
                        {
                            partnerServer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerDatabase"u8))
                        {
                            partnerDatabase = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("role"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            role = property0.Value.GetString().ToSqlServerDatabaseReplicationRole();
                            continue;
                        }
                        if (property0.NameEquals("partnerRole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerRole = property0.Value.GetString().ToSqlServerDatabaseReplicationRole();
                            continue;
                        }
                        if (property0.NameEquals("replicationMode"u8))
                        {
                            replicationMode = property0.Value.GetString();
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
                        if (property0.NameEquals("percentComplete"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentComplete = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("replicationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationState = new ReplicationLinkState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isTerminationAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isTerminationAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("linkType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkType = new ReplicationLinkType(property0.Value.GetString());
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
            return new SqlServerDatabaseReplicationLinkData(id, name, type, systemData.Value, partnerServer.Value, partnerDatabase.Value, Optional.ToNullable(partnerLocation), Optional.ToNullable(role), Optional.ToNullable(partnerRole), replicationMode.Value, Optional.ToNullable(startTime), Optional.ToNullable(percentComplete), Optional.ToNullable(replicationState), Optional.ToNullable(isTerminationAllowed), Optional.ToNullable(linkType), serializedAdditionalRawData);
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
            if (Optional.IsDefined(PartnerServer))
            {
                builder.Append("    partnerServer:");
                builder.AppendLine($" '{PartnerServer}'");
            }

            if (Optional.IsDefined(PartnerDatabase))
            {
                builder.Append("    partnerDatabase:");
                builder.AppendLine($" '{PartnerDatabase}'");
            }

            if (Optional.IsDefined(PartnerLocation))
            {
                builder.Append("    partnerLocation:");
                builder.AppendLine($" '{PartnerLocation.Value.ToString()}'");
            }

            if (Optional.IsDefined(Role))
            {
                builder.Append("    role:");
                builder.AppendLine($" '{Role.ToString()}'");
            }

            if (Optional.IsDefined(PartnerRole))
            {
                builder.Append("    partnerRole:");
                builder.AppendLine($" '{PartnerRole.ToString()}'");
            }

            if (Optional.IsDefined(ReplicationMode))
            {
                builder.Append("    replicationMode:");
                builder.AppendLine($" '{ReplicationMode}'");
            }

            if (Optional.IsDefined(StartOn))
            {
                builder.Append("    startTime:");
                var formattedDateTimeString = TypeFormatters.ToString(StartOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(PercentComplete))
            {
                builder.Append("    percentComplete:");
                builder.AppendLine($" {PercentComplete.Value}");
            }

            if (Optional.IsDefined(ReplicationState))
            {
                builder.Append("    replicationState:");
                builder.AppendLine($" '{ReplicationState.ToString()}'");
            }

            if (Optional.IsDefined(IsTerminationAllowed))
            {
                builder.Append("    isTerminationAllowed:");
                var boolValue = IsTerminationAllowed.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(LinkType))
            {
                builder.Append("    linkType:");
                builder.AppendLine($" '{LinkType.ToString()}'");
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

        BinaryData IPersistableModel<SqlServerDatabaseReplicationLinkData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseReplicationLinkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SqlServerDatabaseReplicationLinkData)} does not support '{options.Format}' format.");
            }
        }

        SqlServerDatabaseReplicationLinkData IPersistableModel<SqlServerDatabaseReplicationLinkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerDatabaseReplicationLinkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlServerDatabaseReplicationLinkData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SqlServerDatabaseReplicationLinkData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerDatabaseReplicationLinkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
