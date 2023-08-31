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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class VirtualNetworksPropertiesStatusProvisioningStatus : IUtf8JsonSerializable, IModelJsonSerializable<VirtualNetworksPropertiesStatusProvisioningStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualNetworksPropertiesStatusProvisioningStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualNetworksPropertiesStatusProvisioningStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Optional.IsDefined(Phase))
            {
                writer.WritePropertyName("phase"u8);
                writer.WriteStringValue(Phase);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
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

        internal static VirtualNetworksPropertiesStatusProvisioningStatus DeserializeVirtualNetworksPropertiesStatusProvisioningStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VirtualNetworksPropertiesStatusProvisioningStatusError> error = default;
            Optional<string> operationId = default;
            Optional<string> phase = default;
            Optional<string> status = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = VirtualNetworksPropertiesStatusProvisioningStatusError.DeserializeVirtualNetworksPropertiesStatusProvisioningStatusError(property.Value);
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phase"u8))
                {
                    phase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualNetworksPropertiesStatusProvisioningStatus(error.Value, operationId.Value, phase.Value, status.Value, rawData);
        }

        VirtualNetworksPropertiesStatusProvisioningStatus IModelJsonSerializable<VirtualNetworksPropertiesStatusProvisioningStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworksPropertiesStatusProvisioningStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualNetworksPropertiesStatusProvisioningStatus>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualNetworksPropertiesStatusProvisioningStatus IModelSerializable<VirtualNetworksPropertiesStatusProvisioningStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualNetworksPropertiesStatusProvisioningStatus(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VirtualNetworksPropertiesStatusProvisioningStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VirtualNetworksPropertiesStatusProvisioningStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualNetworksPropertiesStatusProvisioningStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
