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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class FrontDoorOriginData : IUtf8JsonSerializable, IModelJsonSerializable<FrontDoorOriginData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FrontDoorOriginData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FrontDoorOriginData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Origin))
            {
                writer.WritePropertyName("azureOrigin"u8);
                JsonSerializer.Serialize(writer, Origin);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(HttpPort))
            {
                writer.WritePropertyName("httpPort"u8);
                writer.WriteNumberValue(HttpPort.Value);
            }
            if (Optional.IsDefined(HttpsPort))
            {
                writer.WritePropertyName("httpsPort"u8);
                writer.WriteNumberValue(HttpsPort.Value);
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader"u8);
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(Priority))
            {
                if (Priority != null)
                {
                    writer.WritePropertyName("priority"u8);
                    writer.WriteNumberValue(Priority.Value);
                }
                else
                {
                    writer.WriteNull("priority");
                }
            }
            if (Optional.IsDefined(Weight))
            {
                if (Weight != null)
                {
                    writer.WritePropertyName("weight"u8);
                    writer.WriteNumberValue(Weight.Value);
                }
                else
                {
                    writer.WriteNull("weight");
                }
            }
            if (Optional.IsDefined(SharedPrivateLinkResource))
            {
                if (SharedPrivateLinkResource != null)
                {
                    writer.WritePropertyName("sharedPrivateLinkResource"u8);
                    writer.WriteObjectValue(SharedPrivateLinkResource);
                }
                else
                {
                    writer.WriteNull("sharedPrivateLinkResource");
                }
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(EnforceCertificateNameCheck))
            {
                writer.WritePropertyName("enforceCertificateNameCheck"u8);
                writer.WriteBooleanValue(EnforceCertificateNameCheck.Value);
            }
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

        internal static FrontDoorOriginData DeserializeFrontDoorOriginData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<string> originGroupName = default;
            Optional<WritableSubResource> azureOrigin = default;
            Optional<string> hostName = default;
            Optional<int> httpPort = default;
            Optional<int> httpsPort = default;
            Optional<string> originHostHeader = default;
            Optional<int?> priority = default;
            Optional<int?> weight = default;
            Optional<SharedPrivateLinkResourceProperties> sharedPrivateLinkResource = default;
            Optional<EnabledState> enabledState = default;
            Optional<bool> enforceCertificateNameCheck = default;
            Optional<FrontDoorProvisioningState> provisioningState = default;
            Optional<FrontDoorDeploymentStatus> deploymentStatus = default;
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
                        if (property0.NameEquals("originGroupName"u8))
                        {
                            originGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureOrigin"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureOrigin = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("httpPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("httpsPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpsPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("originHostHeader"u8))
                        {
                            originHostHeader = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                priority = null;
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("weight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                weight = null;
                                continue;
                            }
                            weight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sharedPrivateLinkResource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                sharedPrivateLinkResource = null;
                                continue;
                            }
                            sharedPrivateLinkResource = SharedPrivateLinkResourceProperties.DeserializeSharedPrivateLinkResourceProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enabledState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledState = new EnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enforceCertificateNameCheck"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enforceCertificateNameCheck = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new FrontDoorProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentStatus = new FrontDoorDeploymentStatus(property0.Value.GetString());
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
            return new FrontDoorOriginData(id, name, type, systemData.Value, originGroupName.Value, azureOrigin, hostName.Value, Optional.ToNullable(httpPort), Optional.ToNullable(httpsPort), originHostHeader.Value, Optional.ToNullable(priority), Optional.ToNullable(weight), sharedPrivateLinkResource.Value, Optional.ToNullable(enabledState), Optional.ToNullable(enforceCertificateNameCheck), Optional.ToNullable(provisioningState), Optional.ToNullable(deploymentStatus), rawData);
        }

        FrontDoorOriginData IModelJsonSerializable<FrontDoorOriginData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorOriginData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FrontDoorOriginData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FrontDoorOriginData IModelSerializable<FrontDoorOriginData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFrontDoorOriginData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(FrontDoorOriginData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator FrontDoorOriginData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFrontDoorOriginData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
