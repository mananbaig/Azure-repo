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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class SiteRecoveryAddDisksProperties : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryAddDisksProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryAddDisksProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryAddDisksProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryAddDisksProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("providerSpecificDetails"u8);
            if (ProviderSpecificDetails is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SiteRecoveryAddDisksProviderSpecificContent>)ProviderSpecificDetails).Serialize(writer, options);
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

        internal static SiteRecoveryAddDisksProperties DeserializeSiteRecoveryAddDisksProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SiteRecoveryAddDisksProviderSpecificContent providerSpecificDetails = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    providerSpecificDetails = SiteRecoveryAddDisksProviderSpecificContent.DeserializeSiteRecoveryAddDisksProviderSpecificContent(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryAddDisksProperties(providerSpecificDetails, serializedAdditionalRawData);
        }

        SiteRecoveryAddDisksProperties IModelJsonSerializable<SiteRecoveryAddDisksProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryAddDisksProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryAddDisksProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryAddDisksProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryAddDisksProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryAddDisksProperties IModelSerializable<SiteRecoveryAddDisksProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryAddDisksProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryAddDisksProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryAddDisksProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryAddDisksProperties"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryAddDisksProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryAddDisksProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryAddDisksProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryAddDisksProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
