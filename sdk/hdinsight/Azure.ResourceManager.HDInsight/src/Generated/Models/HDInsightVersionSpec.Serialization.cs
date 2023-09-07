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

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightVersionSpec : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightVersionSpec>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightVersionSpec>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightVersionSpec>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightVersionSpec>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(IsDefault))
            {
                writer.WritePropertyName("isDefault"u8);
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (Optional.IsCollectionDefined(ComponentVersions))
            {
                writer.WritePropertyName("componentVersions"u8);
                writer.WriteStartObject();
                foreach (var item in ComponentVersions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static HDInsightVersionSpec DeserializeHDInsightVersionSpec(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> friendlyName = default;
            Optional<string> displayName = default;
            Optional<bool> isDefault = default;
            Optional<IReadOnlyDictionary<string, string>> componentVersions = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("componentVersions"u8))
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
                    componentVersions = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightVersionSpec(friendlyName.Value, displayName.Value, Optional.ToNullable(isDefault), Optional.ToDictionary(componentVersions), serializedAdditionalRawData);
        }

        HDInsightVersionSpec IModelJsonSerializable<HDInsightVersionSpec>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightVersionSpec>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightVersionSpec(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightVersionSpec>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightVersionSpec>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightVersionSpec IModelSerializable<HDInsightVersionSpec>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightVersionSpec>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightVersionSpec(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HDInsightVersionSpec"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HDInsightVersionSpec"/> to convert. </param>
        public static implicit operator RequestContent(HDInsightVersionSpec model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HDInsightVersionSpec"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HDInsightVersionSpec(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightVersionSpec(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
