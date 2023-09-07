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

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class ServiceUnit : IUtf8JsonSerializable, IModelJsonSerializable<ServiceUnit>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceUnit>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceUnit>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceUnit>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Steps))
            {
                writer.WritePropertyName("steps"u8);
                writer.WriteStartArray();
                foreach (var item in Steps)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RolloutStep>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("targetResourceGroup"u8);
            writer.WriteStringValue(TargetResourceGroup);
            writer.WritePropertyName("deploymentMode"u8);
            writer.WriteStringValue(DeploymentMode.ToSerialString());
            if (Optional.IsDefined(Artifacts))
            {
                writer.WritePropertyName("artifacts"u8);
                if (Artifacts is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ServiceUnitArtifacts>)Artifacts).Serialize(writer, options);
                }
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

        internal static ServiceUnit DeserializeServiceUnit(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<RolloutStep>> steps = default;
            string targetResourceGroup = default;
            DeploymentMode deploymentMode = default;
            Optional<ServiceUnitArtifacts> artifacts = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("steps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RolloutStep> array = new List<RolloutStep>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RolloutStep.DeserializeRolloutStep(item));
                    }
                    steps = array;
                    continue;
                }
                if (property.NameEquals("targetResourceGroup"u8))
                {
                    targetResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentMode"u8))
                {
                    deploymentMode = property.Value.GetString().ToDeploymentMode();
                    continue;
                }
                if (property.NameEquals("artifacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifacts = ServiceUnitArtifacts.DeserializeServiceUnitArtifacts(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceUnit(targetResourceGroup, deploymentMode, artifacts.Value, name.Value, Optional.ToList(steps), serializedAdditionalRawData);
        }

        ServiceUnit IModelJsonSerializable<ServiceUnit>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceUnit>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceUnit(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceUnit>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceUnit>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceUnit IModelSerializable<ServiceUnit>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceUnit>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceUnit(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceUnit"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceUnit"/> to convert. </param>
        public static implicit operator RequestContent(ServiceUnit model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceUnit"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceUnit(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceUnit(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
