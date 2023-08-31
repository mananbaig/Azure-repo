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
    public partial class KubernetesGitRepositoryRef : IUtf8JsonSerializable, IModelJsonSerializable<KubernetesGitRepositoryRef>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KubernetesGitRepositoryRef>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KubernetesGitRepositoryRef>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Branch))
            {
                if (Branch != null)
                {
                    writer.WritePropertyName("branch"u8);
                    writer.WriteStringValue(Branch);
                }
                else
                {
                    writer.WriteNull("branch");
                }
            }
            if (Optional.IsDefined(Tag))
            {
                if (Tag != null)
                {
                    writer.WritePropertyName("tag"u8);
                    writer.WriteStringValue(Tag);
                }
                else
                {
                    writer.WriteNull("tag");
                }
            }
            if (Optional.IsDefined(Semver))
            {
                if (Semver != null)
                {
                    writer.WritePropertyName("semver"u8);
                    writer.WriteStringValue(Semver);
                }
                else
                {
                    writer.WriteNull("semver");
                }
            }
            if (Optional.IsDefined(Commit))
            {
                if (Commit != null)
                {
                    writer.WritePropertyName("commit"u8);
                    writer.WriteStringValue(Commit);
                }
                else
                {
                    writer.WriteNull("commit");
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

        internal static KubernetesGitRepositoryRef DeserializeKubernetesGitRepositoryRef(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> branch = default;
            Optional<string> tag = default;
            Optional<string> semver = default;
            Optional<string> commit = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("branch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        branch = null;
                        continue;
                    }
                    branch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tag = null;
                        continue;
                    }
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("semver"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        semver = null;
                        continue;
                    }
                    semver = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        commit = null;
                        continue;
                    }
                    commit = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KubernetesGitRepositoryRef(branch.Value, tag.Value, semver.Value, commit.Value, rawData);
        }

        KubernetesGitRepositoryRef IModelJsonSerializable<KubernetesGitRepositoryRef>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesGitRepositoryRef(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KubernetesGitRepositoryRef>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KubernetesGitRepositoryRef IModelSerializable<KubernetesGitRepositoryRef>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKubernetesGitRepositoryRef(doc.RootElement, options);
        }

        public static implicit operator RequestContent(KubernetesGitRepositoryRef model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator KubernetesGitRepositoryRef(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKubernetesGitRepositoryRef(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
