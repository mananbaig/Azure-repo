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

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class InstancesSortParameter : IUtf8JsonSerializable, IModelJsonSerializable<InstancesSortParameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InstancesSortParameter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InstancesSortParameter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstancesSortParameter>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(By))
            {
                writer.WritePropertyName("by"u8);
                writer.WriteStringValue(By.Value.ToString());
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

        internal static InstancesSortParameter DeserializeInstancesSortParameter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<InstancesSortBy> @by = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("by"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @by = new InstancesSortBy(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InstancesSortParameter(Optional.ToNullable(@by), serializedAdditionalRawData);
        }

        InstancesSortParameter IModelJsonSerializable<InstancesSortParameter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstancesSortParameter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInstancesSortParameter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InstancesSortParameter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstancesSortParameter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InstancesSortParameter IModelSerializable<InstancesSortParameter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstancesSortParameter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInstancesSortParameter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InstancesSortParameter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InstancesSortParameter"/> to convert. </param>
        public static implicit operator RequestContent(InstancesSortParameter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InstancesSortParameter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InstancesSortParameter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInstancesSortParameter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
