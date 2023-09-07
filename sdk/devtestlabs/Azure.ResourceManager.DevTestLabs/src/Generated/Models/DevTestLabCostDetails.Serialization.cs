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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabCostDetails : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabCostDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabCostDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabCostDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabCostDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(On))
            {
                writer.WritePropertyName("date"u8);
                writer.WriteStringValue(On.Value, "O");
            }
            if (Optional.IsDefined(Cost))
            {
                writer.WritePropertyName("cost"u8);
                writer.WriteNumberValue(Cost.Value);
            }
            if (Optional.IsDefined(CostType))
            {
                writer.WritePropertyName("costType"u8);
                writer.WriteStringValue(CostType.Value.ToString());
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

        internal static DevTestLabCostDetails DeserializeDevTestLabCostDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> date = default;
            Optional<double> cost = default;
            Optional<DevTestLabCostType> costType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("date"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    date = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cost = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("costType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    costType = new DevTestLabCostType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabCostDetails(Optional.ToNullable(date), Optional.ToNullable(cost), Optional.ToNullable(costType), serializedAdditionalRawData);
        }

        DevTestLabCostDetails IModelJsonSerializable<DevTestLabCostDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabCostDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabCostDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabCostDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabCostDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabCostDetails IModelSerializable<DevTestLabCostDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabCostDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabCostDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabCostDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabCostDetails"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabCostDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabCostDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabCostDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabCostDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
