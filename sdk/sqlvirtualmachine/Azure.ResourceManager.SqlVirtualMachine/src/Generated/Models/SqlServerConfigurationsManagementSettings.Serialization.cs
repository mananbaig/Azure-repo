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

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlServerConfigurationsManagementSettings : IUtf8JsonSerializable, IModelJsonSerializable<SqlServerConfigurationsManagementSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SqlServerConfigurationsManagementSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SqlServerConfigurationsManagementSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlServerConfigurationsManagementSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SqlConnectivityUpdateSettings))
            {
                writer.WritePropertyName("sqlConnectivityUpdateSettings"u8);
                if (SqlConnectivityUpdateSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SqlConnectivityUpdateSettings>)SqlConnectivityUpdateSettings).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SqlWorkloadTypeUpdateSettings))
            {
                writer.WritePropertyName("sqlWorkloadTypeUpdateSettings"u8);
                if (SqlWorkloadTypeUpdateSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SqlWorkloadTypeUpdateSettings>)SqlWorkloadTypeUpdateSettings).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SqlStorageUpdateSettings))
            {
                writer.WritePropertyName("sqlStorageUpdateSettings"u8);
                if (SqlStorageUpdateSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SqlStorageUpdateSettings>)SqlStorageUpdateSettings).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AdditionalFeaturesServerConfigurations))
            {
                writer.WritePropertyName("additionalFeaturesServerConfigurations"u8);
                if (AdditionalFeaturesServerConfigurations is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AdditionalFeaturesServerConfigurations>)AdditionalFeaturesServerConfigurations).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SqlInstanceSettings))
            {
                writer.WritePropertyName("sqlInstanceSettings"u8);
                if (SqlInstanceSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SqlInstanceSettings>)SqlInstanceSettings).Serialize(writer, options);
                }
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

        internal static SqlServerConfigurationsManagementSettings DeserializeSqlServerConfigurationsManagementSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlConnectivityUpdateSettings> sqlConnectivityUpdateSettings = default;
            Optional<SqlWorkloadTypeUpdateSettings> sqlWorkloadTypeUpdateSettings = default;
            Optional<SqlStorageUpdateSettings> sqlStorageUpdateSettings = default;
            Optional<AdditionalFeaturesServerConfigurations> additionalFeaturesServerConfigurations = default;
            Optional<SqlInstanceSettings> sqlInstanceSettings = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlConnectivityUpdateSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlConnectivityUpdateSettings = SqlConnectivityUpdateSettings.DeserializeSqlConnectivityUpdateSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("sqlWorkloadTypeUpdateSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlWorkloadTypeUpdateSettings = SqlWorkloadTypeUpdateSettings.DeserializeSqlWorkloadTypeUpdateSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("sqlStorageUpdateSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlStorageUpdateSettings = SqlStorageUpdateSettings.DeserializeSqlStorageUpdateSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("additionalFeaturesServerConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalFeaturesServerConfigurations = AdditionalFeaturesServerConfigurations.DeserializeAdditionalFeaturesServerConfigurations(property.Value);
                    continue;
                }
                if (property.NameEquals("sqlInstanceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlInstanceSettings = SqlInstanceSettings.DeserializeSqlInstanceSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SqlServerConfigurationsManagementSettings(sqlConnectivityUpdateSettings.Value, sqlWorkloadTypeUpdateSettings.Value, sqlStorageUpdateSettings.Value, additionalFeaturesServerConfigurations.Value, sqlInstanceSettings.Value, serializedAdditionalRawData);
        }

        SqlServerConfigurationsManagementSettings IModelJsonSerializable<SqlServerConfigurationsManagementSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlServerConfigurationsManagementSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerConfigurationsManagementSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SqlServerConfigurationsManagementSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlServerConfigurationsManagementSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SqlServerConfigurationsManagementSettings IModelSerializable<SqlServerConfigurationsManagementSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlServerConfigurationsManagementSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSqlServerConfigurationsManagementSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SqlServerConfigurationsManagementSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SqlServerConfigurationsManagementSettings"/> to convert. </param>
        public static implicit operator RequestContent(SqlServerConfigurationsManagementSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SqlServerConfigurationsManagementSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SqlServerConfigurationsManagementSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSqlServerConfigurationsManagementSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
