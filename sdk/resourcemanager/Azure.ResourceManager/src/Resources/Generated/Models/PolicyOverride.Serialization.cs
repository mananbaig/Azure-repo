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
    public partial class PolicyOverride : IUtf8JsonSerializable, IModelJsonSerializable<PolicyOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PolicyOverride>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PolicyOverride>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyOverride>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsCollectionDefined(Selectors))
            {
                writer.WritePropertyName("selectors"u8);
                writer.WriteStartArray();
                foreach (var item in Selectors)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ResourceSelectorExpression>)item).Serialize(writer, options);
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

        internal static PolicyOverride DeserializePolicyOverride(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PolicyOverrideKind> kind = default;
            Optional<string> value = default;
            Optional<IList<ResourceSelectorExpression>> selectors = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new PolicyOverrideKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceSelectorExpression> array = new List<ResourceSelectorExpression>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceSelectorExpression.DeserializeResourceSelectorExpression(item));
                    }
                    selectors = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PolicyOverride(Optional.ToNullable(kind), value.Value, Optional.ToList(selectors), serializedAdditionalRawData);
        }

        PolicyOverride IModelJsonSerializable<PolicyOverride>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyOverride>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyOverride(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PolicyOverride>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyOverride>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PolicyOverride IModelSerializable<PolicyOverride>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyOverride>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePolicyOverride(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PolicyOverride"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PolicyOverride"/> to convert. </param>
        public static implicit operator RequestContent(PolicyOverride model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PolicyOverride"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PolicyOverride(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePolicyOverride(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
