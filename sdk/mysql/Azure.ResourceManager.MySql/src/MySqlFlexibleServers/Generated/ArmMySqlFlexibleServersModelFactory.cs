// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.FlexibleServers;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMySqlFlexibleServersModelFactory
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerAadAdministratorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="administratorType"> Type of the sever administrator. </param>
        /// <param name="login"> Login name of the server administrator. </param>
        /// <param name="sid"> SID (object ID) of the server administrator. </param>
        /// <param name="tenantId"> Tenant ID of the administrator. </param>
        /// <param name="identityResourceId"> The resource id of the identity used for AAD Authentication. </param>
        /// <returns> A new <see cref="FlexibleServers.MySqlFlexibleServerAadAdministratorData"/> instance for mocking. </returns>
        public static MySqlFlexibleServerAadAdministratorData MySqlFlexibleServerAadAdministratorData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MySqlFlexibleServerAdministratorType? administratorType = null, string login = null, string sid = null, Guid? tenantId = null, ResourceIdentifier identityResourceId = null)
        {
            return new MySqlFlexibleServerAadAdministratorData(id, name, resourceType, systemData, administratorType, login, sid, tenantId, identityResourceId);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerBackupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="backupType"> Backup type. </param>
        /// <param name="completedOn"> Backup completed time (ISO8601 format). </param>
        /// <param name="source"> Backup source. </param>
        /// <returns> A new <see cref="FlexibleServers.MySqlFlexibleServerBackupData"/> instance for mocking. </returns>
        public static MySqlFlexibleServerBackupData MySqlFlexibleServerBackupData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string backupType = null, DateTimeOffset? completedOn = null, string source = null)
        {
            return new MySqlFlexibleServerBackupData(id, name, resourceType, systemData, backupType, completedOn, source);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerBackupAndExportResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> The operation status. </param>
        /// <param name="startOn"> Start time. </param>
        /// <param name="endOn"> End time. </param>
        /// <param name="percentComplete"> Operation progress (0-100). </param>
        /// <param name="datasourceSizeInBytes"> Size of datasource in bytes. </param>
        /// <param name="dataTransferredInBytes"> Data transferred in bytes. </param>
        /// <param name="backupMetadata"> Metadata related to backup to be stored for restoring resource in key-value pairs. </param>
        /// <param name="error"> The error object. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerBackupAndExportResult"/> instance for mocking. </returns>
        public static MySqlFlexibleServerBackupAndExportResult MySqlFlexibleServerBackupAndExportResult(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MySqlFlexibleServerBackupAndExportOperationStatus? status = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, double? percentComplete = null, long? datasourceSizeInBytes = null, long? dataTransferredInBytes = null, string backupMetadata = null, ResponseError error = null)
        {
            return new MySqlFlexibleServerBackupAndExportResult(id, name, resourceType, systemData, status, startOn, endOn, percentComplete, datasourceSizeInBytes, dataTransferredInBytes, backupMetadata, error);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerValidateBackupResult. </summary>
        /// <param name="numberOfContainers"> Estimated no of storage containers required for resource data to be backed up. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerValidateBackupResult"/> instance for mocking. </returns>
        public static MySqlFlexibleServerValidateBackupResult MySqlFlexibleServerValidateBackupResult(int? numberOfContainers = null)
        {
            return new MySqlFlexibleServerValidateBackupResult(numberOfContainers);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="value"> Value of the configuration. </param>
        /// <param name="currentValue"> Current value of the configuration. </param>
        /// <param name="description"> Description of the configuration. </param>
        /// <param name="documentationLink"> The link used to get the document from community or Azure site. </param>
        /// <param name="defaultValue"> Default value of the configuration. </param>
        /// <param name="dataType"> Data type of the configuration. </param>
        /// <param name="allowedValues"> Allowed values of the configuration. </param>
        /// <param name="source"> Source of the configuration. </param>
        /// <param name="isReadOnly"> If is the configuration read only. </param>
        /// <param name="isConfigPendingRestart"> If is the configuration pending restart or not. </param>
        /// <param name="isDynamicConfig"> If is the configuration dynamic. </param>
        /// <returns> A new <see cref="FlexibleServers.MySqlFlexibleServerConfigurationData"/> instance for mocking. </returns>
        public static MySqlFlexibleServerConfigurationData MySqlFlexibleServerConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string value = null, string currentValue = null, string description = null, string documentationLink = null, string defaultValue = null, string dataType = null, string allowedValues = null, MySqlFlexibleServerConfigurationSource? source = null, MySqlFlexibleServerConfigReadOnlyState? isReadOnly = null, MySqlFlexibleServerConfigPendingRestartState? isConfigPendingRestart = null, MySqlFlexibleServerConfigDynamicState? isDynamicConfig = null)
        {
            return new MySqlFlexibleServerConfigurationData(id, name, resourceType, systemData, value, currentValue, description, documentationLink, defaultValue, dataType, allowedValues, source, isReadOnly, isConfigPendingRestart, isDynamicConfig);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerConfigurations. </summary>
        /// <param name="values"> The list of server configurations. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerConfigurations"/> instance for mocking. </returns>
        public static MySqlFlexibleServerConfigurations MySqlFlexibleServerConfigurations(IEnumerable<MySqlFlexibleServerConfigurationData> values = null)
        {
            values ??= new List<MySqlFlexibleServerConfigurationData>();

            return new MySqlFlexibleServerConfigurations(values?.ToList());
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerDatabaseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="charset"> The charset of the database. </param>
        /// <param name="collation"> The collation of the database. </param>
        /// <returns> A new <see cref="FlexibleServers.MySqlFlexibleServerDatabaseData"/> instance for mocking. </returns>
        public static MySqlFlexibleServerDatabaseData MySqlFlexibleServerDatabaseData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string charset = null, string collation = null)
        {
            return new MySqlFlexibleServerDatabaseData(id, name, resourceType, systemData, charset, collation);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerFirewallRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startIPAddress"> The start IP address of the server firewall rule. Must be IPv4 format. </param>
        /// <param name="endIPAddress"> The end IP address of the server firewall rule. Must be IPv4 format. </param>
        /// <returns> A new <see cref="FlexibleServers.MySqlFlexibleServerFirewallRuleData"/> instance for mocking. </returns>
        public static MySqlFlexibleServerFirewallRuleData MySqlFlexibleServerFirewallRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IPAddress startIPAddress = null, IPAddress endIPAddress = null)
        {
            return new MySqlFlexibleServerFirewallRuleData(id, name, resourceType, systemData, startIPAddress, endIPAddress);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The cmk identity for the server. Current supported identity types: UserAssigned. </param>
        /// <param name="sku"> The SKU (pricing tier) of the server. </param>
        /// <param name="administratorLogin"> The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation). </param>
        /// <param name="administratorLoginPassword"> The password of the administrator login (required for server creation). </param>
        /// <param name="version"> Server version. </param>
        /// <param name="availabilityZone"> availability Zone information of the server. </param>
        /// <param name="createMode"> The mode to create a new MySQL server. </param>
        /// <param name="sourceServerResourceId"> The source MySQL server id. </param>
        /// <param name="restorePointInTime"> Restore point creation time (ISO8601 format), specifying the time to restore from. </param>
        /// <param name="replicationRole"> The replication role. </param>
        /// <param name="replicaCapacity"> The maximum number of replicas that a primary server can have. </param>
        /// <param name="dataEncryption"> The Data Encryption for CMK. </param>
        /// <param name="state"> The state of a server. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of a server. </param>
        /// <param name="storage"> Storage related properties of a server. </param>
        /// <param name="backup"> Backup related properties of a server. </param>
        /// <param name="highAvailability"> High availability related properties of a server. </param>
        /// <param name="network"> Network related properties of a server. </param>
        /// <param name="privateEndpointConnections"> PrivateEndpointConnections related properties of a server. </param>
        /// <param name="maintenanceWindow"> Maintenance window of a server. </param>
        /// <param name="importSourceProperties"> Source properties for import from storage. </param>
        /// <returns> A new <see cref="FlexibleServers.MySqlFlexibleServerData"/> instance for mocking. </returns>
        public static MySqlFlexibleServerData MySqlFlexibleServerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, MySqlFlexibleServerSku sku = null, string administratorLogin = null, string administratorLoginPassword = null, MySqlFlexibleServerVersion? version = null, string availabilityZone = null, MySqlFlexibleServerCreateMode? createMode = null, ResourceIdentifier sourceServerResourceId = null, DateTimeOffset? restorePointInTime = null, MySqlFlexibleServerReplicationRole? replicationRole = null, int? replicaCapacity = null, MySqlFlexibleServerDataEncryption dataEncryption = null, MySqlFlexibleServerState? state = null, string fullyQualifiedDomainName = null, MySqlFlexibleServerStorage storage = null, MySqlFlexibleServerBackupProperties backup = null, MySqlFlexibleServerHighAvailability highAvailability = null, MySqlFlexibleServerNetwork network = null, IEnumerable<MySqlFlexibleServersPrivateEndpointConnection> privateEndpointConnections = null, MySqlFlexibleServerMaintenanceWindow maintenanceWindow = null, ImportSourceProperties importSourceProperties = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<MySqlFlexibleServersPrivateEndpointConnection>();

            return new MySqlFlexibleServerData(id, name, resourceType, systemData, tags, location, identity, sku, administratorLogin, administratorLoginPassword, version, availabilityZone, createMode, sourceServerResourceId, restorePointInTime, replicationRole, replicaCapacity, dataEncryption, state, fullyQualifiedDomainName, storage, backup, highAvailability, network, privateEndpointConnections?.ToList(), maintenanceWindow, importSourceProperties);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerStorage. </summary>
        /// <param name="storageSizeInGB"> Max storage size allowed for a server. </param>
        /// <param name="iops"> Storage IOPS for a server. </param>
        /// <param name="autoGrow"> Enable Storage Auto Grow or not. </param>
        /// <param name="logOnDisk"> Enable Log On Disk or not. </param>
        /// <param name="storageSku"> The sku name of the server storage. </param>
        /// <param name="autoIoScaling"> Enable IO Auto Scaling or not. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerStorage"/> instance for mocking. </returns>
        public static MySqlFlexibleServerStorage MySqlFlexibleServerStorage(int? storageSizeInGB = null, int? iops = null, MySqlFlexibleServerEnableStatusEnum? autoGrow = null, MySqlFlexibleServerEnableStatusEnum? logOnDisk = null, string storageSku = null, MySqlFlexibleServerEnableStatusEnum? autoIoScaling = null)
        {
            return new MySqlFlexibleServerStorage(storageSizeInGB, iops, autoGrow, logOnDisk, storageSku, autoIoScaling);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerBackupProperties. </summary>
        /// <param name="backupRetentionDays"> Backup retention days for the server. </param>
        /// <param name="geoRedundantBackup"> Whether or not geo redundant backup is enabled. </param>
        /// <param name="earliestRestoreOn"> Earliest restore point creation time (ISO8601 format). </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerBackupProperties"/> instance for mocking. </returns>
        public static MySqlFlexibleServerBackupProperties MySqlFlexibleServerBackupProperties(int? backupRetentionDays = null, MySqlFlexibleServerEnableStatusEnum? geoRedundantBackup = null, DateTimeOffset? earliestRestoreOn = null)
        {
            return new MySqlFlexibleServerBackupProperties(backupRetentionDays, geoRedundantBackup, earliestRestoreOn);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerHighAvailability. </summary>
        /// <param name="mode"> High availability mode for a server. </param>
        /// <param name="state"> The state of server high availability. </param>
        /// <param name="standbyAvailabilityZone"> Availability zone of the standby server. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerHighAvailability"/> instance for mocking. </returns>
        public static MySqlFlexibleServerHighAvailability MySqlFlexibleServerHighAvailability(MySqlFlexibleServerHighAvailabilityMode? mode = null, MySqlFlexibleServerHighAvailabilityState? state = null, string standbyAvailabilityZone = null)
        {
            return new MySqlFlexibleServerHighAvailability(mode, state, standbyAvailabilityZone);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServersPrivateEndpointConnection. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupIds"> The group ids for the private endpoint resource. </param>
        /// <param name="privateEndpointId"> The private endpoint resource. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServersPrivateEndpointConnection"/> instance for mocking. </returns>
        public static MySqlFlexibleServersPrivateEndpointConnection MySqlFlexibleServersPrivateEndpointConnection(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<string> groupIds = null, ResourceIdentifier privateEndpointId = null, MySqlFlexibleServersPrivateLinkServiceConnectionState connectionState = null, MySqlFlexibleServersPrivateEndpointConnectionProvisioningState? provisioningState = null)
        {
            groupIds ??= new List<string>();

            return new MySqlFlexibleServersPrivateEndpointConnection(id, name, resourceType, systemData, groupIds?.ToList(), privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, connectionState, provisioningState);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerLogFile. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sizeInKB"> The size in kb of the logFile. </param>
        /// <param name="createdOn"> Creation timestamp of the log file. </param>
        /// <param name="typePropertiesType"> Type of the log file. </param>
        /// <param name="lastModifiedOn"> Last modified timestamp of the log file. </param>
        /// <param name="uri"> The url to download the log file from. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerLogFile"/> instance for mocking. </returns>
        public static MySqlFlexibleServerLogFile MySqlFlexibleServerLogFile(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, long? sizeInKB = null, DateTimeOffset? createdOn = null, string typePropertiesType = null, DateTimeOffset? lastModifiedOn = null, Uri uri = null)
        {
            return new MySqlFlexibleServerLogFile(id, name, resourceType, systemData, sizeInKB, createdOn, typePropertiesType, lastModifiedOn, uri);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerCapabilityProperties. </summary>
        /// <param name="zone"> zone name. </param>
        /// <param name="supportedHAMode"> Supported high availability mode. </param>
        /// <param name="supportedGeoBackupRegions"> supported geo backup regions. </param>
        /// <param name="supportedFlexibleServerEditions"> A list of supported flexible server editions. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerCapabilityProperties"/> instance for mocking. </returns>
        public static MySqlFlexibleServerCapabilityProperties MySqlFlexibleServerCapabilityProperties(string zone = null, IEnumerable<string> supportedHAMode = null, IEnumerable<string> supportedGeoBackupRegions = null, IEnumerable<MySqlFlexibleServerEditionCapability> supportedFlexibleServerEditions = null)
        {
            supportedHAMode ??= new List<string>();
            supportedGeoBackupRegions ??= new List<string>();
            supportedFlexibleServerEditions ??= new List<MySqlFlexibleServerEditionCapability>();

            return new MySqlFlexibleServerCapabilityProperties(zone, supportedHAMode?.ToList(), supportedGeoBackupRegions?.ToList(), supportedFlexibleServerEditions?.ToList());
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerEditionCapability. </summary>
        /// <param name="name"> Server edition name. </param>
        /// <param name="supportedStorageEditions"> A list of supported storage editions. </param>
        /// <param name="supportedServerVersions"> A list of supported server versions. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerEditionCapability"/> instance for mocking. </returns>
        public static MySqlFlexibleServerEditionCapability MySqlFlexibleServerEditionCapability(string name = null, IEnumerable<MySqlFlexibleServerStorageEditionCapability> supportedStorageEditions = null, IEnumerable<MySqlFlexibleServerServerVersionCapability> supportedServerVersions = null)
        {
            supportedStorageEditions ??= new List<MySqlFlexibleServerStorageEditionCapability>();
            supportedServerVersions ??= new List<MySqlFlexibleServerServerVersionCapability>();

            return new MySqlFlexibleServerEditionCapability(name, supportedStorageEditions?.ToList(), supportedServerVersions?.ToList());
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerStorageEditionCapability. </summary>
        /// <param name="name"> storage edition name. </param>
        /// <param name="minStorageSize"> The minimal supported storage size. </param>
        /// <param name="maxStorageSize"> The maximum supported storage size. </param>
        /// <param name="minBackupRetentionDays"> Minimal backup retention days. </param>
        /// <param name="maxBackupRetentionDays"> Maximum backup retention days. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerStorageEditionCapability"/> instance for mocking. </returns>
        public static MySqlFlexibleServerStorageEditionCapability MySqlFlexibleServerStorageEditionCapability(string name = null, long? minStorageSize = null, long? maxStorageSize = null, long? minBackupRetentionDays = null, long? maxBackupRetentionDays = null)
        {
            return new MySqlFlexibleServerStorageEditionCapability(name, minStorageSize, maxStorageSize, minBackupRetentionDays, maxBackupRetentionDays);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerServerVersionCapability. </summary>
        /// <param name="name"> server version. </param>
        /// <param name="supportedSkus"> A list of supported Skus. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerServerVersionCapability"/> instance for mocking. </returns>
        public static MySqlFlexibleServerServerVersionCapability MySqlFlexibleServerServerVersionCapability(string name = null, IEnumerable<MySqlFlexibleServerSkuCapability> supportedSkus = null)
        {
            supportedSkus ??= new List<MySqlFlexibleServerSkuCapability>();

            return new MySqlFlexibleServerServerVersionCapability(name, supportedSkus?.ToList());
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerSkuCapability. </summary>
        /// <param name="name"> vCore name. </param>
        /// <param name="vCores"> supported vCores. </param>
        /// <param name="supportedIops"> supported IOPS. </param>
        /// <param name="supportedMemoryPerVCoreInMB"> supported memory per vCore in MB. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerSkuCapability"/> instance for mocking. </returns>
        public static MySqlFlexibleServerSkuCapability MySqlFlexibleServerSkuCapability(string name = null, long? vCores = null, long? supportedIops = null, long? supportedMemoryPerVCoreInMB = null)
        {
            return new MySqlFlexibleServerSkuCapability(name, vCores, supportedIops, supportedMemoryPerVCoreInMB);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServersCapabilityData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="supportedGeoBackupRegions"> supported geo backup regions. </param>
        /// <param name="supportedFlexibleServerEditions"> A list of supported flexible server editions. </param>
        /// <param name="supportedServerVersions"> A list of supported server versions. </param>
        /// <returns> A new <see cref="FlexibleServers.MySqlFlexibleServersCapabilityData"/> instance for mocking. </returns>
        public static MySqlFlexibleServersCapabilityData MySqlFlexibleServersCapabilityData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<string> supportedGeoBackupRegions = null, IEnumerable<ServerEditionCapabilityV2> supportedFlexibleServerEditions = null, IEnumerable<ServerVersionCapabilityV2> supportedServerVersions = null)
        {
            supportedGeoBackupRegions ??= new List<string>();
            supportedFlexibleServerEditions ??= new List<ServerEditionCapabilityV2>();
            supportedServerVersions ??= new List<ServerVersionCapabilityV2>();

            return new MySqlFlexibleServersCapabilityData(id, name, resourceType, systemData, supportedGeoBackupRegions?.ToList(), supportedFlexibleServerEditions?.ToList(), supportedServerVersions?.ToList());
        }

        /// <summary> Initializes a new instance of ServerEditionCapabilityV2. </summary>
        /// <param name="name"> Server edition name. </param>
        /// <param name="defaultSku"> Default Sku name. </param>
        /// <param name="defaultStorageSize"> Default storage size. </param>
        /// <param name="supportedStorageEditions"> A list of supported storage editions. </param>
        /// <param name="supportedSkus"> A list of supported Skus. </param>
        /// <returns> A new <see cref="Models.ServerEditionCapabilityV2"/> instance for mocking. </returns>
        public static ServerEditionCapabilityV2 ServerEditionCapabilityV2(string name = null, string defaultSku = null, int? defaultStorageSize = null, IEnumerable<MySqlFlexibleServerStorageEditionCapability> supportedStorageEditions = null, IEnumerable<SkuCapabilityV2> supportedSkus = null)
        {
            supportedStorageEditions ??= new List<MySqlFlexibleServerStorageEditionCapability>();
            supportedSkus ??= new List<SkuCapabilityV2>();

            return new ServerEditionCapabilityV2(name, defaultSku, defaultStorageSize, supportedStorageEditions?.ToList(), supportedSkus?.ToList());
        }

        /// <summary> Initializes a new instance of SkuCapabilityV2. </summary>
        /// <param name="name"> vCore name. </param>
        /// <param name="vCores"> supported vCores. </param>
        /// <param name="supportedIops"> supported IOPS. </param>
        /// <param name="supportedMemoryPerVCoreMB"> supported memory per vCore in MB. </param>
        /// <param name="supportedZones"> Supported zones. </param>
        /// <param name="supportedHAMode"> Supported high availability mode. </param>
        /// <returns> A new <see cref="Models.SkuCapabilityV2"/> instance for mocking. </returns>
        public static SkuCapabilityV2 SkuCapabilityV2(string name = null, long? vCores = null, long? supportedIops = null, long? supportedMemoryPerVCoreMB = null, IEnumerable<string> supportedZones = null, IEnumerable<string> supportedHAMode = null)
        {
            supportedZones ??= new List<string>();
            supportedHAMode ??= new List<string>();

            return new SkuCapabilityV2(name, vCores, supportedIops, supportedMemoryPerVCoreMB, supportedZones?.ToList(), supportedHAMode?.ToList());
        }

        /// <summary> Initializes a new instance of ServerVersionCapabilityV2. </summary>
        /// <param name="name"> server version. </param>
        /// <returns> A new <see cref="Models.ServerVersionCapabilityV2"/> instance for mocking. </returns>
        public static ServerVersionCapabilityV2 ServerVersionCapabilityV2(string name = null)
        {
            return new ServerVersionCapabilityV2(name);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerVirtualNetworkSubnetUsageResult. </summary>
        /// <param name="location"> The location name. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="delegatedSubnetsUsage"> A list of delegated subnet usage. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerVirtualNetworkSubnetUsageResult"/> instance for mocking. </returns>
        public static MySqlFlexibleServerVirtualNetworkSubnetUsageResult MySqlFlexibleServerVirtualNetworkSubnetUsageResult(AzureLocation? location = null, string subscriptionId = null, IEnumerable<MySqlFlexibleServerDelegatedSubnetUsage> delegatedSubnetsUsage = null)
        {
            delegatedSubnetsUsage ??= new List<MySqlFlexibleServerDelegatedSubnetUsage>();

            return new MySqlFlexibleServerVirtualNetworkSubnetUsageResult(location, subscriptionId, delegatedSubnetsUsage?.ToList());
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerDelegatedSubnetUsage. </summary>
        /// <param name="subnetName"> name of the subnet. </param>
        /// <param name="usage"> Number of used delegated subnets. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerDelegatedSubnetUsage"/> instance for mocking. </returns>
        public static MySqlFlexibleServerDelegatedSubnetUsage MySqlFlexibleServerDelegatedSubnetUsage(string subnetName = null, long? usage = null)
        {
            return new MySqlFlexibleServerDelegatedSubnetUsage(subnetName, usage);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerNameAvailabilityResult. </summary>
        /// <param name="message"> Error Message. </param>
        /// <param name="isNameAvailable"> Indicates whether the resource name is available. </param>
        /// <param name="reason"> Reason for name being unavailable. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerNameAvailabilityResult"/> instance for mocking. </returns>
        public static MySqlFlexibleServerNameAvailabilityResult MySqlFlexibleServerNameAvailabilityResult(string message = null, bool? isNameAvailable = null, string reason = null)
        {
            return new MySqlFlexibleServerNameAvailabilityResult(message, isNameAvailable, reason);
        }

        /// <summary> Initializes a new instance of OperationStatusExtendedResult. </summary>
        /// <param name="id"> Fully qualified ID for the async operation. </param>
        /// <param name="resourceId"> Fully qualified ID of the resource against which the original async operation was started. </param>
        /// <param name="name"> Name of the async operation. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="endOn"> The end time of the operation. </param>
        /// <param name="operations"> The operations list. </param>
        /// <param name="error"> If present, details of the operation error. </param>
        /// <param name="properties"> The extended properties of Operation Results. </param>
        /// <returns> A new <see cref="Models.OperationStatusExtendedResult"/> instance for mocking. </returns>
        public static OperationStatusExtendedResult OperationStatusExtendedResult(ResourceIdentifier id = null, ResourceIdentifier resourceId = null, string name = null, string status = null, float? percentComplete = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, IEnumerable<OperationStatusResult> operations = null, ResponseError error = null, IReadOnlyDictionary<string, BinaryData> properties = null)
        {
            operations ??= new List<OperationStatusResult>();
            properties ??= new Dictionary<string, BinaryData>();

            return new OperationStatusExtendedResult(id, resourceId, name, status, percentComplete, startOn, endOn, operations?.ToList(), error, properties);
        }

        /// <summary> Initializes a new instance of OperationStatusResult. </summary>
        /// <param name="id"> Fully qualified ID for the async operation. </param>
        /// <param name="resourceId"> Fully qualified ID of the resource against which the original async operation was started. </param>
        /// <param name="name"> Name of the async operation. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="endOn"> The end time of the operation. </param>
        /// <param name="operations"> The operations list. </param>
        /// <param name="error"> If present, details of the operation error. </param>
        /// <returns> A new <see cref="Models.OperationStatusResult"/> instance for mocking. </returns>
        public static OperationStatusResult OperationStatusResult(ResourceIdentifier id = null, ResourceIdentifier resourceId = null, string name = null, string status = null, float? percentComplete = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, IEnumerable<OperationStatusResult> operations = null, ResponseError error = null)
        {
            operations ??= new List<OperationStatusResult>();

            return new OperationStatusResult(id, resourceId, name, status, percentComplete, startOn, endOn, operations?.ToList(), error);
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerPrivateDnsZoneSuffixResponse. </summary>
        /// <param name="privateDnsZoneSuffix"> Represents the private DNS zone suffix. </param>
        /// <returns> A new <see cref="Models.MySqlFlexibleServerPrivateDnsZoneSuffixResponse"/> instance for mocking. </returns>
        public static MySqlFlexibleServerPrivateDnsZoneSuffixResponse MySqlFlexibleServerPrivateDnsZoneSuffixResponse(string privateDnsZoneSuffix = null)
        {
            return new MySqlFlexibleServerPrivateDnsZoneSuffixResponse(privateDnsZoneSuffix);
        }
    }
}
