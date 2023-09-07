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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppMinorVersion : IUtf8JsonSerializable, IModelJsonSerializable<WebAppMinorVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebAppMinorVersion>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebAppMinorVersion>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAppMinorVersion>(this, options.Format);

            writer.WriteStartObject();
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

        internal static WebAppMinorVersion DeserializeWebAppMinorVersion(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayText = default;
            Optional<string> value = default;
            Optional<WebAppRuntimes> stackSettings = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayText"u8))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stackSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stackSettings = WebAppRuntimes.DeserializeWebAppRuntimes(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WebAppMinorVersion(displayText.Value, value.Value, stackSettings.Value, serializedAdditionalRawData);
        }

        WebAppMinorVersion IModelJsonSerializable<WebAppMinorVersion>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAppMinorVersion>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppMinorVersion(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebAppMinorVersion>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAppMinorVersion>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebAppMinorVersion IModelSerializable<WebAppMinorVersion>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAppMinorVersion>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebAppMinorVersion(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WebAppMinorVersion"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WebAppMinorVersion"/> to convert. </param>
        public static implicit operator RequestContent(WebAppMinorVersion model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WebAppMinorVersion"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WebAppMinorVersion(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebAppMinorVersion(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
