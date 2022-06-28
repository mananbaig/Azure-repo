// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="RestorableDatabaseAccountResource" /> and their operations.
    /// Each <see cref="RestorableDatabaseAccountResource" /> in the collection will belong to the same instance of <see cref="CosmosDBLocationResource" />.
    /// To get a <see cref="RestorableDatabaseAccountCollection" /> instance call the GetRestorableDatabaseAccounts method from an instance of <see cref="CosmosDBLocationResource" />.
    /// </summary>
    public partial class RestorableDatabaseAccountCollection : ArmCollection, IEnumerable<RestorableDatabaseAccountResource>, IAsyncEnumerable<RestorableDatabaseAccountResource>
    {
        private readonly ClientDiagnostics _restorableDatabaseAccountClientDiagnostics;
        private readonly RestorableDatabaseAccountsRestOperations _restorableDatabaseAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorableDatabaseAccountCollection"/> class for mocking. </summary>
        protected RestorableDatabaseAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDatabaseAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RestorableDatabaseAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorableDatabaseAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", RestorableDatabaseAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RestorableDatabaseAccountResource.ResourceType, out string restorableDatabaseAccountApiVersion);
            _restorableDatabaseAccountRestClient = new RestorableDatabaseAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, restorableDatabaseAccountApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBLocationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBLocationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}
        /// Operation Id: RestorableDatabaseAccounts_GetByLocation
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual async Task<Response<RestorableDatabaseAccountResource>> GetAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorableDatabaseAccountRestClient.GetByLocationAsync(Id.SubscriptionId, new AzureLocation(Id.Name), instanceId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDatabaseAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}
        /// Operation Id: RestorableDatabaseAccounts_GetByLocation
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<RestorableDatabaseAccountResource> Get(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _restorableDatabaseAccountRestClient.GetByLocation(Id.SubscriptionId, new AzureLocation(Id.Name), instanceId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDatabaseAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts
        /// Operation Id: RestorableDatabaseAccounts_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableDatabaseAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableDatabaseAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableDatabaseAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorableDatabaseAccountRestClient.ListByLocationAsync(Id.SubscriptionId, new AzureLocation(Id.Name), cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDatabaseAccountResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts
        /// Operation Id: RestorableDatabaseAccounts_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableDatabaseAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableDatabaseAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RestorableDatabaseAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorableDatabaseAccountRestClient.ListByLocation(Id.SubscriptionId, new AzureLocation(Id.Name), cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDatabaseAccountResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}
        /// Operation Id: RestorableDatabaseAccounts_GetByLocation
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _restorableDatabaseAccountRestClient.GetByLocationAsync(Id.SubscriptionId, new AzureLocation(Id.Name), instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}
        /// Operation Id: RestorableDatabaseAccounts_GetByLocation
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<bool> Exists(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _restorableDatabaseAccountRestClient.GetByLocation(Id.SubscriptionId, new AzureLocation(Id.Name), instanceId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RestorableDatabaseAccountResource> IEnumerable<RestorableDatabaseAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestorableDatabaseAccountResource> IAsyncEnumerable<RestorableDatabaseAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
