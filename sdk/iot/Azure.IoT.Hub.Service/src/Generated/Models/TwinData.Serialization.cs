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

namespace Azure.IoT.Hub.Service.Models
{
    public partial class TwinData : IUtf8JsonSerializable, IModelJsonSerializable<TwinData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TwinData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TwinData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceId))
            {
                writer.WritePropertyName("deviceId"u8);
                writer.WriteStringValue(DeviceId);
            }
            if (Optional.IsDefined(ModuleId))
            {
                writer.WritePropertyName("moduleId"u8);
                writer.WriteStringValue(ModuleId);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(DeviceEtag))
            {
                writer.WritePropertyName("deviceEtag"u8);
                writer.WriteStringValue(DeviceEtag);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(StatusReason))
            {
                writer.WritePropertyName("statusReason"u8);
                writer.WriteStringValue(StatusReason);
            }
            if (Optional.IsDefined(StatusUpdateTime))
            {
                writer.WritePropertyName("statusUpdateTime"u8);
                writer.WriteStringValue(StatusUpdateTime.Value, "O");
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("connectionState"u8);
                writer.WriteStringValue(ConnectionState.Value.ToString());
            }
            if (Optional.IsDefined(LastActivityTime))
            {
                writer.WritePropertyName("lastActivityTime"u8);
                writer.WriteStringValue(LastActivityTime.Value, "O");
            }
            if (Optional.IsDefined(CloudToDeviceMessageCount))
            {
                writer.WritePropertyName("cloudToDeviceMessageCount"u8);
                writer.WriteNumberValue(CloudToDeviceMessageCount.Value);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(X509Thumbprint))
            {
                writer.WritePropertyName("x509Thumbprint"u8);
                writer.WriteObjectValue(X509Thumbprint);
            }
            if (Optional.IsDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteObjectValue(Capabilities);
            }
            if (Optional.IsDefined(DeviceScope))
            {
                writer.WritePropertyName("deviceScope"u8);
                writer.WriteStringValue(DeviceScope);
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

        internal static TwinData DeserializeTwinData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceId = default;
            Optional<string> moduleId = default;
            Optional<IDictionary<string, object>> tags = default;
            Optional<TwinProperties> properties = default;
            Optional<string> etag = default;
            Optional<long> version = default;
            Optional<string> deviceEtag = default;
            Optional<TwinStatus> status = default;
            Optional<string> statusReason = default;
            Optional<DateTimeOffset> statusUpdateTime = default;
            Optional<TwinConnectionState> connectionState = default;
            Optional<DateTimeOffset> lastActivityTime = default;
            Optional<int> cloudToDeviceMessageCount = default;
            Optional<TwinAuthenticationType> authenticationType = default;
            Optional<X509Thumbprint> x509Thumbprint = default;
            Optional<DeviceCapabilities> capabilities = default;
            Optional<string> deviceScope = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleId"u8))
                {
                    moduleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = TwinProperties.DeserializeTwinProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("deviceEtag"u8))
                {
                    deviceEtag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new TwinStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusReason"u8))
                {
                    statusReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("connectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionState = new TwinConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastActivityTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastActivityTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cloudToDeviceMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudToDeviceMessageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new TwinAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("x509Thumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x509Thumbprint = X509Thumbprint.DeserializeX509Thumbprint(property.Value);
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capabilities = DeviceCapabilities.DeserializeDeviceCapabilities(property.Value);
                    continue;
                }
                if (property.NameEquals("deviceScope"u8))
                {
                    deviceScope = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TwinData(deviceId.Value, moduleId.Value, Optional.ToDictionary(tags), properties.Value, etag.Value, Optional.ToNullable(version), deviceEtag.Value, Optional.ToNullable(status), statusReason.Value, Optional.ToNullable(statusUpdateTime), Optional.ToNullable(connectionState), Optional.ToNullable(lastActivityTime), Optional.ToNullable(cloudToDeviceMessageCount), Optional.ToNullable(authenticationType), x509Thumbprint.Value, capabilities.Value, deviceScope.Value, rawData);
        }

        TwinData IModelJsonSerializable<TwinData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTwinData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TwinData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TwinData IModelSerializable<TwinData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTwinData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(TwinData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator TwinData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTwinData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
