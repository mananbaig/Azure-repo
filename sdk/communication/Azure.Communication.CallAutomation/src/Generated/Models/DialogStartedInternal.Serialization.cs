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
    internal partial class DialogStartedInternal : IUtf8JsonSerializable, IModelJsonSerializable<DialogStartedInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DialogStartedInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DialogStartedInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static DialogStartedInternal DeserializeDialogStartedInternal(JsonElement element, ModelSerializerOptions options = default)
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DialogStartedInternal(callConnectionId.Value, serverCallId.Value, correlationId.Value, operationContext.Value, resultInformation.Value, Optional.ToNullable(dialogInputType), dialogId.Value, rawData);
        }

        DialogStartedInternal IModelJsonSerializable<DialogStartedInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDialogStartedInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DialogStartedInternal>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DialogStartedInternal IModelSerializable<DialogStartedInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDialogStartedInternal(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DialogStartedInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DialogStartedInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDialogStartedInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
