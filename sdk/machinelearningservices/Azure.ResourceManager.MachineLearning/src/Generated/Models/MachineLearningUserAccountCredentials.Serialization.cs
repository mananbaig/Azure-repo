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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningUserAccountCredentials : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningUserAccountCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningUserAccountCredentials>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningUserAccountCredentials>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("adminUserName"u8);
            writer.WriteStringValue(AdminUserName);
            if (Optional.IsDefined(AdminUserSshPublicKey))
            {
                writer.WritePropertyName("adminUserSshPublicKey"u8);
                writer.WriteStringValue(AdminUserSshPublicKey);
            }
            if (Optional.IsDefined(AdminUserPassword))
            {
                writer.WritePropertyName("adminUserPassword"u8);
                writer.WriteStringValue(AdminUserPassword);
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

        internal static MachineLearningUserAccountCredentials DeserializeMachineLearningUserAccountCredentials(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string adminUserName = default;
            Optional<string> adminUserSshPublicKey = default;
            Optional<string> adminUserPassword = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminUserName"u8))
                {
                    adminUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminUserSshPublicKey"u8))
                {
                    adminUserSshPublicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminUserPassword"u8))
                {
                    adminUserPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningUserAccountCredentials(adminUserName, adminUserSshPublicKey.Value, adminUserPassword.Value, rawData);
        }

        MachineLearningUserAccountCredentials IModelJsonSerializable<MachineLearningUserAccountCredentials>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningUserAccountCredentials(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningUserAccountCredentials>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningUserAccountCredentials IModelSerializable<MachineLearningUserAccountCredentials>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningUserAccountCredentials(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MachineLearningUserAccountCredentials model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MachineLearningUserAccountCredentials(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningUserAccountCredentials(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
