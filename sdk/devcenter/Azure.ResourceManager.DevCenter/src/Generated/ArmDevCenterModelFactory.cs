// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DevCenter;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmDevCenterModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="DevCenterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed identity properties. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="devCenterUri"> The URI of the Dev Center. </param>
        /// <returns> A new <see cref="DevCenter.DevCenterData"/> instance for mocking. </returns>
        public static DevCenterData DevCenterData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, DevCenterProvisioningState? provisioningState = null, Uri devCenterUri = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DevCenterData(id, name, resourceType, systemData, tags, location, identity, provisioningState, devCenterUri, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterProjectData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="devCenterId"> Resource Id of an associated DevCenter. </param>
        /// <param name="description"> Description of the project. </param>
        /// <param name="maxDevBoxesPerUser"> When specified, limits the maximum number of Dev Boxes a single user can create across all pools in the project. This will have no effect on existing Dev Boxes when reduced. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="devCenterUri"> The URI of the Dev Center resource this project is associated with. </param>
        /// <returns> A new <see cref="DevCenter.DevCenterProjectData"/> instance for mocking. </returns>
        public static DevCenterProjectData DevCenterProjectData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ResourceIdentifier devCenterId = null, string description = null, int? maxDevBoxesPerUser = null, DevCenterProvisioningState? provisioningState = null, Uri devCenterUri = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DevCenterProjectData(id, name, resourceType, systemData, tags, location, devCenterId, description, maxDevBoxesPerUser, provisioningState, devCenterUri, default);
        }

        /// <summary> Initializes a new instance of <see cref="AttachedNetworkConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="networkConnectionId"> The resource ID of the NetworkConnection you want to attach. </param>
        /// <param name="networkConnectionLocation"> The geo-location where the NetworkConnection resource specified in 'networkConnectionResourceId' property lives. </param>
        /// <param name="healthCheckStatus"> Health check status values. </param>
        /// <param name="domainJoinType"> AAD Join type of the network. This is populated based on the referenced Network Connection. </param>
        /// <returns> A new <see cref="DevCenter.AttachedNetworkConnectionData"/> instance for mocking. </returns>
        public static AttachedNetworkConnectionData AttachedNetworkConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DevCenterProvisioningState? provisioningState = null, ResourceIdentifier networkConnectionId = null, AzureLocation? networkConnectionLocation = null, DevCenterHealthCheckStatus? healthCheckStatus = null, DomainJoinType? domainJoinType = null)
        {
            return new AttachedNetworkConnectionData(id, name, resourceType, systemData, provisioningState, networkConnectionId, networkConnectionLocation, healthCheckStatus, domainJoinType, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterGalleryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="galleryResourceId"> The resource ID of the backing Azure Compute Gallery. </param>
        /// <returns> A new <see cref="DevCenter.DevCenterGalleryData"/> instance for mocking. </returns>
        public static DevCenterGalleryData DevCenterGalleryData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DevCenterProvisioningState? provisioningState = null, ResourceIdentifier galleryResourceId = null)
        {
            return new DevCenterGalleryData(id, name, resourceType, systemData, provisioningState, galleryResourceId, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterImageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> The description of the image. </param>
        /// <param name="publisher"> The publisher of the image. </param>
        /// <param name="offer"> The name of the image offer. </param>
        /// <param name="sku"> The SKU name for the image. </param>
        /// <param name="recommendedMachineConfiguration"> The recommended machine configuration to use with the image. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="hibernateSupport"> Indicates whether this image has hibernate enabled. Not all images are capable of supporting hibernation. To find out more see https://aka.ms/devbox/hibernate. </param>
        /// <returns> A new <see cref="DevCenter.DevCenterImageData"/> instance for mocking. </returns>
        public static DevCenterImageData DevCenterImageData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string description = null, string publisher = null, string offer = null, string sku = null, RecommendedMachineConfiguration recommendedMachineConfiguration = null, DevCenterProvisioningState? provisioningState = null, DevCenterHibernateSupport? hibernateSupport = null)
        {
            return new DevCenterImageData(id, name, resourceType, systemData, description, publisher, offer, sku, recommendedMachineConfiguration, provisioningState, hibernateSupport, default);
        }

        /// <summary> Initializes a new instance of <see cref="RecommendedMachineConfiguration"/>. </summary>
        /// <param name="memory"> Recommended memory range. </param>
        /// <param name="vCpus"> Recommended vCPU range. </param>
        /// <returns> A new <see cref="Models.RecommendedMachineConfiguration"/> instance for mocking. </returns>
        public static RecommendedMachineConfiguration RecommendedMachineConfiguration(DevCenterResourceRange memory = null, DevCenterResourceRange vCpus = null)
        {
            return new RecommendedMachineConfiguration(memory, vCpus, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterResourceRange"/>. </summary>
        /// <param name="min"> Minimum value. </param>
        /// <param name="max"> Maximum value. </param>
        /// <returns> A new <see cref="Models.DevCenterResourceRange"/> instance for mocking. </returns>
        public static DevCenterResourceRange DevCenterResourceRange(int? min = null, int? max = null)
        {
            return new DevCenterResourceRange(min, max, default);
        }

        /// <summary> Initializes a new instance of <see cref="ImageVersionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="namePropertiesName"> The semantic version string. </param>
        /// <param name="publishedOn"> The datetime that the backing image version was published. </param>
        /// <param name="isExcludedFromLatest"> If the version should be excluded from being treated as the latest version. </param>
        /// <param name="osDiskImageSizeInGB"> The size of the OS disk image, in GB. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="DevCenter.ImageVersionData"/> instance for mocking. </returns>
        public static ImageVersionData ImageVersionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string namePropertiesName = null, DateTimeOffset? publishedOn = null, bool? isExcludedFromLatest = null, int? osDiskImageSizeInGB = null, DevCenterProvisioningState? provisioningState = null)
        {
            return new ImageVersionData(id, name, resourceType, systemData, namePropertiesName, publishedOn, isExcludedFromLatest, osDiskImageSizeInGB, provisioningState, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterCatalogData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="gitHub"> Properties for a GitHub catalog type. </param>
        /// <param name="adoGit"> Properties for an Azure DevOps catalog type. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="syncState"> The synchronization state of the catalog. </param>
        /// <param name="lastSyncOn"> When the catalog was last synced. </param>
        /// <returns> A new <see cref="DevCenter.DevCenterCatalogData"/> instance for mocking. </returns>
        public static DevCenterCatalogData DevCenterCatalogData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DevCenterGitCatalog gitHub = null, DevCenterGitCatalog adoGit = null, DevCenterProvisioningState? provisioningState = null, DevCenterCatalogSyncState? syncState = null, DateTimeOffset? lastSyncOn = null)
        {
            return new DevCenterCatalogData(id, name, resourceType, systemData, gitHub, adoGit, provisioningState, syncState, lastSyncOn, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterEnvironmentTypeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="DevCenter.DevCenterEnvironmentTypeData"/> instance for mocking. </returns>
        public static DevCenterEnvironmentTypeData DevCenterEnvironmentTypeData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, DevCenterProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DevCenterEnvironmentTypeData(id, name, resourceType, systemData, tags, provisioningState, default);
        }

        /// <summary> Initializes a new instance of <see cref="AllowedEnvironmentTypeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="DevCenter.AllowedEnvironmentTypeData"/> instance for mocking. </returns>
        public static AllowedEnvironmentTypeData AllowedEnvironmentTypeData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DevCenterProvisioningState? provisioningState = null)
        {
            return new AllowedEnvironmentTypeData(id, name, resourceType, systemData, provisioningState, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterProjectEnvironmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed identity properties. </param>
        /// <param name="deploymentTargetId"> Id of a subscription that the environment type will be mapped to. The environment's resources will be deployed into this subscription. </param>
        /// <param name="status"> Defines whether this Environment Type can be used in this Project. </param>
        /// <param name="roles"> The role definition assigned to the environment creator on backing resources. </param>
        /// <param name="userRoleAssignments"> Role Assignments created on environment backing resources. This is a mapping from a user object ID to an object of role definition IDs. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="DevCenter.DevCenterProjectEnvironmentData"/> instance for mocking. </returns>
        public static DevCenterProjectEnvironmentData DevCenterProjectEnvironmentData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, ResourceIdentifier deploymentTargetId = null, EnvironmentTypeEnableStatus? status = null, IDictionary<string, DevCenterEnvironmentRole> roles = null, IDictionary<string, DevCenterUserRoleAssignments> userRoleAssignments = null, DevCenterProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();
            roles ??= new Dictionary<string, DevCenterEnvironmentRole>();
            userRoleAssignments ??= new Dictionary<string, DevCenterUserRoleAssignments>();

            return new DevCenterProjectEnvironmentData(id, name, resourceType, systemData, tags, location, identity, deploymentTargetId, status, roles != null ? new ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment(roles, new Dictionary<string, BinaryData>()) : null, userRoleAssignments, provisioningState, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterEnvironmentRole"/>. </summary>
        /// <param name="roleName"> The common name of the Role Assignment. This is a descriptive name such as 'AcrPush'. </param>
        /// <param name="description"> This is a description of the Role Assignment. </param>
        /// <returns> A new <see cref="Models.DevCenterEnvironmentRole"/> instance for mocking. </returns>
        public static DevCenterEnvironmentRole DevCenterEnvironmentRole(string roleName = null, string description = null)
        {
            return new DevCenterEnvironmentRole(roleName, description, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevBoxDefinitionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="imageReference"> Image reference information. </param>
        /// <param name="sku"> The SKU for Dev Boxes created using this definition. </param>
        /// <param name="osStorageType"> The storage type used for the Operating System disk of Dev Boxes created using this definition. </param>
        /// <param name="hibernateSupport"> Indicates whether Dev Boxes created with this definition are capable of hibernation. Not all images are capable of supporting hibernation. To find out more see https://aka.ms/devbox/hibernate. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="imageValidationStatus"> Validation status of the configured image. </param>
        /// <param name="imageValidationErrorDetails"> Details for image validator error. Populated when the image validation is not successful. </param>
        /// <param name="activeImageReference"> Image reference information for the currently active image (only populated during updates). </param>
        /// <returns> A new <see cref="DevCenter.DevBoxDefinitionData"/> instance for mocking. </returns>
        public static DevBoxDefinitionData DevBoxDefinitionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, DevCenterImageReference imageReference = null, DevCenterSku sku = null, string osStorageType = null, DevCenterHibernateSupport? hibernateSupport = null, DevCenterProvisioningState? provisioningState = null, ImageValidationStatus? imageValidationStatus = null, ImageValidationErrorDetails imageValidationErrorDetails = null, DevCenterImageReference activeImageReference = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DevBoxDefinitionData(id, name, resourceType, systemData, tags, location, imageReference, sku, osStorageType, hibernateSupport, provisioningState, imageValidationStatus, imageValidationErrorDetails, activeImageReference, default);
        }

        /// <summary> Initializes a new instance of <see cref="ImageValidationErrorDetails"/>. </summary>
        /// <param name="code"> An identifier for the error. </param>
        /// <param name="message"> A message describing the error. </param>
        /// <returns> A new <see cref="Models.ImageValidationErrorDetails"/> instance for mocking. </returns>
        public static ImageValidationErrorDetails ImageValidationErrorDetails(string code = null, string message = null)
        {
            return new ImageValidationErrorDetails(code, message, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterImageReference"/>. </summary>
        /// <param name="id"> Image ID, or Image version ID. When Image ID is provided, its latest version will be used. </param>
        /// <param name="exactVersion"> The actual version of the image after use. When id references a gallery image latest version, this will indicate the actual version in use. </param>
        /// <returns> A new <see cref="Models.DevCenterImageReference"/> instance for mocking. </returns>
        public static DevCenterImageReference DevCenterImageReference(ResourceIdentifier id = null, string exactVersion = null)
        {
            return new DevCenterImageReference(id, exactVersion, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterOperationStatus"/>. </summary>
        /// <param name="id"> Fully qualified ID for the async operation. </param>
        /// <param name="name"> Name of the async operation. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="endOn"> The end time of the operation. </param>
        /// <param name="operations"> The operations list. </param>
        /// <param name="error"> If present, details of the operation error. </param>
        /// <param name="resourceId"> The id of the resource. </param>
        /// <param name="properties"> Custom operation properties, populated only for a successful operation. </param>
        /// <returns> A new <see cref="Models.DevCenterOperationStatus"/> instance for mocking. </returns>
        public static DevCenterOperationStatus DevCenterOperationStatus(ResourceIdentifier id = null, string name = null, string status = null, float? percentComplete = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, IEnumerable<OperationStatusResult> operations = null, ResponseError error = null, ResourceIdentifier resourceId = null, BinaryData properties = null)
        {
            operations ??= new List<OperationStatusResult>();

            return new DevCenterOperationStatus(id, name, status, percentComplete, startOn, endOn, operations?.ToList(), error, resourceId, properties, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterUsage"/>. </summary>
        /// <param name="currentValue"> The current usage. </param>
        /// <param name="limit"> The limit integer. </param>
        /// <param name="unit"> The unit details. </param>
        /// <param name="name"> The name. </param>
        /// <returns> A new <see cref="Models.DevCenterUsage"/> instance for mocking. </returns>
        public static DevCenterUsage DevCenterUsage(long? currentValue = null, long? limit = null, DevCenterUsageUnit? unit = null, DevCenterUsageName name = null)
        {
            return new DevCenterUsage(currentValue, limit, unit, name, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterUsageName"/>. </summary>
        /// <param name="localizedValue"> The localized name of the resource. </param>
        /// <param name="value"> The name of the resource. </param>
        /// <returns> A new <see cref="Models.DevCenterUsageName"/> instance for mocking. </returns>
        public static DevCenterUsageName DevCenterUsageName(string localizedValue = null, string value = null)
        {
            return new DevCenterUsageName(localizedValue, value, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Indicates if the resource name is available. </param>
        /// <param name="reason"> The reason why the given name is not available. </param>
        /// <param name="message"> Detailed reason why the given name is available. </param>
        /// <returns> A new <see cref="Models.DevCenterNameAvailabilityResult"/> instance for mocking. </returns>
        public static DevCenterNameAvailabilityResult DevCenterNameAvailabilityResult(bool? isNameAvailable = null, DevCenterNameUnavailableReason? reason = null, string message = null)
        {
            return new DevCenterNameAvailabilityResult(isNameAvailable, reason, message, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterSkuDetails"/>. </summary>
        /// <param name="name"> The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <param name="tier"> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </param>
        /// <param name="size"> The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. </param>
        /// <param name="family"> If the service has different generations of hardware, for the same SKU, then that can be captured here. </param>
        /// <param name="capacity"> If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted. </param>
        /// <param name="resourceType"> The name of the resource type. </param>
        /// <param name="locations"> SKU supported locations. </param>
        /// <param name="capabilities"> Collection of name/value pairs to describe the SKU capabilities. </param>
        /// <returns> A new <see cref="Models.DevCenterSkuDetails"/> instance for mocking. </returns>
        public static DevCenterSkuDetails DevCenterSkuDetails(string name = null, DevCenterSkuTier? tier = null, string size = null, string family = null, int? capacity = null, ResourceType? resourceType = null, IEnumerable<string> locations = null, IEnumerable<DevCenterCapability> capabilities = null)
        {
            locations ??= new List<string>();
            capabilities ??= new List<DevCenterCapability>();

            return new DevCenterSkuDetails(name, tier, size, family, capacity, resourceType, locations?.ToList(), capabilities?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterCapability"/>. </summary>
        /// <param name="name"> Name of the capability. </param>
        /// <param name="value"> Value of the capability. </param>
        /// <returns> A new <see cref="Models.DevCenterCapability"/> instance for mocking. </returns>
        public static DevCenterCapability DevCenterCapability(string name = null, string value = null)
        {
            return new DevCenterCapability(name, value, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterPoolData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="devBoxDefinitionName"> Name of a Dev Box definition in parent Project of this Pool. </param>
        /// <param name="networkConnectionName"> Name of a Network Connection in parent Project of this Pool. </param>
        /// <param name="licenseType"> Specifies the license type indicating the caller has already acquired licenses for the Dev Boxes that will be created. </param>
        /// <param name="localAdministrator"> Indicates whether owners of Dev Boxes in this pool are added as local administrators on the Dev Box. </param>
        /// <param name="stopOnDisconnect"> Stop on disconnect configuration settings for Dev Boxes created in this pool. </param>
        /// <param name="healthStatus"> Overall health status of the Pool. Indicates whether or not the Pool is available to create Dev Boxes. </param>
        /// <param name="healthStatusDetails"> Details on the Pool health status to help diagnose issues. This is only populated when the pool status indicates the pool is in a non-healthy state. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="DevCenter.DevCenterPoolData"/> instance for mocking. </returns>
        public static DevCenterPoolData DevCenterPoolData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string devBoxDefinitionName = null, string networkConnectionName = null, DevCenterLicenseType? licenseType = null, LocalAdminStatus? localAdministrator = null, StopOnDisconnectConfiguration stopOnDisconnect = null, DevCenterHealthStatus? healthStatus = null, IEnumerable<DevCenterHealthStatusDetail> healthStatusDetails = null, DevCenterProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();
            healthStatusDetails ??= new List<DevCenterHealthStatusDetail>();

            return new DevCenterPoolData(id, name, resourceType, systemData, tags, location, devBoxDefinitionName, networkConnectionName, licenseType, localAdministrator, stopOnDisconnect, healthStatus, healthStatusDetails?.ToList(), provisioningState, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterHealthStatusDetail"/>. </summary>
        /// <param name="code"> An identifier for the issue. </param>
        /// <param name="message"> A message describing the issue, intended to be suitable for display in a user interface. </param>
        /// <returns> A new <see cref="Models.DevCenterHealthStatusDetail"/> instance for mocking. </returns>
        public static DevCenterHealthStatusDetail DevCenterHealthStatusDetail(string code = null, string message = null)
        {
            return new DevCenterHealthStatusDetail(code, message, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterScheduleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scheduledType"> Supported type this scheduled task represents. </param>
        /// <param name="frequency"> The frequency of this scheduled task. </param>
        /// <param name="time"> The target time to trigger the action. The format is HH:MM. </param>
        /// <param name="timeZone"> The IANA timezone id at which the schedule should execute. </param>
        /// <param name="state"> Indicates whether or not this scheduled task is enabled. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="DevCenter.DevCenterScheduleData"/> instance for mocking. </returns>
        public static DevCenterScheduleData DevCenterScheduleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DevCenterScheduledType? scheduledType = null, DevCenterScheduledFrequency? frequency = null, string time = null, string timeZone = null, DevCenterScheduleEnableStatus? state = null, DevCenterProvisioningState? provisioningState = null)
        {
            return new DevCenterScheduleData(id, name, resourceType, systemData, scheduledType, frequency, time, timeZone, state, provisioningState, default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterNetworkConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="subnetId"> The subnet to attach Virtual Machines to. </param>
        /// <param name="domainName"> Active Directory domain name. </param>
        /// <param name="organizationUnit"> Active Directory domain Organization Unit (OU). </param>
        /// <param name="domainUsername"> The username of an Active Directory account (user or service account) that has permissions to create computer objects in Active Directory. Required format: admin@contoso.com. </param>
        /// <param name="domainPassword"> The password for the account used to join domain. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="healthCheckStatus"> Overall health status of the network connection. Health checks are run on creation, update, and periodically to validate the network connection. </param>
        /// <param name="networkingResourceGroupName"> The name for resource group where NICs will be placed. </param>
        /// <param name="domainJoinType"> AAD Join type. </param>
        /// <returns> A new <see cref="DevCenter.DevCenterNetworkConnectionData"/> instance for mocking. </returns>
        public static DevCenterNetworkConnectionData DevCenterNetworkConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ResourceIdentifier subnetId = null, string domainName = null, string organizationUnit = null, string domainUsername = null, string domainPassword = null, DevCenterProvisioningState? provisioningState = null, DevCenterHealthCheckStatus? healthCheckStatus = null, string networkingResourceGroupName = null, DomainJoinType? domainJoinType = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DevCenterNetworkConnectionData(id, name, resourceType, systemData, tags, location, subnetId, domainName, organizationUnit, domainUsername, domainPassword, provisioningState, healthCheckStatus, networkingResourceGroupName, domainJoinType, default);
        }

        /// <summary> Initializes a new instance of <see cref="HealthCheckStatusDetailData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startOn"> Start time of last execution of the health checks. </param>
        /// <param name="endOn"> End time of last execution of the health checks. </param>
        /// <param name="healthChecks"> Details for each health check item. </param>
        /// <returns> A new <see cref="DevCenter.HealthCheckStatusDetailData"/> instance for mocking. </returns>
        public static HealthCheckStatusDetailData HealthCheckStatusDetailData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, IEnumerable<DevCenterHealthCheck> healthChecks = null)
        {
            healthChecks ??= new List<DevCenterHealthCheck>();

            return new HealthCheckStatusDetailData(id, name, resourceType, systemData, startOn, endOn, healthChecks?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterHealthCheck"/>. </summary>
        /// <param name="status"> The status of the health check item. </param>
        /// <param name="displayName"> The display name of this health check item. </param>
        /// <param name="startOn"> Start time of health check item. </param>
        /// <param name="endOn"> End time of the health check item. </param>
        /// <param name="errorType"> The type of error that occurred during this health check. </param>
        /// <param name="recommendedAction"> The recommended action to fix the corresponding error. </param>
        /// <param name="additionalDetails"> Additional details about the health check or the recommended action. </param>
        /// <returns> A new <see cref="Models.DevCenterHealthCheck"/> instance for mocking. </returns>
        public static DevCenterHealthCheck DevCenterHealthCheck(DevCenterHealthCheckStatus? status = null, string displayName = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, string errorType = null, string recommendedAction = null, string additionalDetails = null)
        {
            return new DevCenterHealthCheck(status, displayName, startOn, endOn, errorType, recommendedAction, additionalDetails, default);
        }

        /// <summary> Initializes a new instance of <see cref="OutboundEnvironmentEndpoint"/>. </summary>
        /// <param name="category"> The type of service that the agent connects to. </param>
        /// <param name="endpoints"> The endpoints for this service for which the agent requires outbound access. </param>
        /// <returns> A new <see cref="Models.OutboundEnvironmentEndpoint"/> instance for mocking. </returns>
        public static OutboundEnvironmentEndpoint OutboundEnvironmentEndpoint(string category = null, IEnumerable<EndpointDependency> endpoints = null)
        {
            endpoints ??= new List<EndpointDependency>();

            return new OutboundEnvironmentEndpoint(category, endpoints?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="EndpointDependency"/>. </summary>
        /// <param name="domainName"> The domain name of the dependency. Domain names may be fully qualified or may contain a * wildcard. </param>
        /// <param name="description"> Human-readable supplemental information about the dependency and when it is applicable. </param>
        /// <param name="endpointDetails"> The list of connection details for this endpoint. </param>
        /// <returns> A new <see cref="Models.EndpointDependency"/> instance for mocking. </returns>
        public static EndpointDependency EndpointDependency(string domainName = null, string description = null, IEnumerable<DevCenterEndpointDetail> endpointDetails = null)
        {
            endpointDetails ??= new List<DevCenterEndpointDetail>();

            return new EndpointDependency(domainName, description, endpointDetails?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterEndpointDetail"/>. </summary>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <returns> A new <see cref="Models.DevCenterEndpointDetail"/> instance for mocking. </returns>
        public static DevCenterEndpointDetail DevCenterEndpointDetail(int? port = null)
        {
            return new DevCenterEndpointDetail(port, default);
        }
    }
}
