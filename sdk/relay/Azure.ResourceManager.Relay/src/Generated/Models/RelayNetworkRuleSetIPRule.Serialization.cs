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

namespace Azure.ResourceManager.Relay.Models
{
    public partial class RelayNetworkRuleSetIPRule : IUtf8JsonSerializable, IModelJsonSerializable<RelayNetworkRuleSetIPRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RelayNetworkRuleSetIPRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RelayNetworkRuleSetIPRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RelayNetworkRuleSetIPRule>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IPMask))
            {
                writer.WritePropertyName("ipMask"u8);
                writer.WriteStringValue(IPMask);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
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

        internal static RelayNetworkRuleSetIPRule DeserializeRelayNetworkRuleSetIPRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ipMask = default;
            Optional<RelayNetworkRuleIPAction> action = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipMask"u8))
                {
                    ipMask = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new RelayNetworkRuleIPAction(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RelayNetworkRuleSetIPRule(ipMask.Value, Optional.ToNullable(action), serializedAdditionalRawData);
        }

        RelayNetworkRuleSetIPRule IModelJsonSerializable<RelayNetworkRuleSetIPRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RelayNetworkRuleSetIPRule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRelayNetworkRuleSetIPRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RelayNetworkRuleSetIPRule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RelayNetworkRuleSetIPRule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RelayNetworkRuleSetIPRule IModelSerializable<RelayNetworkRuleSetIPRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RelayNetworkRuleSetIPRule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRelayNetworkRuleSetIPRule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RelayNetworkRuleSetIPRule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RelayNetworkRuleSetIPRule"/> to convert. </param>
        public static implicit operator RequestContent(RelayNetworkRuleSetIPRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RelayNetworkRuleSetIPRule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RelayNetworkRuleSetIPRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRelayNetworkRuleSetIPRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
