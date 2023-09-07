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
    [JsonConverter(typeof(AutoScalePropertiesConverter))]
    public partial class AutoScaleProperties : IUtf8JsonSerializable, IModelJsonSerializable<AutoScaleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutoScaleProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutoScaleProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoScaleProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MinNodeCount))
            {
                writer.WritePropertyName("minNodeCount"u8);
                writer.WriteNumberValue(MinNodeCount.Value);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(MaxNodeCount))
            {
                writer.WritePropertyName("maxNodeCount"u8);
                writer.WriteNumberValue(MaxNodeCount.Value);
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

        internal static AutoScaleProperties DeserializeAutoScaleProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> minNodeCount = default;
            Optional<bool> enabled = default;
            Optional<int> maxNodeCount = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutoScaleProperties(Optional.ToNullable(minNodeCount), Optional.ToNullable(enabled), Optional.ToNullable(maxNodeCount), serializedAdditionalRawData);
        }

        AutoScaleProperties IModelJsonSerializable<AutoScaleProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoScaleProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoScaleProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutoScaleProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoScaleProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutoScaleProperties IModelSerializable<AutoScaleProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoScaleProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutoScaleProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutoScaleProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutoScaleProperties"/> to convert. </param>
        public static implicit operator RequestContent(AutoScaleProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutoScaleProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutoScaleProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutoScaleProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class AutoScalePropertiesConverter : JsonConverter<AutoScaleProperties>
        {
            public override void Write(Utf8JsonWriter writer, AutoScaleProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AutoScaleProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAutoScaleProperties(document.RootElement);
            }
        }
    }
}
