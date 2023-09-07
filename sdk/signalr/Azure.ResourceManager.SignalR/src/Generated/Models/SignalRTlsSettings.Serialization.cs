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

namespace Azure.ResourceManager.SignalR.Models
{
    internal partial class SignalRTlsSettings : IUtf8JsonSerializable, IModelJsonSerializable<SignalRTlsSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SignalRTlsSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SignalRTlsSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SignalRTlsSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsClientCertEnabled))
            {
                writer.WritePropertyName("clientCertEnabled"u8);
                writer.WriteBooleanValue(IsClientCertEnabled.Value);
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static SignalRTlsSettings DeserializeSignalRTlsSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> clientCertEnabled = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientCertEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientCertEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SignalRTlsSettings(Optional.ToNullable(clientCertEnabled), serializedAdditionalRawData);
        }

        SignalRTlsSettings IModelJsonSerializable<SignalRTlsSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SignalRTlsSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSignalRTlsSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SignalRTlsSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SignalRTlsSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SignalRTlsSettings IModelSerializable<SignalRTlsSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SignalRTlsSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSignalRTlsSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SignalRTlsSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SignalRTlsSettings"/> to convert. </param>
        public static implicit operator RequestContent(SignalRTlsSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SignalRTlsSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SignalRTlsSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSignalRTlsSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
