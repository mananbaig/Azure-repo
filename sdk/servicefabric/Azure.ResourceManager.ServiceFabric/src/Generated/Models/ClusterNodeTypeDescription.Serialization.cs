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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterNodeTypeDescription : IUtf8JsonSerializable, IModelJsonSerializable<ClusterNodeTypeDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ClusterNodeTypeDescription>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ClusterNodeTypeDescription>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterNodeTypeDescription>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsCollectionDefined(PlacementProperties))
            {
                writer.WritePropertyName("placementProperties"u8);
                writer.WriteStartObject();
                foreach (var item in PlacementProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Capacities))
            {
                writer.WritePropertyName("capacities"u8);
                writer.WriteStartObject();
                foreach (var item in Capacities)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("clientConnectionEndpointPort"u8);
            writer.WriteNumberValue(ClientConnectionEndpointPort);
            writer.WritePropertyName("httpGatewayEndpointPort"u8);
            writer.WriteNumberValue(HttpGatewayEndpointPort);
            if (Optional.IsDefined(DurabilityLevel))
            {
                writer.WritePropertyName("durabilityLevel"u8);
                writer.WriteStringValue(DurabilityLevel.Value.ToString());
            }
            if (Optional.IsDefined(ApplicationPorts))
            {
                writer.WritePropertyName("applicationPorts"u8);
                if (ApplicationPorts is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClusterEndpointRangeDescription>)ApplicationPorts).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(EphemeralPorts))
            {
                writer.WritePropertyName("ephemeralPorts"u8);
                if (EphemeralPorts is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ClusterEndpointRangeDescription>)EphemeralPorts).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("isPrimary"u8);
            writer.WriteBooleanValue(IsPrimary);
            writer.WritePropertyName("vmInstanceCount"u8);
            writer.WriteNumberValue(VmInstanceCount);
            if (Optional.IsDefined(ReverseProxyEndpointPort))
            {
                writer.WritePropertyName("reverseProxyEndpointPort"u8);
                writer.WriteNumberValue(ReverseProxyEndpointPort.Value);
            }
            if (Optional.IsDefined(IsStateless))
            {
                writer.WritePropertyName("isStateless"u8);
                writer.WriteBooleanValue(IsStateless.Value);
            }
            if (Optional.IsDefined(IsMultipleAvailabilityZonesSupported))
            {
                writer.WritePropertyName("multipleAvailabilityZones"u8);
                writer.WriteBooleanValue(IsMultipleAvailabilityZonesSupported.Value);
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

        internal static ClusterNodeTypeDescription DeserializeClusterNodeTypeDescription(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<IDictionary<string, string>> placementProperties = default;
            Optional<IDictionary<string, string>> capacities = default;
            int clientConnectionEndpointPort = default;
            int httpGatewayEndpointPort = default;
            Optional<ClusterDurabilityLevel> durabilityLevel = default;
            Optional<ClusterEndpointRangeDescription> applicationPorts = default;
            Optional<ClusterEndpointRangeDescription> ephemeralPorts = default;
            bool isPrimary = default;
            int vmInstanceCount = default;
            Optional<int> reverseProxyEndpointPort = default;
            Optional<bool> isStateless = default;
            Optional<bool> multipleAvailabilityZones = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("placementProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    placementProperties = dictionary;
                    continue;
                }
                if (property.NameEquals("capacities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    capacities = dictionary;
                    continue;
                }
                if (property.NameEquals("clientConnectionEndpointPort"u8))
                {
                    clientConnectionEndpointPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpGatewayEndpointPort"u8))
                {
                    httpGatewayEndpointPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("durabilityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durabilityLevel = new ClusterDurabilityLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationPorts = ClusterEndpointRangeDescription.DeserializeClusterEndpointRangeDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("ephemeralPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ephemeralPorts = ClusterEndpointRangeDescription.DeserializeClusterEndpointRangeDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("isPrimary"u8))
                {
                    isPrimary = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("vmInstanceCount"u8))
                {
                    vmInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("reverseProxyEndpointPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseProxyEndpointPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isStateless"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isStateless = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("multipleAvailabilityZones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multipleAvailabilityZones = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ClusterNodeTypeDescription(name, Optional.ToDictionary(placementProperties), Optional.ToDictionary(capacities), clientConnectionEndpointPort, httpGatewayEndpointPort, Optional.ToNullable(durabilityLevel), applicationPorts.Value, ephemeralPorts.Value, isPrimary, vmInstanceCount, Optional.ToNullable(reverseProxyEndpointPort), Optional.ToNullable(isStateless), Optional.ToNullable(multipleAvailabilityZones), serializedAdditionalRawData);
        }

        ClusterNodeTypeDescription IModelJsonSerializable<ClusterNodeTypeDescription>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterNodeTypeDescription>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterNodeTypeDescription(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ClusterNodeTypeDescription>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterNodeTypeDescription>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ClusterNodeTypeDescription IModelSerializable<ClusterNodeTypeDescription>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterNodeTypeDescription>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeClusterNodeTypeDescription(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ClusterNodeTypeDescription"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ClusterNodeTypeDescription"/> to convert. </param>
        public static implicit operator RequestContent(ClusterNodeTypeDescription model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ClusterNodeTypeDescription"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ClusterNodeTypeDescription(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeClusterNodeTypeDescription(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
