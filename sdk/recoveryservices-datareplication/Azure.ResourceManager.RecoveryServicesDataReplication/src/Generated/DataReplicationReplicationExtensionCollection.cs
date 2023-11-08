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

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A class representing a collection of <see cref="DataReplicationReplicationExtensionResource" /> and their operations.
    /// Each <see cref="DataReplicationReplicationExtensionResource" /> in the collection will belong to the same instance of <see cref="DataReplicationVaultResource" />.
    /// To get a <see cref="DataReplicationReplicationExtensionCollection" /> instance call the GetDataReplicationReplicationExtensions method from an instance of <see cref="DataReplicationVaultResource" />.
    /// </summary>
    public partial class DataReplicationReplicationExtensionCollection : ArmCollection, IEnumerable<DataReplicationReplicationExtensionResource>, IAsyncEnumerable<DataReplicationReplicationExtensionResource>
    {
        private readonly ClientDiagnostics _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics;
        private readonly ReplicationExtensionRestOperations _dataReplicationReplicationExtensionReplicationExtensionRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataReplicationReplicationExtensionCollection"/> class for mocking. </summary>
        protected DataReplicationReplicationExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataReplicationReplicationExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataReplicationReplicationExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", DataReplicationReplicationExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataReplicationReplicationExtensionResource.ResourceType, out string dataReplicationReplicationExtensionReplicationExtensionApiVersion);
            _dataReplicationReplicationExtensionReplicationExtensionRestClient = new ReplicationExtensionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataReplicationReplicationExtensionReplicationExtensionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataReplicationVaultResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataReplicationVaultResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the replication extension in the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationExtensions/{replicationExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationExtension_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="replicationExtensionName"> The replication extension name. </param>
        /// <param name="data"> Replication extension model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationExtensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataReplicationReplicationExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string replicationExtensionName, DataReplicationReplicationExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationExtensionName, nameof(replicationExtensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics.CreateScope("DataReplicationReplicationExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataReplicationReplicationExtensionReplicationExtensionRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationExtensionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesDataReplicationArmOperation<DataReplicationReplicationExtensionResource>(new DataReplicationReplicationExtensionOperationSource(Client), _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics, Pipeline, _dataReplicationReplicationExtensionReplicationExtensionRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationExtensionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates the replication extension in the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationExtensions/{replicationExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationExtension_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="replicationExtensionName"> The replication extension name. </param>
        /// <param name="data"> Replication extension model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationExtensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataReplicationReplicationExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string replicationExtensionName, DataReplicationReplicationExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationExtensionName, nameof(replicationExtensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics.CreateScope("DataReplicationReplicationExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataReplicationReplicationExtensionReplicationExtensionRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationExtensionName, data, cancellationToken);
                var operation = new RecoveryServicesDataReplicationArmOperation<DataReplicationReplicationExtensionResource>(new DataReplicationReplicationExtensionOperationSource(Client), _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics, Pipeline, _dataReplicationReplicationExtensionReplicationExtensionRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationExtensionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of the replication extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationExtensions/{replicationExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationExtension_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicationExtensionName"> The replication extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationExtensionName"/> is null. </exception>
        public virtual async Task<Response<DataReplicationReplicationExtensionResource>> GetAsync(string replicationExtensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationExtensionName, nameof(replicationExtensionName));

            using var scope = _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics.CreateScope("DataReplicationReplicationExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataReplicationReplicationExtensionReplicationExtensionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationExtensionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationReplicationExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the replication extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationExtensions/{replicationExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationExtension_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicationExtensionName"> The replication extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationExtensionName"/> is null. </exception>
        public virtual Response<DataReplicationReplicationExtensionResource> Get(string replicationExtensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationExtensionName, nameof(replicationExtensionName));

            using var scope = _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics.CreateScope("DataReplicationReplicationExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _dataReplicationReplicationExtensionReplicationExtensionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationExtensionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationReplicationExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of replication extensions in the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationExtensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationExtension_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataReplicationReplicationExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataReplicationReplicationExtensionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationReplicationExtensionReplicationExtensionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationReplicationExtensionReplicationExtensionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DataReplicationReplicationExtensionResource(Client, DataReplicationReplicationExtensionData.DeserializeDataReplicationReplicationExtensionData(e)), _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics, Pipeline, "DataReplicationReplicationExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of replication extensions in the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationExtensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationExtension_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataReplicationReplicationExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataReplicationReplicationExtensionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationReplicationExtensionReplicationExtensionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationReplicationExtensionReplicationExtensionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DataReplicationReplicationExtensionResource(Client, DataReplicationReplicationExtensionData.DeserializeDataReplicationReplicationExtensionData(e)), _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics, Pipeline, "DataReplicationReplicationExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationExtensions/{replicationExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationExtension_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicationExtensionName"> The replication extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationExtensionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string replicationExtensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationExtensionName, nameof(replicationExtensionName));

            using var scope = _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics.CreateScope("DataReplicationReplicationExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataReplicationReplicationExtensionReplicationExtensionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationExtensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationExtensions/{replicationExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationExtension_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicationExtensionName"> The replication extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationExtensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string replicationExtensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationExtensionName, nameof(replicationExtensionName));

            using var scope = _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics.CreateScope("DataReplicationReplicationExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataReplicationReplicationExtensionReplicationExtensionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationExtensionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationExtensions/{replicationExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationExtension_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicationExtensionName"> The replication extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationExtensionName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataReplicationReplicationExtensionResource>> GetIfExistsAsync(string replicationExtensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationExtensionName, nameof(replicationExtensionName));

            using var scope = _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics.CreateScope("DataReplicationReplicationExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataReplicationReplicationExtensionReplicationExtensionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationExtensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataReplicationReplicationExtensionResource>(response.GetRawResponse());
                return Response.FromValue(new DataReplicationReplicationExtensionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/replicationExtensions/{replicationExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationExtension_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicationExtensionName"> The replication extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationExtensionName"/> is null. </exception>
        public virtual NullableResponse<DataReplicationReplicationExtensionResource> GetIfExists(string replicationExtensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationExtensionName, nameof(replicationExtensionName));

            using var scope = _dataReplicationReplicationExtensionReplicationExtensionClientDiagnostics.CreateScope("DataReplicationReplicationExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataReplicationReplicationExtensionReplicationExtensionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationExtensionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataReplicationReplicationExtensionResource>(response.GetRawResponse());
                return Response.FromValue(new DataReplicationReplicationExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataReplicationReplicationExtensionResource> IEnumerable<DataReplicationReplicationExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataReplicationReplicationExtensionResource> IAsyncEnumerable<DataReplicationReplicationExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
