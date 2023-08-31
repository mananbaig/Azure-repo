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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeClusterMemoryCapacity : IUtf8JsonSerializable, IModelJsonSerializable<EdgeClusterMemoryCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdgeClusterMemoryCapacity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdgeClusterMemoryCapacity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterFreeMemoryInMB))
            {
                writer.WritePropertyName("clusterFreeMemoryMb"u8);
                writer.WriteNumberValue(ClusterFreeMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterUsedMemoryInMB))
            {
                writer.WritePropertyName("clusterUsedMemoryMb"u8);
                writer.WriteNumberValue(ClusterUsedMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterFailoverMemoryInMB))
            {
                writer.WritePropertyName("clusterFailoverMemoryMb"u8);
                writer.WriteNumberValue(ClusterFailoverMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterFragmentationMemoryInMB))
            {
                writer.WritePropertyName("clusterFragmentationMemoryMb"u8);
                writer.WriteNumberValue(ClusterFragmentationMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterHyperVReserveMemoryMb))
            {
                writer.WritePropertyName("clusterHypervReserveMemoryMb"u8);
                writer.WriteNumberValue(ClusterHyperVReserveMemoryMb.Value);
            }
            if (Optional.IsDefined(ClusterInfraVmMemoryInMB))
            {
                writer.WritePropertyName("clusterInfraVmMemoryMb"u8);
                writer.WriteNumberValue(ClusterInfraVmMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterTotalMemoryInMB))
            {
                writer.WritePropertyName("clusterTotalMemoryMb"u8);
                writer.WriteNumberValue(ClusterTotalMemoryInMB.Value);
            }
            if (Optional.IsDefined(ClusterNonFailoverVmInMB))
            {
                writer.WritePropertyName("clusterNonFailoverVmMb"u8);
                writer.WriteNumberValue(ClusterNonFailoverVmInMB.Value);
            }
            if (Optional.IsDefined(ClusterMemoryUsedByVmsInMB))
            {
                writer.WritePropertyName("clusterMemoryUsedByVmsMb"u8);
                writer.WriteNumberValue(ClusterMemoryUsedByVmsInMB.Value);
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

        internal static EdgeClusterMemoryCapacity DeserializeEdgeClusterMemoryCapacity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double> clusterFreeMemoryMb = default;
            Optional<double> clusterUsedMemoryMb = default;
            Optional<double> clusterFailoverMemoryMb = default;
            Optional<double> clusterFragmentationMemoryMb = default;
            Optional<double> clusterHyperVReserveMemoryMb = default;
            Optional<double> clusterInfraVmMemoryMb = default;
            Optional<double> clusterTotalMemoryMb = default;
            Optional<double> clusterNonFailoverVmMb = default;
            Optional<double> clusterMemoryUsedByVmsMb = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterFreeMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterFreeMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterUsedMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterUsedMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterFailoverMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterFailoverMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterFragmentationMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterFragmentationMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterHypervReserveMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterHyperVReserveMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterInfraVmMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterInfraVmMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterTotalMemoryMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterTotalMemoryMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterNonFailoverVmMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterNonFailoverVmMb = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("clusterMemoryUsedByVmsMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterMemoryUsedByVmsMb = property.Value.GetDouble();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdgeClusterMemoryCapacity(Optional.ToNullable(clusterFreeMemoryMb), Optional.ToNullable(clusterUsedMemoryMb), Optional.ToNullable(clusterFailoverMemoryMb), Optional.ToNullable(clusterFragmentationMemoryMb), Optional.ToNullable(clusterHyperVReserveMemoryMb), Optional.ToNullable(clusterInfraVmMemoryMb), Optional.ToNullable(clusterTotalMemoryMb), Optional.ToNullable(clusterNonFailoverVmMb), Optional.ToNullable(clusterMemoryUsedByVmsMb), rawData);
        }

        EdgeClusterMemoryCapacity IModelJsonSerializable<EdgeClusterMemoryCapacity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeClusterMemoryCapacity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdgeClusterMemoryCapacity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdgeClusterMemoryCapacity IModelSerializable<EdgeClusterMemoryCapacity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdgeClusterMemoryCapacity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EdgeClusterMemoryCapacity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EdgeClusterMemoryCapacity"/> to convert. </param>
        public static implicit operator RequestContent(EdgeClusterMemoryCapacity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EdgeClusterMemoryCapacity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EdgeClusterMemoryCapacity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdgeClusterMemoryCapacity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
