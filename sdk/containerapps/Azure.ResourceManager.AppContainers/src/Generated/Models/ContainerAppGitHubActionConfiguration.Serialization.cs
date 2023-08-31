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
    public partial class ContainerAppGitHubActionConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppGitHubActionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppGitHubActionConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppGitHubActionConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RegistryInfo))
            {
                writer.WritePropertyName("registryInfo"u8);
                writer.WriteObjectValue(RegistryInfo);
            }
            if (Optional.IsDefined(AzureCredentials))
            {
                writer.WritePropertyName("azureCredentials"u8);
                writer.WriteObjectValue(AzureCredentials);
            }
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(GitHubPersonalAccessToken))
            {
                writer.WritePropertyName("githubPersonalAccessToken"u8);
                writer.WriteStringValue(GitHubPersonalAccessToken);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteStringValue(Image);
            }
            if (Optional.IsDefined(PublishType))
            {
                writer.WritePropertyName("publishType"u8);
                writer.WriteStringValue(PublishType);
            }
            if (Optional.IsDefined(OS))
            {
                writer.WritePropertyName("os"u8);
                writer.WriteStringValue(OS);
            }
            if (Optional.IsDefined(RuntimeStack))
            {
                writer.WritePropertyName("runtimeStack"u8);
                writer.WriteStringValue(RuntimeStack);
            }
            if (Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
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

        internal static ContainerAppGitHubActionConfiguration DeserializeContainerAppGitHubActionConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppRegistryInfo> registryInfo = default;
            Optional<ContainerAppCredentials> azureCredentials = default;
            Optional<string> contextPath = default;
            Optional<string> gitHubPersonalAccessToken = default;
            Optional<string> image = default;
            Optional<string> publishType = default;
            Optional<string> os = default;
            Optional<string> runtimeStack = default;
            Optional<string> runtimeVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registryInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registryInfo = ContainerAppRegistryInfo.DeserializeContainerAppRegistryInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("azureCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureCredentials = ContainerAppCredentials.DeserializeContainerAppCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("contextPath"u8))
                {
                    contextPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("githubPersonalAccessToken"u8))
                {
                    gitHubPersonalAccessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    image = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publishType"u8))
                {
                    publishType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("os"u8))
                {
                    os = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeStack"u8))
                {
                    runtimeStack = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppGitHubActionConfiguration(registryInfo.Value, azureCredentials.Value, contextPath.Value, gitHubPersonalAccessToken.Value, image.Value, publishType.Value, os.Value, runtimeStack.Value, runtimeVersion.Value, rawData);
        }

        ContainerAppGitHubActionConfiguration IModelJsonSerializable<ContainerAppGitHubActionConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppGitHubActionConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppGitHubActionConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppGitHubActionConfiguration IModelSerializable<ContainerAppGitHubActionConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppGitHubActionConfiguration(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ContainerAppGitHubActionConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ContainerAppGitHubActionConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppGitHubActionConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
