// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Cosmos DB database account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DatabaseAccountGetResults : ARMResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseAccountGetResults class.
        /// </summary>
        public DatabaseAccountGetResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseAccountGetResults class.
        /// </summary>
        /// <param name="id">The unique resource identifier of the ARM
        /// resource.</param>
        /// <param name="name">The name of the ARM resource.</param>
        /// <param name="type">The type of Azure resource.</param>
        /// <param name="location">The location of the resource group to which
        /// the resource belongs.</param>
        /// <param name="kind">Indicates the type of database account. This can
        /// only be set at database account creation. Possible values include:
        /// 'GlobalDocumentDB', 'MongoDB', 'Parse'</param>
        /// <param name="documentEndpoint">The connection endpoint for the
        /// Cosmos DB database account.</param>
        /// <param name="databaseAccountOfferType">The offer type for the
        /// Cosmos DB database account. Default value: Standard. Possible
        /// values include: 'Standard'</param>
        /// <param name="ipRules">List of IpRules.</param>
        /// <param name="isVirtualNetworkFilterEnabled">Flag to indicate
        /// whether to enable/disable Virtual Network ACL rules.</param>
        /// <param name="enableAutomaticFailover">Enables automatic failover of
        /// the write region in the rare event that the region is unavailable
        /// due to an outage. Automatic failover will result in a new write
        /// region for the account and is chosen based on the failover
        /// priorities configured for the account.</param>
        /// <param name="consistencyPolicy">The consistency policy for the
        /// Cosmos DB database account.</param>
        /// <param name="capabilities">List of Cosmos DB capabilities for the
        /// account</param>
        /// <param name="writeLocations">An array that contains the write
        /// location for the Cosmos DB account.</param>
        /// <param name="readLocations">An array that contains of the read
        /// locations enabled for the Cosmos DB account.</param>
        /// <param name="locations">An array that contains all of the locations
        /// enabled for the Cosmos DB account.</param>
        /// <param name="failoverPolicies">An array that contains the regions
        /// ordered by their failover priorities.</param>
        /// <param name="virtualNetworkRules">List of Virtual Network ACL rules
        /// configured for the Cosmos DB account.</param>
        /// <param name="privateEndpointConnections">List of Private Endpoint
        /// Connections configured for the Cosmos DB account.</param>
        /// <param name="enableMultipleWriteLocations">Enables the account to
        /// write in multiple locations</param>
        /// <param name="enableCassandraConnector">Enables the cassandra
        /// connector on the Cosmos DB C* account</param>
        /// <param name="connectorOffer">The cassandra connector offer type for
        /// the Cosmos DB database C* account. Possible values include:
        /// 'Small'</param>
        /// <param name="disableKeyBasedMetadataWriteAccess">Disable write
        /// operations on metadata resources (databases, containers,
        /// throughput) via account keys</param>
        /// <param name="keyVaultKeyUri">The URI of the key vault</param>
        /// <param name="publicNetworkAccess">Whether requests from Public
        /// Network are allowed. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="enableFreeTier">Flag to indicate whether Free Tier is
        /// enabled.</param>
        /// <param name="apiProperties">API specific properties.</param>
        /// <param name="enableAnalyticalStorage">Flag to indicate whether to
        /// enable storage analytics.</param>
        /// <param name="backupPolicy">The object representing the policy for
        /// taking backups on an account.</param>
        /// <param name="cors">The CORS policy for the Cosmos DB database
        /// account.</param>
        /// <param name="networkAclBypass">Indicates what services are allowed
        /// to bypass firewall checks. Possible values include: 'None',
        /// 'AzureServices'</param>
        /// <param name="networkAclBypassResourceIds">An array that contains
        /// the Resource Ids for Network Acl Bypass for the Cosmos DB
        /// account.</param>
        public DatabaseAccountGetResults(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string kind = default(string), ManagedServiceIdentity identity = default(ManagedServiceIdentity), string provisioningState = default(string), string documentEndpoint = default(string), DatabaseAccountOfferType? databaseAccountOfferType = default(DatabaseAccountOfferType?), IList<IpAddressOrRange> ipRules = default(IList<IpAddressOrRange>), bool? isVirtualNetworkFilterEnabled = default(bool?), bool? enableAutomaticFailover = default(bool?), ConsistencyPolicy consistencyPolicy = default(ConsistencyPolicy), IList<Capability> capabilities = default(IList<Capability>), IList<Location> writeLocations = default(IList<Location>), IList<Location> readLocations = default(IList<Location>), IList<Location> locations = default(IList<Location>), IList<FailoverPolicy> failoverPolicies = default(IList<FailoverPolicy>), IList<VirtualNetworkRule> virtualNetworkRules = default(IList<VirtualNetworkRule>), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), bool? enableMultipleWriteLocations = default(bool?), bool? enableCassandraConnector = default(bool?), string connectorOffer = default(string), bool? disableKeyBasedMetadataWriteAccess = default(bool?), string keyVaultKeyUri = default(string), string publicNetworkAccess = default(string), bool? enableFreeTier = default(bool?), ApiProperties apiProperties = default(ApiProperties), bool? enableAnalyticalStorage = default(bool?), BackupPolicy backupPolicy = default(BackupPolicy), IList<CorsPolicy> cors = default(IList<CorsPolicy>), string networkAclBypass = default(string), IList<string> networkAclBypassResourceIds = default(IList<string>))
            : base(id, name, type, location, tags)
        {
            Kind = kind;
            Identity = identity;
            ProvisioningState = provisioningState;
            DocumentEndpoint = documentEndpoint;
            DatabaseAccountOfferType = databaseAccountOfferType;
            IpRules = ipRules;
            IsVirtualNetworkFilterEnabled = isVirtualNetworkFilterEnabled;
            EnableAutomaticFailover = enableAutomaticFailover;
            ConsistencyPolicy = consistencyPolicy;
            Capabilities = capabilities;
            WriteLocations = writeLocations;
            ReadLocations = readLocations;
            Locations = locations;
            FailoverPolicies = failoverPolicies;
            VirtualNetworkRules = virtualNetworkRules;
            PrivateEndpointConnections = privateEndpointConnections;
            EnableMultipleWriteLocations = enableMultipleWriteLocations;
            EnableCassandraConnector = enableCassandraConnector;
            ConnectorOffer = connectorOffer;
            DisableKeyBasedMetadataWriteAccess = disableKeyBasedMetadataWriteAccess;
            KeyVaultKeyUri = keyVaultKeyUri;
            PublicNetworkAccess = publicNetworkAccess;
            EnableFreeTier = enableFreeTier;
            ApiProperties = apiProperties;
            EnableAnalyticalStorage = enableAnalyticalStorage;
            BackupPolicy = backupPolicy;
            Cors = cors;
            NetworkAclBypass = networkAclBypass;
            NetworkAclBypassResourceIds = networkAclBypassResourceIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates the type of database account. This can only
        /// be set at database account creation. Possible values include:
        /// 'GlobalDocumentDB', 'MongoDB', 'Parse'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ManagedServiceIdentity Identity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets the connection endpoint for the Cosmos DB database account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.documentEndpoint")]
        public string DocumentEndpoint { get; private set; }

        /// <summary>
        /// Gets the offer type for the Cosmos DB database account. Default
        /// value: Standard. Possible values include: 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseAccountOfferType")]
        public DatabaseAccountOfferType? DatabaseAccountOfferType { get; private set; }

        /// <summary>
        /// Gets or sets list of IpRules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipRules")]
        public IList<IpAddressOrRange> IpRules { get; set; }

        /// <summary>
        /// Gets or sets flag to indicate whether to enable/disable Virtual
        /// Network ACL rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isVirtualNetworkFilterEnabled")]
        public bool? IsVirtualNetworkFilterEnabled { get; set; }

        /// <summary>
        /// Gets or sets enables automatic failover of the write region in the
        /// rare event that the region is unavailable due to an outage.
        /// Automatic failover will result in a new write region for the
        /// account and is chosen based on the failover priorities configured
        /// for the account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableAutomaticFailover")]
        public bool? EnableAutomaticFailover { get; set; }

        /// <summary>
        /// Gets or sets the consistency policy for the Cosmos DB database
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consistencyPolicy")]
        public ConsistencyPolicy ConsistencyPolicy { get; set; }

        /// <summary>
        /// Gets or sets list of Cosmos DB capabilities for the account
        /// </summary>
        [JsonProperty(PropertyName = "properties.capabilities")]
        public IList<Capability> Capabilities { get; set; }

        /// <summary>
        /// Gets an array that contains the write location for the Cosmos DB
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.writeLocations")]
        public IList<Location> WriteLocations { get; private set; }

        /// <summary>
        /// Gets an array that contains of the read locations enabled for the
        /// Cosmos DB account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.readLocations")]
        public IList<Location> ReadLocations { get; private set; }

        /// <summary>
        /// Gets an array that contains all of the locations enabled for the
        /// Cosmos DB account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.locations")]
        public IList<Location> Locations { get; private set; }

        /// <summary>
        /// Gets an array that contains the regions ordered by their failover
        /// priorities.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failoverPolicies")]
        public IList<FailoverPolicy> FailoverPolicies { get; private set; }

        /// <summary>
        /// Gets or sets list of Virtual Network ACL rules configured for the
        /// Cosmos DB account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkRules")]
        public IList<VirtualNetworkRule> VirtualNetworkRules { get; set; }

        /// <summary>
        /// Gets list of Private Endpoint Connections configured for the Cosmos
        /// DB account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets or sets enables the account to write in multiple locations
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableMultipleWriteLocations")]
        public bool? EnableMultipleWriteLocations { get; set; }

        /// <summary>
        /// Gets or sets enables the cassandra connector on the Cosmos DB C*
        /// account
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableCassandraConnector")]
        public bool? EnableCassandraConnector { get; set; }

        /// <summary>
        /// Gets or sets the cassandra connector offer type for the Cosmos DB
        /// database C* account. Possible values include: 'Small'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectorOffer")]
        public string ConnectorOffer { get; set; }

        /// <summary>
        /// Gets or sets disable write operations on metadata resources
        /// (databases, containers, throughput) via account keys
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableKeyBasedMetadataWriteAccess")]
        public bool? DisableKeyBasedMetadataWriteAccess { get; set; }

        /// <summary>
        /// Gets or sets the URI of the key vault
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultKeyUri")]
        public string KeyVaultKeyUri { get; set; }

        /// <summary>
        /// Gets or sets whether requests from Public Network are allowed.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets flag to indicate whether Free Tier is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableFreeTier")]
        public bool? EnableFreeTier { get; set; }

        /// <summary>
        /// Gets or sets API specific properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiProperties")]
        public ApiProperties ApiProperties { get; set; }

        /// <summary>
        /// Gets or sets flag to indicate whether to enable storage analytics.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableAnalyticalStorage")]
        public bool? EnableAnalyticalStorage { get; set; }

        /// <summary>
        /// Gets or sets the object representing the policy for taking backups
        /// on an account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupPolicy")]
        public BackupPolicy BackupPolicy { get; set; }

        /// <summary>
        /// Gets or sets the CORS policy for the Cosmos DB database account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cors")]
        public IList<CorsPolicy> Cors { get; set; }

        /// <summary>
        /// Gets or sets indicates what services are allowed to bypass firewall
        /// checks. Possible values include: 'None', 'AzureServices'
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAclBypass")]
        public string NetworkAclBypass { get; set; }

        /// <summary>
        /// Gets or sets an array that contains the Resource Ids for Network
        /// Acl Bypass for the Cosmos DB account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAclBypassResourceIds")]
        public IList<string> NetworkAclBypassResourceIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConsistencyPolicy != null)
            {
                ConsistencyPolicy.Validate();
            }
            if (WriteLocations != null)
            {
                foreach (var element in WriteLocations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ReadLocations != null)
            {
                foreach (var element1 in ReadLocations)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Locations != null)
            {
                foreach (var element2 in Locations)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (FailoverPolicies != null)
            {
                foreach (var element3 in FailoverPolicies)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (Cors != null)
            {
                foreach (var element4 in Cors)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
        }
    }
}
