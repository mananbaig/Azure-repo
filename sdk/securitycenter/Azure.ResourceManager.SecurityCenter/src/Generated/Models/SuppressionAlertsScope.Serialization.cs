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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class SuppressionAlertsScope : IUtf8JsonSerializable, IModelJsonSerializable<SuppressionAlertsScope>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SuppressionAlertsScope>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SuppressionAlertsScope>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SuppressionAlertsScope>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("allOf"u8);
            writer.WriteStartArray();
            foreach (var item in AllOf)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SuppressionAlertsScopeElement>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static SuppressionAlertsScope DeserializeSuppressionAlertsScope(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SuppressionAlertsScopeElement> allOf = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allOf"u8))
                {
                    List<SuppressionAlertsScopeElement> array = new List<SuppressionAlertsScopeElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SuppressionAlertsScopeElement.DeserializeSuppressionAlertsScopeElement(item));
                    }
                    allOf = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SuppressionAlertsScope(allOf, serializedAdditionalRawData);
        }

        SuppressionAlertsScope IModelJsonSerializable<SuppressionAlertsScope>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SuppressionAlertsScope>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSuppressionAlertsScope(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SuppressionAlertsScope>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SuppressionAlertsScope>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SuppressionAlertsScope IModelSerializable<SuppressionAlertsScope>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SuppressionAlertsScope>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSuppressionAlertsScope(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SuppressionAlertsScope"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SuppressionAlertsScope"/> to convert. </param>
        public static implicit operator RequestContent(SuppressionAlertsScope model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SuppressionAlertsScope"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SuppressionAlertsScope(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSuppressionAlertsScope(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
