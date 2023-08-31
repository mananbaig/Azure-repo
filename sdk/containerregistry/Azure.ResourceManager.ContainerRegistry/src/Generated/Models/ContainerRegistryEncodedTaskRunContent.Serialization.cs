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

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryEncodedTaskRunContent : IUtf8JsonSerializable, IModelJsonSerializable<ContainerRegistryEncodedTaskRunContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerRegistryEncodedTaskRunContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerRegistryEncodedTaskRunContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContainerRegistryEncodedTaskRunContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("encodedTaskContent"u8);
            writer.WriteStringValue(EncodedTaskContent);
            if (Optional.IsDefined(EncodedValuesContent))
            {
                writer.WritePropertyName("encodedValuesContent"u8);
                writer.WriteStringValue(EncodedValuesContent);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            writer.WritePropertyName("platform"u8);
            writer.WriteObjectValue(Platform);
            if (Optional.IsDefined(AgentConfiguration))
            {
                writer.WritePropertyName("agentConfiguration"u8);
                writer.WriteObjectValue(AgentConfiguration);
            }
            if (Optional.IsDefined(SourceLocation))
            {
                writer.WritePropertyName("sourceLocation"u8);
                writer.WriteStringValue(SourceLocation);
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RunRequestType);
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (Optional.IsDefined(AgentPoolName))
            {
                writer.WritePropertyName("agentPoolName"u8);
                writer.WriteStringValue(AgentPoolName);
            }
            if (Optional.IsDefined(LogTemplate))
            {
                writer.WritePropertyName("logTemplate"u8);
                writer.WriteStringValue(LogTemplate);
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

        internal static ContainerRegistryEncodedTaskRunContent DeserializeContainerRegistryEncodedTaskRunContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string encodedTaskContent = default;
            Optional<string> encodedValuesContent = default;
            Optional<IList<ContainerRegistryTaskOverridableValue>> values = default;
            Optional<int> timeout = default;
            ContainerRegistryPlatformProperties platform = default;
            Optional<ContainerRegistryAgentProperties> agentConfiguration = default;
            Optional<string> sourceLocation = default;
            Optional<ContainerRegistryCredentials> credentials = default;
            string type = default;
            Optional<bool> isArchiveEnabled = default;
            Optional<string> agentPoolName = default;
            Optional<string> logTemplate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodedTaskContent"u8))
                {
                    encodedTaskContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encodedValuesContent"u8))
                {
                    encodedValuesContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTaskOverridableValue> array = new List<ContainerRegistryTaskOverridableValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTaskOverridableValue.DeserializeContainerRegistryTaskOverridableValue(item));
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("platform"u8))
                {
                    platform = ContainerRegistryPlatformProperties.DeserializeContainerRegistryPlatformProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("agentConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentConfiguration = ContainerRegistryAgentProperties.DeserializeContainerRegistryAgentProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceLocation"u8))
                {
                    sourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = ContainerRegistryCredentials.DeserializeContainerRegistryCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("agentPoolName"u8))
                {
                    agentPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logTemplate"u8))
                {
                    logTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerRegistryEncodedTaskRunContent(type, Optional.ToNullable(isArchiveEnabled), agentPoolName.Value, logTemplate.Value, encodedTaskContent, encodedValuesContent.Value, Optional.ToList(values), Optional.ToNullable(timeout), platform, agentConfiguration.Value, sourceLocation.Value, credentials.Value, rawData);
        }

        ContainerRegistryEncodedTaskRunContent IModelJsonSerializable<ContainerRegistryEncodedTaskRunContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContainerRegistryEncodedTaskRunContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryEncodedTaskRunContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerRegistryEncodedTaskRunContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContainerRegistryEncodedTaskRunContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerRegistryEncodedTaskRunContent IModelSerializable<ContainerRegistryEncodedTaskRunContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContainerRegistryEncodedTaskRunContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerRegistryEncodedTaskRunContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ContainerRegistryEncodedTaskRunContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ContainerRegistryEncodedTaskRunContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerRegistryEncodedTaskRunContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
