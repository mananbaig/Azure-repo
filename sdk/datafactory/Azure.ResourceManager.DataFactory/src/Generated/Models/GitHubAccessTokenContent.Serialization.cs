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
    public partial class GitHubAccessTokenContent : IUtf8JsonSerializable, IModelJsonSerializable<GitHubAccessTokenContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GitHubAccessTokenContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GitHubAccessTokenContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("gitHubAccessCode"u8);
            writer.WriteStringValue(GitHubAccessCode);
            if (Optional.IsDefined(GitHubClientId))
            {
                writer.WritePropertyName("gitHubClientId"u8);
                writer.WriteStringValue(GitHubClientId);
            }
            if (Optional.IsDefined(GitHubClientSecret))
            {
                writer.WritePropertyName("gitHubClientSecret"u8);
                if (GitHubClientSecret is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<FactoryGitHubClientSecret>)GitHubClientSecret).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("gitHubAccessTokenBaseUrl"u8);
            writer.WriteStringValue(GitHubAccessTokenBaseUri.AbsoluteUri);
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

        internal static GitHubAccessTokenContent DeserializeGitHubAccessTokenContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string gitHubAccessCode = default;
            Optional<string> gitHubClientId = default;
            Optional<FactoryGitHubClientSecret> gitHubClientSecret = default;
            Uri gitHubAccessTokenBaseUrl = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gitHubAccessCode"u8))
                {
                    gitHubAccessCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gitHubClientId"u8))
                {
                    gitHubClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gitHubClientSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitHubClientSecret = FactoryGitHubClientSecret.DeserializeFactoryGitHubClientSecret(property.Value);
                    continue;
                }
                if (property.NameEquals("gitHubAccessTokenBaseUrl"u8))
                {
                    gitHubAccessTokenBaseUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GitHubAccessTokenContent(gitHubAccessCode, gitHubClientId.Value, gitHubClientSecret.Value, gitHubAccessTokenBaseUrl, rawData);
        }

        GitHubAccessTokenContent IModelJsonSerializable<GitHubAccessTokenContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGitHubAccessTokenContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GitHubAccessTokenContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GitHubAccessTokenContent IModelSerializable<GitHubAccessTokenContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGitHubAccessTokenContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GitHubAccessTokenContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GitHubAccessTokenContent"/> to convert. </param>
        public static implicit operator RequestContent(GitHubAccessTokenContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GitHubAccessTokenContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GitHubAccessTokenContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGitHubAccessTokenContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
