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
    public partial class VpnClientContent : IUtf8JsonSerializable, IModelJsonSerializable<VpnClientContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VpnClientContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VpnClientContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ProcessorArchitecture))
            {
                writer.WritePropertyName("processorArchitecture"u8);
                writer.WriteStringValue(ProcessorArchitecture.Value.ToString());
            }
            if (Optional.IsDefined(AuthenticationMethod))
            {
                writer.WritePropertyName("authenticationMethod"u8);
                writer.WriteStringValue(AuthenticationMethod.Value.ToString());
            }
            if (Optional.IsDefined(RadiusServerAuthCertificate))
            {
                writer.WritePropertyName("radiusServerAuthCertificate"u8);
                writer.WriteStringValue(RadiusServerAuthCertificate);
            }
            if (Optional.IsCollectionDefined(ClientRootCertificates))
            {
                writer.WritePropertyName("clientRootCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in ClientRootCertificates)
                {
                    writer.WriteStringValue(item);
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

        internal static VpnClientContent DeserializeVpnClientContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProcessorArchitecture> processorArchitecture = default;
            Optional<NetworkAuthenticationMethod> authenticationMethod = default;
            Optional<string> radiusServerAuthCertificate = default;
            Optional<IList<string>> clientRootCertificates = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("processorArchitecture"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processorArchitecture = new ProcessorArchitecture(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authenticationMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationMethod = new NetworkAuthenticationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("radiusServerAuthCertificate"u8))
                {
                    radiusServerAuthCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRootCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    clientRootCertificates = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VpnClientContent(Optional.ToNullable(processorArchitecture), Optional.ToNullable(authenticationMethod), radiusServerAuthCertificate.Value, Optional.ToList(clientRootCertificates), rawData);
        }

        VpnClientContent IModelJsonSerializable<VpnClientContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnClientContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VpnClientContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VpnClientContent IModelSerializable<VpnClientContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVpnClientContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VpnClientContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VpnClientContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVpnClientContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
