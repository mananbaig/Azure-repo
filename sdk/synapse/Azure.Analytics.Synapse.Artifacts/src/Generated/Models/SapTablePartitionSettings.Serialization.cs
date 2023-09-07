// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SapTablePartitionSettingsConverter))]
    public partial class SapTablePartitionSettings : IUtf8JsonSerializable, IModelJsonSerializable<SapTablePartitionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SapTablePartitionSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SapTablePartitionSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapTablePartitionSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PartitionColumnName))
            {
                writer.WritePropertyName("partitionColumnName"u8);
                writer.WriteObjectValue(PartitionColumnName);
            }
            if (Optional.IsDefined(PartitionUpperBound))
            {
                writer.WritePropertyName("partitionUpperBound"u8);
                writer.WriteObjectValue(PartitionUpperBound);
            }
            if (Optional.IsDefined(PartitionLowerBound))
            {
                writer.WritePropertyName("partitionLowerBound"u8);
                writer.WriteObjectValue(PartitionLowerBound);
            }
            if (Optional.IsDefined(MaxPartitionsNumber))
            {
                writer.WritePropertyName("maxPartitionsNumber"u8);
                writer.WriteObjectValue(MaxPartitionsNumber);
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

        internal static SapTablePartitionSettings DeserializeSapTablePartitionSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> partitionColumnName = default;
            Optional<object> partitionUpperBound = default;
            Optional<object> partitionLowerBound = default;
            Optional<object> maxPartitionsNumber = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionColumnName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionUpperBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionUpperBound = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionLowerBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionLowerBound = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxPartitionsNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPartitionsNumber = property.Value.GetObject();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SapTablePartitionSettings(partitionColumnName.Value, partitionUpperBound.Value, partitionLowerBound.Value, maxPartitionsNumber.Value, serializedAdditionalRawData);
        }

        SapTablePartitionSettings IModelJsonSerializable<SapTablePartitionSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapTablePartitionSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSapTablePartitionSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SapTablePartitionSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapTablePartitionSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SapTablePartitionSettings IModelSerializable<SapTablePartitionSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapTablePartitionSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSapTablePartitionSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SapTablePartitionSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SapTablePartitionSettings"/> to convert. </param>
        public static implicit operator RequestContent(SapTablePartitionSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SapTablePartitionSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SapTablePartitionSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSapTablePartitionSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class SapTablePartitionSettingsConverter : JsonConverter<SapTablePartitionSettings>
        {
            public override void Write(Utf8JsonWriter writer, SapTablePartitionSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SapTablePartitionSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSapTablePartitionSettings(document.RootElement);
            }
        }
    }
}
