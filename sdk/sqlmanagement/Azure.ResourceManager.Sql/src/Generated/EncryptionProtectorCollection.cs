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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of EncryptionProtector and their operations over its parent. </summary>
    public partial class EncryptionProtectorCollection : ArmCollection, IEnumerable<EncryptionProtectorResource>, IAsyncEnumerable<EncryptionProtectorResource>
    {
        private readonly ClientDiagnostics _encryptionProtectorClientDiagnostics;
        private readonly EncryptionProtectorsRestOperations _encryptionProtectorRestClient;

        /// <summary> Initializes a new instance of the <see cref="EncryptionProtectorCollection"/> class for mocking. </summary>
        protected EncryptionProtectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EncryptionProtectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EncryptionProtectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _encryptionProtectorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", EncryptionProtectorResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(EncryptionProtectorResource.ResourceType, out string encryptionProtectorApiVersion);
            _encryptionProtectorRestClient = new EncryptionProtectorsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, encryptionProtectorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates an existing encryption protector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// Operation Id: EncryptionProtectors_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be updated. </param>
        /// <param name="parameters"> The requested encryption protector resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<EncryptionProtectorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, EncryptionProtectorName encryptionProtectorName, EncryptionProtectorData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _encryptionProtectorRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<EncryptionProtectorResource>(new EncryptionProtectorOperationSource(Client), _encryptionProtectorClientDiagnostics, Pipeline, _encryptionProtectorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing encryption protector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// Operation Id: EncryptionProtectors_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be updated. </param>
        /// <param name="parameters"> The requested encryption protector resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<EncryptionProtectorResource> CreateOrUpdate(WaitUntil waitUntil, EncryptionProtectorName encryptionProtectorName, EncryptionProtectorData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _encryptionProtectorRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters, cancellationToken);
                var operation = new SqlArmOperation<EncryptionProtectorResource>(new EncryptionProtectorOperationSource(Client), _encryptionProtectorClientDiagnostics, Pipeline, _encryptionProtectorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a server encryption protector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// Operation Id: EncryptionProtectors_Get
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EncryptionProtectorResource>> GetAsync(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _encryptionProtectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EncryptionProtectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server encryption protector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// Operation Id: EncryptionProtectors_Get
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EncryptionProtectorResource> Get(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.Get");
            scope.Start();
            try
            {
                var response = _encryptionProtectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EncryptionProtectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of server encryption protectors
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector
        /// Operation Id: EncryptionProtectors_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EncryptionProtectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EncryptionProtectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EncryptionProtectorResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _encryptionProtectorRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionProtectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EncryptionProtectorResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _encryptionProtectorRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionProtectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of server encryption protectors
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector
        /// Operation Id: EncryptionProtectors_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EncryptionProtectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EncryptionProtectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<EncryptionProtectorResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _encryptionProtectorRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionProtectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EncryptionProtectorResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _encryptionProtectorRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionProtectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// Operation Id: EncryptionProtectors_Get
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(encryptionProtectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// Operation Id: EncryptionProtectors_Get
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(encryptionProtectorName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// Operation Id: EncryptionProtectors_Get
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EncryptionProtectorResource>> GetIfExistsAsync(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _encryptionProtectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<EncryptionProtectorResource>(null, response.GetRawResponse());
                return Response.FromValue(new EncryptionProtectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/encryptionProtector/{encryptionProtectorName}
        /// Operation Id: EncryptionProtectors_Get
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EncryptionProtectorResource> GetIfExists(EncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _encryptionProtectorClientDiagnostics.CreateScope("EncryptionProtectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _encryptionProtectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<EncryptionProtectorResource>(null, response.GetRawResponse());
                return Response.FromValue(new EncryptionProtectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EncryptionProtectorResource> IEnumerable<EncryptionProtectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EncryptionProtectorResource> IAsyncEnumerable<EncryptionProtectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
