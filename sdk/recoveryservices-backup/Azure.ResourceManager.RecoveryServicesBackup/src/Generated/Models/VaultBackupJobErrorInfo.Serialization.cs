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
    public partial class VaultBackupJobErrorInfo : IUtf8JsonSerializable, IModelJsonSerializable<VaultBackupJobErrorInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VaultBackupJobErrorInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VaultBackupJobErrorInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VaultBackupJobErrorInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteNumberValue(ErrorCode.Value);
            }
            if (Optional.IsDefined(ErrorString))
            {
                writer.WritePropertyName("errorString"u8);
                writer.WriteStringValue(ErrorString);
            }
            if (Optional.IsCollectionDefined(Recommendations))
            {
                writer.WritePropertyName("recommendations"u8);
                writer.WriteStartArray();
                foreach (var item in Recommendations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static VaultBackupJobErrorInfo DeserializeVaultBackupJobErrorInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> errorCode = default;
            Optional<string> errorString = default;
            Optional<IList<string>> recommendations = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorString"u8))
                {
                    errorString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    recommendations = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VaultBackupJobErrorInfo(Optional.ToNullable(errorCode), errorString.Value, Optional.ToList(recommendations), serializedAdditionalRawData);
        }

        VaultBackupJobErrorInfo IModelJsonSerializable<VaultBackupJobErrorInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VaultBackupJobErrorInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVaultBackupJobErrorInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VaultBackupJobErrorInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VaultBackupJobErrorInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VaultBackupJobErrorInfo IModelSerializable<VaultBackupJobErrorInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VaultBackupJobErrorInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVaultBackupJobErrorInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VaultBackupJobErrorInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VaultBackupJobErrorInfo"/> to convert. </param>
        public static implicit operator RequestContent(VaultBackupJobErrorInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VaultBackupJobErrorInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VaultBackupJobErrorInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVaultBackupJobErrorInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
