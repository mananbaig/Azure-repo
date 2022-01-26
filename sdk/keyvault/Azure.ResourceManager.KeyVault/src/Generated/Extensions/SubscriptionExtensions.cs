// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        #region DeletedVault
        /// <summary> Gets an object representing a DeletedVaultCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DeletedVaultCollection" /> object. </returns>
        public static DeletedVaultCollection GetDeletedVaults(this Subscription subscription)
        {
            return new DeletedVaultCollection(subscription);
        }
        #endregion

        #region DeletedManagedHsm
        /// <summary> Gets an object representing a DeletedManagedHsmCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DeletedManagedHsmCollection" /> object. </returns>
        public static DeletedManagedHsmCollection GetDeletedManagedHsms(this Subscription subscription)
        {
            return new DeletedManagedHsmCollection(subscription);
        }
        #endregion

        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((armClient) =>
            {
                return new SubscriptionExtensionClient(armClient, subscription.Id);
            }
            );
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/vaults
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_ListBySubscription
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Vault> GetVaultsAsync(this Subscription subscription, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetVaultsAsync(top, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/vaults
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_ListBySubscription
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Vault> GetVaults(this Subscription subscription, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetVaults(top, cancellationToken);
        }

        /// <summary> Filters the list of Vaults for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetVaultsAsGenericResourcesAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetVaultsAsGenericResourcesAsync(filter, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of Vaults for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetVaultsAsGenericResources(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetVaultsAsGenericResources(filter, expand, top, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedVaults
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_ListDeleted
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeletedVault> GetDeletedVaultsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedVaultsAsync(cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedVaults
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_ListDeleted
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeletedVault> GetDeletedVaults(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedVaults(cancellationToken);
        }

        /// <summary> Filters the list of DeletedVaults for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetDeletedVaultsAsGenericResourcesAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedVaultsAsGenericResourcesAsync(filter, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of DeletedVaults for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetDeletedVaultsAsGenericResources(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedVaultsAsGenericResources(filter, expand, top, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkNameAvailability
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_CheckNameAvailability
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public static async Task<CheckNameAvailabilityResult> CheckKeyVaultNameAvailabilityAsync(this Subscription subscription, VaultCheckNameAvailabilityParameters vaultName, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(subscription).CheckKeyVaultNameAvailabilityAsync(vaultName, cancellationToken).ConfigureAwait(false);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkNameAvailability
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Vaults_CheckNameAvailability
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public static CheckNameAvailabilityResult CheckKeyVaultNameAvailability(this Subscription subscription, VaultCheckNameAvailabilityParameters vaultName, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).CheckKeyVaultNameAvailability(vaultName, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/managedHSMs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ManagedHsms_ListBySubscription
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedHsm> GetManagedHsmsAsync(this Subscription subscription, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetManagedHsmsAsync(top, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/managedHSMs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ManagedHsms_ListBySubscription
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedHsm> GetManagedHsms(this Subscription subscription, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetManagedHsms(top, cancellationToken);
        }

        /// <summary> Filters the list of ManagedHsms for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetManagedHsmsAsGenericResourcesAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetManagedHsmsAsGenericResourcesAsync(filter, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of ManagedHsms for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetManagedHsmsAsGenericResources(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetManagedHsmsAsGenericResources(filter, expand, top, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedManagedHSMs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ManagedHsms_ListDeleted
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeletedManagedHsm> GetDeletedManagedHsmsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedManagedHsmsAsync(cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedManagedHSMs
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ManagedHsms_ListDeleted
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeletedManagedHsm> GetDeletedManagedHsms(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedManagedHsms(cancellationToken);
        }

        /// <summary> Filters the list of DeletedManagedHsms for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetDeletedManagedHsmsAsGenericResourcesAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedManagedHsmsAsGenericResourcesAsync(filter, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of DeletedManagedHsms for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetDeletedManagedHsmsAsGenericResources(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeletedManagedHsmsAsGenericResources(filter, expand, top, cancellationToken);
        }
    }
}
