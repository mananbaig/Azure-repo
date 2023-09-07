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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="AppServiceEnvironmentResource" /> and their operations.
    /// Each <see cref="AppServiceEnvironmentResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="AppServiceEnvironmentCollection" /> instance call the GetAppServiceEnvironments method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class AppServiceEnvironmentCollection : ArmCollection, IEnumerable<AppServiceEnvironmentResource>, IAsyncEnumerable<AppServiceEnvironmentResource>
    {
        private readonly ClientDiagnostics _appServiceEnvironmentClientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _appServiceEnvironmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceEnvironmentCollection"/> class for mocking. </summary>
        protected AppServiceEnvironmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServiceEnvironmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppServiceEnvironmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServiceEnvironmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", AppServiceEnvironmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppServiceEnvironmentResource.ResourceType, out string appServiceEnvironmentApiVersion);
            _appServiceEnvironmentRestClient = new AppServiceEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appServiceEnvironmentApiVersion);
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
        /// Description for Create or update an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="data"> Configuration details of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppServiceEnvironmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, AppServiceEnvironmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<AppServiceEnvironmentResource>(new AppServiceEnvironmentOperationSource(Client), _appServiceEnvironmentClientDiagnostics, Pipeline, _appServiceEnvironmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Create or update an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="data"> Configuration details of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppServiceEnvironmentResource> CreateOrUpdate(WaitUntil waitUntil, string name, AppServiceEnvironmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken);
                var operation = new AppServiceArmOperation<AppServiceEnvironmentResource>(new AppServiceEnvironmentOperationSource(Client), _appServiceEnvironmentClientDiagnostics, Pipeline, _appServiceEnvironmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get the properties of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<AppServiceEnvironmentResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the properties of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AppServiceEnvironmentResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all App Service Environments in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceEnvironmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServiceEnvironmentRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServiceEnvironmentRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AppServiceEnvironmentResource(Client, AppServiceEnvironmentData.DeserializeAppServiceEnvironmentData(e)), _appServiceEnvironmentClientDiagnostics, Pipeline, "AppServiceEnvironmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get all App Service Environments in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceEnvironmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appServiceEnvironmentRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appServiceEnvironmentRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AppServiceEnvironmentResource(Client, AppServiceEnvironmentData.DeserializeAppServiceEnvironmentData(e)), _appServiceEnvironmentClientDiagnostics, Pipeline, "AppServiceEnvironmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServiceEnvironmentResource> IEnumerable<AppServiceEnvironmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceEnvironmentResource> IAsyncEnumerable<AppServiceEnvironmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
