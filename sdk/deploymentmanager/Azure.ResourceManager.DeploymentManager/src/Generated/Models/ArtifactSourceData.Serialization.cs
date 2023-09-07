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
using Azure.ResourceManager.DeploymentManager.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeploymentManager
{
    public partial class ArtifactSourceData : IUtf8JsonSerializable, IModelJsonSerializable<ArtifactSourceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ArtifactSourceData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ArtifactSourceData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ArtifactSourceData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceType))
            {
                writer.WritePropertyName("sourceType"u8);
                writer.WriteStringValue(SourceType);
            }
            if (Optional.IsDefined(ArtifactRoot))
            {
                writer.WritePropertyName("artifactRoot"u8);
                writer.WriteStringValue(ArtifactRoot);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                if (Authentication is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<Authentication>)Authentication).Serialize(writer, options);
                }
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

        internal static ArtifactSourceData DeserializeArtifactSourceData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> sourceType = default;
            Optional<string> artifactRoot = default;
            Optional<Authentication> authentication = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("sourceType"u8))
                        {
                            sourceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("artifactRoot"u8))
                        {
                            artifactRoot = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authentication = Authentication.DeserializeAuthentication(property0.Value);
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
            return new ArtifactSourceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sourceType.Value, artifactRoot.Value, authentication.Value, serializedAdditionalRawData);
        }

        ArtifactSourceData IModelJsonSerializable<ArtifactSourceData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ArtifactSourceData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeArtifactSourceData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ArtifactSourceData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ArtifactSourceData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ArtifactSourceData IModelSerializable<ArtifactSourceData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ArtifactSourceData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeArtifactSourceData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ArtifactSourceData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ArtifactSourceData"/> to convert. </param>
        public static implicit operator RequestContent(ArtifactSourceData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ArtifactSourceData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ArtifactSourceData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeArtifactSourceData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
