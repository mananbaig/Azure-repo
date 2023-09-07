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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlDatabaseAutomaticTuningData : IUtf8JsonSerializable, IModelJsonSerializable<SqlDatabaseAutomaticTuningData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SqlDatabaseAutomaticTuningData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SqlDatabaseAutomaticTuningData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlDatabaseAutomaticTuningData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DesiredState))
            {
                writer.WritePropertyName("desiredState"u8);
                writer.WriteStringValue(DesiredState.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteStartObject();
                foreach (var item in Options)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AutomaticTuningOptions>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
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

        internal static SqlDatabaseAutomaticTuningData DeserializeSqlDatabaseAutomaticTuningData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<AutomaticTuningMode> desiredState = default;
            Optional<AutomaticTuningMode> actualState = default;
            Optional<IDictionary<string, AutomaticTuningOptions>> options = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("desiredState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            desiredState = property0.Value.GetString().ToAutomaticTuningMode();
                            continue;
                        }
                        if (property0.NameEquals("actualState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            actualState = property0.Value.GetString().ToAutomaticTuningMode();
                            continue;
                        }
                        if (property0.NameEquals("options"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, AutomaticTuningOptions> dictionary = new Dictionary<string, AutomaticTuningOptions>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, AutomaticTuningOptions.DeserializeAutomaticTuningOptions(property1.Value));
                            }
                            options = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SqlDatabaseAutomaticTuningData(id, name, type, systemData.Value, Optional.ToNullable(desiredState), Optional.ToNullable(actualState), Optional.ToDictionary(options), serializedAdditionalRawData);
        }

        SqlDatabaseAutomaticTuningData IModelJsonSerializable<SqlDatabaseAutomaticTuningData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlDatabaseAutomaticTuningData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlDatabaseAutomaticTuningData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SqlDatabaseAutomaticTuningData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlDatabaseAutomaticTuningData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SqlDatabaseAutomaticTuningData IModelSerializable<SqlDatabaseAutomaticTuningData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlDatabaseAutomaticTuningData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSqlDatabaseAutomaticTuningData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SqlDatabaseAutomaticTuningData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SqlDatabaseAutomaticTuningData"/> to convert. </param>
        public static implicit operator RequestContent(SqlDatabaseAutomaticTuningData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SqlDatabaseAutomaticTuningData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SqlDatabaseAutomaticTuningData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSqlDatabaseAutomaticTuningData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
