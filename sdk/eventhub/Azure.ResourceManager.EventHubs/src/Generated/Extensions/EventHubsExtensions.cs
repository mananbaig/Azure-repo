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
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.EventHubs. </summary>
    public static partial class EventHubsExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary>
        /// List the quantity of available pre-provisioned Event Hubs Clusters, indexed by Azure region.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/availableClusterRegions
        /// Operation Id: Clusters_ListAvailableClusterRegion
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableCluster" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AvailableCluster> GetAvailableClusterRegionClustersAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetAvailableClusterRegionClustersAsync(cancellationToken);
        }

        /// <summary>
        /// List the quantity of available pre-provisioned Event Hubs Clusters, indexed by Azure region.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/availableClusterRegions
        /// Operation Id: Clusters_ListAvailableClusterRegion
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableCluster" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AvailableCluster> GetAvailableClusterRegionClusters(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetAvailableClusterRegionClusters(cancellationToken);
        }

        /// <summary>
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/clusters
        /// Operation Id: Clusters_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubCluster" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EventHubCluster> GetEventHubClustersAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetEventHubClustersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/clusters
        /// Operation Id: Clusters_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubCluster" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EventHubCluster> GetEventHubClusters(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetEventHubClusters(cancellationToken);
        }

        /// <summary>
        /// Lists all the available Namespaces within a subscription, irrespective of the resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/namespaces
        /// Operation Id: Namespaces_List
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubNamespace" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EventHubNamespace> GetEventHubNamespacesAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetEventHubNamespacesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the available Namespaces within a subscription, irrespective of the resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/namespaces
        /// Operation Id: Namespaces_List
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubNamespace" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EventHubNamespace> GetEventHubNamespaces(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetEventHubNamespaces(cancellationToken);
        }

        /// <summary>
        /// Check the give Namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/checkNameAvailability
        /// Operation Id: Namespaces_CheckNameAvailability
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="parameters"> Parameters to check availability of the given Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityResult>> CheckEventHubNameAvailabilityAsync(this Subscription subscription, CheckNameAvailabilityOptions parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            return await GetExtensionClient(subscription).CheckEventHubNameAvailabilityAsync(parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the give Namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/checkNameAvailability
        /// Operation Id: Namespaces_CheckNameAvailability
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="parameters"> Parameters to check availability of the given Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public static Response<CheckNameAvailabilityResult> CheckEventHubNameAvailability(this Subscription subscription, CheckNameAvailabilityOptions parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            return GetExtensionClient(subscription).CheckEventHubNameAvailability(parameters, cancellationToken);
        }

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of EventHubClusters in the EventHubCluster. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of EventHubClusters and their operations over a EventHubCluster. </returns>
        public static EventHubClusterCollection GetEventHubClusters(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetEventHubClusters();
        }

        /// <summary>
        /// Gets the resource description of the specified Event Hubs Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public static async Task<Response<EventHubCluster>> GetEventHubClusterAsync(this ResourceGroup resourceGroup, string clusterName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetEventHubClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the resource description of the specified Event Hubs Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public static Response<EventHubCluster> GetEventHubCluster(this ResourceGroup resourceGroup, string clusterName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetEventHubClusters().Get(clusterName, cancellationToken);
        }

        /// <summary> Gets a collection of EventHubNamespaces in the EventHubNamespace. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of EventHubNamespaces and their operations over a EventHubNamespace. </returns>
        public static EventHubNamespaceCollection GetEventHubNamespaces(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetEventHubNamespaces();
        }

        /// <summary>
        /// Gets the description of the specified namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public static async Task<Response<EventHubNamespace>> GetEventHubNamespaceAsync(this ResourceGroup resourceGroup, string namespaceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetEventHubNamespaces().GetAsync(namespaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the description of the specified namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public static Response<EventHubNamespace> GetEventHubNamespace(this ResourceGroup resourceGroup, string namespaceName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetEventHubNamespaces().Get(namespaceName, cancellationToken);
        }

        #region EventHubCluster
        /// <summary> Gets an object representing a EventHubCluster along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubCluster" /> object. </returns>
        public static EventHubCluster GetEventHubCluster(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubCluster.ValidateResourceId(id);
                return new EventHubCluster(client, id);
            }
            );
        }
        #endregion

        #region EventHubNamespace
        /// <summary> Gets an object representing a EventHubNamespace along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubNamespace" /> object. </returns>
        public static EventHubNamespace GetEventHubNamespace(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubNamespace.ValidateResourceId(id);
                return new EventHubNamespace(client, id);
            }
            );
        }
        #endregion

        #region NetworkRuleSet
        /// <summary> Gets an object representing a NetworkRuleSet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkRuleSet" /> object. </returns>
        public static NetworkRuleSet GetNetworkRuleSet(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetworkRuleSet.ValidateResourceId(id);
                return new NetworkRuleSet(client, id);
            }
            );
        }
        #endregion

        #region NamespaceAuthorizationRule
        /// <summary> Gets an object representing a NamespaceAuthorizationRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceAuthorizationRule" /> object. </returns>
        public static NamespaceAuthorizationRule GetNamespaceAuthorizationRule(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NamespaceAuthorizationRule.ValidateResourceId(id);
                return new NamespaceAuthorizationRule(client, id);
            }
            );
        }
        #endregion

        #region EventHubAuthorizationRule
        /// <summary> Gets an object representing a EventHubAuthorizationRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHubAuthorizationRule" /> object. </returns>
        public static EventHubAuthorizationRule GetEventHubAuthorizationRule(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHubAuthorizationRule.ValidateResourceId(id);
                return new EventHubAuthorizationRule(client, id);
            }
            );
        }
        #endregion

        #region DisasterRecoveryAuthorizationRule
        /// <summary> Gets an object representing a DisasterRecoveryAuthorizationRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DisasterRecoveryAuthorizationRule" /> object. </returns>
        public static DisasterRecoveryAuthorizationRule GetDisasterRecoveryAuthorizationRule(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DisasterRecoveryAuthorizationRule.ValidateResourceId(id);
                return new DisasterRecoveryAuthorizationRule(client, id);
            }
            );
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrivateEndpointConnection.ValidateResourceId(id);
                return new PrivateEndpointConnection(client, id);
            }
            );
        }
        #endregion

        #region EventHub
        /// <summary> Gets an object representing a EventHub along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventHub" /> object. </returns>
        public static EventHub GetEventHub(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EventHub.ValidateResourceId(id);
                return new EventHub(client, id);
            }
            );
        }
        #endregion

        #region DisasterRecovery
        /// <summary> Gets an object representing a DisasterRecovery along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DisasterRecovery" /> object. </returns>
        public static DisasterRecovery GetDisasterRecovery(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DisasterRecovery.ValidateResourceId(id);
                return new DisasterRecovery(client, id);
            }
            );
        }
        #endregion

        #region ConsumerGroup
        /// <summary> Gets an object representing a ConsumerGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConsumerGroup" /> object. </returns>
        public static ConsumerGroup GetConsumerGroup(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ConsumerGroup.ValidateResourceId(id);
                return new ConsumerGroup(client, id);
            }
            );
        }
        #endregion

        #region SchemaGroup
        /// <summary> Gets an object representing a SchemaGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SchemaGroup" /> object. </returns>
        public static SchemaGroup GetSchemaGroup(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SchemaGroup.ValidateResourceId(id);
                return new SchemaGroup(client, id);
            }
            );
        }
        #endregion
    }
}
