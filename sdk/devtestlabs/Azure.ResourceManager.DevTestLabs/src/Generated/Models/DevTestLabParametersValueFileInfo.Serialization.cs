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
    public partial class DevTestLabParametersValueFileInfo : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabParametersValueFileInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabParametersValueFileInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabParametersValueFileInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabParametersValueFileInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(ParametersValueInfo))
            {
                writer.WritePropertyName("parametersValueInfo"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ParametersValueInfo);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ParametersValueInfo.ToString()).RootElement);
#endif
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

        internal static DevTestLabParametersValueFileInfo DeserializeDevTestLabParametersValueFileInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fileName = default;
            Optional<BinaryData> parametersValueInfo = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileName"u8))
                {
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parametersValueInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parametersValueInfo = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabParametersValueFileInfo(fileName.Value, parametersValueInfo.Value, serializedAdditionalRawData);
        }

        DevTestLabParametersValueFileInfo IModelJsonSerializable<DevTestLabParametersValueFileInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabParametersValueFileInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabParametersValueFileInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabParametersValueFileInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabParametersValueFileInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabParametersValueFileInfo IModelSerializable<DevTestLabParametersValueFileInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabParametersValueFileInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabParametersValueFileInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabParametersValueFileInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabParametersValueFileInfo"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabParametersValueFileInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabParametersValueFileInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabParametersValueFileInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabParametersValueFileInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
