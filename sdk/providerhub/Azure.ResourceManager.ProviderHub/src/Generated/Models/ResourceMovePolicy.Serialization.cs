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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceMovePolicy : IUtf8JsonSerializable, IModelJsonSerializable<ResourceMovePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceMovePolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceMovePolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsValidationRequired))
            {
                writer.WritePropertyName("validationRequired"u8);
                writer.WriteBooleanValue(IsValidationRequired.Value);
            }
            if (Optional.IsDefined(IsCrossResourceGroupMoveEnabled))
            {
                writer.WritePropertyName("crossResourceGroupMoveEnabled"u8);
                writer.WriteBooleanValue(IsCrossResourceGroupMoveEnabled.Value);
            }
            if (Optional.IsDefined(IsCrossSubscriptionMoveEnabled))
            {
                writer.WritePropertyName("crossSubscriptionMoveEnabled"u8);
                writer.WriteBooleanValue(IsCrossSubscriptionMoveEnabled.Value);
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

        internal static ResourceMovePolicy DeserializeResourceMovePolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> validationRequired = default;
            Optional<bool> crossResourceGroupMoveEnabled = default;
            Optional<bool> crossSubscriptionMoveEnabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("crossResourceGroupMoveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crossResourceGroupMoveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("crossSubscriptionMoveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crossSubscriptionMoveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceMovePolicy(Optional.ToNullable(validationRequired), Optional.ToNullable(crossResourceGroupMoveEnabled), Optional.ToNullable(crossSubscriptionMoveEnabled), rawData);
        }

        ResourceMovePolicy IModelJsonSerializable<ResourceMovePolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceMovePolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceMovePolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceMovePolicy IModelSerializable<ResourceMovePolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceMovePolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceMovePolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceMovePolicy"/> to convert. </param>
        public static implicit operator RequestContent(ResourceMovePolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceMovePolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceMovePolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceMovePolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
