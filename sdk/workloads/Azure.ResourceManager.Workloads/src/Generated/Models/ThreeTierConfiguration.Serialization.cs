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
    public partial class ThreeTierConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ThreeTierConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ThreeTierConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ThreeTierConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ThreeTierConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                if (NetworkConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NetworkConfiguration>)NetworkConfiguration).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("centralServer"u8);
            if (CentralServer is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<CentralServerConfiguration>)CentralServer).Serialize(writer, options);
            }
            writer.WritePropertyName("applicationServer"u8);
            if (ApplicationServer is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ApplicationServerConfiguration>)ApplicationServer).Serialize(writer, options);
            }
            writer.WritePropertyName("databaseServer"u8);
            if (DatabaseServer is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DatabaseConfiguration>)DatabaseServer).Serialize(writer, options);
            }
            if (Optional.IsDefined(HighAvailabilityConfig))
            {
                writer.WritePropertyName("highAvailabilityConfig"u8);
                if (HighAvailabilityConfig is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<HighAvailabilityConfiguration>)HighAvailabilityConfig).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(StorageConfiguration))
            {
                writer.WritePropertyName("storageConfiguration"u8);
                if (StorageConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SapStorageConfiguration>)StorageConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CustomResourceNames))
            {
                writer.WritePropertyName("customResourceNames"u8);
                if (CustomResourceNames is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ThreeTierCustomResourceNames>)CustomResourceNames).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteStringValue(DeploymentType.ToString());
            writer.WritePropertyName("appResourceGroup"u8);
            writer.WriteStringValue(AppResourceGroup);
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

        internal static ThreeTierConfiguration DeserializeThreeTierConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetworkConfiguration> networkConfiguration = default;
            CentralServerConfiguration centralServer = default;
            ApplicationServerConfiguration applicationServer = default;
            DatabaseConfiguration databaseServer = default;
            Optional<HighAvailabilityConfiguration> highAvailabilityConfig = default;
            Optional<SapStorageConfiguration> storageConfiguration = default;
            Optional<ThreeTierCustomResourceNames> customResourceNames = default;
            SapDeploymentType deploymentType = default;
            string appResourceGroup = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkConfiguration = NetworkConfiguration.DeserializeNetworkConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("centralServer"u8))
                {
                    centralServer = CentralServerConfiguration.DeserializeCentralServerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("applicationServer"u8))
                {
                    applicationServer = ApplicationServerConfiguration.DeserializeApplicationServerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("databaseServer"u8))
                {
                    databaseServer = DatabaseConfiguration.DeserializeDatabaseConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("highAvailabilityConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    highAvailabilityConfig = HighAvailabilityConfiguration.DeserializeHighAvailabilityConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("storageConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageConfiguration = SapStorageConfiguration.DeserializeSapStorageConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("customResourceNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customResourceNames = ThreeTierCustomResourceNames.DeserializeThreeTierCustomResourceNames(property.Value);
                    continue;
                }
                if (property.NameEquals("deploymentType"u8))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appResourceGroup"u8))
                {
                    appResourceGroup = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ThreeTierConfiguration(deploymentType, appResourceGroup, networkConfiguration.Value, centralServer, applicationServer, databaseServer, highAvailabilityConfig.Value, storageConfiguration.Value, customResourceNames.Value, serializedAdditionalRawData);
        }

        ThreeTierConfiguration IModelJsonSerializable<ThreeTierConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ThreeTierConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeThreeTierConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ThreeTierConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ThreeTierConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ThreeTierConfiguration IModelSerializable<ThreeTierConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ThreeTierConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeThreeTierConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ThreeTierConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ThreeTierConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ThreeTierConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ThreeTierConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ThreeTierConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeThreeTierConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
