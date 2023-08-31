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
    public partial class IntegrationRuntimeComputeProperties : IUtf8JsonSerializable, IModelJsonSerializable<IntegrationRuntimeComputeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IntegrationRuntimeComputeProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IntegrationRuntimeComputeProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(NodeSize))
            {
                writer.WritePropertyName("nodeSize"u8);
                writer.WriteStringValue(NodeSize);
            }
            if (Optional.IsDefined(NumberOfNodes))
            {
                writer.WritePropertyName("numberOfNodes"u8);
                writer.WriteNumberValue(NumberOfNodes.Value);
            }
            if (Optional.IsDefined(MaxParallelExecutionsPerNode))
            {
                writer.WritePropertyName("maxParallelExecutionsPerNode"u8);
                writer.WriteNumberValue(MaxParallelExecutionsPerNode.Value);
            }
            if (Optional.IsDefined(DataFlowProperties))
            {
                writer.WritePropertyName("dataFlowProperties"u8);
                if (DataFlowProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IntegrationRuntimeDataFlowProperties>)DataFlowProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(VnetProperties))
            {
                writer.WritePropertyName("vNetProperties"u8);
                if (VnetProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IntegrationRuntimeVnetProperties>)VnetProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CopyComputeScaleProperties))
            {
                writer.WritePropertyName("copyComputeScaleProperties"u8);
                if (CopyComputeScaleProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CopyComputeScaleProperties>)CopyComputeScaleProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PipelineExternalComputeScaleProperties))
            {
                writer.WritePropertyName("pipelineExternalComputeScaleProperties"u8);
                if (PipelineExternalComputeScaleProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PipelineExternalComputeScaleProperties>)PipelineExternalComputeScaleProperties).Serialize(writer, options);
                }
            }
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

        internal static IntegrationRuntimeComputeProperties DeserializeIntegrationRuntimeComputeProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<string> nodeSize = default;
            Optional<int> numberOfNodes = default;
            Optional<int> maxParallelExecutionsPerNode = default;
            Optional<IntegrationRuntimeDataFlowProperties> dataFlowProperties = default;
            Optional<IntegrationRuntimeVnetProperties> vnetProperties = default;
            Optional<CopyComputeScaleProperties> copyComputeScaleProperties = default;
            Optional<PipelineExternalComputeScaleProperties> pipelineExternalComputeScaleProperties = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeSize"u8))
                {
                    nodeSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxParallelExecutionsPerNode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxParallelExecutionsPerNode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataFlowProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFlowProperties = IntegrationRuntimeDataFlowProperties.DeserializeIntegrationRuntimeDataFlowProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("vNetProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetProperties = IntegrationRuntimeVnetProperties.DeserializeIntegrationRuntimeVnetProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("copyComputeScaleProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyComputeScaleProperties = CopyComputeScaleProperties.DeserializeCopyComputeScaleProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("pipelineExternalComputeScaleProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pipelineExternalComputeScaleProperties = PipelineExternalComputeScaleProperties.DeserializePipelineExternalComputeScaleProperties(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeComputeProperties(Optional.ToNullable(location), nodeSize.Value, Optional.ToNullable(numberOfNodes), Optional.ToNullable(maxParallelExecutionsPerNode), dataFlowProperties.Value, vnetProperties.Value, copyComputeScaleProperties.Value, pipelineExternalComputeScaleProperties.Value, additionalProperties);
        }

        IntegrationRuntimeComputeProperties IModelJsonSerializable<IntegrationRuntimeComputeProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeComputeProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IntegrationRuntimeComputeProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IntegrationRuntimeComputeProperties IModelSerializable<IntegrationRuntimeComputeProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIntegrationRuntimeComputeProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IntegrationRuntimeComputeProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IntegrationRuntimeComputeProperties"/> to convert. </param>
        public static implicit operator RequestContent(IntegrationRuntimeComputeProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IntegrationRuntimeComputeProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IntegrationRuntimeComputeProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIntegrationRuntimeComputeProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
