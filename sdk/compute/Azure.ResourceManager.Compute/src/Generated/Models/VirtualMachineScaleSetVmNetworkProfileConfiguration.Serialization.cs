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

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class VirtualMachineScaleSetVmNetworkProfileConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<VirtualMachineScaleSetVmNetworkProfileConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualMachineScaleSetVmNetworkProfileConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualMachineScaleSetVmNetworkProfileConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NetworkInterfaceConfigurations))
            {
                writer.WritePropertyName("networkInterfaceConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaceConfigurations)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VirtualMachineScaleSetNetworkConfiguration>)item).Serialize(writer, options);
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

        internal static VirtualMachineScaleSetVmNetworkProfileConfiguration DeserializeVirtualMachineScaleSetVmNetworkProfileConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<VirtualMachineScaleSetNetworkConfiguration>> networkInterfaceConfigurations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaceConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineScaleSetNetworkConfiguration> array = new List<VirtualMachineScaleSetNetworkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineScaleSetNetworkConfiguration.DeserializeVirtualMachineScaleSetNetworkConfiguration(item));
                    }
                    networkInterfaceConfigurations = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualMachineScaleSetVmNetworkProfileConfiguration(Optional.ToList(networkInterfaceConfigurations), rawData);
        }

        VirtualMachineScaleSetVmNetworkProfileConfiguration IModelJsonSerializable<VirtualMachineScaleSetVmNetworkProfileConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetVmNetworkProfileConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualMachineScaleSetVmNetworkProfileConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualMachineScaleSetVmNetworkProfileConfiguration IModelSerializable<VirtualMachineScaleSetVmNetworkProfileConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualMachineScaleSetVmNetworkProfileConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualMachineScaleSetVmNetworkProfileConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualMachineScaleSetVmNetworkProfileConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(VirtualMachineScaleSetVmNetworkProfileConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualMachineScaleSetVmNetworkProfileConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualMachineScaleSetVmNetworkProfileConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualMachineScaleSetVmNetworkProfileConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
