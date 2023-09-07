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

namespace Azure.ResourceManager.Quantum.Models
{
    public partial class QuotaDimension : IUtf8JsonSerializable, IModelJsonSerializable<QuotaDimension>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<QuotaDimension>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<QuotaDimension>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QuotaDimension>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(Period))
            {
                writer.WritePropertyName("period"u8);
                writer.WriteStringValue(Period);
            }
            if (Optional.IsDefined(Quota))
            {
                writer.WritePropertyName("quota"u8);
                writer.WriteNumberValue(Quota.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (Optional.IsDefined(UnitPlural))
            {
                writer.WritePropertyName("unitPlural"u8);
                writer.WriteStringValue(UnitPlural);
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

        internal static QuotaDimension DeserializeQuotaDimension(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> scope = default;
            Optional<string> period = default;
            Optional<float> quota = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> unit = default;
            Optional<string> unitPlural = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("period"u8))
                {
                    period = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quota"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quota = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unitPlural"u8))
                {
                    unitPlural = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new QuotaDimension(id.Value, scope.Value, period.Value, Optional.ToNullable(quota), name.Value, description.Value, unit.Value, unitPlural.Value, serializedAdditionalRawData);
        }

        QuotaDimension IModelJsonSerializable<QuotaDimension>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QuotaDimension>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaDimension(doc.RootElement, options);
        }

        BinaryData IModelSerializable<QuotaDimension>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QuotaDimension>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        QuotaDimension IModelSerializable<QuotaDimension>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QuotaDimension>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeQuotaDimension(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="QuotaDimension"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="QuotaDimension"/> to convert. </param>
        public static implicit operator RequestContent(QuotaDimension model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="QuotaDimension"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator QuotaDimension(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeQuotaDimension(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
