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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformBuilderResource" /> and their operations.
    /// Each <see cref="AppPlatformBuilderResource" /> in the collection will belong to the same instance of <see cref="AppPlatformBuildServiceResource" />.
    /// To get an <see cref="AppPlatformBuilderCollection" /> instance call the GetAppPlatformBuilders method from an instance of <see cref="AppPlatformBuildServiceResource" />.
    /// </summary>
    public partial class AppPlatformBuilderCollection : ArmCollection, IEnumerable<AppPlatformBuilderResource>, IAsyncEnumerable<AppPlatformBuilderResource>
    {
        private readonly ClientDiagnostics _appPlatformBuilderBuildServiceBuilderClientDiagnostics;
        private readonly BuildServiceBuilderRestOperations _appPlatformBuilderBuildServiceBuilderRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuilderCollection"/> class for mocking. </summary>
        protected AppPlatformBuilderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuilderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformBuilderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformBuilderBuildServiceBuilderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformBuilderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformBuilderResource.ResourceType, out string appPlatformBuilderBuildServiceBuilderApiVersion);
            _appPlatformBuilderBuildServiceBuilderRestClient = new BuildServiceBuilderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformBuilderBuildServiceBuilderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformBuildServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformBuildServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a KPack builder.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceBuilder_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="data"> The target builder for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="builderName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformBuilderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string builderName, AppPlatformBuilderData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformBuilderBuildServiceBuilderClientDiagnostics.CreateScope("AppPlatformBuilderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformBuilderBuildServiceBuilderRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, builderName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformBuilderResource>(new AppPlatformBuilderOperationSource(Client), _appPlatformBuilderBuildServiceBuilderClientDiagnostics, Pipeline, _appPlatformBuilderBuildServiceBuilderRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, builderName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a KPack builder.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceBuilder_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="data"> The target builder for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="builderName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformBuilderResource> CreateOrUpdate(WaitUntil waitUntil, string builderName, AppPlatformBuilderData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformBuilderBuildServiceBuilderClientDiagnostics.CreateScope("AppPlatformBuilderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformBuilderBuildServiceBuilderRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, builderName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformBuilderResource>(new AppPlatformBuilderOperationSource(Client), _appPlatformBuilderBuildServiceBuilderClientDiagnostics, Pipeline, _appPlatformBuilderBuildServiceBuilderRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, builderName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a KPack builder.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceBuilder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="builderName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformBuilderResource>> GetAsync(string builderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));

            using var scope = _appPlatformBuilderBuildServiceBuilderClientDiagnostics.CreateScope("AppPlatformBuilderCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformBuilderBuildServiceBuilderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, builderName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuilderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a KPack builder.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceBuilder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="builderName"/> is null. </exception>
        public virtual Response<AppPlatformBuilderResource> Get(string builderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));

            using var scope = _appPlatformBuilderBuildServiceBuilderClientDiagnostics.CreateScope("AppPlatformBuilderCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformBuilderBuildServiceBuilderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, builderName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuilderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List KPack builders result.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceBuilder_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformBuilderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformBuilderResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformBuilderBuildServiceBuilderRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformBuilderBuildServiceBuilderRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformBuilderResource(Client, AppPlatformBuilderData.DeserializeAppPlatformBuilderData(e)), _appPlatformBuilderBuildServiceBuilderClientDiagnostics, Pipeline, "AppPlatformBuilderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List KPack builders result.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceBuilder_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformBuilderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformBuilderResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformBuilderBuildServiceBuilderRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformBuilderBuildServiceBuilderRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformBuilderResource(Client, AppPlatformBuilderData.DeserializeAppPlatformBuilderData(e)), _appPlatformBuilderBuildServiceBuilderClientDiagnostics, Pipeline, "AppPlatformBuilderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceBuilder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="builderName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string builderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));

            using var scope = _appPlatformBuilderBuildServiceBuilderClientDiagnostics.CreateScope("AppPlatformBuilderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformBuilderBuildServiceBuilderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, builderName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceBuilder_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="builderName"/> is null. </exception>
        public virtual Response<bool> Exists(string builderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(builderName, nameof(builderName));

            using var scope = _appPlatformBuilderBuildServiceBuilderClientDiagnostics.CreateScope("AppPlatformBuilderCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformBuilderBuildServiceBuilderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, builderName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformBuilderResource> IEnumerable<AppPlatformBuilderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformBuilderResource> IAsyncEnumerable<AppPlatformBuilderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
