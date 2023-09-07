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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabArtifactDeploymentStatus : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabArtifactDeploymentStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabArtifactDeploymentStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabArtifactDeploymentStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabArtifactDeploymentStatus>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DeploymentStatus))
            {
                writer.WritePropertyName("deploymentStatus"u8);
                writer.WriteStringValue(DeploymentStatus);
            }
            if (Optional.IsDefined(ArtifactsApplied))
            {
                writer.WritePropertyName("artifactsApplied"u8);
                writer.WriteNumberValue(ArtifactsApplied.Value);
            }
            if (Optional.IsDefined(TotalArtifacts))
            {
                writer.WritePropertyName("totalArtifacts"u8);
                writer.WriteNumberValue(TotalArtifacts.Value);
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

        internal static DevTestLabArtifactDeploymentStatus DeserializeDevTestLabArtifactDeploymentStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deploymentStatus = default;
            Optional<int> artifactsApplied = default;
            Optional<int> totalArtifacts = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentStatus"u8))
                {
                    deploymentStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactsApplied"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactsApplied = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalArtifacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalArtifacts = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabArtifactDeploymentStatus(deploymentStatus.Value, Optional.ToNullable(artifactsApplied), Optional.ToNullable(totalArtifacts), serializedAdditionalRawData);
        }

        DevTestLabArtifactDeploymentStatus IModelJsonSerializable<DevTestLabArtifactDeploymentStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabArtifactDeploymentStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabArtifactDeploymentStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabArtifactDeploymentStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabArtifactDeploymentStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabArtifactDeploymentStatus IModelSerializable<DevTestLabArtifactDeploymentStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabArtifactDeploymentStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabArtifactDeploymentStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabArtifactDeploymentStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabArtifactDeploymentStatus"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabArtifactDeploymentStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabArtifactDeploymentStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabArtifactDeploymentStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabArtifactDeploymentStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
