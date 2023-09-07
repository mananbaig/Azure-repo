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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSsisParameter : IUtf8JsonSerializable, IModelJsonSerializable<SynapseSsisParameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseSsisParameter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseSsisParameter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSsisParameter>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DataType))
            {
                writer.WritePropertyName("dataType"u8);
                writer.WriteStringValue(DataType);
            }
            if (Optional.IsDefined(IsRequired))
            {
                writer.WritePropertyName("required"u8);
                writer.WriteBooleanValue(IsRequired.Value);
            }
            if (Optional.IsDefined(IsSensitive))
            {
                writer.WritePropertyName("sensitive"u8);
                writer.WriteBooleanValue(IsSensitive.Value);
            }
            if (Optional.IsDefined(DesignDefaultValue))
            {
                writer.WritePropertyName("designDefaultValue"u8);
                writer.WriteStringValue(DesignDefaultValue);
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
            }
            if (Optional.IsDefined(SensitiveDefaultValue))
            {
                writer.WritePropertyName("sensitiveDefaultValue"u8);
                writer.WriteStringValue(SensitiveDefaultValue);
            }
            if (Optional.IsDefined(ValueType))
            {
                writer.WritePropertyName("valueType"u8);
                writer.WriteStringValue(ValueType);
            }
            if (Optional.IsDefined(ValueSet))
            {
                writer.WritePropertyName("valueSet"u8);
                writer.WriteBooleanValue(ValueSet.Value);
            }
            if (Optional.IsDefined(Variable))
            {
                writer.WritePropertyName("variable"u8);
                writer.WriteStringValue(Variable);
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

        internal static SynapseSsisParameter DeserializeSynapseSsisParameter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> dataType = default;
            Optional<bool> required = default;
            Optional<bool> sensitive = default;
            Optional<string> designDefaultValue = default;
            Optional<string> defaultValue = default;
            Optional<string> sensitiveDefaultValue = default;
            Optional<string> valueType = default;
            Optional<bool> valueSet = default;
            Optional<string> variable = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataType"u8))
                {
                    dataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("required"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    required = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("designDefaultValue"u8))
                {
                    designDefaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sensitiveDefaultValue"u8))
                {
                    sensitiveDefaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueType"u8))
                {
                    valueType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueSet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueSet = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("variable"u8))
                {
                    variable = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseSsisParameter(Optional.ToNullable(id), name.Value, description.Value, dataType.Value, Optional.ToNullable(required), Optional.ToNullable(sensitive), designDefaultValue.Value, defaultValue.Value, sensitiveDefaultValue.Value, valueType.Value, Optional.ToNullable(valueSet), variable.Value, serializedAdditionalRawData);
        }

        SynapseSsisParameter IModelJsonSerializable<SynapseSsisParameter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSsisParameter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSsisParameter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseSsisParameter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSsisParameter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseSsisParameter IModelSerializable<SynapseSsisParameter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSsisParameter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseSsisParameter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseSsisParameter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseSsisParameter"/> to convert. </param>
        public static implicit operator RequestContent(SynapseSsisParameter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseSsisParameter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseSsisParameter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseSsisParameter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
