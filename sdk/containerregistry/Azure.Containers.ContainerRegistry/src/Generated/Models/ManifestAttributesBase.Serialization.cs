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

namespace Azure.Containers.ContainerRegistry
{
    internal partial class ManifestAttributesBase : IUtf8JsonSerializable, IModelJsonSerializable<ManifestAttributesBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManifestAttributesBase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManifestAttributesBase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("changeableAttributes"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CanDelete))
            {
                writer.WritePropertyName("deleteEnabled"u8);
                writer.WriteBooleanValue(CanDelete.Value);
            }
            if (Optional.IsDefined(CanWrite))
            {
                writer.WritePropertyName("writeEnabled"u8);
                writer.WriteBooleanValue(CanWrite.Value);
            }
            if (Optional.IsDefined(CanList))
            {
                writer.WritePropertyName("listEnabled"u8);
                writer.WriteBooleanValue(CanList.Value);
            }
            if (Optional.IsDefined(CanRead))
            {
                writer.WritePropertyName("readEnabled"u8);
                writer.WriteBooleanValue(CanRead.Value);
            }
            writer.WriteEndObject();
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

        internal static ManifestAttributesBase DeserializeManifestAttributesBase(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string digest = default;
            Optional<long> imageSize = default;
            DateTimeOffset createdTime = default;
            DateTimeOffset lastUpdateTime = default;
            Optional<ArtifactArchitecture?> architecture = default;
            Optional<ArtifactOperatingSystem?> os = default;
            Optional<IReadOnlyList<ArtifactManifestPlatform>> references = default;
            Optional<IReadOnlyList<string>> tags = default;
            Optional<bool> deleteEnabled = default;
            Optional<bool> writeEnabled = default;
            Optional<bool> listEnabled = default;
            Optional<bool> readEnabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("digest"u8))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"u8))
                {
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("architecture"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        architecture = null;
                        continue;
                    }
                    architecture = new ArtifactArchitecture(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("os"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        os = null;
                        continue;
                    }
                    os = new ArtifactOperatingSystem(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("references"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ArtifactManifestPlatform> array = new List<ArtifactManifestPlatform>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ArtifactManifestPlatform.DeserializeArtifactManifestPlatform(item));
                    }
                    references = array;
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = array;
                    continue;
                }
                if (property.NameEquals("changeableAttributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("deleteEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("writeEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            writeEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("listEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            listEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("readEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManifestAttributesBase(digest, Optional.ToNullable(imageSize), createdTime, lastUpdateTime, Optional.ToNullable(architecture), Optional.ToNullable(os), Optional.ToList(references), Optional.ToList(tags), Optional.ToNullable(deleteEnabled), Optional.ToNullable(writeEnabled), Optional.ToNullable(listEnabled), Optional.ToNullable(readEnabled), rawData);
        }

        ManifestAttributesBase IModelJsonSerializable<ManifestAttributesBase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManifestAttributesBase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManifestAttributesBase>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManifestAttributesBase IModelSerializable<ManifestAttributesBase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManifestAttributesBase(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManifestAttributesBase"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManifestAttributesBase"/> to convert. </param>
        public static implicit operator RequestContent(ManifestAttributesBase model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManifestAttributesBase"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManifestAttributesBase(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManifestAttributesBase(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
