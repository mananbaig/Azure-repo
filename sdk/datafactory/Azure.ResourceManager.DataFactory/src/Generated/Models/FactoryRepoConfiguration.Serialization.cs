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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class FactoryRepoConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<FactoryRepoConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FactoryRepoConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FactoryRepoConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FactoryRepoConfigurationType);
            writer.WritePropertyName("accountName"u8);
            writer.WriteStringValue(AccountName);
            writer.WritePropertyName("repositoryName"u8);
            writer.WriteStringValue(RepositoryName);
            writer.WritePropertyName("collaborationBranch"u8);
            writer.WriteStringValue(CollaborationBranch);
            writer.WritePropertyName("rootFolder"u8);
            writer.WriteStringValue(RootFolder);
            if (Optional.IsDefined(LastCommitId))
            {
                writer.WritePropertyName("lastCommitId"u8);
                writer.WriteStringValue(LastCommitId);
            }
            if (Optional.IsDefined(DisablePublish))
            {
                writer.WritePropertyName("disablePublish"u8);
                writer.WriteBooleanValue(DisablePublish.Value);
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

        internal static FactoryRepoConfiguration DeserializeFactoryRepoConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FactoryGitHubConfiguration": return FactoryGitHubConfiguration.DeserializeFactoryGitHubConfiguration(element);
                    case "FactoryVSTSConfiguration": return FactoryVstsConfiguration.DeserializeFactoryVstsConfiguration(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string type = default;
            string accountName = default;
            string repositoryName = default;
            string collaborationBranch = default;
            string rootFolder = default;
            Optional<string> lastCommitId = default;
            Optional<bool> disablePublish = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryName"u8))
                {
                    repositoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collaborationBranch"u8))
                {
                    collaborationBranch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootFolder"u8))
                {
                    rootFolder = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCommitId"u8))
                {
                    lastCommitId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disablePublish"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disablePublish = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownFactoryRepoConfiguration(type, accountName, repositoryName, collaborationBranch, rootFolder, lastCommitId.Value, Optional.ToNullable(disablePublish), rawData);
        }

        FactoryRepoConfiguration IModelJsonSerializable<FactoryRepoConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFactoryRepoConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FactoryRepoConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FactoryRepoConfiguration IModelSerializable<FactoryRepoConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFactoryRepoConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FactoryRepoConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FactoryRepoConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(FactoryRepoConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FactoryRepoConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FactoryRepoConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFactoryRepoConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
