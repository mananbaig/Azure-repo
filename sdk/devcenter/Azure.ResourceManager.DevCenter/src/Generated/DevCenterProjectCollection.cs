// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="DevCenterProjectResource" /> and their operations.
    /// Each <see cref="DevCenterProjectResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DevCenterProjectCollection" /> instance call the GetDevCenterProjects method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DevCenterProjectCollection : ArmCollection, IEnumerable<DevCenterProjectResource>, IAsyncEnumerable<DevCenterProjectResource>
    {
        private readonly ClientDiagnostics _devCenterProjectProjectsClientDiagnostics;
        private readonly ProjectsRestOperations _devCenterProjectProjectsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevCenterProjectCollection"/> class for mocking. </summary>
        protected DevCenterProjectCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevCenterProjectCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevCenterProjectCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devCenterProjectProjectsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", DevCenterProjectResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevCenterProjectResource.ResourceType, out string devCenterProjectProjectsApiVersion);
            _devCenterProjectProjectsRestClient = new ProjectsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devCenterProjectProjectsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a project.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="projectName"> The name of the project. </param>
        /// <param name="data"> Represents a project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevCenterProjectResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string projectName, DevCenterProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterProjectProjectsClientDiagnostics.CreateScope("DevCenterProjectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devCenterProjectProjectsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, projectName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation<DevCenterProjectResource>(new DevCenterProjectOperationSource(Client), _devCenterProjectProjectsClientDiagnostics, Pipeline, _devCenterProjectProjectsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, projectName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a project.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="projectName"> The name of the project. </param>
        /// <param name="data"> Represents a project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevCenterProjectResource> CreateOrUpdate(WaitUntil waitUntil, string projectName, DevCenterProjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterProjectProjectsClientDiagnostics.CreateScope("DevCenterProjectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devCenterProjectProjectsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, projectName, data, cancellationToken);
                var operation = new DevCenterArmOperation<DevCenterProjectResource>(new DevCenterProjectOperationSource(Client), _devCenterProjectProjectsClientDiagnostics, Pipeline, _devCenterProjectProjectsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, projectName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific project.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The name of the project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual async Task<Response<DevCenterProjectResource>> GetAsync(string projectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));

            using var scope = _devCenterProjectProjectsClientDiagnostics.CreateScope("DevCenterProjectCollection.Get");
            scope.Start();
            try
            {
                var response = await _devCenterProjectProjectsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, projectName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific project.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The name of the project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual Response<DevCenterProjectResource> Get(string projectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));

            using var scope = _devCenterProjectProjectsClientDiagnostics.CreateScope("DevCenterProjectCollection.Get");
            scope.Start();
            try
            {
                var response = _devCenterProjectProjectsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, projectName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all projects in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevCenterProjectResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevCenterProjectResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterProjectProjectsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterProjectProjectsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DevCenterProjectResource(Client, DevCenterProjectData.DeserializeDevCenterProjectData(e)), _devCenterProjectProjectsClientDiagnostics, Pipeline, "DevCenterProjectCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all projects in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevCenterProjectResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevCenterProjectResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterProjectProjectsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterProjectProjectsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DevCenterProjectResource(Client, DevCenterProjectData.DeserializeDevCenterProjectData(e)), _devCenterProjectProjectsClientDiagnostics, Pipeline, "DevCenterProjectCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The name of the project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string projectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));

            using var scope = _devCenterProjectProjectsClientDiagnostics.CreateScope("DevCenterProjectCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devCenterProjectProjectsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, projectName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The name of the project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual Response<bool> Exists(string projectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));

            using var scope = _devCenterProjectProjectsClientDiagnostics.CreateScope("DevCenterProjectCollection.Exists");
            scope.Start();
            try
            {
                var response = _devCenterProjectProjectsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, projectName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The name of the project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual async Task<NullableResponse<DevCenterProjectResource>> GetIfExistsAsync(string projectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));

            using var scope = _devCenterProjectProjectsClientDiagnostics.CreateScope("DevCenterProjectCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _devCenterProjectProjectsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, projectName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DevCenterProjectResource>(response.GetRawResponse());
                return Response.FromValue(new DevCenterProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Projects_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The name of the project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        public virtual NullableResponse<DevCenterProjectResource> GetIfExists(string projectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));

            using var scope = _devCenterProjectProjectsClientDiagnostics.CreateScope("DevCenterProjectCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _devCenterProjectProjectsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, projectName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DevCenterProjectResource>(response.GetRawResponse());
                return Response.FromValue(new DevCenterProjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevCenterProjectResource> IEnumerable<DevCenterProjectResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevCenterProjectResource> IAsyncEnumerable<DevCenterProjectResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
