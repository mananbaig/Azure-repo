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
    public partial class ExpressRouteCircuitRoutesTableSummary : IUtf8JsonSerializable, IModelJsonSerializable<ExpressRouteCircuitRoutesTableSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExpressRouteCircuitRoutesTableSummary>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExpressRouteCircuitRoutesTableSummary>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Neighbor))
            {
                writer.WritePropertyName("neighbor"u8);
                writer.WriteStringValue(Neighbor);
            }
            if (Optional.IsDefined(V))
            {
                writer.WritePropertyName("v"u8);
                writer.WriteNumberValue(V.Value);
            }
            if (Optional.IsDefined(As))
            {
                writer.WritePropertyName("as"u8);
                writer.WriteNumberValue(As.Value);
            }
            if (Optional.IsDefined(UpDown))
            {
                writer.WritePropertyName("upDown"u8);
                writer.WriteStringValue(UpDown);
            }
            if (Optional.IsDefined(StatePfxRcd))
            {
                writer.WritePropertyName("statePfxRcd"u8);
                writer.WriteStringValue(StatePfxRcd);
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

        internal static ExpressRouteCircuitRoutesTableSummary DeserializeExpressRouteCircuitRoutesTableSummary(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> neighbor = default;
            Optional<int> v = default;
            Optional<int> @as = default;
            Optional<string> upDown = default;
            Optional<string> statePfxRcd = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("neighbor"u8))
                {
                    neighbor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("v"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    v = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("as"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @as = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("upDown"u8))
                {
                    upDown = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statePfxRcd"u8))
                {
                    statePfxRcd = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExpressRouteCircuitRoutesTableSummary(neighbor.Value, Optional.ToNullable(v), Optional.ToNullable(@as), upDown.Value, statePfxRcd.Value, rawData);
        }

        ExpressRouteCircuitRoutesTableSummary IModelJsonSerializable<ExpressRouteCircuitRoutesTableSummary>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCircuitRoutesTableSummary(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExpressRouteCircuitRoutesTableSummary>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExpressRouteCircuitRoutesTableSummary IModelSerializable<ExpressRouteCircuitRoutesTableSummary>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExpressRouteCircuitRoutesTableSummary(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ExpressRouteCircuitRoutesTableSummary model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ExpressRouteCircuitRoutesTableSummary(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExpressRouteCircuitRoutesTableSummary(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
