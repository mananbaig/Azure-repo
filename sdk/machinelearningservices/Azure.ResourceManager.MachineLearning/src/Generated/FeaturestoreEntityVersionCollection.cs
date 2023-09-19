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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="FeaturestoreEntityVersionResource" /> and their operations.
    /// Each <see cref="FeaturestoreEntityVersionResource" /> in the collection will belong to the same instance of <see cref="FeaturestoreEntityContainerResource" />.
    /// To get a <see cref="FeaturestoreEntityVersionCollection" /> instance call the GetFeaturestoreEntityVersions method from an instance of <see cref="FeaturestoreEntityContainerResource" />.
    /// </summary>
    public partial class FeaturestoreEntityVersionCollection : ArmCollection, IEnumerable<FeaturestoreEntityVersionResource>, IAsyncEnumerable<FeaturestoreEntityVersionResource>
    {
        private readonly ClientDiagnostics _featurestoreEntityVersionClientDiagnostics;
        private readonly FeaturestoreEntityVersionsRestOperations _featurestoreEntityVersionRestClient;

        /// <summary> Initializes a new instance of the <see cref="FeaturestoreEntityVersionCollection"/> class for mocking. </summary>
        protected FeaturestoreEntityVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FeaturestoreEntityVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FeaturestoreEntityVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _featurestoreEntityVersionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", FeaturestoreEntityVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FeaturestoreEntityVersionResource.ResourceType, out string featurestoreEntityVersionApiVersion);
            _featurestoreEntityVersionRestClient = new FeaturestoreEntityVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, featurestoreEntityVersionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FeaturestoreEntityContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FeaturestoreEntityContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FeaturestoreEntityVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string version, FeaturestoreEntityVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _featurestoreEntityVersionClientDiagnostics.CreateScope("FeaturestoreEntityVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _featurestoreEntityVersionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<FeaturestoreEntityVersionResource>(new FeaturestoreEntityVersionOperationSource(Client), _featurestoreEntityVersionClientDiagnostics, Pipeline, _featurestoreEntityVersionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FeaturestoreEntityVersionResource> CreateOrUpdate(WaitUntil waitUntil, string version, FeaturestoreEntityVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _featurestoreEntityVersionClientDiagnostics.CreateScope("FeaturestoreEntityVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _featurestoreEntityVersionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken);
                var operation = new MachineLearningArmOperation<FeaturestoreEntityVersionResource>(new FeaturestoreEntityVersionOperationSource(Client), _featurestoreEntityVersionClientDiagnostics, Pipeline, _featurestoreEntityVersionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<FeaturestoreEntityVersionResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _featurestoreEntityVersionClientDiagnostics.CreateScope("FeaturestoreEntityVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _featurestoreEntityVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeaturestoreEntityVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<FeaturestoreEntityVersionResource> Get(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _featurestoreEntityVersionClientDiagnostics.CreateScope("FeaturestoreEntityVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _featurestoreEntityVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeaturestoreEntityVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FeaturestoreEntityVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FeaturestoreEntityVersionResource> GetAllAsync(FeaturestoreEntityVersionCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new FeaturestoreEntityVersionCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _featurestoreEntityVersionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.VersionName, options.Version, options.Description, options.CreatedBy, options.Stage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _featurestoreEntityVersionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.VersionName, options.Version, options.Description, options.CreatedBy, options.Stage);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FeaturestoreEntityVersionResource(Client, FeaturestoreEntityVersionData.DeserializeFeaturestoreEntityVersionData(e)), _featurestoreEntityVersionClientDiagnostics, Pipeline, "FeaturestoreEntityVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FeaturestoreEntityVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FeaturestoreEntityVersionResource> GetAll(FeaturestoreEntityVersionCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new FeaturestoreEntityVersionCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _featurestoreEntityVersionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.VersionName, options.Version, options.Description, options.CreatedBy, options.Stage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _featurestoreEntityVersionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.VersionName, options.Version, options.Description, options.CreatedBy, options.Stage);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FeaturestoreEntityVersionResource(Client, FeaturestoreEntityVersionData.DeserializeFeaturestoreEntityVersionData(e)), _featurestoreEntityVersionClientDiagnostics, Pipeline, "FeaturestoreEntityVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _featurestoreEntityVersionClientDiagnostics.CreateScope("FeaturestoreEntityVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _featurestoreEntityVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _featurestoreEntityVersionClientDiagnostics.CreateScope("FeaturestoreEntityVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _featurestoreEntityVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FeaturestoreEntityVersionResource> IEnumerable<FeaturestoreEntityVersionResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<FeaturestoreEntityVersionResource> IAsyncEnumerable<FeaturestoreEntityVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
