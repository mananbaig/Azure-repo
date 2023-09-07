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

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    public partial class AzureDevOpsProjectMetadata : IUtf8JsonSerializable, IModelJsonSerializable<AzureDevOpsProjectMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureDevOpsProjectMetadata>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureDevOpsProjectMetadata>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDevOpsProjectMetadata>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AutoDiscovery))
            {
                writer.WritePropertyName("autoDiscovery"u8);
                writer.WriteStringValue(AutoDiscovery.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Repos))
            {
                writer.WritePropertyName("repos"u8);
                writer.WriteStartArray();
                foreach (var item in Repos)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static AzureDevOpsProjectMetadata DeserializeAzureDevOpsProjectMetadata(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<AutoDiscovery> autoDiscovery = default;
            Optional<IList<string>> repos = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoDiscovery = new AutoDiscovery(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("repos"u8))
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
                    repos = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureDevOpsProjectMetadata(name.Value, Optional.ToNullable(autoDiscovery), Optional.ToList(repos), serializedAdditionalRawData);
        }

        AzureDevOpsProjectMetadata IModelJsonSerializable<AzureDevOpsProjectMetadata>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDevOpsProjectMetadata>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDevOpsProjectMetadata(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureDevOpsProjectMetadata>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDevOpsProjectMetadata>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureDevOpsProjectMetadata IModelSerializable<AzureDevOpsProjectMetadata>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDevOpsProjectMetadata>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureDevOpsProjectMetadata(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureDevOpsProjectMetadata"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureDevOpsProjectMetadata"/> to convert. </param>
        public static implicit operator RequestContent(AzureDevOpsProjectMetadata model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureDevOpsProjectMetadata"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureDevOpsProjectMetadata(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureDevOpsProjectMetadata(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
