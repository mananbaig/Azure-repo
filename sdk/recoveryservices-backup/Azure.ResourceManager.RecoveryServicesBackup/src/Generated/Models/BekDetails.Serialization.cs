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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BekDetails : IUtf8JsonSerializable, IModelJsonSerializable<BekDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BekDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BekDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BekDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SecretUri))
            {
                writer.WritePropertyName("secretUrl"u8);
                writer.WriteStringValue(SecretUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SecretVaultId))
            {
                writer.WritePropertyName("secretVaultId"u8);
                writer.WriteStringValue(SecretVaultId);
            }
            if (Optional.IsDefined(SecretData))
            {
                writer.WritePropertyName("secretData"u8);
                writer.WriteStringValue(SecretData);
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

        internal static BekDetails DeserializeBekDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> secretUrl = default;
            Optional<ResourceIdentifier> secretVaultId = default;
            Optional<string> secretData = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secretUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secretVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secretVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secretData"u8))
                {
                    secretData = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BekDetails(secretUrl.Value, secretVaultId.Value, secretData.Value, serializedAdditionalRawData);
        }

        BekDetails IModelJsonSerializable<BekDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BekDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBekDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BekDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BekDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BekDetails IModelSerializable<BekDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BekDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBekDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BekDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BekDetails"/> to convert. </param>
        public static implicit operator RequestContent(BekDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BekDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BekDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBekDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
