// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SecurityEventSqlInjectionAdditionalProperties : IUtf8JsonSerializable, IJsonModel<SecurityEventSqlInjectionAdditionalProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityEventSqlInjectionAdditionalProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SecurityEventSqlInjectionAdditionalProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ThreatId))
                {
                    writer.WritePropertyName("threatId"u8);
                    writer.WriteStringValue(ThreatId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Statement))
                {
                    writer.WritePropertyName("statement"u8);
                    writer.WriteStringValue(Statement);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(StatementHighlightOffset))
                {
                    writer.WritePropertyName("statementHighlightOffset"u8);
                    writer.WriteNumberValue(StatementHighlightOffset.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(StatementHighlightLength))
                {
                    writer.WritePropertyName("statementHighlightLength"u8);
                    writer.WriteNumberValue(StatementHighlightLength.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ErrorCode))
                {
                    writer.WritePropertyName("errorCode"u8);
                    writer.WriteNumberValue(ErrorCode.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ErrorSeverity))
                {
                    writer.WritePropertyName("errorSeverity"u8);
                    writer.WriteNumberValue(ErrorSeverity.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ErrorMessage))
                {
                    writer.WritePropertyName("errorMessage"u8);
                    writer.WriteStringValue(ErrorMessage);
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        SecurityEventSqlInjectionAdditionalProperties IJsonModel<SecurityEventSqlInjectionAdditionalProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityEventSqlInjectionAdditionalProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityEventSqlInjectionAdditionalProperties(document.RootElement, options);
        }

        internal static SecurityEventSqlInjectionAdditionalProperties DeserializeSecurityEventSqlInjectionAdditionalProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> threatId = default;
            Optional<string> statement = default;
            Optional<int> statementHighlightOffset = default;
            Optional<int> statementHighlightLength = default;
            Optional<int> errorCode = default;
            Optional<int> errorSeverity = default;
            Optional<string> errorMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("threatId"u8))
                {
                    threatId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statement"u8))
                {
                    statement = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statementHighlightOffset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statementHighlightOffset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("statementHighlightLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statementHighlightLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorSeverity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorSeverity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityEventSqlInjectionAdditionalProperties(threatId.Value, statement.Value, Optional.ToNullable(statementHighlightOffset), Optional.ToNullable(statementHighlightLength), Optional.ToNullable(errorCode), Optional.ToNullable(errorSeverity), errorMessage.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<SecurityEventSqlInjectionAdditionalProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityEventSqlInjectionAdditionalProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SecurityEventSqlInjectionAdditionalProperties IModel<SecurityEventSqlInjectionAdditionalProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityEventSqlInjectionAdditionalProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSecurityEventSqlInjectionAdditionalProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SecurityEventSqlInjectionAdditionalProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
