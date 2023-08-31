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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SelfHostedIntegrationRuntime : IUtf8JsonSerializable, IModelJsonSerializable<SelfHostedIntegrationRuntime>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SelfHostedIntegrationRuntime>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SelfHostedIntegrationRuntime>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SelfHostedIntegrationRuntime>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(IntegrationRuntimeType.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedInfo))
            {
                writer.WritePropertyName("linkedInfo"u8);
                writer.WriteObjectValue(LinkedInfo);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static SelfHostedIntegrationRuntime DeserializeSelfHostedIntegrationRuntime(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            Optional<string> description = default;
            Optional<LinkedIntegrationRuntimeType> linkedInfo = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("linkedInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkedInfo = LinkedIntegrationRuntimeType.DeserializeLinkedIntegrationRuntimeType(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SelfHostedIntegrationRuntime(type, description.Value, additionalProperties, linkedInfo.Value);
        }

        SelfHostedIntegrationRuntime IModelJsonSerializable<SelfHostedIntegrationRuntime>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SelfHostedIntegrationRuntime>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHostedIntegrationRuntime(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SelfHostedIntegrationRuntime>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SelfHostedIntegrationRuntime>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SelfHostedIntegrationRuntime IModelSerializable<SelfHostedIntegrationRuntime>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SelfHostedIntegrationRuntime>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSelfHostedIntegrationRuntime(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SelfHostedIntegrationRuntime model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SelfHostedIntegrationRuntime(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSelfHostedIntegrationRuntime(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
