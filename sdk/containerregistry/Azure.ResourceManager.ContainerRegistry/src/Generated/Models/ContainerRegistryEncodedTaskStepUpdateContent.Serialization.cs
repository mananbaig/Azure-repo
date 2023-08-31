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

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryEncodedTaskStepUpdateContent : IUtf8JsonSerializable, IModelJsonSerializable<ContainerRegistryEncodedTaskStepUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerRegistryEncodedTaskStepUpdateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerRegistryEncodedTaskStepUpdateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContainerRegistryEncodedTaskStepUpdateContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EncodedTaskContent))
            {
                writer.WritePropertyName("encodedTaskContent"u8);
                writer.WriteStringValue(EncodedTaskContent);
            }
            if (Optional.IsDefined(EncodedValuesContent))
            {
                writer.WritePropertyName("encodedValuesContent"u8);
                writer.WriteStringValue(EncodedValuesContent);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ContainerRegistryTaskOverridableValue>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StepType.ToString());
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(ContextAccessToken))
            {
                writer.WritePropertyName("contextAccessToken"u8);
                writer.WriteStringValue(ContextAccessToken);
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

        internal static ContainerRegistryEncodedTaskStepUpdateContent DeserializeContainerRegistryEncodedTaskStepUpdateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> encodedTaskContent = default;
            Optional<string> encodedValuesContent = default;
            Optional<IList<ContainerRegistryTaskOverridableValue>> values = default;
            ContainerRegistryTaskStepType type = default;
            Optional<string> contextPath = default;
            Optional<string> contextAccessToken = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodedTaskContent"u8))
                {
                    encodedTaskContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encodedValuesContent"u8))
                {
                    encodedValuesContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTaskOverridableValue> array = new List<ContainerRegistryTaskOverridableValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTaskOverridableValue.DeserializeContainerRegistryTaskOverridableValue(item));
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ContainerRegistryTaskStepType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contextPath"u8))
                {
                    contextPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contextAccessToken"u8))
                {
                    contextAccessToken = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerRegistryEncodedTaskStepUpdateContent(type, contextPath.Value, contextAccessToken.Value, encodedTaskContent.Value, encodedValuesContent.Value, Optional.ToList(values), rawData);
        }

        ContainerRegistryEncodedTaskStepUpdateContent IModelJsonSerializable<ContainerRegistryEncodedTaskStepUpdateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContainerRegistryEncodedTaskStepUpdateContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryEncodedTaskStepUpdateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerRegistryEncodedTaskStepUpdateContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContainerRegistryEncodedTaskStepUpdateContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerRegistryEncodedTaskStepUpdateContent IModelSerializable<ContainerRegistryEncodedTaskStepUpdateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContainerRegistryEncodedTaskStepUpdateContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerRegistryEncodedTaskStepUpdateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerRegistryEncodedTaskStepUpdateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerRegistryEncodedTaskStepUpdateContent"/> to convert. </param>
        public static implicit operator RequestContent(ContainerRegistryEncodedTaskStepUpdateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerRegistryEncodedTaskStepUpdateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerRegistryEncodedTaskStepUpdateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerRegistryEncodedTaskStepUpdateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
