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

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicObservabilityAccountInfo : IUtf8JsonSerializable, IModelJsonSerializable<NewRelicObservabilityAccountInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NewRelicObservabilityAccountInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NewRelicObservabilityAccountInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AccountId))
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteStringValue(AccountId);
            }
            if (Optional.IsDefined(IngestionKey))
            {
                writer.WritePropertyName("ingestionKey"u8);
                writer.WriteStringValue(IngestionKey);
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region.Value);
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

        internal static NewRelicObservabilityAccountInfo DeserializeNewRelicObservabilityAccountInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> accountId = default;
            Optional<string> ingestionKey = default;
            Optional<AzureLocation> region = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountId"u8))
                {
                    accountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ingestionKey"u8))
                {
                    ingestionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    region = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NewRelicObservabilityAccountInfo(accountId.Value, ingestionKey.Value, Optional.ToNullable(region), rawData);
        }

        NewRelicObservabilityAccountInfo IModelJsonSerializable<NewRelicObservabilityAccountInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicObservabilityAccountInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NewRelicObservabilityAccountInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NewRelicObservabilityAccountInfo IModelSerializable<NewRelicObservabilityAccountInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNewRelicObservabilityAccountInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NewRelicObservabilityAccountInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NewRelicObservabilityAccountInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNewRelicObservabilityAccountInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
