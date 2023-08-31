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
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CosmosDBFirewallRuleData : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBFirewallRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBFirewallRuleData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBFirewallRuleData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("startIpAddress"u8);
            writer.WriteStringValue(StartIPAddress);
            writer.WritePropertyName("endIpAddress"u8);
            writer.WriteStringValue(EndIPAddress);
            writer.WriteEndObject();
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

        internal static CosmosDBFirewallRuleData DeserializeCosmosDBFirewallRuleData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<CosmosDBProvisioningState> provisioningState = default;
            string startIPAddress = default;
            string endIPAddress = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new CosmosDBProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startIpAddress"u8))
                        {
                            startIPAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endIpAddress"u8))
                        {
                            endIPAddress = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CosmosDBFirewallRuleData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), startIPAddress, endIPAddress, rawData);
        }

        CosmosDBFirewallRuleData IModelJsonSerializable<CosmosDBFirewallRuleData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBFirewallRuleData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBFirewallRuleData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBFirewallRuleData IModelSerializable<CosmosDBFirewallRuleData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBFirewallRuleData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CosmosDBFirewallRuleData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CosmosDBFirewallRuleData"/> to convert. </param>
        public static implicit operator RequestContent(CosmosDBFirewallRuleData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CosmosDBFirewallRuleData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CosmosDBFirewallRuleData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBFirewallRuleData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
