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
    public partial class EdgeKubernetesRoleCompute : IUtf8JsonSerializable, IModelJsonSerializable<EdgeKubernetesRoleCompute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdgeKubernetesRoleCompute>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdgeKubernetesRoleCompute>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("vmProfile"u8);
            writer.WriteStringValue(VmProfile);
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

        internal static EdgeKubernetesRoleCompute DeserializeEdgeKubernetesRoleCompute(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vmProfile = default;
            Optional<long> memoryInBytes = default;
            Optional<int> processorCount = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmProfile"u8))
                {
                    vmProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("processorCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processorCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdgeKubernetesRoleCompute(vmProfile, Optional.ToNullable(memoryInBytes), Optional.ToNullable(processorCount), rawData);
        }

        EdgeKubernetesRoleCompute IModelJsonSerializable<EdgeKubernetesRoleCompute>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeKubernetesRoleCompute(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdgeKubernetesRoleCompute>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdgeKubernetesRoleCompute IModelSerializable<EdgeKubernetesRoleCompute>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdgeKubernetesRoleCompute(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EdgeKubernetesRoleCompute model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EdgeKubernetesRoleCompute(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdgeKubernetesRoleCompute(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
