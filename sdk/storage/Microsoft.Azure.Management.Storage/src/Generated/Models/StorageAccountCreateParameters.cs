// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters used when creating a storage account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageAccountCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountCreateParameters
        /// class.
        /// </summary>
        public StorageAccountCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountCreateParameters
        /// class.
        /// </summary>
        /// <param name="sku">Required. Gets or sets the SKU name.</param>
        /// <param name="kind">Required. Indicates the type of storage account.
        /// Possible values include: 'Storage', 'StorageV2', 'BlobStorage',
        /// 'FileStorage', 'BlockBlobStorage'</param>
        /// <param name="location">Required. Gets or sets the location of the
        /// resource. This will be one of the supported and registered Azure
        /// Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo
        /// region of a resource cannot be changed once it is created, but if
        /// an identical geo region is specified on update, the request will
        /// succeed.</param>
        /// <param name="extendedLocation">Optional. Set the extended location
        /// of the resource. If not set, the storage account will be created in
        /// Azure main region. Otherwise it will be created in the specified
        /// extended location</param>
        /// <param name="tags">Gets or sets a list of key value pairs that
        /// describe the resource. These tags can be used for viewing and
        /// grouping this resource (across resource groups). A maximum of 15
        /// tags can be provided for a resource. Each tag must have a key with
        /// a length no greater than 128 characters and a value with a length
        /// no greater than 256 characters.</param>
        /// <param name="identity">The identity of the resource.</param>
        /// <param name="publicNetworkAccess">Allow or disallow public network
        /// access to Storage Account. Value is optional but if passed in, must
        /// be 'Enabled' or 'Disabled'. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="sasPolicy">SasPolicy assigned to the storage
        /// account.</param>
        /// <param name="keyPolicy">KeyPolicy assigned to the storage
        /// account.</param>
        /// <param name="customDomain">User domain assigned to the storage
        /// account. Name is the CNAME source. Only one custom domain is
        /// supported per storage account at this time. To clear the existing
        /// custom domain, use an empty string for the custom domain name
        /// property.</param>
        /// <param name="encryption">Not applicable. Azure Storage encryption
        /// is enabled for all storage accounts and cannot be disabled.</param>
        /// <param name="networkRuleSet">Network rule set</param>
        /// <param name="accessTier">Required for storage accounts where kind =
        /// BlobStorage. The access tier used for billing. Possible values
        /// include: 'Hot', 'Cool'</param>
        /// <param name="azureFilesIdentityBasedAuthentication">Provides the
        /// identity based authentication settings for Azure Files.</param>
        /// <param name="enableHttpsTrafficOnly">Allows https traffic only to
        /// storage service if sets to true. The default value is true since
        /// API version 2019-04-01.</param>
        /// <param name="isHnsEnabled">Account HierarchicalNamespace enabled if
        /// sets to true.</param>
        /// <param name="largeFileSharesState">Allow large file shares if sets
        /// to Enabled. It cannot be disabled once it is enabled. Possible
        /// values include: 'Disabled', 'Enabled'</param>
        /// <param name="routingPreference">Maintains information about the
        /// network routing choice opted by the user for data transfer</param>
        /// <param name="allowBlobPublicAccess">Allow or disallow public access
        /// to all blobs or containers in the storage account. The default
        /// interpretation is true for this property.</param>
        /// <param name="minimumTlsVersion">Set the minimum TLS version to be
        /// permitted on requests to storage. The default interpretation is TLS
        /// 1.0 for this property. Possible values include: 'TLS1_0', 'TLS1_1',
        /// 'TLS1_2'</param>
        /// <param name="allowSharedKeyAccess">Indicates whether the storage
        /// account permits requests to be authorized with the account access
        /// key via Shared Key. If false, then all requests, including shared
        /// access signatures, must be authorized with Azure Active Directory
        /// (Azure AD). The default value is null, which is equivalent to
        /// true.</param>
        /// <param name="enableNfsV3">NFS 3.0 protocol support enabled if set
        /// to true.</param>
        /// <param name="allowCrossTenantReplication">Allow or disallow cross
        /// AAD tenant object replication. The default interpretation is true
        /// for this property.</param>
        /// <param name="defaultToOAuthAuthentication">A boolean flag which
        /// indicates whether the default authentication is OAuth or not. The
        /// default interpretation is false for this property.</param>
        /// <param name="immutableStorageWithVersioning">The property is
        /// immutable and can only be set to true at the account creation time.
        /// When set to true, it enables object level immutability for all the
        /// new containers in the account by default.</param>
        public StorageAccountCreateParameters(Sku sku, string kind, string location, ExtendedLocation extendedLocation = default(ExtendedLocation), IDictionary<string, string> tags = default(IDictionary<string, string>), Identity identity = default(Identity), string publicNetworkAccess = default(string), SasPolicy sasPolicy = default(SasPolicy), KeyPolicy keyPolicy = default(KeyPolicy), CustomDomain customDomain = default(CustomDomain), Encryption encryption = default(Encryption), NetworkRuleSet networkRuleSet = default(NetworkRuleSet), AccessTier? accessTier = default(AccessTier?), AzureFilesIdentityBasedAuthentication azureFilesIdentityBasedAuthentication = default(AzureFilesIdentityBasedAuthentication), bool? enableHttpsTrafficOnly = default(bool?), bool? isHnsEnabled = default(bool?), string largeFileSharesState = default(string), RoutingPreference routingPreference = default(RoutingPreference), bool? allowBlobPublicAccess = default(bool?), string minimumTlsVersion = default(string), bool? allowSharedKeyAccess = default(bool?), bool? enableNfsV3 = default(bool?), bool? allowCrossTenantReplication = default(bool?), bool? defaultToOAuthAuthentication = default(bool?), ImmutableStorageAccount immutableStorageWithVersioning = default(ImmutableStorageAccount))
        {
            Sku = sku;
            Kind = kind;
            Location = location;
            ExtendedLocation = extendedLocation;
            Tags = tags;
            Identity = identity;
            PublicNetworkAccess = publicNetworkAccess;
            SasPolicy = sasPolicy;
            KeyPolicy = keyPolicy;
            CustomDomain = customDomain;
            Encryption = encryption;
            NetworkRuleSet = networkRuleSet;
            AccessTier = accessTier;
            AzureFilesIdentityBasedAuthentication = azureFilesIdentityBasedAuthentication;
            EnableHttpsTrafficOnly = enableHttpsTrafficOnly;
            IsHnsEnabled = isHnsEnabled;
            LargeFileSharesState = largeFileSharesState;
            RoutingPreference = routingPreference;
            AllowBlobPublicAccess = allowBlobPublicAccess;
            MinimumTlsVersion = minimumTlsVersion;
            AllowSharedKeyAccess = allowSharedKeyAccess;
            EnableNfsV3 = enableNfsV3;
            AllowCrossTenantReplication = allowCrossTenantReplication;
            DefaultToOAuthAuthentication = defaultToOAuthAuthentication;
            ImmutableStorageWithVersioning = immutableStorageWithVersioning;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required. Gets or sets the SKU name.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets required. Indicates the type of storage account.
        /// Possible values include: 'Storage', 'StorageV2', 'BlobStorage',
        /// 'FileStorage', 'BlockBlobStorage'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets required. Gets or sets the location of the resource.
        /// This will be one of the supported and registered Azure Geo Regions
        /// (e.g. West US, East US, Southeast Asia, etc.). The geo region of a
        /// resource cannot be changed once it is created, but if an identical
        /// geo region is specified on update, the request will succeed.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets optional. Set the extended location of the resource.
        /// If not set, the storage account will be created in Azure main
        /// region. Otherwise it will be created in the specified extended
        /// location
        /// </summary>
        [JsonProperty(PropertyName = "extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used for viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided for
        /// a resource. Each tag must have a key with a length no greater than
        /// 128 characters and a value with a length no greater than 256
        /// characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the identity of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets allow or disallow public network access to Storage
        /// Account. Value is optional but if passed in, must be 'Enabled' or
        /// 'Disabled'. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets sasPolicy assigned to the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sasPolicy")]
        public SasPolicy SasPolicy { get; set; }

        /// <summary>
        /// Gets or sets keyPolicy assigned to the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyPolicy")]
        public KeyPolicy KeyPolicy { get; set; }

        /// <summary>
        /// Gets or sets user domain assigned to the storage account. Name is
        /// the CNAME source. Only one custom domain is supported per storage
        /// account at this time. To clear the existing custom domain, use an
        /// empty string for the custom domain name property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomain")]
        public CustomDomain CustomDomain { get; set; }

        /// <summary>
        /// Gets or sets not applicable. Azure Storage encryption is enabled
        /// for all storage accounts and cannot be disabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets network rule set
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAcls")]
        public NetworkRuleSet NetworkRuleSet { get; set; }

        /// <summary>
        /// Gets or sets required for storage accounts where kind =
        /// BlobStorage. The access tier used for billing. Possible values
        /// include: 'Hot', 'Cool'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessTier")]
        public AccessTier? AccessTier { get; set; }

        /// <summary>
        /// Gets or sets provides the identity based authentication settings
        /// for Azure Files.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureFilesIdentityBasedAuthentication")]
        public AzureFilesIdentityBasedAuthentication AzureFilesIdentityBasedAuthentication { get; set; }

        /// <summary>
        /// Gets or sets allows https traffic only to storage service if sets
        /// to true. The default value is true since API version 2019-04-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportsHttpsTrafficOnly")]
        public bool? EnableHttpsTrafficOnly { get; set; }

        /// <summary>
        /// Gets or sets account HierarchicalNamespace enabled if sets to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isHnsEnabled")]
        public bool? IsHnsEnabled { get; set; }

        /// <summary>
        /// Gets or sets allow large file shares if sets to Enabled. It cannot
        /// be disabled once it is enabled. Possible values include:
        /// 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.largeFileSharesState")]
        public string LargeFileSharesState { get; set; }

        /// <summary>
        /// Gets or sets maintains information about the network routing choice
        /// opted by the user for data transfer
        /// </summary>
        [JsonProperty(PropertyName = "properties.routingPreference")]
        public RoutingPreference RoutingPreference { get; set; }

        /// <summary>
        /// Gets or sets allow or disallow public access to all blobs or
        /// containers in the storage account. The default interpretation is
        /// true for this property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowBlobPublicAccess")]
        public bool? AllowBlobPublicAccess { get; set; }

        /// <summary>
        /// Gets or sets set the minimum TLS version to be permitted on
        /// requests to storage. The default interpretation is TLS 1.0 for this
        /// property. Possible values include: 'TLS1_0', 'TLS1_1', 'TLS1_2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.minimumTlsVersion")]
        public string MinimumTlsVersion { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the storage account permits requests
        /// to be authorized with the account access key via Shared Key. If
        /// false, then all requests, including shared access signatures, must
        /// be authorized with Azure Active Directory (Azure AD). The default
        /// value is null, which is equivalent to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowSharedKeyAccess")]
        public bool? AllowSharedKeyAccess { get; set; }

        /// <summary>
        /// Gets or sets NFS 3.0 protocol support enabled if set to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isNfsV3Enabled")]
        public bool? EnableNfsV3 { get; set; }

        /// <summary>
        /// Gets or sets allow or disallow cross AAD tenant object replication.
        /// The default interpretation is true for this property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowCrossTenantReplication")]
        public bool? AllowCrossTenantReplication { get; set; }

        /// <summary>
        /// Gets or sets a boolean flag which indicates whether the default
        /// authentication is OAuth or not. The default interpretation is false
        /// for this property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultToOAuthAuthentication")]
        public bool? DefaultToOAuthAuthentication { get; set; }

        /// <summary>
        /// Gets or sets the property is immutable and can only be set to true
        /// at the account creation time. When set to true, it enables object
        /// level immutability for all the new containers in the account by
        /// default.
        /// </summary>
        [JsonProperty(PropertyName = "properties.immutableStorageWithVersioning")]
        public ImmutableStorageAccount ImmutableStorageWithVersioning { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Kind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Kind");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (Identity != null)
            {
                Identity.Validate();
            }
            if (SasPolicy != null)
            {
                SasPolicy.Validate();
            }
            if (KeyPolicy != null)
            {
                KeyPolicy.Validate();
            }
            if (CustomDomain != null)
            {
                CustomDomain.Validate();
            }
            if (Encryption != null)
            {
                Encryption.Validate();
            }
            if (NetworkRuleSet != null)
            {
                NetworkRuleSet.Validate();
            }
            if (AzureFilesIdentityBasedAuthentication != null)
            {
                AzureFilesIdentityBasedAuthentication.Validate();
            }
            if (ImmutableStorageWithVersioning != null)
            {
                ImmutableStorageWithVersioning.Validate();
            }
        }
    }
}
