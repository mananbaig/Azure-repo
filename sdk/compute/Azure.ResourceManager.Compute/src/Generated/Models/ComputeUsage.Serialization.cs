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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ComputeUsage : IUtf8JsonSerializable, IModelJsonSerializable<ComputeUsage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ComputeUsage>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ComputeUsage>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("unit"u8);
            writer.WriteStringValue(Unit.ToString());
            writer.WritePropertyName("currentValue"u8);
            writer.WriteNumberValue(CurrentValue);
            writer.WritePropertyName("limit"u8);
            writer.WriteNumberValue(Limit);
            writer.WritePropertyName("name"u8);
            if (Name is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ComputeUsageName>)Name).Serialize(writer, options);
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

        internal static ComputeUsage DeserializeComputeUsage(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ComputeUsageUnit unit = default;
            int currentValue = default;
            long limit = default;
            ComputeUsageName name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unit"u8))
                {
                    unit = new ComputeUsageUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentValue"u8))
                {
                    currentValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = ComputeUsageName.DeserializeComputeUsageName(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ComputeUsage(unit, currentValue, limit, name, rawData);
        }

        ComputeUsage IModelJsonSerializable<ComputeUsage>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeUsage(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ComputeUsage>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ComputeUsage IModelSerializable<ComputeUsage>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeComputeUsage(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ComputeUsage"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ComputeUsage"/> to convert. </param>
        public static implicit operator RequestContent(ComputeUsage model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ComputeUsage"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ComputeUsage(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeComputeUsage(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
