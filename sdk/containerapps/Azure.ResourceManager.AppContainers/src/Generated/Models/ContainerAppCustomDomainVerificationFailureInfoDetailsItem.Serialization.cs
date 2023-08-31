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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppCustomDomainVerificationFailureInfoDetailsItem : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppCustomDomainVerificationFailureInfoDetailsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppCustomDomainVerificationFailureInfoDetailsItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppCustomDomainVerificationFailureInfoDetailsItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static ContainerAppCustomDomainVerificationFailureInfoDetailsItem DeserializeContainerAppCustomDomainVerificationFailureInfoDetailsItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppCustomDomainVerificationFailureInfoDetailsItem(code.Value, message.Value, target.Value, rawData);
        }

        ContainerAppCustomDomainVerificationFailureInfoDetailsItem IModelJsonSerializable<ContainerAppCustomDomainVerificationFailureInfoDetailsItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppCustomDomainVerificationFailureInfoDetailsItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppCustomDomainVerificationFailureInfoDetailsItem>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppCustomDomainVerificationFailureInfoDetailsItem IModelSerializable<ContainerAppCustomDomainVerificationFailureInfoDetailsItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppCustomDomainVerificationFailureInfoDetailsItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppCustomDomainVerificationFailureInfoDetailsItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppCustomDomainVerificationFailureInfoDetailsItem"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppCustomDomainVerificationFailureInfoDetailsItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppCustomDomainVerificationFailureInfoDetailsItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppCustomDomainVerificationFailureInfoDetailsItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppCustomDomainVerificationFailureInfoDetailsItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
