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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ProviderHubExtendedLocationOptions : IUtf8JsonSerializable, IModelJsonSerializable<ProviderHubExtendedLocationOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProviderHubExtendedLocationOptions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProviderHubExtendedLocationOptions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocationOptionsType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ExtendedLocationOptionsType);
            }
            if (Optional.IsDefined(SupportedPolicy))
            {
                writer.WritePropertyName("supportedPolicy"u8);
                writer.WriteStringValue(SupportedPolicy);
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

        internal static ProviderHubExtendedLocationOptions DeserializeProviderHubExtendedLocationOptions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> type = default;
            Optional<string> supportedPolicy = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedPolicy"u8))
                {
                    supportedPolicy = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProviderHubExtendedLocationOptions(type.Value, supportedPolicy.Value, rawData);
        }

        ProviderHubExtendedLocationOptions IModelJsonSerializable<ProviderHubExtendedLocationOptions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderHubExtendedLocationOptions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProviderHubExtendedLocationOptions>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProviderHubExtendedLocationOptions IModelSerializable<ProviderHubExtendedLocationOptions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProviderHubExtendedLocationOptions(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ProviderHubExtendedLocationOptions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ProviderHubExtendedLocationOptions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProviderHubExtendedLocationOptions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
