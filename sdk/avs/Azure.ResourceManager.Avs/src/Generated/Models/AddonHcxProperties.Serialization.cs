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

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AddonHcxProperties : IUtf8JsonSerializable, IModelJsonSerializable<AddonHcxProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AddonHcxProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AddonHcxProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AddonHcxProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("offer"u8);
            writer.WriteStringValue(Offer);
            writer.WritePropertyName("addonType"u8);
            writer.WriteStringValue(AddonType.ToString());
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

        internal static AddonHcxProperties DeserializeAddonHcxProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string offer = default;
            AddonType addonType = default;
            Optional<AddonProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offer"u8))
                {
                    offer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addonType"u8))
                {
                    addonType = new AddonType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AddonProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AddonHcxProperties(addonType, Optional.ToNullable(provisioningState), offer, rawData);
        }

        AddonHcxProperties IModelJsonSerializable<AddonHcxProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AddonHcxProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAddonHcxProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AddonHcxProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AddonHcxProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AddonHcxProperties IModelSerializable<AddonHcxProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AddonHcxProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAddonHcxProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AddonHcxProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AddonHcxProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAddonHcxProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
