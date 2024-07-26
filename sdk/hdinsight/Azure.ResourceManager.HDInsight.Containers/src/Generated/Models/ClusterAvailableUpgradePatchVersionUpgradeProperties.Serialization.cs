// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterAvailableUpgradePatchVersionUpgradeProperties : IUtf8JsonSerializable, IJsonModel<ClusterAvailableUpgradePatchVersionUpgradeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterAvailableUpgradePatchVersionUpgradeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterAvailableUpgradePatchVersionUpgradeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableUpgradePatchVersionUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterAvailableUpgradePatchVersionUpgradeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(SourceOssVersion))
            {
                writer.WritePropertyName("sourceOssVersion"u8);
                writer.WriteStringValue(SourceOssVersion);
            }
            if (Optional.IsDefined(SourceClusterVersion))
            {
                writer.WritePropertyName("sourceClusterVersion"u8);
                writer.WriteStringValue(SourceClusterVersion);
            }
            if (Optional.IsDefined(SourceBuildNumber))
            {
                writer.WritePropertyName("sourceBuildNumber"u8);
                writer.WriteStringValue(SourceBuildNumber);
            }
            if (Optional.IsDefined(TargetOssVersion))
            {
                writer.WritePropertyName("targetOssVersion"u8);
                writer.WriteStringValue(TargetOssVersion);
            }
            if (Optional.IsDefined(TargetClusterVersion))
            {
                writer.WritePropertyName("targetClusterVersion"u8);
                writer.WriteStringValue(TargetClusterVersion);
            }
            if (Optional.IsDefined(TargetBuildNumber))
            {
                writer.WritePropertyName("targetBuildNumber"u8);
                writer.WriteStringValue(TargetBuildNumber);
            }
            if (Optional.IsDefined(ComponentName))
            {
                writer.WritePropertyName("componentName"u8);
                writer.WriteStringValue(ComponentName);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(ExtendedProperties))
            {
                writer.WritePropertyName("extendedProperties"u8);
                writer.WriteStringValue(ExtendedProperties);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            writer.WritePropertyName("upgradeType"u8);
            writer.WriteStringValue(UpgradeType.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ClusterAvailableUpgradePatchVersionUpgradeProperties IJsonModel<ClusterAvailableUpgradePatchVersionUpgradeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableUpgradePatchVersionUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterAvailableUpgradePatchVersionUpgradeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterAvailableUpgradePatchVersionUpgradeProperties(document.RootElement, options);
        }

        internal static ClusterAvailableUpgradePatchVersionUpgradeProperties DeserializeClusterAvailableUpgradePatchVersionUpgradeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            string sourceOssVersion = default;
            string sourceClusterVersion = default;
            string sourceBuildNumber = default;
            string targetOssVersion = default;
            string targetClusterVersion = default;
            string targetBuildNumber = default;
            string componentName = default;
            ClusterUpgradeSeverityType? severity = default;
            string extendedProperties = default;
            DateTimeOffset? createdTime = default;
            ClusterAvailableUpgradeType upgradeType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceOssVersion"u8))
                {
                    sourceOssVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceClusterVersion"u8))
                {
                    sourceClusterVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceBuildNumber"u8))
                {
                    sourceBuildNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetOssVersion"u8))
                {
                    targetOssVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetClusterVersion"u8))
                {
                    targetClusterVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetBuildNumber"u8))
                {
                    targetBuildNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("componentName"u8))
                {
                    componentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new ClusterUpgradeSeverityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("extendedProperties"u8))
                {
                    extendedProperties = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("upgradeType"u8))
                {
                    upgradeType = new ClusterAvailableUpgradeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterAvailableUpgradePatchVersionUpgradeProperties(
                upgradeType,
                serializedAdditionalRawData,
                description,
                sourceOssVersion,
                sourceClusterVersion,
                sourceBuildNumber,
                targetOssVersion,
                targetClusterVersion,
                targetBuildNumber,
                componentName,
                severity,
                extendedProperties,
                createdTime);
        }

        BinaryData IPersistableModel<ClusterAvailableUpgradePatchVersionUpgradeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableUpgradePatchVersionUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterAvailableUpgradePatchVersionUpgradeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterAvailableUpgradePatchVersionUpgradeProperties IPersistableModel<ClusterAvailableUpgradePatchVersionUpgradeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableUpgradePatchVersionUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterAvailableUpgradePatchVersionUpgradeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterAvailableUpgradePatchVersionUpgradeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterAvailableUpgradePatchVersionUpgradeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
