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

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class CveLink : IUtf8JsonSerializable, IModelJsonSerializable<CveLink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CveLink>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CveLink>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Href))
            {
                if (Href != null)
                {
                    writer.WritePropertyName("href"u8);
                    writer.WriteStringValue(Href);
                }
                else
                {
                    writer.WriteNull("href");
                }
            }
            if (Optional.IsDefined(Label))
            {
                if (Label != null)
                {
                    writer.WritePropertyName("label"u8);
                    writer.WriteStringValue(Label);
                }
                else
                {
                    writer.WriteNull("label");
                }
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

        internal static CveLink DeserializeCveLink(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> href = default;
            Optional<string> label = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("href"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        href = null;
                        continue;
                    }
                    href = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        label = null;
                        continue;
                    }
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CveLink(href.Value, label.Value, rawData);
        }

        CveLink IModelJsonSerializable<CveLink>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCveLink(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CveLink>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CveLink IModelSerializable<CveLink>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCveLink(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CveLink model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CveLink(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCveLink(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
