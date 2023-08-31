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
    public partial class ApplicationGatewayBackendHealthHttpSettings : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationGatewayBackendHealthHttpSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationGatewayBackendHealthHttpSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationGatewayBackendHealthHttpSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BackendHttpSettings))
            {
                writer.WritePropertyName("backendHttpSettings"u8);
                if (BackendHttpSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ApplicationGatewayBackendHttpSettings>)BackendHttpSettings).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Servers))
            {
                writer.WritePropertyName("servers"u8);
                writer.WriteStartArray();
                foreach (var item in Servers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ApplicationGatewayBackendHealthServer>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static ApplicationGatewayBackendHealthHttpSettings DeserializeApplicationGatewayBackendHealthHttpSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ApplicationGatewayBackendHttpSettings> backendHttpSettings = default;
            Optional<IReadOnlyList<ApplicationGatewayBackendHealthServer>> servers = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backendHttpSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendHttpSettings = ApplicationGatewayBackendHttpSettings.DeserializeApplicationGatewayBackendHttpSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("servers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayBackendHealthServer> array = new List<ApplicationGatewayBackendHealthServer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayBackendHealthServer.DeserializeApplicationGatewayBackendHealthServer(item));
                    }
                    servers = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationGatewayBackendHealthHttpSettings(backendHttpSettings.Value, Optional.ToList(servers), rawData);
        }

        ApplicationGatewayBackendHealthHttpSettings IModelJsonSerializable<ApplicationGatewayBackendHealthHttpSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayBackendHealthHttpSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationGatewayBackendHealthHttpSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationGatewayBackendHealthHttpSettings IModelSerializable<ApplicationGatewayBackendHealthHttpSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationGatewayBackendHealthHttpSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApplicationGatewayBackendHealthHttpSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApplicationGatewayBackendHealthHttpSettings"/> to convert. </param>
        public static implicit operator RequestContent(ApplicationGatewayBackendHealthHttpSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApplicationGatewayBackendHealthHttpSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApplicationGatewayBackendHealthHttpSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationGatewayBackendHealthHttpSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
