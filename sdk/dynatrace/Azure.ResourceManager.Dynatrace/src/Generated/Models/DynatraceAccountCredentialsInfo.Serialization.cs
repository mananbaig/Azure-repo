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

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceAccountCredentialsInfo : IUtf8JsonSerializable, IModelJsonSerializable<DynatraceAccountCredentialsInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DynatraceAccountCredentialsInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DynatraceAccountCredentialsInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceAccountCredentialsInfo>(this, options.Format);

            writer.WriteStartObject();
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

        internal static DynatraceAccountCredentialsInfo DeserializeDynatraceAccountCredentialsInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> accountId = default;
            Optional<string> apiKey = default;
            Optional<string> regionId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountId"u8))
                {
                    accountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiKey"u8))
                {
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionId"u8))
                {
                    regionId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DynatraceAccountCredentialsInfo(accountId.Value, apiKey.Value, regionId.Value, serializedAdditionalRawData);
        }

        DynatraceAccountCredentialsInfo IModelJsonSerializable<DynatraceAccountCredentialsInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceAccountCredentialsInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceAccountCredentialsInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DynatraceAccountCredentialsInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceAccountCredentialsInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DynatraceAccountCredentialsInfo IModelSerializable<DynatraceAccountCredentialsInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceAccountCredentialsInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDynatraceAccountCredentialsInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DynatraceAccountCredentialsInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DynatraceAccountCredentialsInfo"/> to convert. </param>
        public static implicit operator RequestContent(DynatraceAccountCredentialsInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DynatraceAccountCredentialsInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DynatraceAccountCredentialsInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDynatraceAccountCredentialsInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
