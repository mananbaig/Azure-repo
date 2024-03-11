// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceGraph.Mocking;
using Azure.ResourceManager.ResourceGraph.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ResourceGraph
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ResourceGraph. </summary>
    public static partial class ResourceGraphExtensions
    {
        private static MockableResourceGraphTenantResource GetMockableResourceGraphTenantResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableResourceGraphTenantResource(client, resource.Id));
        }

        /// <summary>
        /// Queries the resources managed by Azure Resource Manager for scopes specified in the request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceGraph/resources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Resources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceGraphTenantResource.GetResources(ResourceQueryContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> Request specifying query and its options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<ResourceQueryResult>> GetResourcesAsync(this TenantResource tenantResource, ResourceQueryContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return await GetMockableResourceGraphTenantResource(tenantResource).GetResourcesAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Queries the resources managed by Azure Resource Manager for scopes specified in the request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceGraph/resources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Resources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceGraphTenantResource.GetResources(ResourceQueryContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> Request specifying query and its options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<ResourceQueryResult> GetResources(this TenantResource tenantResource, ResourceQueryContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableResourceGraphTenantResource(tenantResource).GetResources(content, cancellationToken);
        }

        /// <summary>
        /// List all snapshots of a resource for a given time interval.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceGraph/resourcesHistory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcesHistory</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceGraphTenantResource.GetResourceHistory(ResourcesHistoryContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> Request specifying the query and its options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<BinaryData>> GetResourceHistoryAsync(this TenantResource tenantResource, ResourcesHistoryContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return await GetMockableResourceGraphTenantResource(tenantResource).GetResourceHistoryAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// List all snapshots of a resource for a given time interval.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceGraph/resourcesHistory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcesHistory</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableResourceGraphTenantResource.GetResourceHistory(ResourcesHistoryContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> Request specifying the query and its options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<BinaryData> GetResourceHistory(this TenantResource tenantResource, ResourcesHistoryContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableResourceGraphTenantResource(tenantResource).GetResourceHistory(content, cancellationToken);
        }
    }
}
