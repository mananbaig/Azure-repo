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
using Azure.ResourceManager.CosmosDBForPostgreSql.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    public partial class CosmosDBForPostgreSqlClusterData : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBForPostgreSqlClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBForPostgreSqlClusterData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBForPostgreSqlClusterData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(PostgresqlVersion))
            {
                writer.WritePropertyName("postgresqlVersion"u8);
                writer.WriteStringValue(PostgresqlVersion);
            }
            if (Optional.IsDefined(CitusVersion))
            {
                writer.WritePropertyName("citusVersion"u8);
                writer.WriteStringValue(CitusVersion);
            }
            if (Optional.IsDefined(MaintenanceWindow))
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                if (MaintenanceWindow is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CosmosDBForPostgreSqlMaintenanceWindow>)MaintenanceWindow).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PreferredPrimaryZone))
            {
                writer.WritePropertyName("preferredPrimaryZone"u8);
                writer.WriteStringValue(PreferredPrimaryZone);
            }
            if (Optional.IsDefined(IsShardsOnCoordinatorEnabled))
            {
                writer.WritePropertyName("enableShardsOnCoordinator"u8);
                writer.WriteBooleanValue(IsShardsOnCoordinatorEnabled.Value);
            }
            if (Optional.IsDefined(IsHAEnabled))
            {
                writer.WritePropertyName("enableHa"u8);
                writer.WriteBooleanValue(IsHAEnabled.Value);
            }
            if (Optional.IsDefined(CoordinatorServerEdition))
            {
                writer.WritePropertyName("coordinatorServerEdition"u8);
                writer.WriteStringValue(CoordinatorServerEdition);
            }
            if (Optional.IsDefined(CoordinatorStorageQuotaInMb))
            {
                writer.WritePropertyName("coordinatorStorageQuotaInMb"u8);
                writer.WriteNumberValue(CoordinatorStorageQuotaInMb.Value);
            }
            if (Optional.IsDefined(CoordinatorVCores))
            {
                writer.WritePropertyName("coordinatorVCores"u8);
                writer.WriteNumberValue(CoordinatorVCores.Value);
            }
            if (Optional.IsDefined(IsCoordinatorPublicIPAccessEnabled))
            {
                writer.WritePropertyName("coordinatorEnablePublicIpAccess"u8);
                writer.WriteBooleanValue(IsCoordinatorPublicIPAccessEnabled.Value);
            }
            if (Optional.IsDefined(NodeServerEdition))
            {
                writer.WritePropertyName("nodeServerEdition"u8);
                writer.WriteStringValue(NodeServerEdition);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (Optional.IsDefined(NodeStorageQuotaInMb))
            {
                writer.WritePropertyName("nodeStorageQuotaInMb"u8);
                writer.WriteNumberValue(NodeStorageQuotaInMb.Value);
            }
            if (Optional.IsDefined(NodeVCores))
            {
                writer.WritePropertyName("nodeVCores"u8);
                writer.WriteNumberValue(NodeVCores.Value);
            }
            if (Optional.IsDefined(IsNodePublicIPAccessEnabled))
            {
                writer.WritePropertyName("nodeEnablePublicIpAccess"u8);
                writer.WriteBooleanValue(IsNodePublicIPAccessEnabled.Value);
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(SourceLocation))
            {
                writer.WritePropertyName("sourceLocation"u8);
                writer.WriteStringValue(SourceLocation.Value);
            }
            if (Optional.IsDefined(PointInTimeUTC))
            {
                writer.WritePropertyName("pointInTimeUTC"u8);
                writer.WriteStringValue(PointInTimeUTC.Value, "O");
            }
            writer.WriteEndObject();
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

        internal static CosmosDBForPostgreSqlClusterData DeserializeCosmosDBForPostgreSqlClusterData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> administratorLogin = default;
            Optional<string> administratorLoginPassword = default;
            Optional<string> provisioningState = default;
            Optional<string> state = default;
            Optional<string> postgresqlVersion = default;
            Optional<string> citusVersion = default;
            Optional<CosmosDBForPostgreSqlMaintenanceWindow> maintenanceWindow = default;
            Optional<string> preferredPrimaryZone = default;
            Optional<bool> enableShardsOnCoordinator = default;
            Optional<bool> enableHa = default;
            Optional<string> coordinatorServerEdition = default;
            Optional<int> coordinatorStorageQuotaInMb = default;
            Optional<int> coordinatorVCores = default;
            Optional<bool> coordinatorEnablePublicIPAccess = default;
            Optional<string> nodeServerEdition = default;
            Optional<int> nodeCount = default;
            Optional<int> nodeStorageQuotaInMb = default;
            Optional<int> nodeVCores = default;
            Optional<bool> nodeEnablePublicIPAccess = default;
            Optional<IReadOnlyList<ServerNameItem>> serverNames = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<AzureLocation> sourceLocation = default;
            Optional<DateTimeOffset> pointInTimeUTC = default;
            Optional<IReadOnlyList<string>> readReplicas = default;
            Optional<DateTimeOffset> earliestRestoreTime = default;
            Optional<IReadOnlyList<CosmosDBForPostgreSqlSimplePrivateEndpointConnection>> privateEndpointConnections = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("administratorLogin"u8))
                        {
                            administratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administratorLoginPassword"u8))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("postgresqlVersion"u8))
                        {
                            postgresqlVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("citusVersion"u8))
                        {
                            citusVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceWindow = CosmosDBForPostgreSqlMaintenanceWindow.DeserializeCosmosDBForPostgreSqlMaintenanceWindow(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("preferredPrimaryZone"u8))
                        {
                            preferredPrimaryZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableShardsOnCoordinator"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableShardsOnCoordinator = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableHa"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableHa = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorServerEdition"u8))
                        {
                            coordinatorServerEdition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorStorageQuotaInMb"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorStorageQuotaInMb = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorVCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorVCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("coordinatorEnablePublicIpAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coordinatorEnablePublicIPAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("nodeServerEdition"u8))
                        {
                            nodeServerEdition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeStorageQuotaInMb"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeStorageQuotaInMb = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeVCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeVCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("nodeEnablePublicIpAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeEnablePublicIPAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("serverNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServerNameItem> array = new List<ServerNameItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServerNameItem.DeserializeServerNameItem(item));
                            }
                            serverNames = array;
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("pointInTimeUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pointInTimeUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("readReplicas"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            readReplicas = array;
                            continue;
                        }
                        if (property0.NameEquals("earliestRestoreTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            earliestRestoreTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBForPostgreSqlSimplePrivateEndpointConnection> array = new List<CosmosDBForPostgreSqlSimplePrivateEndpointConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBForPostgreSqlSimplePrivateEndpointConnection.DeserializeCosmosDBForPostgreSqlSimplePrivateEndpointConnection(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CosmosDBForPostgreSqlClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, administratorLogin.Value, administratorLoginPassword.Value, provisioningState.Value, state.Value, postgresqlVersion.Value, citusVersion.Value, maintenanceWindow.Value, preferredPrimaryZone.Value, Optional.ToNullable(enableShardsOnCoordinator), Optional.ToNullable(enableHa), coordinatorServerEdition.Value, Optional.ToNullable(coordinatorStorageQuotaInMb), Optional.ToNullable(coordinatorVCores), Optional.ToNullable(coordinatorEnablePublicIPAccess), nodeServerEdition.Value, Optional.ToNullable(nodeCount), Optional.ToNullable(nodeStorageQuotaInMb), Optional.ToNullable(nodeVCores), Optional.ToNullable(nodeEnablePublicIPAccess), Optional.ToList(serverNames), sourceResourceId.Value, Optional.ToNullable(sourceLocation), Optional.ToNullable(pointInTimeUTC), Optional.ToList(readReplicas), Optional.ToNullable(earliestRestoreTime), Optional.ToList(privateEndpointConnections), rawData);
        }

        CosmosDBForPostgreSqlClusterData IModelJsonSerializable<CosmosDBForPostgreSqlClusterData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBForPostgreSqlClusterData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBForPostgreSqlClusterData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBForPostgreSqlClusterData IModelSerializable<CosmosDBForPostgreSqlClusterData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBForPostgreSqlClusterData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CosmosDBForPostgreSqlClusterData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CosmosDBForPostgreSqlClusterData"/> to convert. </param>
        public static implicit operator RequestContent(CosmosDBForPostgreSqlClusterData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CosmosDBForPostgreSqlClusterData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CosmosDBForPostgreSqlClusterData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBForPostgreSqlClusterData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
