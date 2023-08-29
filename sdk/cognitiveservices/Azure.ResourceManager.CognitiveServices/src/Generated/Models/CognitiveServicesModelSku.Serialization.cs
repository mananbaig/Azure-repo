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

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesModelSku : IUtf8JsonSerializable, IModelJsonSerializable<CognitiveServicesModelSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CognitiveServicesModelSku>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CognitiveServicesModelSku>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(UsageName))
            {
                writer.WritePropertyName("usageName"u8);
                writer.WriteStringValue(UsageName);
            }
            if (Optional.IsDefined(DeprecationOn))
            {
                writer.WritePropertyName("deprecationDate"u8);
                writer.WriteStringValue(DeprecationOn.Value, "O");
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity);
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

        internal static CognitiveServicesModelSku DeserializeCognitiveServicesModelSku(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> usageName = default;
            Optional<DateTimeOffset> deprecationDate = default;
            Optional<CognitiveServicesCapacityConfig> capacity = default;
            Optional<IReadOnlyList<ServiceAccountCallRateLimit>> rateLimits = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usageName"u8))
                {
                    usageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deprecationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deprecationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = CognitiveServicesCapacityConfig.DeserializeCognitiveServicesCapacityConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("rateLimits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAccountCallRateLimit> array = new List<ServiceAccountCallRateLimit>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAccountCallRateLimit.DeserializeServiceAccountCallRateLimit(item));
                    }
                    rateLimits = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CognitiveServicesModelSku(name.Value, usageName.Value, Optional.ToNullable(deprecationDate), capacity.Value, Optional.ToList(rateLimits), rawData);
        }

        CognitiveServicesModelSku IModelJsonSerializable<CognitiveServicesModelSku>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCognitiveServicesModelSku(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CognitiveServicesModelSku>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CognitiveServicesModelSku IModelSerializable<CognitiveServicesModelSku>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCognitiveServicesModelSku(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CognitiveServicesModelSku model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CognitiveServicesModelSku(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCognitiveServicesModelSku(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
