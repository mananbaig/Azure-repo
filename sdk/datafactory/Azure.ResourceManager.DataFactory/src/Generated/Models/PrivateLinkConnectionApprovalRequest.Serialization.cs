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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PrivateLinkConnectionApprovalRequest : IUtf8JsonSerializable, IModelJsonSerializable<PrivateLinkConnectionApprovalRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PrivateLinkConnectionApprovalRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PrivateLinkConnectionApprovalRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateLinkServiceConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                if (PrivateLinkServiceConnectionState is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PrivateLinkConnectionState>)PrivateLinkServiceConnectionState).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
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

        internal static PrivateLinkConnectionApprovalRequest DeserializePrivateLinkConnectionApprovalRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PrivateLinkConnectionState> privateLinkServiceConnectionState = default;
            Optional<WritableSubResource> privateEndpoint = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceConnectionState = PrivateLinkConnectionState.DeserializePrivateLinkConnectionState(property.Value);
                    continue;
                }
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PrivateLinkConnectionApprovalRequest(privateLinkServiceConnectionState.Value, privateEndpoint, rawData);
        }

        PrivateLinkConnectionApprovalRequest IModelJsonSerializable<PrivateLinkConnectionApprovalRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateLinkConnectionApprovalRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PrivateLinkConnectionApprovalRequest>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PrivateLinkConnectionApprovalRequest IModelSerializable<PrivateLinkConnectionApprovalRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePrivateLinkConnectionApprovalRequest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PrivateLinkConnectionApprovalRequest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PrivateLinkConnectionApprovalRequest"/> to convert. </param>
        public static implicit operator RequestContent(PrivateLinkConnectionApprovalRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PrivateLinkConnectionApprovalRequest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PrivateLinkConnectionApprovalRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePrivateLinkConnectionApprovalRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
