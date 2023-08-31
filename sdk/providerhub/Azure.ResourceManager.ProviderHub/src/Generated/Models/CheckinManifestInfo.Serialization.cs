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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class CheckinManifestInfo : IUtf8JsonSerializable, IModelJsonSerializable<CheckinManifestInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CheckinManifestInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CheckinManifestInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("isCheckedIn"u8);
            writer.WriteBooleanValue(IsCheckedIn);
            writer.WritePropertyName("statusMessage"u8);
            writer.WriteStringValue(StatusMessage);
            if (Optional.IsDefined(PullRequest))
            {
                writer.WritePropertyName("pullRequest"u8);
                writer.WriteStringValue(PullRequest);
            }
            if (Optional.IsDefined(CommitId))
            {
                writer.WritePropertyName("commitId"u8);
                writer.WriteStringValue(CommitId);
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

        internal static CheckinManifestInfo DeserializeCheckinManifestInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool isCheckedIn = default;
            string statusMessage = default;
            Optional<string> pullRequest = default;
            Optional<string> commitId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isCheckedIn"u8))
                {
                    isCheckedIn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pullRequest"u8))
                {
                    pullRequest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commitId"u8))
                {
                    commitId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CheckinManifestInfo(isCheckedIn, statusMessage, pullRequest.Value, commitId.Value, rawData);
        }

        CheckinManifestInfo IModelJsonSerializable<CheckinManifestInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckinManifestInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CheckinManifestInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CheckinManifestInfo IModelSerializable<CheckinManifestInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCheckinManifestInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CheckinManifestInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CheckinManifestInfo"/> to convert. </param>
        public static implicit operator RequestContent(CheckinManifestInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CheckinManifestInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CheckinManifestInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCheckinManifestInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
