// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class X12OneWayAgreement : IUtf8JsonSerializable, IModelJsonSerializable<X12OneWayAgreement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<X12OneWayAgreement>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<X12OneWayAgreement>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("senderBusinessIdentity"u8);
            writer.WriteObjectValue(SenderBusinessIdentity);
            writer.WritePropertyName("receiverBusinessIdentity"u8);
            writer.WriteObjectValue(ReceiverBusinessIdentity);
            writer.WritePropertyName("protocolSettings"u8);
            writer.WriteObjectValue(ProtocolSettings);
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

        internal static X12OneWayAgreement DeserializeX12OneWayAgreement(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationAccountBusinessIdentity senderBusinessIdentity = default;
            IntegrationAccountBusinessIdentity receiverBusinessIdentity = default;
            X12ProtocolSettings protocolSettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("senderBusinessIdentity"u8))
                {
                    senderBusinessIdentity = IntegrationAccountBusinessIdentity.DeserializeIntegrationAccountBusinessIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("receiverBusinessIdentity"u8))
                {
                    receiverBusinessIdentity = IntegrationAccountBusinessIdentity.DeserializeIntegrationAccountBusinessIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("protocolSettings"u8))
                {
                    protocolSettings = X12ProtocolSettings.DeserializeX12ProtocolSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new X12OneWayAgreement(senderBusinessIdentity, receiverBusinessIdentity, protocolSettings, rawData);
        }

        X12OneWayAgreement IModelJsonSerializable<X12OneWayAgreement>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeX12OneWayAgreement(doc.RootElement, options);
        }

        BinaryData IModelSerializable<X12OneWayAgreement>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        X12OneWayAgreement IModelSerializable<X12OneWayAgreement>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeX12OneWayAgreement(doc.RootElement, options);
        }

        public static implicit operator RequestContent(X12OneWayAgreement model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator X12OneWayAgreement(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeX12OneWayAgreement(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
