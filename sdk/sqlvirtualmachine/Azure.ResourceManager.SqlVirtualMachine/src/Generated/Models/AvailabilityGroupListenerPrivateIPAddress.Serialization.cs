// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class AvailabilityGroupListenerPrivateIPAddress : IUtf8JsonSerializable, IModelJsonSerializable<AvailabilityGroupListenerPrivateIPAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AvailabilityGroupListenerPrivateIPAddress>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AvailabilityGroupListenerPrivateIPAddress>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailabilityGroupListenerPrivateIPAddress>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress.ToString());
            }
            if (Optional.IsDefined(SubnetResourceId))
            {
                writer.WritePropertyName("subnetResourceId"u8);
                writer.WriteStringValue(SubnetResourceId);
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static AvailabilityGroupListenerPrivateIPAddress DeserializeAvailabilityGroupListenerPrivateIPAddress(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IPAddress> ipAddress = default;
            Optional<ResourceIdentifier> subnetResourceId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AvailabilityGroupListenerPrivateIPAddress(ipAddress.Value, subnetResourceId.Value, serializedAdditionalRawData);
        }

        AvailabilityGroupListenerPrivateIPAddress IModelJsonSerializable<AvailabilityGroupListenerPrivateIPAddress>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailabilityGroupListenerPrivateIPAddress>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailabilityGroupListenerPrivateIPAddress(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AvailabilityGroupListenerPrivateIPAddress>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailabilityGroupListenerPrivateIPAddress>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AvailabilityGroupListenerPrivateIPAddress IModelSerializable<AvailabilityGroupListenerPrivateIPAddress>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailabilityGroupListenerPrivateIPAddress>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAvailabilityGroupListenerPrivateIPAddress(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AvailabilityGroupListenerPrivateIPAddress"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AvailabilityGroupListenerPrivateIPAddress"/> to convert. </param>
        public static implicit operator RequestContent(AvailabilityGroupListenerPrivateIPAddress model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AvailabilityGroupListenerPrivateIPAddress"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AvailabilityGroupListenerPrivateIPAddress(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAvailabilityGroupListenerPrivateIPAddress(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
