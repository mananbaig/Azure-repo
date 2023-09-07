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

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    public partial class GitHubConnectorStatsProperties : IUtf8JsonSerializable, IModelJsonSerializable<GitHubConnectorStatsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GitHubConnectorStatsProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GitHubConnectorStatsProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GitHubConnectorStatsProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(OwnersCount))
            {
                writer.WritePropertyName("ownersCount"u8);
                writer.WriteNumberValue(OwnersCount.Value);
            }
            if (Optional.IsDefined(ReposCount))
            {
                writer.WritePropertyName("reposCount"u8);
                writer.WriteNumberValue(ReposCount.Value);
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

        internal static GitHubConnectorStatsProperties DeserializeGitHubConnectorStatsProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<long> ownersCount = default;
            Optional<long> reposCount = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ownersCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ownersCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("reposCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reposCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GitHubConnectorStatsProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(ownersCount), Optional.ToNullable(reposCount), serializedAdditionalRawData);
        }

        GitHubConnectorStatsProperties IModelJsonSerializable<GitHubConnectorStatsProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GitHubConnectorStatsProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGitHubConnectorStatsProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GitHubConnectorStatsProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GitHubConnectorStatsProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GitHubConnectorStatsProperties IModelSerializable<GitHubConnectorStatsProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GitHubConnectorStatsProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGitHubConnectorStatsProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GitHubConnectorStatsProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GitHubConnectorStatsProperties"/> to convert. </param>
        public static implicit operator RequestContent(GitHubConnectorStatsProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GitHubConnectorStatsProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GitHubConnectorStatsProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGitHubConnectorStatsProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
