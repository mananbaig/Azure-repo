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
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class SiteRecoveryPolicyListResult : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryPolicyListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryPolicyListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryPolicyListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryPolicyListResult>(this, options.Format);

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
                        ((IModelJsonSerializable<SiteRecoveryPolicyData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static SiteRecoveryPolicyListResult DeserializeSiteRecoveryPolicyListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SiteRecoveryPolicyData>> value = default;
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
                    List<SiteRecoveryPolicyData> array = new List<SiteRecoveryPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryPolicyData.DeserializeSiteRecoveryPolicyData(item));
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
            return new SiteRecoveryPolicyListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        SiteRecoveryPolicyListResult IModelJsonSerializable<SiteRecoveryPolicyListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryPolicyListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryPolicyListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryPolicyListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryPolicyListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryPolicyListResult IModelSerializable<SiteRecoveryPolicyListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryPolicyListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryPolicyListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryPolicyListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryPolicyListResult"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryPolicyListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryPolicyListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryPolicyListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryPolicyListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
