// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DataProtectionBackup.Mocking;
using Azure.ResourceManager.DataProtectionBackup.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DataProtectionBackup. </summary>
    public static partial class DataProtectionBackupExtensions
    {
        private static MockableDataProtectionBackupArmClient GetMockableDataProtectionBackupArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableDataProtectionBackupArmClient(client0));
        }

        private static MockableDataProtectionBackupResourceGroupResource GetMockableDataProtectionBackupResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDataProtectionBackupResourceGroupResource(client, resource.Id));
        }

        private static MockableDataProtectionBackupSubscriptionResource GetMockableDataProtectionBackupSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDataProtectionBackupSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataProtectionBackupVaultResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataProtectionBackupVaultResource.CreateResourceIdentifier" /> to create a <see cref="DataProtectionBackupVaultResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupArmClient.GetDataProtectionBackupVaultResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataProtectionBackupVaultResource" /> object. </returns>
        public static DataProtectionBackupVaultResource GetDataProtectionBackupVaultResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataProtectionBackupArmClient(client).GetDataProtectionBackupVaultResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataProtectionBackupPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataProtectionBackupPolicyResource.CreateResourceIdentifier" /> to create a <see cref="DataProtectionBackupPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupArmClient.GetDataProtectionBackupPolicyResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataProtectionBackupPolicyResource" /> object. </returns>
        public static DataProtectionBackupPolicyResource GetDataProtectionBackupPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataProtectionBackupArmClient(client).GetDataProtectionBackupPolicyResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataProtectionBackupInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataProtectionBackupInstanceResource.CreateResourceIdentifier" /> to create a <see cref="DataProtectionBackupInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupArmClient.GetDataProtectionBackupInstanceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataProtectionBackupInstanceResource" /> object. </returns>
        public static DataProtectionBackupInstanceResource GetDataProtectionBackupInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataProtectionBackupArmClient(client).GetDataProtectionBackupInstanceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataProtectionBackupRecoveryPointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataProtectionBackupRecoveryPointResource.CreateResourceIdentifier" /> to create a <see cref="DataProtectionBackupRecoveryPointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupArmClient.GetDataProtectionBackupRecoveryPointResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataProtectionBackupRecoveryPointResource" /> object. </returns>
        public static DataProtectionBackupRecoveryPointResource GetDataProtectionBackupRecoveryPointResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataProtectionBackupArmClient(client).GetDataProtectionBackupRecoveryPointResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataProtectionBackupJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataProtectionBackupJobResource.CreateResourceIdentifier" /> to create a <see cref="DataProtectionBackupJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupArmClient.GetDataProtectionBackupJobResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataProtectionBackupJobResource" /> object. </returns>
        public static DataProtectionBackupJobResource GetDataProtectionBackupJobResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataProtectionBackupArmClient(client).GetDataProtectionBackupJobResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeletedDataProtectionBackupInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeletedDataProtectionBackupInstanceResource.CreateResourceIdentifier" /> to create a <see cref="DeletedDataProtectionBackupInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupArmClient.GetDeletedDataProtectionBackupInstanceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedDataProtectionBackupInstanceResource" /> object. </returns>
        public static DeletedDataProtectionBackupInstanceResource GetDeletedDataProtectionBackupInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataProtectionBackupArmClient(client).GetDeletedDataProtectionBackupInstanceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ResourceGuardResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceGuardResource.CreateResourceIdentifier" /> to create a <see cref="ResourceGuardResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupArmClient.GetResourceGuardResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceGuardResource" /> object. </returns>
        public static ResourceGuardResource GetResourceGuardResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataProtectionBackupArmClient(client).GetResourceGuardResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ResourceGuardProxyBaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceGuardProxyBaseResource.CreateResourceIdentifier" /> to create a <see cref="ResourceGuardProxyBaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupArmClient.GetResourceGuardProxyBaseResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceGuardProxyBaseResource" /> object. </returns>
        public static ResourceGuardProxyBaseResource GetResourceGuardProxyBaseResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableDataProtectionBackupArmClient(client).GetResourceGuardProxyBaseResource(id);
        }

        /// <summary>
        /// Gets a collection of DataProtectionBackupVaultResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupResourceGroupResource.GetDataProtectionBackupVaults()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataProtectionBackupVaultResources and their operations over a DataProtectionBackupVaultResource. </returns>
        public static DataProtectionBackupVaultCollection GetDataProtectionBackupVaults(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableDataProtectionBackupResourceGroupResource(resourceGroupResource).GetDataProtectionBackupVaults();
        }

        /// <summary>
        /// Returns a resource belonging to a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupResourceGroupResource.GetDataProtectionBackupVaultAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DataProtectionBackupVaultResource>> GetDataProtectionBackupVaultAsync(this ResourceGroupResource resourceGroupResource, string vaultName, CancellationToken cancellationToken = default)
        {
            return await GetMockableDataProtectionBackupResourceGroupResource(resourceGroupResource).GetDataProtectionBackupVaultAsync(vaultName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a resource belonging to a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupResourceGroupResource.GetDataProtectionBackupVault(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DataProtectionBackupVaultResource> GetDataProtectionBackupVault(this ResourceGroupResource resourceGroupResource, string vaultName, CancellationToken cancellationToken = default)
        {
            return GetMockableDataProtectionBackupResourceGroupResource(resourceGroupResource).GetDataProtectionBackupVault(vaultName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of ResourceGuardResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupResourceGroupResource.GetResourceGuards()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ResourceGuardResources and their operations over a ResourceGuardResource. </returns>
        public static ResourceGuardCollection GetResourceGuards(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableDataProtectionBackupResourceGroupResource(resourceGroupResource).GetResourceGuards();
        }

        /// <summary>
        /// Returns a ResourceGuard belonging to a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuards_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupResourceGroupResource.GetResourceGuardAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceGuardsName"> The name of ResourceGuard. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardsName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardsName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ResourceGuardResource>> GetResourceGuardAsync(this ResourceGroupResource resourceGroupResource, string resourceGuardsName, CancellationToken cancellationToken = default)
        {
            return await GetMockableDataProtectionBackupResourceGroupResource(resourceGroupResource).GetResourceGuardAsync(resourceGuardsName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a ResourceGuard belonging to a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuards_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupResourceGroupResource.GetResourceGuard(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceGuardsName"> The name of ResourceGuard. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardsName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardsName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ResourceGuardResource> GetResourceGuard(this ResourceGroupResource resourceGroupResource, string resourceGuardsName, CancellationToken cancellationToken = default)
        {
            return GetMockableDataProtectionBackupResourceGroupResource(resourceGroupResource).GetResourceGuard(resourceGuardsName, cancellationToken);
        }

        /// <summary>
        /// API to check for resource name availability
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupResourceGroupResource.CheckDataProtectionBackupVaultNameAvailability(AzureLocation,DataProtectionBackupNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="content"> Check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<DataProtectionBackupNameAvailabilityResult>> CheckDataProtectionBackupVaultNameAvailabilityAsync(this ResourceGroupResource resourceGroupResource, AzureLocation location, DataProtectionBackupNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetMockableDataProtectionBackupResourceGroupResource(resourceGroupResource).CheckDataProtectionBackupVaultNameAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// API to check for resource name availability
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupResourceGroupResource.CheckDataProtectionBackupVaultNameAvailability(AzureLocation,DataProtectionBackupNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="content"> Check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<DataProtectionBackupNameAvailabilityResult> CheckDataProtectionBackupVaultNameAvailability(this ResourceGroupResource resourceGroupResource, AzureLocation location, DataProtectionBackupNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetMockableDataProtectionBackupResourceGroupResource(resourceGroupResource).CheckDataProtectionBackupVaultNameAvailability(location, content, cancellationToken);
        }

        /// <summary>
        /// Returns resource collection belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/backupVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_GetInSubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupSubscriptionResource.GetDataProtectionBackupVaults(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataProtectionBackupVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataProtectionBackupVaultResource> GetDataProtectionBackupVaultsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableDataProtectionBackupSubscriptionResource(subscriptionResource).GetDataProtectionBackupVaultsAsync(cancellationToken);
        }

        /// <summary>
        /// Returns resource collection belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/backupVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_GetInSubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupSubscriptionResource.GetDataProtectionBackupVaults(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataProtectionBackupVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataProtectionBackupVaultResource> GetDataProtectionBackupVaults(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableDataProtectionBackupSubscriptionResource(subscriptionResource).GetDataProtectionBackupVaults(cancellationToken);
        }

        /// <summary>
        /// Validates if a feature is supported
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/locations/{location}/checkFeatureSupport</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProtection_CheckFeatureSupport</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupSubscriptionResource.CheckDataProtectionBackupFeatureSupport(AzureLocation,BackupFeatureValidationContentBase,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The AzureLocation to use. </param>
        /// <param name="content"> Feature support request object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<BackupFeatureValidationResultBase>> CheckDataProtectionBackupFeatureSupportAsync(this SubscriptionResource subscriptionResource, AzureLocation location, BackupFeatureValidationContentBase content, CancellationToken cancellationToken = default)
        {
            return await GetMockableDataProtectionBackupSubscriptionResource(subscriptionResource).CheckDataProtectionBackupFeatureSupportAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Validates if a feature is supported
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/locations/{location}/checkFeatureSupport</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataProtection_CheckFeatureSupport</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupSubscriptionResource.CheckDataProtectionBackupFeatureSupport(AzureLocation,BackupFeatureValidationContentBase,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The AzureLocation to use. </param>
        /// <param name="content"> Feature support request object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<BackupFeatureValidationResultBase> CheckDataProtectionBackupFeatureSupport(this SubscriptionResource subscriptionResource, AzureLocation location, BackupFeatureValidationContentBase content, CancellationToken cancellationToken = default)
        {
            return GetMockableDataProtectionBackupSubscriptionResource(subscriptionResource).CheckDataProtectionBackupFeatureSupport(location, content, cancellationToken);
        }

        /// <summary>
        /// Returns ResourceGuards collection belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/resourceGuards</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuards_GetResourcesInSubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupSubscriptionResource.GetResourceGuards(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGuardResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceGuardResource> GetResourceGuardsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableDataProtectionBackupSubscriptionResource(subscriptionResource).GetResourceGuardsAsync(cancellationToken);
        }

        /// <summary>
        /// Returns ResourceGuards collection belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataProtection/resourceGuards</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuards_GetResourcesInSubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataProtectionBackupSubscriptionResource.GetResourceGuards(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGuardResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceGuardResource> GetResourceGuards(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableDataProtectionBackupSubscriptionResource(subscriptionResource).GetResourceGuards(cancellationToken);
        }
    }
}
