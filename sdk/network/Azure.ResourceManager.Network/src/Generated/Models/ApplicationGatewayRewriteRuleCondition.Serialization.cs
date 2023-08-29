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

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayRewriteRuleCondition : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationGatewayRewriteRuleCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationGatewayRewriteRuleCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationGatewayRewriteRuleCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Variable))
            {
                writer.WritePropertyName("variable"u8);
                writer.WriteStringValue(Variable);
            }
            if (Optional.IsDefined(Pattern))
            {
                writer.WritePropertyName("pattern"u8);
                writer.WriteStringValue(Pattern);
            }
            if (Optional.IsDefined(IgnoreCase))
            {
                writer.WritePropertyName("ignoreCase"u8);
                writer.WriteBooleanValue(IgnoreCase.Value);
            }
            if (Optional.IsDefined(Negate))
            {
                writer.WritePropertyName("negate"u8);
                writer.WriteBooleanValue(Negate.Value);
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

        internal static ApplicationGatewayRewriteRuleCondition DeserializeApplicationGatewayRewriteRuleCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> variable = default;
            Optional<string> pattern = default;
            Optional<bool> ignoreCase = default;
            Optional<bool> negate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("variable"u8))
                {
                    variable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pattern"u8))
                {
                    pattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ignoreCase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreCase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("negate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negate = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationGatewayRewriteRuleCondition(variable.Value, pattern.Value, Optional.ToNullable(ignoreCase), Optional.ToNullable(negate), rawData);
        }

        ApplicationGatewayRewriteRuleCondition IModelJsonSerializable<ApplicationGatewayRewriteRuleCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayRewriteRuleCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationGatewayRewriteRuleCondition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationGatewayRewriteRuleCondition IModelSerializable<ApplicationGatewayRewriteRuleCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationGatewayRewriteRuleCondition(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ApplicationGatewayRewriteRuleCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ApplicationGatewayRewriteRuleCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationGatewayRewriteRuleCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
