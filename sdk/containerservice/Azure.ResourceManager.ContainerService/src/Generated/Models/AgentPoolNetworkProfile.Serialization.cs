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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class AgentPoolNetworkProfile : IUtf8JsonSerializable, IModelJsonSerializable<AgentPoolNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AgentPoolNetworkProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AgentPoolNetworkProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NodePublicIPTags))
            {
                writer.WritePropertyName("nodePublicIPTags"u8);
                writer.WriteStartArray();
                foreach (var item in NodePublicIPTags)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ContainerServiceIPTag>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowedHostPorts))
            {
                writer.WritePropertyName("allowedHostPorts"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedHostPorts)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AgentPoolNetworkPortRange>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationSecurityGroups))
            {
                writer.WritePropertyName("applicationSecurityGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationSecurityGroups)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
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

        internal static AgentPoolNetworkProfile DeserializeAgentPoolNetworkProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ContainerServiceIPTag>> nodePublicIPTags = default;
            Optional<IList<AgentPoolNetworkPortRange>> allowedHostPorts = default;
            Optional<IList<ResourceIdentifier>> applicationSecurityGroups = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodePublicIPTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerServiceIPTag> array = new List<ContainerServiceIPTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceIPTag.DeserializeContainerServiceIPTag(item));
                    }
                    nodePublicIPTags = array;
                    continue;
                }
                if (property.NameEquals("allowedHostPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AgentPoolNetworkPortRange> array = new List<AgentPoolNetworkPortRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AgentPoolNetworkPortRange.DeserializeAgentPoolNetworkPortRange(item));
                    }
                    allowedHostPorts = array;
                    continue;
                }
                if (property.NameEquals("applicationSecurityGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    applicationSecurityGroups = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AgentPoolNetworkProfile(Optional.ToList(nodePublicIPTags), Optional.ToList(allowedHostPorts), Optional.ToList(applicationSecurityGroups), rawData);
        }

        AgentPoolNetworkProfile IModelJsonSerializable<AgentPoolNetworkProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentPoolNetworkProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AgentPoolNetworkProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AgentPoolNetworkProfile IModelSerializable<AgentPoolNetworkProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAgentPoolNetworkProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AgentPoolNetworkProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AgentPoolNetworkProfile"/> to convert. </param>
        public static implicit operator RequestContent(AgentPoolNetworkProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AgentPoolNetworkProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AgentPoolNetworkProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAgentPoolNetworkProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
