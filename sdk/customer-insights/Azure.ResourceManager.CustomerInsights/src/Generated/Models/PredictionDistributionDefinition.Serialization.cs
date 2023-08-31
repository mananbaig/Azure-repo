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

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class PredictionDistributionDefinition : IUtf8JsonSerializable, IModelJsonSerializable<PredictionDistributionDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PredictionDistributionDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PredictionDistributionDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TotalPositives))
            {
                writer.WritePropertyName("totalPositives"u8);
                writer.WriteNumberValue(TotalPositives.Value);
            }
            if (Optional.IsDefined(TotalNegatives))
            {
                writer.WritePropertyName("totalNegatives"u8);
                writer.WriteNumberValue(TotalNegatives.Value);
            }
            if (Optional.IsCollectionDefined(Distributions))
            {
                writer.WritePropertyName("distributions"u8);
                writer.WriteStartArray();
                foreach (var item in Distributions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<PredictionDistributionDefinitionDistributionsItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static PredictionDistributionDefinition DeserializePredictionDistributionDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> totalPositives = default;
            Optional<long> totalNegatives = default;
            Optional<IReadOnlyList<PredictionDistributionDefinitionDistributionsItem>> distributions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalPositives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalPositives = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalNegatives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalNegatives = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("distributions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PredictionDistributionDefinitionDistributionsItem> array = new List<PredictionDistributionDefinitionDistributionsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PredictionDistributionDefinitionDistributionsItem.DeserializePredictionDistributionDefinitionDistributionsItem(item));
                    }
                    distributions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PredictionDistributionDefinition(Optional.ToNullable(totalPositives), Optional.ToNullable(totalNegatives), Optional.ToList(distributions), rawData);
        }

        PredictionDistributionDefinition IModelJsonSerializable<PredictionDistributionDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePredictionDistributionDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PredictionDistributionDefinition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PredictionDistributionDefinition IModelSerializable<PredictionDistributionDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePredictionDistributionDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PredictionDistributionDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PredictionDistributionDefinition"/> to convert. </param>
        public static implicit operator RequestContent(PredictionDistributionDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PredictionDistributionDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PredictionDistributionDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePredictionDistributionDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
