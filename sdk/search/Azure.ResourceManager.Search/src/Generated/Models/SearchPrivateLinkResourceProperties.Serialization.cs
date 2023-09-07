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

namespace Azure.ResourceManager.Search.Models
{
    public partial class SearchPrivateLinkResourceProperties : IUtf8JsonSerializable, IModelJsonSerializable<SearchPrivateLinkResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchPrivateLinkResourceProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchPrivateLinkResourceProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchPrivateLinkResourceProperties>(this, options.Format);

            writer.WriteStartObject();
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

        internal static SearchPrivateLinkResourceProperties DeserializeSearchPrivateLinkResourceProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> groupId = default;
            Optional<IReadOnlyList<string>> requiredMembers = default;
            Optional<IReadOnlyList<string>> requiredZoneNames = default;
            Optional<IReadOnlyList<ShareableSearchServicePrivateLinkResourceType>> shareablePrivateLinkResourceTypes = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiredMembers"u8))
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
                    requiredMembers = array;
                    continue;
                }
                if (property.NameEquals("requiredZoneNames"u8))
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
                    requiredZoneNames = array;
                    continue;
                }
                if (property.NameEquals("shareablePrivateLinkResourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ShareableSearchServicePrivateLinkResourceType> array = new List<ShareableSearchServicePrivateLinkResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ShareableSearchServicePrivateLinkResourceType.DeserializeShareableSearchServicePrivateLinkResourceType(item));
                    }
                    shareablePrivateLinkResourceTypes = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SearchPrivateLinkResourceProperties(groupId.Value, Optional.ToList(requiredMembers), Optional.ToList(requiredZoneNames), Optional.ToList(shareablePrivateLinkResourceTypes), serializedAdditionalRawData);
        }

        SearchPrivateLinkResourceProperties IModelJsonSerializable<SearchPrivateLinkResourceProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchPrivateLinkResourceProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchPrivateLinkResourceProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchPrivateLinkResourceProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchPrivateLinkResourceProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchPrivateLinkResourceProperties IModelSerializable<SearchPrivateLinkResourceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchPrivateLinkResourceProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchPrivateLinkResourceProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SearchPrivateLinkResourceProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SearchPrivateLinkResourceProperties"/> to convert. </param>
        public static implicit operator RequestContent(SearchPrivateLinkResourceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SearchPrivateLinkResourceProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SearchPrivateLinkResourceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchPrivateLinkResourceProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
