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

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesClusterExtensionScope : IUtf8JsonSerializable, IModelJsonSerializable<KubernetesClusterExtensionScope>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KubernetesClusterExtensionScope>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KubernetesClusterExtensionScope>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Cluster))
            {
                if (Cluster != null)
                {
                    writer.WritePropertyName("cluster"u8);
                    writer.WriteObjectValue(Cluster);
                }
                else
                {
                    writer.WriteNull("cluster");
                }
            }
            if (Optional.IsDefined(Namespace))
            {
                if (Namespace != null)
                {
                    writer.WritePropertyName("namespace"u8);
                    writer.WriteObjectValue(Namespace);
                }
                else
                {
                    writer.WriteNull("namespace");
                }
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

        internal static KubernetesClusterExtensionScope DeserializeKubernetesClusterExtensionScope(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ScopeCluster> cluster = default;
            Optional<ScopeNamespace> @namespace = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cluster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cluster = null;
                        continue;
                    }
                    cluster = ScopeCluster.DeserializeScopeCluster(property.Value);
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        @namespace = null;
                        continue;
                    }
                    @namespace = ScopeNamespace.DeserializeScopeNamespace(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KubernetesClusterExtensionScope(cluster.Value, @namespace.Value, rawData);
        }

        KubernetesClusterExtensionScope IModelJsonSerializable<KubernetesClusterExtensionScope>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesClusterExtensionScope(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KubernetesClusterExtensionScope>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KubernetesClusterExtensionScope IModelSerializable<KubernetesClusterExtensionScope>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKubernetesClusterExtensionScope(doc.RootElement, options);
        }

        public static implicit operator RequestContent(KubernetesClusterExtensionScope model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator KubernetesClusterExtensionScope(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKubernetesClusterExtensionScope(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
