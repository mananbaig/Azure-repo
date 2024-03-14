// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraDataCenterProperties : IUtf8JsonSerializable, IJsonModel<CassandraDataCenterProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraDataCenterProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CassandraDataCenterProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraDataCenterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraDataCenterProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(DataCenterLocation))
            {
                writer.WritePropertyName("dataCenterLocation"u8);
                writer.WriteStringValue(DataCenterLocation.Value);
            }
            if (Optional.IsDefined(DelegatedSubnetId))
            {
                writer.WritePropertyName("delegatedSubnetId"u8);
                writer.WriteStringValue(DelegatedSubnetId);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SeedNodes))
            {
                writer.WritePropertyName("seedNodes"u8);
                writer.WriteStartArray();
                foreach (var item in SeedNodes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Base64EncodedCassandraYamlFragment))
            {
                writer.WritePropertyName("base64EncodedCassandraYamlFragment"u8);
                writer.WriteStringValue(Base64EncodedCassandraYamlFragment);
            }
            if (Optional.IsDefined(ManagedDiskCustomerKeyUri))
            {
                writer.WritePropertyName("managedDiskCustomerKeyUri"u8);
                writer.WriteStringValue(ManagedDiskCustomerKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(BackupStorageCustomerKeyUri))
            {
                writer.WritePropertyName("backupStorageCustomerKeyUri"u8);
                writer.WriteStringValue(BackupStorageCustomerKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (Optional.IsDefined(DiskSku))
            {
                writer.WritePropertyName("diskSku"u8);
                writer.WriteStringValue(DiskSku);
            }
            if (Optional.IsDefined(DiskCapacity))
            {
                writer.WritePropertyName("diskCapacity"u8);
                writer.WriteNumberValue(DiskCapacity.Value);
            }
            if (Optional.IsDefined(DoesSupportAvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteBooleanValue(DoesSupportAvailabilityZone.Value);
            }
            if (Optional.IsDefined(AuthenticationMethodLdapProperties))
            {
                writer.WritePropertyName("authenticationMethodLdapProperties"u8);
                writer.WriteObjectValue(AuthenticationMethodLdapProperties);
            }
            if (Optional.IsDefined(Deallocated))
            {
                writer.WritePropertyName("deallocated"u8);
                writer.WriteBooleanValue(Deallocated.Value);
            }
            if (Optional.IsDefined(ProvisionError))
            {
                writer.WritePropertyName("provisionError"u8);
                writer.WriteObjectValue(ProvisionError);
            }
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

        CassandraDataCenterProperties IJsonModel<CassandraDataCenterProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraDataCenterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraDataCenterProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraDataCenterProperties(document.RootElement, options);
        }

        internal static CassandraDataCenterProperties DeserializeCassandraDataCenterProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CassandraProvisioningState? provisioningState = default;
            AzureLocation? dataCenterLocation = default;
            ResourceIdentifier delegatedSubnetId = default;
            int? nodeCount = default;
            IReadOnlyList<CassandraDataCenterSeedNode> seedNodes = default;
            string base64EncodedCassandraYamlFragment = default;
            Uri managedDiskCustomerKeyUri = default;
            Uri backupStorageCustomerKeyUri = default;
            string sku = default;
            string diskSku = default;
            int? diskCapacity = default;
            bool? availabilityZone = default;
            AuthenticationMethodLdapProperties authenticationMethodLdapProperties = default;
            bool? deallocated = default;
            CassandraError provisionError = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new CassandraProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataCenterLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("delegatedSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delegatedSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("seedNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraDataCenterSeedNode> array = new List<CassandraDataCenterSeedNode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraDataCenterSeedNode.DeserializeCassandraDataCenterSeedNode(item, options));
                    }
                    seedNodes = array;
                    continue;
                }
                if (property.NameEquals("base64EncodedCassandraYamlFragment"u8))
                {
                    base64EncodedCassandraYamlFragment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedDiskCustomerKeyUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedDiskCustomerKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupStorageCustomerKeyUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStorageCustomerKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskSku"u8))
                {
                    diskSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskCapacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("availabilityZone"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availabilityZone = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("authenticationMethodLdapProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationMethodLdapProperties = AuthenticationMethodLdapProperties.DeserializeAuthenticationMethodLdapProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deallocated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deallocated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("provisionError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisionError = CassandraError.DeserializeCassandraError(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CassandraDataCenterProperties(
                provisioningState,
                dataCenterLocation,
                delegatedSubnetId,
                nodeCount,
                seedNodes ?? new ChangeTrackingList<CassandraDataCenterSeedNode>(),
                base64EncodedCassandraYamlFragment,
                managedDiskCustomerKeyUri,
                backupStorageCustomerKeyUri,
                sku,
                diskSku,
                diskCapacity,
                availabilityZone,
                authenticationMethodLdapProperties,
                deallocated,
                provisionError,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CassandraDataCenterProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraDataCenterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CassandraDataCenterProperties)} does not support '{options.Format}' format.");
            }
        }

        CassandraDataCenterProperties IPersistableModel<CassandraDataCenterProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraDataCenterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraDataCenterProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CassandraDataCenterProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraDataCenterProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
