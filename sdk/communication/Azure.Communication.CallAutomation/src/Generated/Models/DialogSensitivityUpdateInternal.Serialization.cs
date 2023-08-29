// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Communication.CallAutomation;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.CallAutomation.Models.Events
{
    internal partial class DialogSensitivityUpdateInternal : IUtf8JsonSerializable, IModelJsonSerializable<DialogSensitivityUpdateInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DialogSensitivityUpdateInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DialogSensitivityUpdateInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ServerCallId))
            {
                writer.WritePropertyName("serverCallId"u8);
                writer.WriteStringValue(ServerCallId);
            }
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (Optional.IsDefined(DialogInputType))
            {
                writer.WritePropertyName("dialogInputType"u8);
                writer.WriteStringValue(DialogInputType.Value.ToString());
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static DialogSensitivityUpdateInternal DeserializeDialogSensitivityUpdateInternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> callConnectionId = default;
            Optional<string> serverCallId = default;
            Optional<string> correlationId = default;
            Optional<string> operationContext = default;
            Optional<ResultInformation> resultInformation = default;
            Optional<DialogInputType> dialogInputType = default;
            Optional<string> dialogId = default;
            Optional<bool> sensitiveMask = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("dialogInputType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dialogInputType = new DialogInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dialogId"u8))
                {
                    dialogId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sensitiveMask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitiveMask = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DialogSensitivityUpdateInternal(callConnectionId.Value, serverCallId.Value, correlationId.Value, operationContext.Value, resultInformation.Value, Optional.ToNullable(dialogInputType), dialogId.Value, Optional.ToNullable(sensitiveMask), rawData);
        }

        DialogSensitivityUpdateInternal IModelJsonSerializable<DialogSensitivityUpdateInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDialogSensitivityUpdateInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DialogSensitivityUpdateInternal>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DialogSensitivityUpdateInternal IModelSerializable<DialogSensitivityUpdateInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDialogSensitivityUpdateInternal(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DialogSensitivityUpdateInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DialogSensitivityUpdateInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDialogSensitivityUpdateInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
