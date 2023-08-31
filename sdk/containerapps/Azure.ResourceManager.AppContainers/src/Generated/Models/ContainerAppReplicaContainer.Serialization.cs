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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppReplicaContainer : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppReplicaContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppReplicaContainer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppReplicaContainer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ContainerId))
            {
                writer.WritePropertyName("containerId"u8);
                writer.WriteStringValue(ContainerId);
            }
            if (Optional.IsDefined(IsReady))
            {
                writer.WritePropertyName("ready"u8);
                writer.WriteBooleanValue(IsReady.Value);
            }
            if (Optional.IsDefined(IsStarted))
            {
                writer.WritePropertyName("started"u8);
                writer.WriteBooleanValue(IsStarted.Value);
            }
            if (Optional.IsDefined(RestartCount))
            {
                writer.WritePropertyName("restartCount"u8);
                writer.WriteNumberValue(RestartCount.Value);
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

        internal static ContainerAppReplicaContainer DeserializeContainerAppReplicaContainer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> containerId = default;
            Optional<bool> ready = default;
            Optional<bool> started = default;
            Optional<int> restartCount = default;
            Optional<ContainerAppContainerRunningState> runningState = default;
            Optional<string> runningStateDetails = default;
            Optional<string> logStreamEndpoint = default;
            Optional<string> execEndpoint = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerId"u8))
                {
                    containerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ready"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ready = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("started"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    started = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("restartCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restartCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("runningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runningState = new ContainerAppContainerRunningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("runningStateDetails"u8))
                {
                    runningStateDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logStreamEndpoint"u8))
                {
                    logStreamEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("execEndpoint"u8))
                {
                    execEndpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppReplicaContainer(name.Value, containerId.Value, Optional.ToNullable(ready), Optional.ToNullable(started), Optional.ToNullable(restartCount), Optional.ToNullable(runningState), runningStateDetails.Value, logStreamEndpoint.Value, execEndpoint.Value, rawData);
        }

        ContainerAppReplicaContainer IModelJsonSerializable<ContainerAppReplicaContainer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppReplicaContainer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppReplicaContainer>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppReplicaContainer IModelSerializable<ContainerAppReplicaContainer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppReplicaContainer(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppReplicaContainer"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppReplicaContainer"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppReplicaContainer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppReplicaContainer"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppReplicaContainer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppReplicaContainer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
