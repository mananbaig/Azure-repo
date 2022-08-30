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
using Azure.ResourceManager.NetApp.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetApp
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.NetApp. </summary>
    public static partial class NetAppExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Check if a resource name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkNameAvailability
        /// Operation Id: NetAppResource_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<NetAppCheckAvailabilityResult>> CheckNetAppNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, NetAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNetAppNameAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if a resource name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkNameAvailability
        /// Operation Id: NetAppResource_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<NetAppCheckAvailabilityResult> CheckNetAppNameAvailability(this SubscriptionResource subscriptionResource, AzureLocation location, NetAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNetAppNameAvailability(location, content, cancellationToken);
        }

        /// <summary>
        /// Check if a file path is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkFilePathAvailability
        /// Operation Id: NetAppResource_CheckFilePathAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> File path availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<NetAppCheckAvailabilityResult>> CheckNetAppFilePathAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, NetAppFilePathAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNetAppFilePathAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if a file path is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkFilePathAvailability
        /// Operation Id: NetAppResource_CheckFilePathAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> File path availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<NetAppCheckAvailabilityResult> CheckNetAppFilePathAvailability(this SubscriptionResource subscriptionResource, AzureLocation location, NetAppFilePathAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNetAppFilePathAvailability(location, content, cancellationToken);
        }

        /// <summary>
        /// Check if a quota is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkQuotaAvailability
        /// Operation Id: NetAppResource_CheckQuotaAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Quota availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<NetAppCheckAvailabilityResult>> CheckNetAppQuotaAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, NetAppQuotaAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNetAppQuotaAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if a quota is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkQuotaAvailability
        /// Operation Id: NetAppResource_CheckQuotaAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Quota availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<NetAppCheckAvailabilityResult> CheckNetAppQuotaAvailability(this SubscriptionResource subscriptionResource, AzureLocation location, NetAppQuotaAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNetAppQuotaAvailability(location, content, cancellationToken);
        }

        /// <summary>
        /// Get the default and current limits for quotas
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits
        /// Operation Id: NetAppResourceQuotaLimits_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppSubscriptionQuotaItem" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NetAppSubscriptionQuotaItem> GetNetAppQuotaLimitsAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetNetAppQuotaLimitsAsync(location, cancellationToken);
        }

        /// <summary>
        /// Get the default and current limits for quotas
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits
        /// Operation Id: NetAppResourceQuotaLimits_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppSubscriptionQuotaItem" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NetAppSubscriptionQuotaItem> GetNetAppQuotaLimits(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetNetAppQuotaLimits(location, cancellationToken);
        }

        /// <summary>
        /// Get the default and current subscription quota limit
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits/{quotaLimitName}
        /// Operation Id: NetAppResourceQuotaLimits_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="quotaLimitName"> The name of the Quota Limit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaLimitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaLimitName"/> is null. </exception>
        public static async Task<Response<NetAppSubscriptionQuotaItem>> GetNetAppQuotaLimitAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string quotaLimitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(quotaLimitName, nameof(quotaLimitName));

            return await GetExtensionClient(subscriptionResource).GetNetAppQuotaLimitAsync(location, quotaLimitName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the default and current subscription quota limit
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits/{quotaLimitName}
        /// Operation Id: NetAppResourceQuotaLimits_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="quotaLimitName"> The name of the Quota Limit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaLimitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaLimitName"/> is null. </exception>
        public static Response<NetAppSubscriptionQuotaItem> GetNetAppQuotaLimit(this SubscriptionResource subscriptionResource, AzureLocation location, string quotaLimitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(quotaLimitName, nameof(quotaLimitName));

            return GetExtensionClient(subscriptionResource).GetNetAppQuotaLimit(location, quotaLimitName, cancellationToken);
        }

        /// <summary>
        /// List and describe all NetApp accounts in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/netAppAccounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NetAppAccountResource> GetNetAppAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetNetAppAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// List and describe all NetApp accounts in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/netAppAccounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NetAppAccountResource> GetNetAppAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetNetAppAccounts(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of NetAppAccountResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of NetAppAccountResources and their operations over a NetAppAccountResource. </returns>
        public static NetAppAccountCollection GetNetAppAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetNetAppAccounts();
        }

        /// <summary>
        /// Get the NetApp account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<NetAppAccountResource>> GetNetAppAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetNetAppAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the NetApp account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<NetAppAccountResource> GetNetAppAccount(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetNetAppAccounts().Get(accountName, cancellationToken);
        }

        #region NetAppAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppAccountResource.CreateResourceIdentifier" /> to create a <see cref="NetAppAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppAccountResource" /> object. </returns>
        public static NetAppAccountResource GetNetAppAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppAccountResource.ValidateResourceId(id);
                return new NetAppAccountResource(client, id);
            }
            );
        }
        #endregion

        #region CapacityPoolResource
        /// <summary>
        /// Gets an object representing a <see cref="CapacityPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CapacityPoolResource.CreateResourceIdentifier" /> to create a <see cref="CapacityPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CapacityPoolResource" /> object. </returns>
        public static CapacityPoolResource GetCapacityPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                CapacityPoolResource.ValidateResourceId(id);
                return new CapacityPoolResource(client, id);
            }
            );
        }
        #endregion

        #region NetAppVolumeResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppVolumeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppVolumeResource.CreateResourceIdentifier" /> to create a <see cref="NetAppVolumeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppVolumeResource" /> object. </returns>
        public static NetAppVolumeResource GetNetAppVolumeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppVolumeResource.ValidateResourceId(id);
                return new NetAppVolumeResource(client, id);
            }
            );
        }
        #endregion

        #region NetAppVolumeSnapshotResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppVolumeSnapshotResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppVolumeSnapshotResource.CreateResourceIdentifier" /> to create a <see cref="NetAppVolumeSnapshotResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppVolumeSnapshotResource" /> object. </returns>
        public static NetAppVolumeSnapshotResource GetNetAppVolumeSnapshotResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppVolumeSnapshotResource.ValidateResourceId(id);
                return new NetAppVolumeSnapshotResource(client, id);
            }
            );
        }
        #endregion

        #region SnapshotPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="SnapshotPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SnapshotPolicyResource.CreateResourceIdentifier" /> to create a <see cref="SnapshotPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SnapshotPolicyResource" /> object. </returns>
        public static SnapshotPolicyResource GetSnapshotPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SnapshotPolicyResource.ValidateResourceId(id);
                return new SnapshotPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region NetAppVolumeBackupResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppVolumeBackupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppVolumeBackupResource.CreateResourceIdentifier" /> to create a <see cref="NetAppVolumeBackupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppVolumeBackupResource" /> object. </returns>
        public static NetAppVolumeBackupResource GetNetAppVolumeBackupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppVolumeBackupResource.ValidateResourceId(id);
                return new NetAppVolumeBackupResource(client, id);
            }
            );
        }
        #endregion

        #region NetAppAccountBackupResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppAccountBackupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppAccountBackupResource.CreateResourceIdentifier" /> to create a <see cref="NetAppAccountBackupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppAccountBackupResource" /> object. </returns>
        public static NetAppAccountBackupResource GetNetAppAccountBackupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppAccountBackupResource.ValidateResourceId(id);
                return new NetAppAccountBackupResource(client, id);
            }
            );
        }
        #endregion

        #region NetAppBackupPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppBackupPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppBackupPolicyResource.CreateResourceIdentifier" /> to create a <see cref="NetAppBackupPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppBackupPolicyResource" /> object. </returns>
        public static NetAppBackupPolicyResource GetNetAppBackupPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppBackupPolicyResource.ValidateResourceId(id);
                return new NetAppBackupPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region NetAppVolumeQuotaRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppVolumeQuotaRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppVolumeQuotaRuleResource.CreateResourceIdentifier" /> to create a <see cref="NetAppVolumeQuotaRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppVolumeQuotaRuleResource" /> object. </returns>
        public static NetAppVolumeQuotaRuleResource GetNetAppVolumeQuotaRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppVolumeQuotaRuleResource.ValidateResourceId(id);
                return new NetAppVolumeQuotaRuleResource(client, id);
            }
            );
        }
        #endregion

        #region NetAppVolumeGroupResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppVolumeGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppVolumeGroupResource.CreateResourceIdentifier" /> to create a <see cref="NetAppVolumeGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppVolumeGroupResource" /> object. </returns>
        public static NetAppVolumeGroupResource GetNetAppVolumeGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppVolumeGroupResource.ValidateResourceId(id);
                return new NetAppVolumeGroupResource(client, id);
            }
            );
        }
        #endregion

        #region NetAppSubvolumeResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppSubvolumeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppSubvolumeResource.CreateResourceIdentifier" /> to create a <see cref="NetAppSubvolumeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppSubvolumeResource" /> object. </returns>
        public static NetAppSubvolumeResource GetNetAppSubvolumeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppSubvolumeResource.ValidateResourceId(id);
                return new NetAppSubvolumeResource(client, id);
            }
            );
        }
        #endregion
    }
}
