// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SignalR;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmSignalRModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="SignalRNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Indicates whether the name is available or not. </param>
        /// <param name="reason"> The reason of the availability. Required if name is not available. </param>
        /// <param name="message"> The message of the operation. </param>
        /// <returns> A new <see cref="Models.SignalRNameAvailabilityResult"/> instance for mocking. </returns>
        public static SignalRNameAvailabilityResult SignalRNameAvailabilityResult(bool? isNameAvailable = null, string reason = null, string message = null)
        {
            return new SignalRNameAvailabilityResult(isNameAvailable, reason, message, default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRUsage"/>. </summary>
        /// <param name="id"> Fully qualified ARM resource id. </param>
        /// <param name="currentValue"> Current value for the usage quota. </param>
        /// <param name="limit"> The maximum permitted value for the usage quota. If there is no limit, this value will be -1. </param>
        /// <param name="name"> Localizable String object containing the name and a localized value. </param>
        /// <param name="unit"> Representing the units of the usage quota. Possible values are: Count, Bytes, Seconds, Percent, CountPerSecond, BytesPerSecond. </param>
        /// <returns> A new <see cref="Models.SignalRUsage"/> instance for mocking. </returns>
        public static SignalRUsage SignalRUsage(ResourceIdentifier id = null, long? currentValue = null, long? limit = null, SignalRUsageName name = null, string unit = null)
        {
            return new SignalRUsage(id, currentValue, limit, name, unit, default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRUsageName"/>. </summary>
        /// <param name="value"> The identifier of the usage. </param>
        /// <param name="localizedValue"> Localized name of the usage. </param>
        /// <returns> A new <see cref="Models.SignalRUsageName"/> instance for mocking. </returns>
        public static SignalRUsageName SignalRUsageName(string value = null, string localizedValue = null)
        {
            return new SignalRUsageName(value, localizedValue, default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The billing information of the resource. </param>
        /// <param name="kind"> The kind of the service, it can be SignalR or RawWebSockets. </param>
        /// <param name="identity"> A class represent managed identities used for request and response. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="externalIP"> The publicly accessible IP of the resource. </param>
        /// <param name="hostName"> FQDN of the service instance. </param>
        /// <param name="publicPort"> The publicly accessible port of the resource which is designed for browser/client side usage. </param>
        /// <param name="serverPort"> The publicly accessible port of the resource which is designed for customer server side usage. </param>
        /// <param name="version"> Version of the resource. Probably you need the same or higher version of client SDKs. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections to the resource. </param>
        /// <param name="sharedPrivateLinkResources"> The list of shared private link resources. </param>
        /// <param name="isClientCertEnabled"> TLS settings for the resource. </param>
        /// <param name="hostNamePrefix"> Deprecated. </param>
        /// <param name="features">
        /// List of the featureFlags.
        ///
        /// FeatureFlags that are not included in the parameters for the update operation will not be modified.
        /// And the response will only include featureFlags that are explicitly set.
        /// When a featureFlag is not explicitly set, its globally default value will be used
        /// But keep in mind, the default value doesn't mean "false". It varies in terms of different FeatureFlags.
        /// </param>
        /// <param name="liveTraceConfiguration"> Live trace configuration of a Microsoft.SignalRService resource. </param>
        /// <param name="resourceLogCategories"> Resource log configuration of a Microsoft.SignalRService resource. </param>
        /// <param name="corsAllowedOrigins"> Cross-Origin Resource Sharing (CORS) settings. </param>
        /// <param name="upstreamTemplates"> The settings for the Upstream when the service is in server-less mode. </param>
        /// <param name="networkACLs"> Network ACLs for the resource. </param>
        /// <param name="publicNetworkAccess">
        /// Enable or disable public network access. Default to "Enabled".
        /// When it's Enabled, network ACLs still apply.
        /// When it's Disabled, public network access is always disabled no matter what you set in network ACLs.
        /// </param>
        /// <param name="disableLocalAuth">
        /// DisableLocalAuth
        /// Enable or disable local auth with AccessKey
        /// When set as true, connection with AccessKey=xxx won't work.
        /// </param>
        /// <param name="disableAadAuth">
        /// DisableLocalAuth
        /// Enable or disable aad auth
        /// When set as true, connection with AuthType=aad won't work.
        /// </param>
        /// <returns> A new <see cref="SignalR.SignalRData"/> instance for mocking. </returns>
        public static SignalRData SignalRData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, SignalRResourceSku sku = null, SignalRServiceKind? kind = null, ManagedServiceIdentity identity = null, SignalRProvisioningState? provisioningState = null, string externalIP = null, string hostName = null, int? publicPort = null, int? serverPort = null, string version = null, IEnumerable<SignalRPrivateEndpointConnectionData> privateEndpointConnections = null, IEnumerable<SignalRSharedPrivateLinkResourceData> sharedPrivateLinkResources = null, bool? isClientCertEnabled = null, string hostNamePrefix = null, IEnumerable<SignalRFeature> features = null, SignalRLiveTraceConfiguration liveTraceConfiguration = null, IEnumerable<SignalRResourceLogCategory> resourceLogCategories = null, IEnumerable<string> corsAllowedOrigins = null, IEnumerable<SignalRUpstreamTemplate> upstreamTemplates = null, SignalRNetworkAcls networkACLs = null, string publicNetworkAccess = null, bool? disableLocalAuth = null, bool? disableAadAuth = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<SignalRPrivateEndpointConnectionData>();
            sharedPrivateLinkResources ??= new List<SignalRSharedPrivateLinkResourceData>();
            features ??= new List<SignalRFeature>();
            resourceLogCategories ??= new List<SignalRResourceLogCategory>();
            corsAllowedOrigins ??= new List<string>();
            upstreamTemplates ??= new List<SignalRUpstreamTemplate>();

            return new SignalRData(id, name, resourceType, systemData, tags, location, sku, kind, identity, provisioningState, externalIP, hostName, publicPort, serverPort, version, privateEndpointConnections?.ToList(), sharedPrivateLinkResources?.ToList(), isClientCertEnabled != null ? new SignalRTlsSettings(isClientCertEnabled, new Dictionary<string, BinaryData>()) : null, hostNamePrefix, features?.ToList(), liveTraceConfiguration, resourceLogCategories != null ? new SignalRResourceLogCategoryListResult(resourceLogCategories?.ToList(), new Dictionary<string, BinaryData>()) : null, corsAllowedOrigins != null ? new SignalRCorsSettings(corsAllowedOrigins?.ToList(), new Dictionary<string, BinaryData>()) : null, upstreamTemplates != null ? new ServerlessUpstreamSettings(upstreamTemplates?.ToList(), new Dictionary<string, BinaryData>()) : null, networkACLs, publicNetworkAccess, disableLocalAuth, disableAadAuth, default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRResourceSku"/>. </summary>
        /// <param name="name">
        /// The name of the SKU. Required.
        ///
        /// Allowed values: Standard_S1, Free_F1
        /// </param>
        /// <param name="tier">
        /// Optional tier of this particular SKU. 'Standard' or 'Free'.
        ///
        /// `Basic` is deprecated, use `Standard` instead.
        /// </param>
        /// <param name="size"> Not used. Retained for future use. </param>
        /// <param name="family"> Not used. Retained for future use. </param>
        /// <param name="capacity">
        /// Optional, integer. The unit count of the resource. 1 by default.
        ///
        /// If present, following values are allowed:
        ///     Free: 1
        ///     Standard: 1,2,5,10,20,50,100
        /// </param>
        /// <returns> A new <see cref="Models.SignalRResourceSku"/> instance for mocking. </returns>
        public static SignalRResourceSku SignalRResourceSku(string name = null, SignalRSkuTier? tier = null, string size = null, string family = null, int? capacity = null)
        {
            return new SignalRResourceSku(name, tier, size, family, capacity, default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="privateEndpointId"> Private endpoint. </param>
        /// <param name="groupIds"> Group IDs. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <returns> A new <see cref="SignalR.SignalRPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static SignalRPrivateEndpointConnectionData SignalRPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, SignalRProvisioningState? provisioningState = null, ResourceIdentifier privateEndpointId = null, IEnumerable<string> groupIds = null, SignalRPrivateLinkServiceConnectionState connectionState = null)
        {
            groupIds ??= new List<string>();

            return new SignalRPrivateEndpointConnectionData(id, name, resourceType, systemData, provisioningState, privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null, groupIds?.ToList(), connectionState, default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRSharedPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The group id from the provider of resource the shared private link resource is for. </param>
        /// <param name="privateLinkResourceId"> The resource id of the resource the shared private link resource is for. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="requestMessage"> The request message for requesting approval of the shared private link resource. </param>
        /// <param name="status"> Status of the shared private link resource. </param>
        /// <returns> A new <see cref="SignalR.SignalRSharedPrivateLinkResourceData"/> instance for mocking. </returns>
        public static SignalRSharedPrivateLinkResourceData SignalRSharedPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, ResourceIdentifier privateLinkResourceId = null, SignalRProvisioningState? provisioningState = null, string requestMessage = null, SignalRSharedPrivateLinkResourceStatus? status = null)
        {
            return new SignalRSharedPrivateLinkResourceData(id, name, resourceType, systemData, groupId, privateLinkResourceId, provisioningState, requestMessage, status, default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRCustomCertificateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="keyVaultBaseUri"> Base uri of the KeyVault that stores certificate. </param>
        /// <param name="keyVaultSecretName"> Certificate secret name. </param>
        /// <param name="keyVaultSecretVersion"> Certificate secret version. </param>
        /// <returns> A new <see cref="SignalR.SignalRCustomCertificateData"/> instance for mocking. </returns>
        public static SignalRCustomCertificateData SignalRCustomCertificateData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, SignalRProvisioningState? provisioningState = null, Uri keyVaultBaseUri = null, string keyVaultSecretName = null, string keyVaultSecretVersion = null)
        {
            return new SignalRCustomCertificateData(id, name, resourceType, systemData, provisioningState, keyVaultBaseUri, keyVaultSecretName, keyVaultSecretVersion, default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRCustomDomainData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="customCertificateId"> Reference to a resource. </param>
        /// <returns> A new <see cref="SignalR.SignalRCustomDomainData"/> instance for mocking. </returns>
        public static SignalRCustomDomainData SignalRCustomDomainData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, SignalRProvisioningState? provisioningState = null, string domainName = null, ResourceIdentifier customCertificateId = null)
        {
            return new SignalRCustomDomainData(id, name, resourceType, systemData, provisioningState, domainName, customCertificateId != null ? ResourceManagerModelFactory.WritableSubResource(customCertificateId) : null, default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRKeys"/>. </summary>
        /// <param name="primaryKey"> The primary access key. </param>
        /// <param name="secondaryKey"> The secondary access key. </param>
        /// <param name="primaryConnectionString"> Connection string constructed via the primaryKey. </param>
        /// <param name="secondaryConnectionString"> Connection string constructed via the secondaryKey. </param>
        /// <returns> A new <see cref="Models.SignalRKeys"/> instance for mocking. </returns>
        public static SignalRKeys SignalRKeys(string primaryKey = null, string secondaryKey = null, string primaryConnectionString = null, string secondaryConnectionString = null)
        {
            return new SignalRKeys(primaryKey, secondaryKey, primaryConnectionString, secondaryConnectionString, default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRPrivateLinkResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> Group Id of the private link resource. </param>
        /// <param name="requiredMembers"> Required members of the private link resource. </param>
        /// <param name="requiredZoneNames"> Required private DNS zone names. </param>
        /// <param name="shareablePrivateLinkResourceTypes"> The list of resources that are onboarded to private link service. </param>
        /// <returns> A new <see cref="Models.SignalRPrivateLinkResource"/> instance for mocking. </returns>
        public static SignalRPrivateLinkResource SignalRPrivateLinkResource(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null, IEnumerable<ShareablePrivateLinkResourceType> shareablePrivateLinkResourceTypes = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();
            shareablePrivateLinkResourceTypes ??= new List<ShareablePrivateLinkResourceType>();

            return new SignalRPrivateLinkResource(id, name, resourceType, systemData, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), shareablePrivateLinkResourceTypes?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRSku"/>. </summary>
        /// <param name="resourceType"> The resource type that this object applies to. </param>
        /// <param name="sku"> The billing information of the resource. </param>
        /// <param name="capacity"> Describes scaling information of a sku. </param>
        /// <returns> A new <see cref="Models.SignalRSku"/> instance for mocking. </returns>
        public static SignalRSku SignalRSku(ResourceType? resourceType = null, SignalRResourceSku sku = null, SignalRSkuCapacity capacity = null)
        {
            return new SignalRSku(resourceType, sku, capacity, default);
        }

        /// <summary> Initializes a new instance of <see cref="SignalRSkuCapacity"/>. </summary>
        /// <param name="minimum"> The lowest permitted capacity for this resource. </param>
        /// <param name="maximum"> The highest permitted capacity for this resource. </param>
        /// <param name="default"> The default capacity. </param>
        /// <param name="allowedValues"> Allows capacity value list. </param>
        /// <param name="scaleType"> The scale type applicable to the sku. </param>
        /// <returns> A new <see cref="Models.SignalRSkuCapacity"/> instance for mocking. </returns>
        public static SignalRSkuCapacity SignalRSkuCapacity(int? minimum = null, int? maximum = null, int? @default = null, IEnumerable<int> allowedValues = null, SignalRScaleType? scaleType = null)
        {
            allowedValues ??= new List<int>();

            return new SignalRSkuCapacity(minimum, maximum, @default, allowedValues?.ToList(), scaleType, default);
        }
    }
}
