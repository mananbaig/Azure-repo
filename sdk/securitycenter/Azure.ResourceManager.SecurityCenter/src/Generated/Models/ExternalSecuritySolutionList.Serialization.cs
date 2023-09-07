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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class ExternalSecuritySolutionList : IUtf8JsonSerializable, IModelJsonSerializable<ExternalSecuritySolutionList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExternalSecuritySolutionList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExternalSecuritySolutionList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExternalSecuritySolutionList>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ExternalSecuritySolution>)item).Serialize(writer, options);
                    }
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

        internal static ExternalSecuritySolutionList DeserializeExternalSecuritySolutionList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ExternalSecuritySolution>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExternalSecuritySolution> array = new List<ExternalSecuritySolution>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExternalSecuritySolution.DeserializeExternalSecuritySolution(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExternalSecuritySolutionList(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        ExternalSecuritySolutionList IModelJsonSerializable<ExternalSecuritySolutionList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExternalSecuritySolutionList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExternalSecuritySolutionList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExternalSecuritySolutionList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExternalSecuritySolutionList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExternalSecuritySolutionList IModelSerializable<ExternalSecuritySolutionList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExternalSecuritySolutionList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExternalSecuritySolutionList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExternalSecuritySolutionList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExternalSecuritySolutionList"/> to convert. </param>
        public static implicit operator RequestContent(ExternalSecuritySolutionList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExternalSecuritySolutionList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExternalSecuritySolutionList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExternalSecuritySolutionList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
