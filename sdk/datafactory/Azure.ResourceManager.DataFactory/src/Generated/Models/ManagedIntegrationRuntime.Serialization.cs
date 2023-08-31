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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ManagedIntegrationRuntime : IUtf8JsonSerializable, IModelJsonSerializable<ManagedIntegrationRuntime>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedIntegrationRuntime>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedIntegrationRuntime>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManagedIntegrationRuntime>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedVirtualNetwork))
            {
                writer.WritePropertyName("managedVirtualNetwork"u8);
                writer.WriteObjectValue(ManagedVirtualNetwork);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(IntegrationRuntimeType.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ComputeProperties))
            {
                writer.WritePropertyName("computeProperties"u8);
                writer.WriteObjectValue(ComputeProperties);
            }
            if (Optional.IsDefined(SsisProperties))
            {
                writer.WritePropertyName("ssisProperties"u8);
                writer.WriteObjectValue(SsisProperties);
            }
            if (Optional.IsDefined(CustomerVirtualNetwork))
            {
                writer.WritePropertyName("customerVirtualNetwork"u8);
                writer.WriteObjectValue(CustomerVirtualNetwork);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ManagedIntegrationRuntime DeserializeManagedIntegrationRuntime(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IntegrationRuntimeState> state = default;
            Optional<ManagedVirtualNetworkReference> managedVirtualNetwork = default;
            IntegrationRuntimeType type = default;
            Optional<string> description = default;
            Optional<IntegrationRuntimeComputeProperties> computeProperties = default;
            Optional<IntegrationRuntimeSsisProperties> ssisProperties = default;
            Optional<IntegrationRuntimeCustomerVirtualNetwork> customerVirtualNetwork = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new IntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedVirtualNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedVirtualNetwork = ManagedVirtualNetworkReference.DeserializeManagedVirtualNetworkReference(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("computeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeProperties = IntegrationRuntimeComputeProperties.DeserializeIntegrationRuntimeComputeProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ssisProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ssisProperties = IntegrationRuntimeSsisProperties.DeserializeIntegrationRuntimeSsisProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customerVirtualNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customerVirtualNetwork = IntegrationRuntimeCustomerVirtualNetwork.DeserializeIntegrationRuntimeCustomerVirtualNetwork(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ManagedIntegrationRuntime(type, description.Value, additionalProperties, Optional.ToNullable(state), managedVirtualNetwork.Value, computeProperties.Value, ssisProperties.Value, customerVirtualNetwork.Value);
        }

        ManagedIntegrationRuntime IModelJsonSerializable<ManagedIntegrationRuntime>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManagedIntegrationRuntime>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedIntegrationRuntime(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedIntegrationRuntime>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManagedIntegrationRuntime>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedIntegrationRuntime IModelSerializable<ManagedIntegrationRuntime>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManagedIntegrationRuntime>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedIntegrationRuntime(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ManagedIntegrationRuntime model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ManagedIntegrationRuntime(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedIntegrationRuntime(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
