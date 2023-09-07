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

namespace Azure.ResourceManager.RecoveryServices.Models
{
    internal partial class CrossSubscriptionRestoreSettings : IUtf8JsonSerializable, IModelJsonSerializable<CrossSubscriptionRestoreSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CrossSubscriptionRestoreSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CrossSubscriptionRestoreSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CrossSubscriptionRestoreSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CrossSubscriptionRestoreState))
            {
                writer.WritePropertyName("crossSubscriptionRestoreState"u8);
                writer.WriteStringValue(CrossSubscriptionRestoreState.Value.ToString());
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

        internal static CrossSubscriptionRestoreSettings DeserializeCrossSubscriptionRestoreSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CrossSubscriptionRestoreState> crossSubscriptionRestoreState = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("crossSubscriptionRestoreState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crossSubscriptionRestoreState = new CrossSubscriptionRestoreState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CrossSubscriptionRestoreSettings(Optional.ToNullable(crossSubscriptionRestoreState), serializedAdditionalRawData);
        }

        CrossSubscriptionRestoreSettings IModelJsonSerializable<CrossSubscriptionRestoreSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CrossSubscriptionRestoreSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCrossSubscriptionRestoreSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CrossSubscriptionRestoreSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CrossSubscriptionRestoreSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CrossSubscriptionRestoreSettings IModelSerializable<CrossSubscriptionRestoreSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CrossSubscriptionRestoreSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCrossSubscriptionRestoreSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CrossSubscriptionRestoreSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CrossSubscriptionRestoreSettings"/> to convert. </param>
        public static implicit operator RequestContent(CrossSubscriptionRestoreSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CrossSubscriptionRestoreSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CrossSubscriptionRestoreSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCrossSubscriptionRestoreSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
