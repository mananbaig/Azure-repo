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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class SwaggerCustomDynamicTree : IUtf8JsonSerializable, IModelJsonSerializable<SwaggerCustomDynamicTree>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SwaggerCustomDynamicTree>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SwaggerCustomDynamicTree>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
                writer.WriteObjectValue(Settings);
            }
            if (Optional.IsDefined(Open))
            {
                writer.WritePropertyName("open"u8);
                writer.WriteObjectValue(Open);
            }
            if (Optional.IsDefined(Browse))
            {
                writer.WritePropertyName("browse"u8);
                writer.WriteObjectValue(Browse);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static SwaggerCustomDynamicTree DeserializeSwaggerCustomDynamicTree(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SwaggerCustomDynamicTreeSettings> settings = default;
            Optional<SwaggerCustomDynamicTreeCommand> open = default;
            Optional<SwaggerCustomDynamicTreeCommand> browse = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    settings = SwaggerCustomDynamicTreeSettings.DeserializeSwaggerCustomDynamicTreeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("open"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    open = SwaggerCustomDynamicTreeCommand.DeserializeSwaggerCustomDynamicTreeCommand(property.Value);
                    continue;
                }
                if (property.NameEquals("browse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    browse = SwaggerCustomDynamicTreeCommand.DeserializeSwaggerCustomDynamicTreeCommand(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SwaggerCustomDynamicTree(settings.Value, open.Value, browse.Value, rawData);
        }

        SwaggerCustomDynamicTree IModelJsonSerializable<SwaggerCustomDynamicTree>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSwaggerCustomDynamicTree(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SwaggerCustomDynamicTree>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SwaggerCustomDynamicTree IModelSerializable<SwaggerCustomDynamicTree>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSwaggerCustomDynamicTree(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SwaggerCustomDynamicTree model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SwaggerCustomDynamicTree(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSwaggerCustomDynamicTree(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
