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
    public partial class EdifactAgreementContent : IUtf8JsonSerializable, IModelJsonSerializable<EdifactAgreementContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdifactAgreementContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdifactAgreementContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("receiveAgreement"u8);
            writer.WriteObjectValue(ReceiveAgreement);
            writer.WritePropertyName("sendAgreement"u8);
            writer.WriteObjectValue(SendAgreement);
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

        internal static EdifactAgreementContent DeserializeEdifactAgreementContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EdifactOneWayAgreement receiveAgreement = default;
            EdifactOneWayAgreement sendAgreement = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("receiveAgreement"u8))
                {
                    receiveAgreement = EdifactOneWayAgreement.DeserializeEdifactOneWayAgreement(property.Value);
                    continue;
                }
                if (property.NameEquals("sendAgreement"u8))
                {
                    sendAgreement = EdifactOneWayAgreement.DeserializeEdifactOneWayAgreement(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdifactAgreementContent(receiveAgreement, sendAgreement, rawData);
        }

        EdifactAgreementContent IModelJsonSerializable<EdifactAgreementContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdifactAgreementContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdifactAgreementContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdifactAgreementContent IModelSerializable<EdifactAgreementContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdifactAgreementContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EdifactAgreementContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EdifactAgreementContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdifactAgreementContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
