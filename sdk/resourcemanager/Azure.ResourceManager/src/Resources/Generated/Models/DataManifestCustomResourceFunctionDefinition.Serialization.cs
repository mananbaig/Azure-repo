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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class DataManifestCustomResourceFunctionDefinition : IUtf8JsonSerializable, IModelJsonSerializable<DataManifestCustomResourceFunctionDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataManifestCustomResourceFunctionDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataManifestCustomResourceFunctionDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataManifestCustomResourceFunctionDefinition>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(FullyQualifiedResourceType))
            {
                writer.WritePropertyName("fullyQualifiedResourceType"u8);
                writer.WriteStringValue(FullyQualifiedResourceType.Value);
            }
            if (Optional.IsCollectionDefined(DefaultProperties))
            {
                writer.WritePropertyName("defaultProperties"u8);
                writer.WriteStartArray();
                foreach (var item in DefaultProperties)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllowCustomProperties))
            {
                writer.WritePropertyName("allowCustomProperties"u8);
                writer.WriteBooleanValue(AllowCustomProperties.Value);
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

        internal static DataManifestCustomResourceFunctionDefinition DeserializeDataManifestCustomResourceFunctionDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ResourceType> fullyQualifiedResourceType = default;
            Optional<IReadOnlyList<string>> defaultProperties = default;
            Optional<bool> allowCustomProperties = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fullyQualifiedResourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullyQualifiedResourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultProperties"u8))
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
                    defaultProperties = array;
                    continue;
                }
                if (property.NameEquals("allowCustomProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowCustomProperties = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataManifestCustomResourceFunctionDefinition(name.Value, Optional.ToNullable(fullyQualifiedResourceType), Optional.ToList(defaultProperties), Optional.ToNullable(allowCustomProperties), serializedAdditionalRawData);
        }

        DataManifestCustomResourceFunctionDefinition IModelJsonSerializable<DataManifestCustomResourceFunctionDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataManifestCustomResourceFunctionDefinition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataManifestCustomResourceFunctionDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataManifestCustomResourceFunctionDefinition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataManifestCustomResourceFunctionDefinition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataManifestCustomResourceFunctionDefinition IModelSerializable<DataManifestCustomResourceFunctionDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataManifestCustomResourceFunctionDefinition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataManifestCustomResourceFunctionDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataManifestCustomResourceFunctionDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataManifestCustomResourceFunctionDefinition"/> to convert. </param>
        public static implicit operator RequestContent(DataManifestCustomResourceFunctionDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataManifestCustomResourceFunctionDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataManifestCustomResourceFunctionDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataManifestCustomResourceFunctionDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
