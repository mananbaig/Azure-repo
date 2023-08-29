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

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayOnDemandProbe : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationGatewayOnDemandProbe>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationGatewayOnDemandProbe>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationGatewayOnDemandProbe>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host"u8);
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteNumberValue(Timeout.Value);
            }
            if (Optional.IsDefined(PickHostNameFromBackendHttpSettings))
            {
                writer.WritePropertyName("pickHostNameFromBackendHttpSettings"u8);
                writer.WriteBooleanValue(PickHostNameFromBackendHttpSettings.Value);
            }
            if (Optional.IsDefined(Match))
            {
                writer.WritePropertyName("match"u8);
                writer.WriteObjectValue(Match);
            }
            if (Optional.IsDefined(BackendAddressPool))
            {
                writer.WritePropertyName("backendAddressPool"u8);
                JsonSerializer.Serialize(writer, BackendAddressPool);
            }
            if (Optional.IsDefined(BackendHttpSettings))
            {
                writer.WritePropertyName("backendHttpSettings"u8);
                JsonSerializer.Serialize(writer, BackendHttpSettings);
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

        internal static ApplicationGatewayOnDemandProbe DeserializeApplicationGatewayOnDemandProbe(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ApplicationGatewayProtocol> protocol = default;
            Optional<string> host = default;
            Optional<string> path = default;
            Optional<int> timeout = default;
            Optional<bool> pickHostNameFromBackendHttpSettings = default;
            Optional<ApplicationGatewayProbeHealthResponseMatch> match = default;
            Optional<WritableSubResource> backendAddressPool = default;
            Optional<WritableSubResource> backendHttpSettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new ApplicationGatewayProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pickHostNameFromBackendHttpSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pickHostNameFromBackendHttpSettings = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("match"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    match = ApplicationGatewayProbeHealthResponseMatch.DeserializeApplicationGatewayProbeHealthResponseMatch(property.Value);
                    continue;
                }
                if (property.NameEquals("backendAddressPool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendAddressPool = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("backendHttpSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendHttpSettings = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationGatewayOnDemandProbe(Optional.ToNullable(protocol), host.Value, path.Value, Optional.ToNullable(timeout), Optional.ToNullable(pickHostNameFromBackendHttpSettings), match.Value, backendAddressPool, backendHttpSettings, rawData);
        }

        ApplicationGatewayOnDemandProbe IModelJsonSerializable<ApplicationGatewayOnDemandProbe>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayOnDemandProbe(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationGatewayOnDemandProbe>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationGatewayOnDemandProbe IModelSerializable<ApplicationGatewayOnDemandProbe>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationGatewayOnDemandProbe(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ApplicationGatewayOnDemandProbe model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ApplicationGatewayOnDemandProbe(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationGatewayOnDemandProbe(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
