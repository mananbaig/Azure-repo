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
    [JsonConverter(typeof(SapHanaPartitionSettingsConverter))]
    public partial class SapHanaPartitionSettings : IUtf8JsonSerializable, IModelJsonSerializable<SapHanaPartitionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SapHanaPartitionSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SapHanaPartitionSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapHanaPartitionSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PartitionColumnName))
            {
                writer.WritePropertyName("partitionColumnName"u8);
                writer.WriteObjectValue(PartitionColumnName);
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

        internal static SapHanaPartitionSettings DeserializeSapHanaPartitionSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> partitionColumnName = default;
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SapHanaPartitionSettings(partitionColumnName.Value, serializedAdditionalRawData);
        }

        SapHanaPartitionSettings IModelJsonSerializable<SapHanaPartitionSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapHanaPartitionSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSapHanaPartitionSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SapHanaPartitionSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapHanaPartitionSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SapHanaPartitionSettings IModelSerializable<SapHanaPartitionSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapHanaPartitionSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSapHanaPartitionSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SapHanaPartitionSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SapHanaPartitionSettings"/> to convert. </param>
        public static implicit operator RequestContent(SapHanaPartitionSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SapHanaPartitionSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SapHanaPartitionSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSapHanaPartitionSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class SapHanaPartitionSettingsConverter : JsonConverter<SapHanaPartitionSettings>
        {
            public override void Write(Utf8JsonWriter writer, SapHanaPartitionSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SapHanaPartitionSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSapHanaPartitionSettings(document.RootElement);
            }
        }
    }
}
