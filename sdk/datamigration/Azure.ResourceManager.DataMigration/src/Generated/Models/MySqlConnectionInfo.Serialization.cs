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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MySqlConnectionInfo : IUtf8JsonSerializable, IModelJsonSerializable<MySqlConnectionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MySqlConnectionInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MySqlConnectionInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MySqlConnectionInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("serverName"u8);
            writer.WriteStringValue(ServerName);
            if (Optional.IsDefined(DataSource))
            {
                writer.WritePropertyName("dataSource"u8);
                writer.WriteStringValue(DataSource);
            }
            writer.WritePropertyName("port"u8);
            writer.WriteNumberValue(Port);
            if (Optional.IsDefined(EncryptConnection))
            {
                writer.WritePropertyName("encryptConnection"u8);
                writer.WriteBooleanValue(EncryptConnection.Value);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteStringValue(Authentication.Value.ToString());
            }
            if (Optional.IsDefined(AdditionalSettings))
            {
                writer.WritePropertyName("additionalSettings"u8);
                writer.WriteStringValue(AdditionalSettings);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ConnectionInfoType);
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
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

        internal static MySqlConnectionInfo DeserializeMySqlConnectionInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serverName = default;
            Optional<string> dataSource = default;
            int port = default;
            Optional<bool> encryptConnection = default;
            Optional<AuthenticationType> authentication = default;
            Optional<string> additionalSettings = default;
            string type = default;
            Optional<string> userName = default;
            Optional<string> password = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSource"u8))
                {
                    dataSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("encryptConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptConnection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("authentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authentication = new AuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("additionalSettings"u8))
                {
                    additionalSettings = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MySqlConnectionInfo(type, userName.Value, password.Value, serverName, dataSource.Value, port, Optional.ToNullable(encryptConnection), Optional.ToNullable(authentication), additionalSettings.Value, rawData);
        }

        MySqlConnectionInfo IModelJsonSerializable<MySqlConnectionInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MySqlConnectionInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlConnectionInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MySqlConnectionInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MySqlConnectionInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MySqlConnectionInfo IModelSerializable<MySqlConnectionInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MySqlConnectionInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMySqlConnectionInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MySqlConnectionInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MySqlConnectionInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMySqlConnectionInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
