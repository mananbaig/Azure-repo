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

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class SourceShareSynchronizationSetting : IUtf8JsonSerializable, IModelJsonSerializable<SourceShareSynchronizationSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SourceShareSynchronizationSetting>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SourceShareSynchronizationSetting>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceShareSynchronizationSetting>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        internal static SourceShareSynchronizationSetting DeserializeSourceShareSynchronizationSetting(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ScheduleBased": return ScheduledSourceSynchronizationSetting.DeserializeScheduledSourceSynchronizationSetting(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            SourceShareSynchronizationSettingKind kind = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SourceShareSynchronizationSettingKind(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownSourceShareSynchronizationSetting(kind, serializedAdditionalRawData);
        }

        SourceShareSynchronizationSetting IModelJsonSerializable<SourceShareSynchronizationSetting>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceShareSynchronizationSetting>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceShareSynchronizationSetting(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SourceShareSynchronizationSetting>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceShareSynchronizationSetting>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SourceShareSynchronizationSetting IModelSerializable<SourceShareSynchronizationSetting>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceShareSynchronizationSetting>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSourceShareSynchronizationSetting(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SourceShareSynchronizationSetting"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SourceShareSynchronizationSetting"/> to convert. </param>
        public static implicit operator RequestContent(SourceShareSynchronizationSetting model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SourceShareSynchronizationSetting"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SourceShareSynchronizationSetting(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSourceShareSynchronizationSetting(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
