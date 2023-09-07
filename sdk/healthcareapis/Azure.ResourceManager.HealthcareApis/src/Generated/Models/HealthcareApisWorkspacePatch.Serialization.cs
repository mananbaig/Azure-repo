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

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisWorkspacePatch : IUtf8JsonSerializable, IModelJsonSerializable<HealthcareApisWorkspacePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HealthcareApisWorkspacePatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HealthcareApisWorkspacePatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisWorkspacePatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static HealthcareApisWorkspacePatch DeserializeHealthcareApisWorkspacePatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HealthcareApisWorkspacePatch(Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        HealthcareApisWorkspacePatch IModelJsonSerializable<HealthcareApisWorkspacePatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisWorkspacePatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareApisWorkspacePatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HealthcareApisWorkspacePatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisWorkspacePatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HealthcareApisWorkspacePatch IModelSerializable<HealthcareApisWorkspacePatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisWorkspacePatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHealthcareApisWorkspacePatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HealthcareApisWorkspacePatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HealthcareApisWorkspacePatch"/> to convert. </param>
        public static implicit operator RequestContent(HealthcareApisWorkspacePatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HealthcareApisWorkspacePatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HealthcareApisWorkspacePatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHealthcareApisWorkspacePatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
