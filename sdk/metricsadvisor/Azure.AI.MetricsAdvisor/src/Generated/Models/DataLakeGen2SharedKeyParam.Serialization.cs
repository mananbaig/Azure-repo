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

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class DataLakeGen2SharedKeyParam : IUtf8JsonSerializable, IModelJsonSerializable<DataLakeGen2SharedKeyParam>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataLakeGen2SharedKeyParam>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataLakeGen2SharedKeyParam>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AccountKey))
            {
                writer.WritePropertyName("accountKey"u8);
                writer.WriteStringValue(AccountKey);
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

        internal static DataLakeGen2SharedKeyParam DeserializeDataLakeGen2SharedKeyParam(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> accountKey = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountKey"u8))
                {
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataLakeGen2SharedKeyParam(accountKey.Value, rawData);
        }

        DataLakeGen2SharedKeyParam IModelJsonSerializable<DataLakeGen2SharedKeyParam>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeGen2SharedKeyParam(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataLakeGen2SharedKeyParam>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataLakeGen2SharedKeyParam IModelSerializable<DataLakeGen2SharedKeyParam>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataLakeGen2SharedKeyParam(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DataLakeGen2SharedKeyParam model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DataLakeGen2SharedKeyParam(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataLakeGen2SharedKeyParam(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
