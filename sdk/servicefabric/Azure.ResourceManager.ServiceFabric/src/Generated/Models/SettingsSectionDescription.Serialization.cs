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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class SettingsSectionDescription : IUtf8JsonSerializable, IModelJsonSerializable<SettingsSectionDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SettingsSectionDescription>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SettingsSectionDescription>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SettingsSectionDescription>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("parameters"u8);
            writer.WriteStartArray();
            foreach (var item in Parameters)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SettingsParameterDescription>)item).Serialize(writer, options);
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

        internal static SettingsSectionDescription DeserializeSettingsSectionDescription(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<SettingsParameterDescription> parameters = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    List<SettingsParameterDescription> array = new List<SettingsParameterDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SettingsParameterDescription.DeserializeSettingsParameterDescription(item));
                    }
                    parameters = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SettingsSectionDescription(name, parameters, serializedAdditionalRawData);
        }

        SettingsSectionDescription IModelJsonSerializable<SettingsSectionDescription>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SettingsSectionDescription>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSettingsSectionDescription(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SettingsSectionDescription>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SettingsSectionDescription>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SettingsSectionDescription IModelSerializable<SettingsSectionDescription>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SettingsSectionDescription>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSettingsSectionDescription(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SettingsSectionDescription"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SettingsSectionDescription"/> to convert. </param>
        public static implicit operator RequestContent(SettingsSectionDescription model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SettingsSectionDescription"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SettingsSectionDescription(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSettingsSectionDescription(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
