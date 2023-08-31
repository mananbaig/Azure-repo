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
    public partial class NatRulePortMapping : IUtf8JsonSerializable, IModelJsonSerializable<NatRulePortMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NatRulePortMapping>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NatRulePortMapping>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(InboundNatRuleName))
            {
                writer.WritePropertyName("inboundNatRuleName"u8);
                writer.WriteStringValue(InboundNatRuleName);
            }
            if (Optional.IsDefined(FrontendPort))
            {
                writer.WritePropertyName("frontendPort"u8);
                writer.WriteNumberValue(FrontendPort.Value);
            }
            if (Optional.IsDefined(BackendPort))
            {
                writer.WritePropertyName("backendPort"u8);
                writer.WriteNumberValue(BackendPort.Value);
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

        internal static NatRulePortMapping DeserializeNatRulePortMapping(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> inboundNatRuleName = default;
            Optional<int> frontendPort = default;
            Optional<int> backendPort = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inboundNatRuleName"u8))
                {
                    inboundNatRuleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frontendPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frontendPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backendPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendPort = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NatRulePortMapping(inboundNatRuleName.Value, Optional.ToNullable(frontendPort), Optional.ToNullable(backendPort), rawData);
        }

        NatRulePortMapping IModelJsonSerializable<NatRulePortMapping>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNatRulePortMapping(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NatRulePortMapping>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NatRulePortMapping IModelSerializable<NatRulePortMapping>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNatRulePortMapping(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NatRulePortMapping"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NatRulePortMapping"/> to convert. </param>
        public static implicit operator RequestContent(NatRulePortMapping model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NatRulePortMapping"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NatRulePortMapping(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNatRulePortMapping(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
