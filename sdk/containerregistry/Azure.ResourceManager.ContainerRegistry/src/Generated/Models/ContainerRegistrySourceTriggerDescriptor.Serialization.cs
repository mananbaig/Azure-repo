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
    public partial class ContainerRegistrySourceTriggerDescriptor : IUtf8JsonSerializable, IModelJsonSerializable<ContainerRegistrySourceTriggerDescriptor>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerRegistrySourceTriggerDescriptor>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerRegistrySourceTriggerDescriptor>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id.Value);
            }
            if (Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteStringValue(EventType);
            }
            if (Optional.IsDefined(CommitId))
            {
                writer.WritePropertyName("commitId"u8);
                writer.WriteStringValue(CommitId);
            }
            if (Optional.IsDefined(PullRequestId))
            {
                writer.WritePropertyName("pullRequestId"u8);
                writer.WriteStringValue(PullRequestId);
            }
            if (Optional.IsDefined(RepositoryUri))
            {
                writer.WritePropertyName("repositoryUrl"u8);
                writer.WriteStringValue(RepositoryUri.AbsoluteUri);
            }
            if (Optional.IsDefined(BranchName))
            {
                writer.WritePropertyName("branchName"u8);
                writer.WriteStringValue(BranchName);
            }
            if (Optional.IsDefined(ProviderType))
            {
                writer.WritePropertyName("providerType"u8);
                writer.WriteStringValue(ProviderType);
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

        internal static ContainerRegistrySourceTriggerDescriptor DeserializeContainerRegistrySourceTriggerDescriptor(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> id = default;
            Optional<string> eventType = default;
            Optional<string> commitId = default;
            Optional<string> pullRequestId = default;
            Optional<Uri> repositoryUrl = default;
            Optional<string> branchName = default;
            Optional<string> providerType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("eventType"u8))
                {
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commitId"u8))
                {
                    commitId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pullRequestId"u8))
                {
                    pullRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repositoryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("branchName"u8))
                {
                    branchName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerRegistrySourceTriggerDescriptor(Optional.ToNullable(id), eventType.Value, commitId.Value, pullRequestId.Value, repositoryUrl.Value, branchName.Value, providerType.Value, rawData);
        }

        ContainerRegistrySourceTriggerDescriptor IModelJsonSerializable<ContainerRegistrySourceTriggerDescriptor>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistrySourceTriggerDescriptor(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerRegistrySourceTriggerDescriptor>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerRegistrySourceTriggerDescriptor IModelSerializable<ContainerRegistrySourceTriggerDescriptor>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerRegistrySourceTriggerDescriptor(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerRegistrySourceTriggerDescriptor"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerRegistrySourceTriggerDescriptor"/> to convert. </param>
        public static implicit operator RequestContent(ContainerRegistrySourceTriggerDescriptor model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerRegistrySourceTriggerDescriptor"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerRegistrySourceTriggerDescriptor(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerRegistrySourceTriggerDescriptor(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
