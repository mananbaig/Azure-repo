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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityDevOps.Mocking;

namespace Azure.ResourceManager.SecurityDevOps
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.SecurityDevOps. </summary>
    public static partial class SecurityDevOpsExtensions
    {
        private static SecurityDevOpsArmClientMockingExtension GetSecurityDevOpsArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client0 => new SecurityDevOpsArmClientMockingExtension(client0));
        }

        private static SecurityDevOpsResourceGroupMockingExtension GetSecurityDevOpsResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client => new SecurityDevOpsResourceGroupMockingExtension(client, resource.Id));
        }

        private static SecurityDevOpsSubscriptionMockingExtension GetSecurityDevOpsSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client => new SecurityDevOpsSubscriptionMockingExtension(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="AzureDevOpsConnectorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AzureDevOpsConnectorResource.CreateResourceIdentifier" /> to create an <see cref="AzureDevOpsConnectorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsArmClientMockingExtension.GetAzureDevOpsConnectorResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureDevOpsConnectorResource" /> object. </returns>
        public static AzureDevOpsConnectorResource GetAzureDevOpsConnectorResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSecurityDevOpsArmClientMockingExtension(client).GetAzureDevOpsConnectorResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AzureDevOpsRepoResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AzureDevOpsRepoResource.CreateResourceIdentifier" /> to create an <see cref="AzureDevOpsRepoResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsArmClientMockingExtension.GetAzureDevOpsRepoResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureDevOpsRepoResource" /> object. </returns>
        public static AzureDevOpsRepoResource GetAzureDevOpsRepoResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSecurityDevOpsArmClientMockingExtension(client).GetAzureDevOpsRepoResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AzureDevOpsOrgResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AzureDevOpsOrgResource.CreateResourceIdentifier" /> to create an <see cref="AzureDevOpsOrgResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsArmClientMockingExtension.GetAzureDevOpsOrgResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureDevOpsOrgResource" /> object. </returns>
        public static AzureDevOpsOrgResource GetAzureDevOpsOrgResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSecurityDevOpsArmClientMockingExtension(client).GetAzureDevOpsOrgResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AzureDevOpsProjectResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AzureDevOpsProjectResource.CreateResourceIdentifier" /> to create an <see cref="AzureDevOpsProjectResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsArmClientMockingExtension.GetAzureDevOpsProjectResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureDevOpsProjectResource" /> object. </returns>
        public static AzureDevOpsProjectResource GetAzureDevOpsProjectResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSecurityDevOpsArmClientMockingExtension(client).GetAzureDevOpsProjectResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GitHubConnectorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GitHubConnectorResource.CreateResourceIdentifier" /> to create a <see cref="GitHubConnectorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsArmClientMockingExtension.GetGitHubConnectorResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GitHubConnectorResource" /> object. </returns>
        public static GitHubConnectorResource GetGitHubConnectorResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSecurityDevOpsArmClientMockingExtension(client).GetGitHubConnectorResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GitHubRepoResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GitHubRepoResource.CreateResourceIdentifier" /> to create a <see cref="GitHubRepoResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsArmClientMockingExtension.GetGitHubRepoResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GitHubRepoResource" /> object. </returns>
        public static GitHubRepoResource GetGitHubRepoResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSecurityDevOpsArmClientMockingExtension(client).GetGitHubRepoResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GitHubOwnerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GitHubOwnerResource.CreateResourceIdentifier" /> to create a <see cref="GitHubOwnerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsArmClientMockingExtension.GetGitHubOwnerResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GitHubOwnerResource" /> object. </returns>
        public static GitHubOwnerResource GetGitHubOwnerResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSecurityDevOpsArmClientMockingExtension(client).GetGitHubOwnerResource(id);
        }

        /// <summary>
        /// Gets a collection of AzureDevOpsConnectorResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsResourceGroupMockingExtension.GetAzureDevOpsConnectors()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AzureDevOpsConnectorResources and their operations over a AzureDevOpsConnectorResource. </returns>
        public static AzureDevOpsConnectorCollection GetAzureDevOpsConnectors(this ResourceGroupResource resourceGroupResource)
        {
            return GetSecurityDevOpsResourceGroupMockingExtension(resourceGroupResource).GetAzureDevOpsConnectors();
        }

        /// <summary>
        /// Returns a monitored AzureDevOps Connector resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsResourceGroupMockingExtension.GetAzureDevOpsConnectorAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AzureDevOpsConnectorResource>> GetAzureDevOpsConnectorAsync(this ResourceGroupResource resourceGroupResource, string azureDevOpsConnectorName, CancellationToken cancellationToken = default)
        {
            return await GetSecurityDevOpsResourceGroupMockingExtension(resourceGroupResource).GetAzureDevOpsConnectorAsync(azureDevOpsConnectorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a monitored AzureDevOps Connector resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsResourceGroupMockingExtension.GetAzureDevOpsConnector(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<AzureDevOpsConnectorResource> GetAzureDevOpsConnector(this ResourceGroupResource resourceGroupResource, string azureDevOpsConnectorName, CancellationToken cancellationToken = default)
        {
            return GetSecurityDevOpsResourceGroupMockingExtension(resourceGroupResource).GetAzureDevOpsConnector(azureDevOpsConnectorName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of GitHubConnectorResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsResourceGroupMockingExtension.GetGitHubConnectors()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of GitHubConnectorResources and their operations over a GitHubConnectorResource. </returns>
        public static GitHubConnectorCollection GetGitHubConnectors(this ResourceGroupResource resourceGroupResource)
        {
            return GetSecurityDevOpsResourceGroupMockingExtension(resourceGroupResource).GetGitHubConnectors();
        }

        /// <summary>
        /// Returns a monitored GitHub Connector resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubConnector_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsResourceGroupMockingExtension.GetGitHubConnectorAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="gitHubConnectorName"> Name of the GitHub Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubConnectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="gitHubConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<GitHubConnectorResource>> GetGitHubConnectorAsync(this ResourceGroupResource resourceGroupResource, string gitHubConnectorName, CancellationToken cancellationToken = default)
        {
            return await GetSecurityDevOpsResourceGroupMockingExtension(resourceGroupResource).GetGitHubConnectorAsync(gitHubConnectorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a monitored GitHub Connector resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubConnector_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsResourceGroupMockingExtension.GetGitHubConnector(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="gitHubConnectorName"> Name of the GitHub Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubConnectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="gitHubConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<GitHubConnectorResource> GetGitHubConnector(this ResourceGroupResource resourceGroupResource, string gitHubConnectorName, CancellationToken cancellationToken = default)
        {
            return GetSecurityDevOpsResourceGroupMockingExtension(resourceGroupResource).GetGitHubConnector(gitHubConnectorName, cancellationToken);
        }

        /// <summary>
        /// Returns a list of monitored AzureDevOps Connectors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsSubscriptionMockingExtension.GetAzureDevOpsConnectors(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureDevOpsConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AzureDevOpsConnectorResource> GetAzureDevOpsConnectorsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSecurityDevOpsSubscriptionMockingExtension(subscriptionResource).GetAzureDevOpsConnectorsAsync(cancellationToken);
        }

        /// <summary>
        /// Returns a list of monitored AzureDevOps Connectors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsSubscriptionMockingExtension.GetAzureDevOpsConnectors(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureDevOpsConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AzureDevOpsConnectorResource> GetAzureDevOpsConnectors(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSecurityDevOpsSubscriptionMockingExtension(subscriptionResource).GetAzureDevOpsConnectors(cancellationToken);
        }

        /// <summary>
        /// Returns a list of monitored GitHub Connectors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SecurityDevOps/gitHubConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubConnector_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsSubscriptionMockingExtension.GetGitHubConnectors(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GitHubConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GitHubConnectorResource> GetGitHubConnectorsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSecurityDevOpsSubscriptionMockingExtension(subscriptionResource).GetGitHubConnectorsAsync(cancellationToken);
        }

        /// <summary>
        /// Returns a list of monitored GitHub Connectors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SecurityDevOps/gitHubConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubConnector_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="SecurityDevOpsSubscriptionMockingExtension.GetGitHubConnectors(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GitHubConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<GitHubConnectorResource> GetGitHubConnectors(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSecurityDevOpsSubscriptionMockingExtension(subscriptionResource).GetGitHubConnectors(cancellationToken);
        }
    }
}
