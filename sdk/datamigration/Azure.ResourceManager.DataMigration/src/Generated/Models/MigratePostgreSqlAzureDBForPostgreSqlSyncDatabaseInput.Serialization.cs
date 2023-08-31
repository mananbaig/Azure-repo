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
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput : IUtf8JsonSerializable, IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(TargetDatabaseName))
            {
                writer.WritePropertyName("targetDatabaseName"u8);
                writer.WriteStringValue(TargetDatabaseName);
            }
            if (Optional.IsCollectionDefined(MigrationSetting))
            {
                writer.WritePropertyName("migrationSetting"u8);
                writer.WriteStartObject();
                foreach (var item in MigrationSetting)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(SourceSetting))
            {
                writer.WritePropertyName("sourceSetting"u8);
                writer.WriteStartObject();
                foreach (var item in SourceSetting)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TargetSetting))
            {
                writer.WritePropertyName("targetSetting"u8);
                writer.WriteStartObject();
                foreach (var item in TargetSetting)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(SelectedTables))
            {
                writer.WritePropertyName("selectedTables"u8);
                writer.WriteStartArray();
                foreach (var item in SelectedTables)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> targetDatabaseName = default;
            Optional<IDictionary<string, BinaryData>> migrationSetting = default;
            Optional<IDictionary<string, string>> sourceSetting = default;
            Optional<IDictionary<string, string>> targetSetting = default;
            Optional<IList<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput>> selectedTables = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatabaseName"u8))
                {
                    targetDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    migrationSetting = dictionary;
                    continue;
                }
                if (property.NameEquals("sourceSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    sourceSetting = dictionary;
                    continue;
                }
                if (property.NameEquals("targetSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetSetting = dictionary;
                    continue;
                }
                if (property.NameEquals("selectedTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput> array = new List<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput(item));
                    }
                    selectedTables = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput(name.Value, id.Value, targetDatabaseName.Value, Optional.ToDictionary(migrationSetting), Optional.ToDictionary(sourceSetting), Optional.ToDictionary(targetSetting), Optional.ToList(selectedTables), rawData);
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput IModelSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput"/> to convert. </param>
        public static implicit operator RequestContent(MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
