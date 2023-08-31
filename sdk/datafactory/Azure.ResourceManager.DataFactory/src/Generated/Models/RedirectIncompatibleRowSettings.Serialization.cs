// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class RedirectIncompatibleRowSettings : IUtf8JsonSerializable, IModelJsonSerializable<RedirectIncompatibleRowSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RedirectIncompatibleRowSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RedirectIncompatibleRowSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("linkedServiceName"u8);
            JsonSerializer.Serialize(writer, LinkedServiceName);
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                JsonSerializer.Serialize(writer, Path);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static RedirectIncompatibleRowSettings DeserializeRedirectIncompatibleRowSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> linkedServiceName = default;
            Optional<DataFactoryElement<string>> path = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    path = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RedirectIncompatibleRowSettings(linkedServiceName, path.Value, additionalProperties);
        }

        RedirectIncompatibleRowSettings IModelJsonSerializable<RedirectIncompatibleRowSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRedirectIncompatibleRowSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RedirectIncompatibleRowSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RedirectIncompatibleRowSettings IModelSerializable<RedirectIncompatibleRowSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRedirectIncompatibleRowSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RedirectIncompatibleRowSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RedirectIncompatibleRowSettings"/> to convert. </param>
        public static implicit operator RequestContent(RedirectIncompatibleRowSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RedirectIncompatibleRowSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RedirectIncompatibleRowSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRedirectIncompatibleRowSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
