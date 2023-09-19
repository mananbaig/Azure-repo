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
    /// A class representing a collection of <see cref="FeaturesetContainerResource" /> and their operations.
    /// Each <see cref="FeaturesetContainerResource" /> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource" />.
    /// To get a <see cref="FeaturesetContainerCollection" /> instance call the GetFeaturesetContainers method from an instance of <see cref="MachineLearningWorkspaceResource" />.
    /// </summary>
    public partial class FeaturesetContainerCollection : ArmCollection, IEnumerable<FeaturesetContainerResource>, IAsyncEnumerable<FeaturesetContainerResource>
    {
        private readonly ClientDiagnostics _featuresetContainerClientDiagnostics;
        private readonly FeaturesetContainersRestOperations _featuresetContainerRestClient;

        /// <summary> Initializes a new instance of the <see cref="FeaturesetContainerCollection"/> class for mocking. </summary>
        protected FeaturesetContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FeaturesetContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FeaturesetContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _featuresetContainerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", FeaturesetContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FeaturesetContainerResource.ResourceType, out string featuresetContainerApiVersion);
            _featuresetContainerRestClient = new FeaturesetContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, featuresetContainerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetContainers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FeaturesetContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, FeaturesetContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _featuresetContainerClientDiagnostics.CreateScope("FeaturesetContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _featuresetContainerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<FeaturesetContainerResource>(new FeaturesetContainerOperationSource(Client), _featuresetContainerClientDiagnostics, Pipeline, _featuresetContainerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetContainers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FeaturesetContainerResource> CreateOrUpdate(WaitUntil waitUntil, string name, FeaturesetContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _featuresetContainerClientDiagnostics.CreateScope("FeaturesetContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _featuresetContainerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<FeaturesetContainerResource>(new FeaturesetContainerOperationSource(Client), _featuresetContainerClientDiagnostics, Pipeline, _featuresetContainerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetContainers_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<FeaturesetContainerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _featuresetContainerClientDiagnostics.CreateScope("FeaturesetContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _featuresetContainerRestClient.GetEntityAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeaturesetContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetContainers_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<FeaturesetContainerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _featuresetContainerClientDiagnostics.CreateScope("FeaturesetContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _featuresetContainerRestClient.GetEntity(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeaturesetContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List featurestore entity containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetContainers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FeaturesetContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FeaturesetContainerResource> GetAllAsync(FeaturesetContainerCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new FeaturesetContainerCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _featuresetContainerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.Name, options.Description, options.CreatedBy);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _featuresetContainerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.Name, options.Description, options.CreatedBy);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FeaturesetContainerResource(Client, FeaturesetContainerData.DeserializeFeaturesetContainerData(e)), _featuresetContainerClientDiagnostics, Pipeline, "FeaturesetContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List featurestore entity containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetContainers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FeaturesetContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FeaturesetContainerResource> GetAll(FeaturesetContainerCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new FeaturesetContainerCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _featuresetContainerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.Name, options.Description, options.CreatedBy);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _featuresetContainerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.Name, options.Description, options.CreatedBy);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FeaturesetContainerResource(Client, FeaturesetContainerData.DeserializeFeaturesetContainerData(e)), _featuresetContainerClientDiagnostics, Pipeline, "FeaturesetContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetContainers_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _featuresetContainerClientDiagnostics.CreateScope("FeaturesetContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _featuresetContainerRestClient.GetEntityAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetContainers_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _featuresetContainerClientDiagnostics.CreateScope("FeaturesetContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _featuresetContainerRestClient.GetEntity(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FeaturesetContainerResource> IEnumerable<FeaturesetContainerResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<FeaturesetContainerResource> IAsyncEnumerable<FeaturesetContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
