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
    public partial class ExpressRouteCircuitArpTable : IUtf8JsonSerializable, IModelJsonSerializable<ExpressRouteCircuitArpTable>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExpressRouteCircuitArpTable>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExpressRouteCircuitArpTable>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Age))
            {
                writer.WritePropertyName("age"u8);
                writer.WriteNumberValue(Age.Value);
            }
            if (Optional.IsDefined(Interface))
            {
                writer.WritePropertyName("interface"u8);
                writer.WriteStringValue(Interface);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (Optional.IsDefined(MacAddress))
            {
                writer.WritePropertyName("macAddress"u8);
                writer.WriteStringValue(MacAddress);
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

        internal static ExpressRouteCircuitArpTable DeserializeExpressRouteCircuitArpTable(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> age = default;
            Optional<string> @interface = default;
            Optional<string> ipAddress = default;
            Optional<string> macAddress = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("age"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    age = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("interface"u8))
                {
                    @interface = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExpressRouteCircuitArpTable(Optional.ToNullable(age), @interface.Value, ipAddress.Value, macAddress.Value, rawData);
        }

        ExpressRouteCircuitArpTable IModelJsonSerializable<ExpressRouteCircuitArpTable>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCircuitArpTable(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExpressRouteCircuitArpTable>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExpressRouteCircuitArpTable IModelSerializable<ExpressRouteCircuitArpTable>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExpressRouteCircuitArpTable(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExpressRouteCircuitArpTable"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExpressRouteCircuitArpTable"/> to convert. </param>
        public static implicit operator RequestContent(ExpressRouteCircuitArpTable model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExpressRouteCircuitArpTable"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExpressRouteCircuitArpTable(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExpressRouteCircuitArpTable(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
