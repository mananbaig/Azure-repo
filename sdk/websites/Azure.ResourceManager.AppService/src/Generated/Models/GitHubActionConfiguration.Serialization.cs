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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class GitHubActionConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<GitHubActionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GitHubActionConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GitHubActionConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GitHubActionConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CodeConfiguration))
            {
                writer.WritePropertyName("codeConfiguration"u8);
                if (CodeConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GitHubActionCodeConfiguration>)CodeConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ContainerConfiguration))
            {
                writer.WritePropertyName("containerConfiguration"u8);
                if (ContainerConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GitHubActionContainerConfiguration>)ContainerConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IsLinux))
            {
                writer.WritePropertyName("isLinux"u8);
                writer.WriteBooleanValue(IsLinux.Value);
            }
            if (Optional.IsDefined(GenerateWorkflowFile))
            {
                writer.WritePropertyName("generateWorkflowFile"u8);
                writer.WriteBooleanValue(GenerateWorkflowFile.Value);
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static GitHubActionConfiguration DeserializeGitHubActionConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GitHubActionCodeConfiguration> codeConfiguration = default;
            Optional<GitHubActionContainerConfiguration> containerConfiguration = default;
            Optional<bool> isLinux = default;
            Optional<bool> generateWorkflowFile = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    codeConfiguration = GitHubActionCodeConfiguration.DeserializeGitHubActionCodeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("containerConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerConfiguration = GitHubActionContainerConfiguration.DeserializeGitHubActionContainerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("isLinux"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLinux = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("generateWorkflowFile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    generateWorkflowFile = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GitHubActionConfiguration(codeConfiguration.Value, containerConfiguration.Value, Optional.ToNullable(isLinux), Optional.ToNullable(generateWorkflowFile), serializedAdditionalRawData);
        }

        GitHubActionConfiguration IModelJsonSerializable<GitHubActionConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GitHubActionConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGitHubActionConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GitHubActionConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GitHubActionConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GitHubActionConfiguration IModelSerializable<GitHubActionConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GitHubActionConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGitHubActionConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GitHubActionConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GitHubActionConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(GitHubActionConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GitHubActionConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GitHubActionConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGitHubActionConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
