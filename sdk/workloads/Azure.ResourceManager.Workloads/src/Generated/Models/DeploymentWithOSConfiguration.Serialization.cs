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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class DeploymentWithOSConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<DeploymentWithOSConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeploymentWithOSConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeploymentWithOSConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeploymentWithOSConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AppLocation))
            {
                writer.WritePropertyName("appLocation"u8);
                writer.WriteStringValue(AppLocation.Value);
            }
            if (Optional.IsDefined(InfrastructureConfiguration))
            {
                writer.WritePropertyName("infrastructureConfiguration"u8);
                if (InfrastructureConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<InfrastructureConfiguration>)InfrastructureConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SoftwareConfiguration))
            {
                writer.WritePropertyName("softwareConfiguration"u8);
                if (SoftwareConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SapSoftwareConfiguration>)SoftwareConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OSSapConfiguration))
            {
                writer.WritePropertyName("osSapConfiguration"u8);
                if (OSSapConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OSSapConfiguration>)OSSapConfiguration).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
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

        internal static DeploymentWithOSConfiguration DeserializeDeploymentWithOSConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> appLocation = default;
            Optional<InfrastructureConfiguration> infrastructureConfiguration = default;
            Optional<SapSoftwareConfiguration> softwareConfiguration = default;
            Optional<OSSapConfiguration> osSapConfiguration = default;
            SapConfigurationType configurationType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("infrastructureConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureConfiguration = InfrastructureConfiguration.DeserializeInfrastructureConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("softwareConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softwareConfiguration = SapSoftwareConfiguration.DeserializeSapSoftwareConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("osSapConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osSapConfiguration = OSSapConfiguration.DeserializeOSSapConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new SapConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeploymentWithOSConfiguration(configurationType, Optional.ToNullable(appLocation), infrastructureConfiguration.Value, softwareConfiguration.Value, osSapConfiguration.Value, serializedAdditionalRawData);
        }

        DeploymentWithOSConfiguration IModelJsonSerializable<DeploymentWithOSConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeploymentWithOSConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeploymentWithOSConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeploymentWithOSConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeploymentWithOSConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeploymentWithOSConfiguration IModelSerializable<DeploymentWithOSConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeploymentWithOSConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeploymentWithOSConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeploymentWithOSConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeploymentWithOSConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(DeploymentWithOSConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeploymentWithOSConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeploymentWithOSConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeploymentWithOSConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
