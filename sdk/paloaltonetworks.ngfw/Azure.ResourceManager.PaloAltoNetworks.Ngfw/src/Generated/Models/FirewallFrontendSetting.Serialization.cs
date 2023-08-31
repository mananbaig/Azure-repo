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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallFrontendSetting : IUtf8JsonSerializable, IModelJsonSerializable<FirewallFrontendSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FirewallFrontendSetting>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FirewallFrontendSetting>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToString());
            writer.WritePropertyName("frontendConfiguration"u8);
            if (FrontendConfiguration is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<FirewallEndpointConfiguration>)FrontendConfiguration).Serialize(writer, options);
            }
            writer.WritePropertyName("backendConfiguration"u8);
            if (BackendConfiguration is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<FirewallEndpointConfiguration>)BackendConfiguration).Serialize(writer, options);
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

        internal static FirewallFrontendSetting DeserializeFirewallFrontendSetting(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            FirewallProtocolType protocol = default;
            FirewallEndpointConfiguration frontendConfiguration = default;
            FirewallEndpointConfiguration backendConfiguration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = new FirewallProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frontendConfiguration"u8))
                {
                    frontendConfiguration = FirewallEndpointConfiguration.DeserializeFirewallEndpointConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("backendConfiguration"u8))
                {
                    backendConfiguration = FirewallEndpointConfiguration.DeserializeFirewallEndpointConfiguration(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FirewallFrontendSetting(name, protocol, frontendConfiguration, backendConfiguration, rawData);
        }

        FirewallFrontendSetting IModelJsonSerializable<FirewallFrontendSetting>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallFrontendSetting(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FirewallFrontendSetting>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FirewallFrontendSetting IModelSerializable<FirewallFrontendSetting>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFirewallFrontendSetting(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FirewallFrontendSetting"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FirewallFrontendSetting"/> to convert. </param>
        public static implicit operator RequestContent(FirewallFrontendSetting model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FirewallFrontendSetting"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FirewallFrontendSetting(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFirewallFrontendSetting(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
