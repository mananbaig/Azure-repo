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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class NumberGreaterThanOrEqualsAdvancedFilter : IUtf8JsonSerializable, IModelJsonSerializable<NumberGreaterThanOrEqualsAdvancedFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NumberGreaterThanOrEqualsAdvancedFilter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NumberGreaterThanOrEqualsAdvancedFilter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NumberGreaterThanOrEqualsAdvancedFilter>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            writer.WritePropertyName("operatorType"u8);
            writer.WriteStringValue(OperatorType.ToString());
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
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

        internal static NumberGreaterThanOrEqualsAdvancedFilter DeserializeNumberGreaterThanOrEqualsAdvancedFilter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double> value = default;
            AdvancedFilterOperatorType operatorType = default;
            Optional<string> key = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("operatorType"u8))
                {
                    operatorType = new AdvancedFilterOperatorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NumberGreaterThanOrEqualsAdvancedFilter(operatorType, key.Value, Optional.ToNullable(value), serializedAdditionalRawData);
        }

        NumberGreaterThanOrEqualsAdvancedFilter IModelJsonSerializable<NumberGreaterThanOrEqualsAdvancedFilter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NumberGreaterThanOrEqualsAdvancedFilter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNumberGreaterThanOrEqualsAdvancedFilter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NumberGreaterThanOrEqualsAdvancedFilter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NumberGreaterThanOrEqualsAdvancedFilter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NumberGreaterThanOrEqualsAdvancedFilter IModelSerializable<NumberGreaterThanOrEqualsAdvancedFilter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NumberGreaterThanOrEqualsAdvancedFilter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNumberGreaterThanOrEqualsAdvancedFilter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NumberGreaterThanOrEqualsAdvancedFilter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NumberGreaterThanOrEqualsAdvancedFilter"/> to convert. </param>
        public static implicit operator RequestContent(NumberGreaterThanOrEqualsAdvancedFilter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NumberGreaterThanOrEqualsAdvancedFilter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NumberGreaterThanOrEqualsAdvancedFilter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNumberGreaterThanOrEqualsAdvancedFilter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
