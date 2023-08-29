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
    public partial class StaticRoutesConfig : IUtf8JsonSerializable, IModelJsonSerializable<StaticRoutesConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StaticRoutesConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StaticRoutesConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VnetLocalRouteOverrideCriteria))
            {
                writer.WritePropertyName("vnetLocalRouteOverrideCriteria"u8);
                writer.WriteStringValue(VnetLocalRouteOverrideCriteria.Value.ToString());
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

        internal static StaticRoutesConfig DeserializeStaticRoutesConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> propagateStaticRoutes = default;
            Optional<VnetLocalRouteOverrideCriterion> vnetLocalRouteOverrideCriteria = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propagateStaticRoutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    propagateStaticRoutes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("vnetLocalRouteOverrideCriteria"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetLocalRouteOverrideCriteria = new VnetLocalRouteOverrideCriterion(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StaticRoutesConfig(Optional.ToNullable(propagateStaticRoutes), Optional.ToNullable(vnetLocalRouteOverrideCriteria), rawData);
        }

        StaticRoutesConfig IModelJsonSerializable<StaticRoutesConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticRoutesConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StaticRoutesConfig>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StaticRoutesConfig IModelSerializable<StaticRoutesConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStaticRoutesConfig(doc.RootElement, options);
        }

        public static implicit operator RequestContent(StaticRoutesConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator StaticRoutesConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStaticRoutesConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
